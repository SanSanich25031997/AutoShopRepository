#pragma checksum "C:\Users\1\source\repos\AutoShop\AutoShop\Views\AutoShopCart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e3986b27829b28d786a67820c0c91ca36ca7813"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AutoShopCart_Index), @"mvc.1.0.view", @"/Views/AutoShopCart/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AutoShopCart/Index.cshtml", typeof(AspNetCore.Views_AutoShopCart_Index))]
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
#line 1 "C:\Users\1\source\repos\AutoShop\AutoShop\Views\_ViewImports.cshtml"
using AutoShop.ViewModels.AutoShopCartVM;

#line default
#line hidden
#line 2 "C:\Users\1\source\repos\AutoShop\AutoShop\Views\_ViewImports.cshtml"
using AutoShop.ViewModels.CarsVM;

#line default
#line hidden
#line 3 "C:\Users\1\source\repos\AutoShop\AutoShop\Views\_ViewImports.cshtml"
using AutoShop.ViewModels.HomeVM;

#line default
#line hidden
#line 4 "C:\Users\1\source\repos\AutoShop\AutoShop\Views\_ViewImports.cshtml"
using AutoShop.ViewModels.OrderVM;

#line default
#line hidden
#line 6 "C:\Users\1\source\repos\AutoShop\AutoShop\Views\_ViewImports.cshtml"
using DataLayer.Entities;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e3986b27829b28d786a67820c0c91ca36ca7813", @"/Views/AutoShopCart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3eb9c2f7bfc804a7c1d556dc89e093806552165a", @"/Views/_ViewImports.cshtml")]
    public class Views_AutoShopCart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AutoShopCartViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger mb-5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Checkout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(30, 32, true);
            WriteLiteral("\r\n<div class=\"container mt-5\">\r\n");
            EndContext();
#line 4 "C:\Users\1\source\repos\AutoShop\AutoShop\Views\AutoShopCart\Index.cshtml"
     foreach (var elemenet in Model.AutoShopCart.ListAutoShopItems)
    {

#line default
#line hidden
            BeginContext(138, 79, true);
            WriteLiteral("        <div class=\"alert alert-warning mt-3\">\r\n            <b>Автомобиль: </b>");
            EndContext();
            BeginContext(218, 17, false);
#line 7 "C:\Users\1\source\repos\AutoShop\AutoShop\Views\AutoShopCart\Index.cshtml"
                          Write(elemenet.Car.Name);

#line default
#line hidden
            EndContext();
            BeginContext(235, 33, true);
            WriteLiteral("<br />\r\n            <b>Цена: </b>");
            EndContext();
            BeginContext(269, 32, false);
#line 8 "C:\Users\1\source\repos\AutoShop\AutoShop\Views\AutoShopCart\Index.cshtml"
                    Write(elemenet.Car.Price.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(301, 24, true);
            WriteLiteral("<br />\r\n        </div>\r\n");
            EndContext();
#line 10 "C:\Users\1\source\repos\AutoShop\AutoShop\Views\AutoShopCart\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(332, 16, true);
            WriteLiteral("    <hr />\r\n    ");
            EndContext();
            BeginContext(348, 88, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e3986b27829b28d786a67820c0c91ca36ca78136030", async() => {
                BeginContext(424, 8, true);
                WriteLiteral("Оплатить");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(436, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AutoShopCartViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591