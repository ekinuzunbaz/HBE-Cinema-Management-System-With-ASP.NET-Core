#pragma checksum "C:\Users\90555\Desktop\dbmsproje\Cinema\Cinema\Cinema.Management.System\Views\MainPage\MainPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7cc632c732d2aeccb51a8652b62966afa8d92e3b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MainPage_MainPage), @"mvc.1.0.view", @"/Views/MainPage/MainPage.cshtml")]
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
#line 1 "C:\Users\90555\Desktop\dbmsproje\Cinema\Cinema\Cinema.Management.System\Views\_ViewImports.cshtml"
using Cinema.Management.System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\90555\Desktop\dbmsproje\Cinema\Cinema\Cinema.Management.System\Views\_ViewImports.cshtml"
using Cinema.Management.System.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7cc632c732d2aeccb51a8652b62966afa8d92e3b", @"/Views/MainPage/MainPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26b2ab5b483ddc53d150517cfefb6c5dcf999151", @"/Views/_ViewImports.cshtml")]
    public class Views_MainPage_MainPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Movie>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-block w-100 img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/promo1.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/promo2.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/promo3.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n<!--HALO DENEME -->\r\n<!--EKİN DENEME -->\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7cc632c732d2aeccb51a8652b62966afa8d92e3b5346", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Main Page</title>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7cc632c732d2aeccb51a8652b62966afa8d92e3b7199", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 29 "C:\Users\90555\Desktop\dbmsproje\Cinema\Cinema\Cinema.Management.System\Views\MainPage\MainPage.cshtml"
Write(await Html.PartialAsync("_navbar"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

    <!-- PROMOTION AND A FEW FILMS -->
    <section class=""promo"">
        <div id=""slider-promo"" class=""carousel slide carousel-fade my-3"" data-bs-ride=""carousel"">
            <div class=""carousel-indicators"">
                <button type=""button"" data-bs-target=""#slider-promo"" data-bs-slide-to=""0"" class=""active""
                    aria-current=""true"" aria-label=""Slide 1""></button>
                <button type=""button"" data-bs-target=""#slider-promo"" data-bs-slide-to=""1"" aria-label=""Slide 2""></button>
                <button type=""button"" data-bs-target=""#slider-promo"" data-bs-slide-to=""2"" aria-label=""Slide 3""></button>
            </div>
            <div class=""carousel-inner"">
                <div class=""carousel-item active"">
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7cc632c732d2aeccb51a8652b62966afa8d92e3b8542", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    <div class=""carousel-caption d-none d-md-block"">
                        <h5>Slider Header 1</h5>
                        <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Voluptates, eaque!</p>
                    </div>
                </div>
                <div class=""carousel-item"">
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7cc632c732d2aeccb51a8652b62966afa8d92e3b10152", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    <div class=""carousel-caption d-none d-md-block"">
                        <h5>Slider Header 1</h5>
                        <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Voluptates, eaque!</p>
                    </div>
                </div>
                <div class=""carousel-item"">
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7cc632c732d2aeccb51a8652b62966afa8d92e3b11763", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    <div class=""carousel-caption d-none d-md-block"">
                        <h5>Slider Header 1</h5>
                        <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Voluptates, eaque!</p>
                    </div>
                </div>
            </div>
            <button class=""carousel-control-prev"" type=""button"" data-bs-target=""#slider-promo"" data-bs-slide=""prev"">
                <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                <span class=""visually-hidden"">Previous</span>
            </button>
            <button class=""carousel-control-next"" type=""button"" data-bs-target=""#slider-promo"" data-bs-slide=""next"">
                <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                <span class=""visually-hidden"">Next</span>
            </button>
        </div>

    </section>
    <!-- PROMOTION AND A FEW FILMS -->

    <br>
    <hr style=""border-top: 5px solid red;"">
    <br>


  ");
                WriteLiteral(@"  <div class=""container"" id=""background"">
        <div style=""color: white;"">
            <a href=""#"" class=""navbar-brand "">HBE CINEMA HALL</a>
            <p>
                Lorem ipsum dolor sit amet consectetur adipisicing elit. Qui soluta maiores exercitationem omnis.
                Commodi
                totam dolor doloribus rerum nam autem eius voluptatum natus id molestiae culpa aliquid, dolorum
                consequuntur
                rem, odit sapiente vitae fugiat nihil ipsam iste distinctio iusto eligendi repellat. Nobis nemo corrupti
                facere quod necessitatibus, assumenda impedit laborum!
                Lorem ipsum dolor sit amet consectetur adipisicing elit. Qui soluta maiores exercitationem omnis.
                Commodi
                totam dolor doloribus rerum nam autem eius voluptatum natus id molestiae culpa aliquid, dolorum
                consequuntur
                rem, odit sapiente vitae fugiat nihil ipsam iste distinctio iusto eligendi repellat.");
                WriteLiteral(@" Nobis nemo corrupti
                facere quod necessitatibus, assumenda impedit laborum!
                Lorem ipsum dolor sit amet consectetur adipisicing elit. Qui soluta maiores exercitationem omnis.
                Commodi
                totam dolor doloribus rerum nam autem eius voluptatum natus id molestiae culpa aliquid, dolorum
                consequuntur
                rem, odit sapiente vitae fugiat nihil ipsam iste distinctio iusto eligendi repellat. Nobis nemo corrupti
                facere quod necessitatibus, assumenda impedit laborum!
            </p>
        </div>

    </div>

    <br>
    <hr style=""border-top: 5px solid red;"">
    <br>

    <!-- ON SHOWING FILMS -->
    <section class=""onShowing"">
        <div class=""container"">
            <div class=""row"">
                <h2>On Showing</h2>
            </div>
        </div>

        <div class=""container"">


         <div id=""slider-onShowing"" class=""carousel slide carousel-fade my-3"" data-bs-ride=""caro");
                WriteLiteral("usel\">\r\n            <div class=\"carousel-indicators\">\r\n");
#nullable restore
#line 125 "C:\Users\90555\Desktop\dbmsproje\Cinema\Cinema\Cinema.Management.System\Views\MainPage\MainPage.cshtml"
                 for (int i = 0; i < @Model.Count; i++)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 127 "C:\Users\90555\Desktop\dbmsproje\Cinema\Cinema\Cinema.Management.System\Views\MainPage\MainPage.cshtml"
                     if (@Model[i].isShowing && i == 0)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <button type=\"button\" data-bs-target=\"#slider-onShowing\" data-bs-slide-to=\"");
#nullable restore
#line 129 "C:\Users\90555\Desktop\dbmsproje\Cinema\Cinema\Cinema.Management.System\Views\MainPage\MainPage.cshtml"
                                                                                              Write(i);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" class=\"active\"\r\n                    aria-current=\"true\" aria-label=\"Slide 1\"></button>\r\n");
#nullable restore
#line 131 "C:\Users\90555\Desktop\dbmsproje\Cinema\Cinema\Cinema.Management.System\Views\MainPage\MainPage.cshtml"
                    }
                    else if (@Model[i].isShowing && i!=0)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <button type=\"button\" data-bs-target=\"#slider-onShowing\" data-bs-slide-to=\"");
