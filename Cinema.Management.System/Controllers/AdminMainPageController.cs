using Microsoft.AspNetCore.Mvc;
using Cinema.Management.System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cinema.Management.System.Data;
using Cinema.Management.System.ViewModels;

namespace Cinema.Management.System.Controllers
{
    public class AdminMainPageController : Controller
    {
        public IActionResult AdminMainPage()
        {

            return View();
        }


        public IActionResult AdminMovies()
        {

            List<Movie> movies = movieRepository.getAllMovies();

            return View(movies);
        }

        [HttpGet]
        public IActionResult AdminComments()
        {

            List<Comment> allComments = movieRepository.getAllComments();

            return View(allComments);
        }

        [HttpPost]
        public IActionResult AdminComments(int commentId){

            Console.WriteLine(commentId+" asdapsodjaşlskdjalskjdalskjd");
            movieRepository.deleteCommentById(commentId);
            return RedirectToAction("AdminComments");
        }

        public IActionResult AdminCinemaHalls()
        {

            return View();
        }

        public IActionResult AdminTickets()
        {

            return View();
        }

        public IActionResult AdminMoviePage(int id)
        {

            Movie movieDetail = movieRepository.getMovieById(id);

            //List<Actor> actors = movieRepository.getActorsById(id);

            //actorMovieViewModel viewModel= new actorMovieViewModel(movieDetail,actors);

            return View(movieDetail);
        }



        public IActionResult AdminAddMovie(string MovieName, string MovieReleaseDate, int MovieDuration,
        string MovieTrailerUrl, string MovieSummary, string DirectorFirstName
        , string DirectorLastName, int MovieIsShowing, string MoviePhotoUrl, string MoviePosterUrl, string MovieCategory)
        {
             List<string> allCategoryNames=categoryRepository.getAllCategoryNames();
             

            if (MovieName != null && MovieReleaseDate != null && 
        MovieTrailerUrl != null && MovieSummary != null && DirectorFirstName != null &&
        DirectorLastName != null  && MoviePhotoUrl != null && MoviePosterUrl != null && MovieCategory != null)
            {
                movieRepository.getAllMovieNames();

                if (movieRepository._moviesName != null && !movieRepository._moviesName.Contains(MovieName))
                {

                    directorRepository.GetDirectorByName(DirectorFirstName, DirectorLastName);
                    if (directorRepository._director == null)
                    {
                        directorRepository.CreateDirector(DirectorFirstName, DirectorLastName);
                        directorRepository.GetDirectorByName(DirectorFirstName, DirectorLastName); //for find directorId
                    }

                    int directorIdTemp = directorRepository._director.directorId;
                    bool isShowing = false;

                    if (MovieIsShowing == 1)
                    {
                        isShowing = true;
                    }

                    Movie m = new Movie(MovieName, MovieReleaseDate, MovieDuration, MovieTrailerUrl, MovieSummary, directorIdTemp,
                    isShowing, MoviePhotoUrl, MoviePosterUrl, MovieCategory, DirectorFirstName, DirectorLastName);

                    movieRepository.SendMovieToDatabase(m);
                    

                    categoryRepository.SendCategoryToDatabase(categoryRepository.getCategoryIdByName(m.movieCategory),movieRepository.getMovieIdByName(m.movieName));

                    return RedirectToAction("AdminMovies");

                }
                else if (movieRepository._moviesName == null)
                {
                    directorRepository.GetDirectorByName(DirectorFirstName, DirectorLastName);
                    if (directorRepository._director == null)
                    {
                        directorRepository.CreateDirector(DirectorFirstName, DirectorLastName);
                        directorRepository.GetDirectorByName(DirectorFirstName, DirectorLastName); //for find directorId
                    }

                    int directorIdTemp = directorRepository._director.directorId;
                    bool isShowing = false;

                    if (MovieIsShowing == 1)
                    {
                        isShowing = true;
                    }

                    Movie m = new Movie(MovieName, MovieReleaseDate, MovieDuration, MovieTrailerUrl, MovieSummary, directorIdTemp,
                    isShowing, MoviePhotoUrl, MoviePosterUrl, MovieCategory, DirectorFirstName, DirectorLastName);

                    movieRepository.SendMovieToDatabase(m);

                    categoryRepository.SendCategoryToDatabase(categoryRepository.getCategoryIdByName(m.movieCategory),movieRepository.getMovieIdByName(m.movieName));
                    return RedirectToAction("AdminMovies");
                }
                else
                {

                    if (MovieName != null && MovieReleaseDate != null && 
                        MovieTrailerUrl != null && MovieSummary != null && DirectorFirstName != null &&
                        DirectorLastName != null  && MoviePhotoUrl != null && MoviePosterUrl != null && MovieCategory != null)
                    {
                        TempData["MovieCreateError"] = "Movie has already exists in database";
                    }

                    return RedirectToAction("AdminAddMovie");
                }



            }

            return View(allCategoryNames);
        }

        [HttpGet]
        public IActionResult AddActor(int id,string actorName,string actorSurname){

             
             
            Console.WriteLine(id);
            
            if (actorName!=null && actorSurname!=null)
            {
                Actor actor=movieRepository.getActorsByName(actorName,actorSurname);
                
                if(actor==null){
                    
                    //create new actor
                    movieRepository.createActor(actorName,actorSurname);
                    //get created actors id
                    int actorId=movieRepository.getActorIdByName(actorName,actorSurname);

                    Console.WriteLine(id+" ifin içinde");

                    //attach movie and actors at movie has actors table
                    movieRepository.SendActorAndMovieRelationToDatabase(actorId,id);

                    return View(id);

                }

                else{
                    Console.WriteLine(id+" else in içinde");
                    //add exist actor to movies cast
                    movieRepository.SendActorAndMovieRelationToDatabase(actor.actorId,id);
                    return View(id);

                }



            }

            return View(id);
        }
    }
}