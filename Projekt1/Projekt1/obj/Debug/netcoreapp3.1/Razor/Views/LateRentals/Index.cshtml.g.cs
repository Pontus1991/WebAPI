#pragma checksum "C:\Users\Pontu\source\repos\WebAPI\Projekt1\Projekt1\Views\LateRentals\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "140645a8753cdeb8b38704f616edadc4d7daaf3e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LateRentals_Index), @"mvc.1.0.view", @"/Views/LateRentals/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"140645a8753cdeb8b38704f616edadc4d7daaf3e", @"/Views/LateRentals/Index.cshtml")]
    public class Views_LateRentals_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Projekt1.Models.Rental>>
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
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\Pontu\source\repos\WebAPI\Projekt1\Projekt1\Views\LateRentals\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "140645a8753cdeb8b38704f616edadc4d7daaf3e2983", async() => {
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css\" integrity=\"sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh\" crossorigin=\"anonymous\">\r\n");
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
            WriteLiteral("\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "140645a8753cdeb8b38704f616edadc4d7daaf3e4184", async() => {
                WriteLiteral(@"
    <div class=""row"" style=""height: 150px;"">
        <h1 style=""font-size: 60px;margin-top: 32px;margin-left: 450px;"">CentrumBiblioteket</h1>
    </div>

    <div class=""row"">
        <div class=""col"" style=""max-width: 200px;"">
            <ul class=""list-group"">
                <li class=""list-group-item"">
                    <span>Sök...</span>
                </li>
                <li class=""list-group-item"">
                    <span>Startsida</span>
                </li>
                <li class=""list-group-item"">
                    <span>Artiklar</span>
                </li>
                <li class=""list-group-item"">
                    <span>Uppföljning/Statistik</span>
                </li>
                <li class=""list-group-item"">
                    <span>Böcker som är utlånade</span>
                </li>
                <li class=""list-group-item"">
                    <span>Försenade Utlån</span>
                </li>
            </ul>
        </div>
        <di");
                WriteLiteral(@"v class=""col"">
            <table class=""table"">
                <thead>
                    <tr>
                        <th>
                            Förnamn
                        </th>
                        <th>
                            Efternamn
                        </th>
                        <th>
                            Telefonnummer
                        </th>
                        <th>
                            Epostadress
                        </th>
                        <th>
                            Boktitel
                        </th>
                        <th>
                            Uthyrningsdatum
                        </th>
                        <th>
                            Inlämningsdatum
                        </th>
                        <th>
                            Bok tillbakalämnad
                        </th>
                        <th></th>
                    </tr>
                </thead>
          ");
                WriteLiteral("      <tbody>\r\n");
#nullable restore
#line 73 "C:\Users\Pontu\source\repos\WebAPI\Projekt1\Projekt1\Views\LateRentals\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
#nullable restore
#line 77 "C:\Users\Pontu\source\repos\WebAPI\Projekt1\Projekt1\Views\LateRentals\Index.cshtml"
                           Write(item.Customer.FirstName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 80 "C:\Users\Pontu\source\repos\WebAPI\Projekt1\Projekt1\Views\LateRentals\Index.cshtml"
                           Write(item.Customer.LastName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 83 "C:\Users\Pontu\source\repos\WebAPI\Projekt1\Projekt1\Views\LateRentals\Index.cshtml"
                           Write(item.Customer.PhoneNumber);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 86 "C:\Users\Pontu\source\repos\WebAPI\Projekt1\Projekt1\Views\LateRentals\Index.cshtml"
                           Write(item.Customer.EmailAddress);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 89 "C:\Users\Pontu\source\repos\WebAPI\Projekt1\Projekt1\Views\LateRentals\Index.cshtml"
                           Write(item.Inventory.Book.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 92 "C:\Users\Pontu\source\repos\WebAPI\Projekt1\Projekt1\Views\LateRentals\Index.cshtml"
                           Write(item.RentalDate);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 95 "C:\Users\Pontu\source\repos\WebAPI\Projekt1\Projekt1\Views\LateRentals\Index.cshtml"
                           Write(item.ReturnDate);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n");
                WriteLiteral(@"                                <form action=""/action_page.php"">
                                    <input type=""checkbox"">
                                    <label for=""Rentalid"">Tillbakalämnad</label><br>
                                </form>
                            </td>
                        </tr>
");
#nullable restore
#line 107 "C:\Users\Pontu\source\repos\WebAPI\Projekt1\Projekt1\Views\LateRentals\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                </tbody>
            </table>
            <button class=""btn btn-primary"" type=""button"">Spara</button>
            <input class=""btn btn-danger"" type=""submit"" value=""Delete"" />
            <input type=""submit"" asp-action=""DeleteConfirmed"" method=""post"" value=""Submit"">
        </div>
    </div>


");
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
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Projekt1.Models.Rental>> Html { get; private set; }
    }
}
#pragma warning restore 1591