#nullable restore
#line 134 "C:\Users\90555\Desktop\dbmsproje\Cinema\Cinema\Cinema.Management.System\Views\MainPage\MainPage.cshtml"
                                                                                              Write(i);

#line default
#line hidden
#nullable disable
                WriteLiteral("\"\r\n                    aria-label=\"Slide 2\"></button>\r\n");
#nullable restore
#line 136 "C:\Users\90555\Desktop\dbmsproje\Cinema\Cinema\Cinema.Management.System\Views\MainPage\MainPage.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 136 "C:\Users\90555\Desktop\dbmsproje\Cinema\Cinema\Cinema.Management.System\Views\MainPage\MainPage.cshtml"
                     

                }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                \r\n            </div> \r\n            <div class=\"carousel-inner\">\r\n\r\n");
#nullable restore
#line 144 "C:\Users\90555\Desktop\dbmsproje\Cinema\Cinema\Cinema.Management.System\Views\MainPage\MainPage.cshtml"
                 for (int i = 0; i < @Model.Count; i++)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 146 "C:\Users\90555\Desktop\dbmsproje\Cinema\Cinema\Cinema.Management.System\Views\MainPage\MainPage.cshtml"
                     if (@Model[i].isShowing && i == 0)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <div class=\"carousel-item active\">\r\n                            <a href=\"promo2.png\"><img class=\"d-block  w-100 img-fluid\"");
                BeginWriteAttribute("src", " src=\"", 6869, "\"", 6899, 1);
#nullable restore
#line 149 "C:\Users\90555\Desktop\dbmsproje\Cinema\Cinema\Cinema.Management.System\Views\MainPage\MainPage.cshtml"
WriteAttributeValue("", 6875, Model[i].moviePosterUrl, 6875, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 6900, "\"", 6906, 0);
                EndWriteAttribute();
                WriteLiteral("></a>\r\n                            <div class=\"carousel-caption carousel-caption2 d-none d-md-block\">\r\n                                <h5>");
