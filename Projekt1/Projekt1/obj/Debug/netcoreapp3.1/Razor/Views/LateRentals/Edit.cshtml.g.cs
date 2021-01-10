#pragma checksum "C:\Users\Pontu\source\repos\WebAPI\Projekt1\Projekt1\Views\LateRentals\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4597e969d73ee8610f7a53b62516ec41323ce1df"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LateRentals_Edit), @"mvc.1.0.view", @"/Views/LateRentals/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4597e969d73ee8610f7a53b62516ec41323ce1df", @"/Views/LateRentals/Edit.cshtml")]
    public class Views_LateRentals_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Projekt1.Models.Rental>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Pontu\source\repos\WebAPI\Projekt1\Projekt1\Views\LateRentals\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Edit</h1>

<h4>Rental</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Edit"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <input type=""hidden"" asp-for=""RentalId"" />
            <div class=""form-group"">
                <label asp-for=""RentalDate"" class=""control-label""></label>
                <input asp-for=""RentalDate"" class=""form-control"" />
                <span asp-validation-for=""RentalDate"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""ReturnDate"" class=""control-label""></label>
                <input asp-for=""ReturnDate"" class=""form-control"" />
                <span asp-validation-for=""ReturnDate"" class=""text-danger""></span>
            </div>
            <div class=""form-group form-check"">
                <label class=""form-check-label"">
                    <input class=""form-check-input"" asp-for=""Rented"" /> ");
#nullable restore
#line 28 "C:\Users\Pontu\source\repos\WebAPI\Projekt1\Projekt1\Views\LateRentals\Edit.cshtml"
                                                                   Write(Html.DisplayNameFor(model => model.Rented));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </label>
            </div>
            <div class=""form-group"">
                <label asp-for=""InventoryId"" class=""control-label""></label>
                <select asp-for=""InventoryId"" class=""form-control"" asp-items=""ViewBag.InventoryId""></select>
                <span asp-validation-for=""InventoryId"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Save"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 48 "C:\Users\Pontu\source\repos\WebAPI\Projekt1\Projekt1\Views\LateRentals\Edit.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Projekt1.Models.Rental> Html { get; private set; }
    }
}
#pragma warning restore 1591
