#pragma checksum "C:\Users\Ekin\Desktop\New.Project\Cinema\Cinema.Management.System\Views\AdminMainPage\AdminTickets.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e519f9c0b6129f9daaddfea7f0d8f7ddb0dba07"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminMainPage_AdminTickets), @"mvc.1.0.view", @"/Views/AdminMainPage/AdminTickets.cshtml")]
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
#nullable restore
#line 3 "C:\Users\Ekin\Desktop\New.Project\Cinema\Cinema.Management.System\Views\_ViewImports.cshtml"
using Cinema.Management.System.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e519f9c0b6129f9daaddfea7f0d8f7ddb0dba07", @"/Views/AdminMainPage/AdminTickets.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42fd429d129da1b7030d35220f8e50d42701dc4f", @"/Views/_ViewImports.cshtml")]
    public class Views_AdminMainPage_AdminTickets : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Ticket>>
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e519f9c0b6129f9daaddfea7f0d8f7ddb0dba073619", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Tickets</title>
    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css"" rel=""stylesheet""
        integrity=""sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3"" crossorigin=""anonymous"">
    <link rel=""stylesheet"" href=""https://use.fontawesome.com/releases/v5.15.4/css/all.css"">
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e519f9c0b6129f9daaddfea7f0d8f7ddb0dba075119", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 17 "C:\Users\Ekin\Desktop\New.Project\Cinema\Cinema.Management.System\Views\AdminMainPage\AdminTickets.cshtml"
Write(await Html.PartialAsync("_admNavbar"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

        <div class=""row"">
    <div class=""col-md-12"">
        <h1 class=""h3"">All Tickets</h1>
        <hr>
       <table class=""table table-bordered mt-3"">
            <thead>
                <tr>
                    <td style=""width: 20px;"">Ticket Id</td>
                    <td style=""width: 20px;"">User Id</td>
                    <td style=""width: 20px;"">Session Id</td>
                    <td style=""width: 20px;"">Session Time</td>
                    <td style=""width: 20px;"">Seat Id</td>
                    <td style=""width: 20px;"">Cinema Hall Name</td>
                    <td style=""width: 20px;"">Movie Name</td>
                    <td style=""width: 20px;"">User FirstName</td>
                    <td style=""width: 20px;"">User LastName</td>
                    <td style=""width: 20px;"">User Email</td>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 39 "C:\Users\Ekin\Desktop\New.Project\Cinema\Cinema.Management.System\Views\AdminMainPage\AdminTickets.cshtml"
                 if(Model.Count > 0)
                {
                       

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\Ekin\Desktop\New.Project\Cinema\Cinema.Management.System\Views\AdminMainPage\AdminTickets.cshtml"
                        foreach (Ticket ticket in Model)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 44 "C:\Users\Ekin\Desktop\New.Project\Cinema\Cinema.Management.System\Views\AdminMainPage\AdminTickets.cshtml"
                               Write(ticket.ticketId);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 45 "C:\Users\Ekin\Desktop\New.Project\Cinema\Cinema.Management.System\Views\AdminMainPage\AdminTickets.cshtml"
                               Write(ticket.userId);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 46 "C:\Users\Ekin\Desktop\New.Project\Cinema\Cinema.Management.System\Views\AdminMainPage\AdminTickets.cshtml"
                               Write(ticket.sessionId);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 47 "C:\Users\Ekin\Desktop\New.Project\Cinema\Cinema.Management.System\Views\AdminMainPage\AdminTickets.cshtml"
                               Write(ticket.sessionTime);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 48 "C:\Users\Ekin\Desktop\New.Project\Cinema\Cinema.Management.System\Views\AdminMainPage\AdminTickets.cshtml"
                               Write(ticket.seatId);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 49 "C:\Users\Ekin\Desktop\New.Project\Cinema\Cinema.Management.System\Views\AdminMainPage\AdminTickets.cshtml"
                               Write(ticket.cinemaHallName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 50 "C:\Users\Ekin\Desktop\New.Project\Cinema\Cinema.Management.System\Views\AdminMainPage\AdminTickets.cshtml"
                               Write(ticket.movieName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 51 "C:\Users\Ekin\Desktop\New.Project\Cinema\Cinema.Management.System\Views\AdminMainPage\AdminTickets.cshtml"
                               Write(ticket.userFirstName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 52 "C:\Users\Ekin\Desktop\New.Project\Cinema\Cinema.Management.System\Views\AdminMainPage\AdminTickets.cshtml"
                               Write(ticket.userLastName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 53 "C:\Users\Ekin\Desktop\New.Project\Cinema\Cinema.Management.System\Views\AdminMainPage\AdminTickets.cshtml"
                               Write(ticket.userEmail);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n\r\n");
                WriteLiteral("                            </tr>\r\n");
#nullable restore
#line 63 "C:\Users\Ekin\Desktop\New.Project\Cinema\Cinema.Management.System\Views\AdminMainPage\AdminTickets.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "C:\Users\Ekin\Desktop\New.Project\Cinema\Cinema.Management.System\Views\AdminMainPage\AdminTickets.cshtml"
                         
                }else{

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"alert alert-warning\">\r\n                        <h3>No Tickets!</h3>\r\n                    </div>\r\n");
#nullable restore
#line 68 "C:\Users\Ekin\Desktop\New.Project\Cinema\Cinema.Management.System\Views\AdminMainPage\AdminTickets.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n\r\n    \r\n\r\n    ");
#nullable restore
#line 76 "C:\Users\Ekin\Desktop\New.Project\Cinema\Cinema.Management.System\Views\AdminMainPage\AdminTickets.cshtml"
Write(await Html.PartialAsync("_footer"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\r\n    <script src=\"https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js\"\r\n        integrity=\"sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p\"\r\n        crossorigin=\"anonymous\"></script>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Ticket>> Html { get; private set; }
    }
}
#pragma warning restore 1591
