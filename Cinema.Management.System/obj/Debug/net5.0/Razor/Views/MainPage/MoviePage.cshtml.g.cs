#pragma checksum "C:\Users\Ekin\Desktop\New.Project\Cinema\Cinema.Management.System\Views\MainPage\MoviePage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ca6c7b968db9137823dc89d8f46527fca72cd10d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MainPage_MoviePage), @"mvc.1.0.view", @"/Views/MainPage/MoviePage.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Ekin\Desktop\New.Project\Cinema\Cinema.Management.System\Views\_ViewImports.cshtml"
using Cinema.Management.System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ekin\Desktop\New.Project\Cinema\Cinema.Management.System\Views\_ViewImports.cshtml"
using Cinema.Management.System.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca6c7b968db9137823dc89d8f46527fca72cd10d", @"/Views/MainPage/MoviePage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26b2ab5b483ddc53d150517cfefb6c5dcf999151", @"/Views/_ViewImports.cshtml")]
    public class Views_MainPage_MoviePage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Cinema.Management.System.ViewModels.actorMovieViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-lg btn-dark mb-4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("text-decoration: none;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "TicketPage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateTicket", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ca6c7b968db9137823dc89d8f46527fca72cd10d4880", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Movie Page</title>
    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css"" rel=""stylesheet""
        integrity=""sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3"" crossorigin=""anonymous"">
    <link rel=""stylesheet"" href=""https://use.fontawesome.com/releases/v5.15.4/css/all.css"">
    <style>
        #background {
            background-image: url(https://www.arttablo.com/upload/U-sinema-salonu-fotograf-kanvas-tablo1461331435-800.jpg);
            background-attachment: fixed;
            background-position: center;
            background-repeat: no-repeat;
            background-size: cover;
        }
    </style>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ca6c7b968db9137823dc89d8f46527fca72cd10d6736", async() => {
                WriteLiteral("\r\n\r\n    ");
#nullable restore
#line 29 "C:\Users\Ekin\Desktop\New.Project\Cinema\Cinema.Management.System\Views\MainPage\MoviePage.cshtml"
Write(await Html.PartialAsync("_navbar"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    <!-- PARTIAL VIEW ILE YAPARSAK -->\r\n    <!--<partial name=\"_navbar\" /> -->\r\n\r\n    <h2 class=\"fw-bold text-capitalize text-center bg-white mt-5\"><strong>");
#nullable restore
#line 34 "C:\Users\Ekin\Desktop\New.Project\Cinema\Cinema.Management.System\Views\MainPage\MoviePage.cshtml"
                                                                     Write(Model.movie.movieName);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</strong></h2>
    <!-- AFİŞ VE FRAGMAN -->
    <!-- ROW 2 COLUMN'A BÖLÜNÜYOR -->
    <div class=""row mt-5"" id=""background"">

        <!-- FOTO BÖLÜMÜ -->
        <div class=""col-md-5 col-lg-4 col-xl-3 mx-auto my-4 text-center "">
            <img class=""ms-5 border border-5 rounded img-fluid""");
                BeginWriteAttribute("src", " src=", 1520, "", 1551, 1);
#nullable restore
#line 41 "C:\Users\Ekin\Desktop\New.Project\Cinema\Cinema.Management.System\Views\MainPage\MoviePage.cshtml"
WriteAttributeValue("", 1525, Model.movie.moviePhotoUrl, 1525, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 1551, "\"", 1557, 0);
                EndWriteAttribute();
                WriteLiteral(@" width=""255px"">
        </div>

        <!-- FRAGMAN BÖLÜMÜ -->
        <!-- RESPONSIVE YAPAMADIM FRAGMANI,çok az bi OVERFLOW OLUYO EKRANI KÜÇÜLTÜNCE -->
        <div class=""col-md-7 col-lg-8 col-xl-9 mx-auto my-auto text-center "">
            <iframe class=""border border-5 rounded"" width=""560"" height=""315""");
                BeginWriteAttribute("src", " src=", 1872, "", 1905, 1);
#nullable restore
#line 47 "C:\Users\Ekin\Desktop\New.Project\Cinema\Cinema.Management.System\Views\MainPage\MoviePage.cshtml"
WriteAttributeValue("", 1877, Model.movie.movieTrailerUrl, 1877, 28, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@"
                title=""YouTube video player"" frameborder=""0""
                allow=""accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture""
                allowfullscreen></iframe>
        </div>
    </div>
    <!-- ROW 2 COLUMN'A BÖLÜNÜYOR -->
    <!-- AFİŞ VE FRAGMAN -->
    <!-- FİLM INFO -->
    <section class=""filmInfo mt-5"">
        <div class=""container"">
            <h2 class=""text-center"">");
#nullable restore
#line 58 "C:\Users\Ekin\Desktop\New.Project\Cinema\Cinema.Management.System\Views\MainPage\MoviePage.cshtml"
                               Write(Model.movie.movieName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n            <p> <strong>Director: </strong> ");
#nullable restore
#line 59 "C:\Users\Ekin\Desktop\New.Project\Cinema\Cinema.Management.System\Views\MainPage\MoviePage.cshtml"
                                       Write(Model.movie.movieDirector.directorFirstName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
#nullable restore
#line 60 "C:\Users\Ekin\Desktop\New.Project\Cinema\Cinema.Management.System\Views\MainPage\MoviePage.cshtml"
           Write(Model.movie.movieDirector.directorLastName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n            <p>\r\n                <strong>Cast: </strong>\r\n\r\n            </p>\r\n            <div class=\"row\">\r\n                <div class=\"col-3\">\r\n                    <div><strong>Release Date:</strong> ");
#nullable restore
#line 67 "C:\Users\Ekin\Desktop\New.Project\Cinema\Cinema.Management.System\Views\MainPage\MoviePage.cshtml"
                                                   Write(Model.movie.movieReleaseDate);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                    <div><strong>Duration:</strong> ");
#nullable restore
#line 68 "C:\Users\Ekin\Desktop\New.Project\Cinema\Cinema.Management.System\Views\MainPage\MoviePage.cshtml"
                                               Write(Model.movie.movieDuration);

#line default
#line hidden
#nullable disable
                WriteLiteral(" Minutes</div>\r\n                    <div><strong>Category:</strong> ");
#nullable restore
#line 69 "C:\Users\Ekin\Desktop\New.Project\Cinema\Cinema.Management.System\Views\MainPage\MoviePage.cshtml"
                                               Write(Model.movie.movieCategory);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n\r\n\r\n                </div>\r\n                <div class=\"col-9\">\r\n                    <div>\r\n                        <strong>Summary: </strong>");
#nullable restore
#line 75 "C:\Users\Ekin\Desktop\New.Project\Cinema\Cinema.Management.System\Views\MainPage\MoviePage.cshtml"
                                             Write(Model.movie.movieSummary);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    </div>
                </div>
            </div>
        </div>
    </section>

    <br><br>
    <hr style=""border: 3px solid black;"">
    <br><br>

    <!-- FİLM VİZYONDAYSA BİLET AL -->
    <!--
        <a asp-controller=""Home""  asp-action=""Register"">
                        <button style=""background-color: orange;"">Sign Up</button>

                    </a>
    -->
    <!-- BUY TICKET -->
");
#nullable restore
#line 94 "C:\Users\Ekin\Desktop\New.Project\Cinema\Cinema.Management.System\Views\MainPage\MoviePage.cshtml"
     if (Model.movie.isShowing)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"container\">\r\n            <h2 class=\"text-center\">Watch Now!</h2>\r\n            <div class=\"btn-lg col-md-12 text-center\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ca6c7b968db9137823dc89d8f46527fca72cd10d13272", async() => {
                    WriteLiteral("Buy Ticket");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("asp", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 100 "C:\Users\Ekin\Desktop\New.Project\Cinema\Cinema.Management.System\Views\MainPage\MoviePage.cshtml"
                                            WriteLiteral(Model.movie.movieId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n            </div>\r\n        </div>\r\n");
                WriteLiteral("        <br>\r\n        <hr style=\"border: 3px solid black;\">\r\n        <br>\r\n");
#nullable restore
#line 108 "C:\Users\Ekin\Desktop\New.Project\Cinema\Cinema.Management.System\Views\MainPage\MoviePage.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"container\">\r\n            <h2 class=\"text-center pb-3\">📆 Not In Show - You can\'t buy a ticket ❌</h2>\r\n        </div>\r\n");
                WriteLiteral("        <br>\r\n        <hr style=\"border: 3px solid black;\">\r\n        <br>\r\n");
#nullable restore
#line 118 "C:\Users\Ekin\Desktop\New.Project\Cinema\Cinema.Management.System\Views\MainPage\MoviePage.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

    <!-- YORUMLAR (yorum yapması için giriş yapması gereksin mi?) -->
    <!--YORUM YAP -->
    <div id=""makeComment"" class=""container"">
        <h2>Add a comment</h2>
        <div class=""mb-3"">
            <label for=""makeComment"" class=""form-label"">Your comment:</label>
            <textarea style=""resize: none; height: 200px;"" class=""form-control"" id=""makeComment"" rows=""3""
                placeholder=""Your comment..."" maxlength=""500""></textarea>
        </div>
        <div class=""container"">
            <div class=""text-end"">
                <button class=""btn-lg btn-danger mb-4"">Spoiler</button>
                <button class=""btn-lg btn-dark mb-4"">Post</button>
            </div>
        </div>
    </div>

    <br>

    <!-- YORUM OKU -->
    <div id=""readComment"" class=""container"">
        <h2 class=""mb-4"">Other comments</h2>
        <div class=""row"">
            <!-- Kullanıcı bilgisi -->
            <div class=""col-3 text-center"">
                <i class=""fas fa-user-circl");
                WriteLiteral(@"e fa-5x""></i>
                <p class=""mt-3""><strong>Ekin Uzunbaz</strong></p>
            </div>
            <!-- Yorum içeriği -->
            <div class=""col-9"">
                <p>
                    Lorem ipsum, dolor sit amet consectetur adipisicing elit. Minima perspiciatis aspernatur fugiat hic
                    nesciunt quos, optio numquam! Quae reiciendis voluptatum labore itaque exercitationem atque ipsum,
                    dolore nisi, fugiat nihil debitis doloribus amet, ab culpa voluptatibus animi minus? Pariatur
                    accusantium placeat, enim aliquid dolore laboriosam ex numquam assumenda libero architecto unde
                    expedita animi voluptates quos cum praesentium asperiores itaque cumque. Veniam nesciunt eveniet
                    dolorum veritatis earum dolores eligendi et quis odio aut perspiciatis aliquid consequatur esse odit
                    assumenda, velit quidem explicabo expedita! Reprehenderit assumenda ea, excepturi voluptas quibusda");
                WriteLiteral(@"m
                    itaque praesentium nostrum necessitatibus nisi architecto neque porro eos, voluptatibus suscipit
                    explicabo autem.
                </p>
            </div>
        </div>
        <br>
        <hr style=""border: 1px solid black;"">
        <br>

        <div class=""row"">
            <!-- Kullanıcı bilgisi -->
            <div class=""col-3 text-center"">
                <i class=""fas fa-user-circle fa-5x""></i>
                <p class=""mt-3""><strong>Ekin Uzunbaz</strong></p>
            </div>
            <!-- Yorum içeriği -->
            <div class=""col-9"">
                <p>
                    Lorem ipsum, dolor sit amet consectetur adipisicing elit. Minima perspiciatis aspernatur fugiat hic
                    nesciunt quos, optio numquam! Quae reiciendis voluptatum labore itaque exercitationem atque ipsum,
                    dolore nisi, fugiat nihil debitis doloribus amet, ab culpa voluptatibus animi minus? Pariatur
                    accusan");
                WriteLiteral(@"tium placeat, enim aliquid dolore laboriosam ex numquam assumenda libero architecto unde
                    expedita animi voluptates quos cum praesentium asperiores itaque cumque. Veniam nesciunt eveniet
                    dolorum veritatis earum dolores eligendi et quis odio aut perspiciatis aliquid consequatur esse odit
                    assumenda, velit quidem explicabo expedita! Reprehenderit assumenda ea, excepturi voluptas quibusdam
                    itaque praesentium nostrum necessitatibus nisi architecto neque porro eos, voluptatibus suscipit
                    explicabo autem.
                </p>
            </div>
        </div>
    </div>

    <br><br>
    <hr style=""border: 3px solid black;"">
    <br><br>

    <!-- BENZER FİLMLER (sorguda LIKE dicez falan) -->

    <section class=""benzerFilmler container"">
        <h2>May you interested in...</h2>
        <div id=""slider-benzerFilmler"" class=""carousel slide carousel-fade my-3"" data-bs-ride=""carousel"">
            <div");
                WriteLiteral(@" class=""carousel-indicators"">
                <button type=""button"" data-bs-target=""#slider-benzerFilmler"" data-bs-slide-to=""0"" class=""active""
                    aria-current=""true"" aria-label=""Slide 1""></button>
                <button type=""button"" data-bs-target=""#slider-benzerFilmler"" data-bs-slide-to=""1""
                    aria-label=""Slide 2""></button>
                <button type=""button"" data-bs-target=""#slider-benzerFilmler"" data-bs-slide-to=""2""
                    aria-label=""Slide 3""></button>
            </div>
            <div class=""carousel-inner"">
                <div class=""carousel-item active"">
                    <!-- Afişine tıklayınca film'in sayfasına gitsin burda-->
                    <!-- YAZSINI ALTA ALAMADIM -->
                    <a href=""promo1.png""><img class=""d-block w-100 img-fluid"" src=""promo1.png""");
                BeginWriteAttribute("alt", " alt=\"", 9261, "\"", 9267, 0);
                EndWriteAttribute();
                WriteLiteral(@"></a>
                    <div class=""carousel-caption carousel-caption2 d-none d-md-block"">
                        <h5>Slider Header 1</h5>
                        <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Voluptates, eaque!</p>
                    </div>
                    <div class=""carousel-caption d-none d-md-block"">
                        <h5>Slider Header 1</h5>
                        <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Voluptates, eaque!</p>
                    </div>
                </div>
                <div class=""carousel-item"">
                    <img class=""d-block w-100 img-fluid"" src=""promo2.png""");
                BeginWriteAttribute("alt", " alt=\"", 9949, "\"", 9955, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                    <div class=""carousel-caption d-none d-md-block"">
                        <h5>Slider Header 1</h5>
                        <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Voluptates, eaque!</p>
                    </div>
                </div>
                <div class=""carousel-item"">
                    <img class=""d-block w-100 img-fluid"" src=""promo3.png""");
                BeginWriteAttribute("alt", " alt=\"", 10358, "\"", 10364, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                    <div class=""carousel-caption d-none d-md-block"">
                        <h5>Slider Header 1</h5>
                        <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Voluptates, eaque!</p>
                    </div>
                </div>
            </div>
            <button class=""carousel-control-prev"" type=""button"" data-bs-target=""#slider-benzerFilmler""
                data-bs-slide=""prev"">
                <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                <span class=""visually-hidden"">Previous</span>
            </button>
            <button class=""carousel-control-next"" type=""button"" data-bs-target=""#slider-benzerFilmler""
                data-bs-slide=""next"">
                <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                <span class=""visually-hidden"">Next</span>
            </button>
        </div>

    </section>

    <br><br>
    <hr style=""border: 3px solid black;"">
   ");
                WriteLiteral(" <br>\r\n\r\n    ");
#nullable restore
#line 255 "C:\Users\Ekin\Desktop\New.Project\Cinema\Cinema.Management.System\Views\MainPage\MoviePage.cshtml"
Write(await Html.PartialAsync("_footer"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\r\n    <script src=\"https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js\"\r\n        integrity=\"sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p\"\r\n        crossorigin=\"anonymous\"></script>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Cinema.Management.System.ViewModels.actorMovieViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