#nullable restore
#line 151 "C:\Users\90555\Desktop\dbmsproje\Cinema\Cinema\Cinema.Management.System\Views\MainPage\MainPage.cshtml"
                               Write(Model[i].movieName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n                                <p>");
#nullable restore
#line 152 "C:\Users\90555\Desktop\dbmsproje\Cinema\Cinema\Cinema.Management.System\Views\MainPage\MainPage.cshtml"
                              Write(Model[i].movieSummary);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 155 "C:\Users\90555\Desktop\dbmsproje\Cinema\Cinema\Cinema.Management.System\Views\MainPage\MainPage.cshtml"
                    }
                    else if (@Model[i].isShowing && i!=0)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <div class=\"carousel-item\">\r\n                            <a href=\"promo2.png\"><img class=\"d-block w-100 img-fluid\"");
                BeginWriteAttribute("src", " src=\"", 7446, "\"", 7476, 1);
#nullable restore
#line 159 "C:\Users\90555\Desktop\dbmsproje\Cinema\Cinema\Cinema.Management.System\Views\MainPage\MainPage.cshtml"
WriteAttributeValue("", 7452, Model[i].moviePosterUrl, 7452, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 7477, "\"", 7483, 0);
                EndWriteAttribute();
                WriteLiteral("></a>\r\n                            <div class=\"carousel-caption carousel-caption2 d-none d-md-block\">\r\n                                <h5>");
#nullable restore
#line 161 "C:\Users\90555\Desktop\dbmsproje\Cinema\Cinema\Cinema.Management.System\Views\MainPage\MainPage.cshtml"
                               Write(Model[i].movieName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n                                <p>");
#nullable restore
#line 162 "C:\Users\90555\Desktop\dbmsproje\Cinema\Cinema\Cinema.Management.System\Views\MainPage\MainPage.cshtml"
                              Write(Model[i].movieSummary);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 165 "C:\Users\90555\Desktop\dbmsproje\Cinema\Cinema\Cinema.Management.System\Views\MainPage\MainPage.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 165 "C:\Users\90555\Desktop\dbmsproje\Cinema\Cinema\Cinema.Management.System\Views\MainPage\MainPage.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                
            </div>
            <button class=""carousel-control-prev"" type=""button"" data-bs-target=""#slider-onShowing"" data-bs-slide=""prev"">
                <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                <span class=""visually-hidden"">Previous</span>
            </button>
            <button class=""carousel-control-next"" type=""button"" data-bs-target=""#slider-onShowing"" data-bs-slide=""next"">
                <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                <span class=""visually-hidden"">Next</span>
            </button>
        </div>
</div>
    </section>
    

    <br>
    <hr style=""border-top: 5px solid red;"">
    <br>
    <!-- NOT SHOWING FILMS -->

    <section class=""notShowing"">
        <div class=""container"">
            <div class=""row"">
                <h2>Not Showing</h2>
            </div>
        </div>

        <div class=""container"">

         <div id=""slider-notShowing"" class=""caro");
                WriteLiteral("usel slide carousel-fade my-3\" data-bs-ride=\"carousel\">\r\n            <div class=\"carousel-indicators\">\r\n");
#nullable restore
#line 198 "C:\Users\90555\Desktop\dbmsproje\Cinema\Cinema\Cinema.Management.System\Views\MainPage\MainPage.cshtml"
                 for (int i = 0; i < @Model.Count; i++)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 200 "C:\Users\90555\Desktop\dbmsproje\Cinema\Cinema\Cinema.Management.System\Views\MainPage\MainPage.cshtml"
                     if (@Model[i].isShowing == false && i == 0)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <button type=\"button\" data-bs-target=\"#slider-notShowing\" data-bs-slide-to=\"");
#nullable restore
#line 202 "C:\Users\90555\Desktop\dbmsproje\Cinema\Cinema\Cinema.Management.System\Views\MainPage\MainPage.cshtml"
                                                                                               Write(i);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" class=\"active\"\r\n                    aria-current=\"true\" aria-label=\"Slide 1\"></button>\r\n");
#nullable restore
#line 204 "C:\Users\90555\Desktop\dbmsproje\Cinema\Cinema\Cinema.Management.System\Views\MainPage\MainPage.cshtml"
                    }
                    else if (@Model[i].isShowing == false && i!=0)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <button type=\"button\" data-bs-target=\"#slider-notShowing\" data-bs-slide-to=\"");
#nullable restore
#line 207 "C:\Users\90555\Desktop\dbmsproje\Cinema\Cinema\Cinema.Management.System\Views\MainPage\MainPage.cshtml"
                                                                                               Write(i);

#line default
#line hidden
#nullable disable
                WriteLiteral("\"\r\n                    aria-label=\"Slide 2\"></button>\r\n");
