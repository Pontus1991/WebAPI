#pragma checksum "C:\Users\Pontu\source\repos\WebAPI\Projekt1\projekt1\Views\LateRentals\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "00234ff576bb3ac82487f8b6b4db51cbb5a96afc"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00234ff576bb3ac82487f8b6b4db51cbb5a96afc", @"/Views/LateRentals/Index.cshtml")]
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Pontu\source\repos\WebAPI\Projekt1\projekt1\Views\LateRentals\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "00234ff576bb3ac82487f8b6b4db51cbb5a96afc2839", async() => {
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
            WriteLiteral("\r\n\r\n<h1 class=\"text-danger\">Index</h1>\r\n\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "C:\Users\Pontu\source\repos\WebAPI\Projekt1\projekt1\Views\LateRentals\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.RentalDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "C:\Users\Pontu\source\repos\WebAPI\Projekt1\projekt1\Views\LateRentals\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ReturnDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "C:\Users\Pontu\source\repos\WebAPI\Projekt1\projekt1\Views\LateRentals\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Rented));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 29 "C:\Users\Pontu\source\repos\WebAPI\Projekt1\projekt1\Views\LateRentals\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Inventory));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 35 "C:\Users\Pontu\source\repos\WebAPI\Projekt1\projekt1\Views\LateRentals\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 38 "C:\Users\Pontu\source\repos\WebAPI\Projekt1\projekt1\Views\LateRentals\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.RentalDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 41 "C:\Users\Pontu\source\repos\WebAPI\Projekt1\projekt1\Views\LateRentals\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ReturnDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 44 "C:\Users\Pontu\source\repos\WebAPI\Projekt1\projekt1\Views\LateRentals\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Rented));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 47 "C:\Users\Pontu\source\repos\WebAPI\Projekt1\projekt1\Views\LateRentals\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Inventory.InventoryId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1446, "\"", 1475, 1);
#nullable restore
#line 50 "C:\Users\Pontu\source\repos\WebAPI\Projekt1\projekt1\Views\LateRentals\Index.cshtml"
WriteAttributeValue("", 1461, item.RentalId, 1461, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n                <a asp-action=\"Details\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1528, "\"", 1557, 1);
#nullable restore
#line 51 "C:\Users\Pontu\source\repos\WebAPI\Projekt1\projekt1\Views\LateRentals\Index.cshtml"
WriteAttributeValue("", 1543, item.RentalId, 1543, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a> |\r\n                <a asp-action=\"Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1612, "\"", 1641, 1);
#nullable restore
#line 52 "C:\Users\Pontu\source\repos\WebAPI\Projekt1\projekt1\Views\LateRentals\Index.cshtml"
WriteAttributeValue("", 1627, item.RentalId, 1627, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 55 "C:\Users\Pontu\source\repos\WebAPI\Projekt1\projekt1\Views\LateRentals\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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