#nullable restore
#line 209 "C:\Users\90555\Desktop\dbmsproje\Cinema\Cinema\Cinema.Management.System\Views\MainPage\MainPage.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 209 "C:\Users\90555\Desktop\dbmsproje\Cinema\Cinema\Cinema.Management.System\Views\MainPage\MainPage.cshtml"
                     

                }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                \r\n            </div> \r\n            <div class=\"carousel-inner\">\r\n\r\n");
#nullable restore
#line 217 "C:\Users\90555\Desktop\dbmsproje\Cinema\Cinema\Cinema.Management.System\Views\MainPage\MainPage.cshtml"
                 for (int i = 0; i < @Model.Count; i++)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 219 "C:\Users\90555\Desktop\dbmsproje\Cinema\Cinema\Cinema.Management.System\Views\MainPage\MainPage.cshtml"
                     if (@Model[i].isShowing == false && i == 0)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <div class=\"carousel-item\">\r\n                            <a href=\"promo2.png\"><img class=\"d-block  w-100 img-fluid\"");
                BeginWriteAttribute("src", " src=\"", 10011, "\"", 10041, 1);
#nullable restore
#line 222 "C:\Users\90555\Desktop\dbmsproje\Cinema\Cinema\Cinema.Management.System\Views\MainPage\MainPage.cshtml"
WriteAttributeValue("", 10017, Model[i].moviePosterUrl, 10017, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 10042, "\"", 10048, 0);
                EndWriteAttribute();
                WriteLiteral("></a>\r\n                            <div class=\"carousel-caption carousel-caption2 d-none d-md-block\">\r\n                                <h5>");
#nullable restore
#line 224 "C:\Users\90555\Desktop\dbmsproje\Cinema\Cinema\Cinema.Management.System\Views\MainPage\MainPage.cshtml"
                               Write(Model[i].movieName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n                                <p>");
#nullable restore
#line 225 "C:\Users\90555\Desktop\dbmsproje\Cinema\Cinema\Cinema.Management.System\Views\MainPage\MainPage.cshtml"
                              Write(Model[i].movieSummary);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 228 "C:\Users\90555\Desktop\dbmsproje\Cinema\Cinema\Cinema.Management.System\Views\MainPage\MainPage.cshtml"
                    }
                    else if (@Model[i].isShowing == false && i!=0)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <div class=\"carousel-item active\">\r\n                            <a href=\"promo2.png\"><img class=\"d-block w-100 img-fluid\"");
                BeginWriteAttribute("src", " src=\"", 10604, "\"", 10634, 1);
#nullable restore
#line 232 "C:\Users\90555\Desktop\dbmsproje\Cinema\Cinema\Cinema.Management.System\Views\MainPage\MainPage.cshtml"
WriteAttributeValue("", 10610, Model[i].moviePosterUrl, 10610, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 10635, "\"", 10641, 0);
                EndWriteAttribute();
                WriteLiteral("></a>\r\n                            <div class=\"carousel-caption carousel-caption2 d-none d-md-block\">\r\n                                <h5>");
#nullable restore
#line 234 "C:\Users\90555\Desktop\dbmsproje\Cinema\Cinema\Cinema.Management.System\Views\MainPage\MainPage.cshtml"
                               Write(Model[i].movieName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n                                <p>");
#nullable restore
#line 235 "C:\Users\90555\Desktop\dbmsproje\Cinema\Cinema\Cinema.Management.System\Views\MainPage\MainPage.cshtml"
                              Write(Model[i].movieSummary);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 238 "C:\Users\90555\Desktop\dbmsproje\Cinema\Cinema\Cinema.Management.System\Views\MainPage\MainPage.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 238 "C:\Users\90555\Desktop\dbmsproje\Cinema\Cinema\Cinema.Management.System\Views\MainPage\MainPage.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                
            </div>
            <button class=""carousel-control-prev"" type=""button"" data-bs-target=""#slider-notShowing"" data-bs-slide=""prev"">
                <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                <span class=""visually-hidden"">Previous</span>
            </button>
            <button class=""carousel-control-next"" type=""button"" data-bs-target=""#slider-notShowing"" data-bs-slide=""next"">
                <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                <span class=""visually-hidden"">Next</span>
            </button>
        </div>
        </div>
    </section>
    <!-- ON SHOWING FILMS -->

    <br>
    <hr style=""border-top: 5px solid red;"">
    <br>

    ");
#nullable restore
#line 259 "C:\Users\90555\Desktop\dbmsproje\Cinema\Cinema\Cinema.Management.System\Views\MainPage\MainPage.cshtml"
Write(await Html.PartialAsync("_footer"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    <script src=\"https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js\"\r\n        integrity=\"sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p\"\r\n        crossorigin=\"anonymous\"></script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Movie>> Html { get; private set; }
    }
}
#pragma warning restore 1591
