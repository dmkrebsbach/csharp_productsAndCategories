#pragma checksum "/home/dmkrebsbach/CodingDojo/CSharp/ENTITY/productsAndCategories/Views/Home/Category.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "572f5c30b762f7a466d452677703e109aba02162"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MyApp.Namespace.Home.Views_Home_Category), @"mvc.1.0.view", @"/Views/Home/Category.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Category.cshtml", typeof(MyApp.Namespace.Home.Views_Home_Category))]
namespace MyApp.Namespace.Home
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 3 "/home/dmkrebsbach/CodingDojo/CSharp/ENTITY/productsAndCategories/Views/_ViewImports.cshtml"
using productsAndCategories.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"572f5c30b762f7a466d452677703e109aba02162", @"/Views/Home/Category.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62ad738efb3bcfdacd646255ce594eb59ff0e057", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Category : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CategoryViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/productStyle.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("categoryForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddIndProduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 41, true);
            WriteLiteral("<!DOCTYPE html>\n<html lang=\"en\"></html>\n\t");
            EndContext();
            BeginContext(41, 323, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "572f5c30b762f7a466d452677703e109aba021626048", async() => {
                BeginContext(47, 255, true);
                WriteLiteral("\n        <meta charset=\"UTF-8\">\n        <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\n        <meta http-equiv=\"X-UA-Compatible\" content=\"ie=edge\">\n        <title>Individual Category</title>\n        <meta charset=\"utf-8\">\n        ");
                EndContext();
                BeginContext(302, 53, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "572f5c30b762f7a466d452677703e109aba021626694", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(355, 2, true);
                WriteLiteral("\n\t");
                EndContext();
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
            EndContext();
            BeginContext(364, 5, true);
            WriteLiteral("\n    ");
            EndContext();
            BeginContext(369, 1667, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "572f5c30b762f7a466d452677703e109aba021628792", async() => {
                BeginContext(375, 1, true);
                WriteLiteral("\n");
                EndContext();
                BeginContext(409, 117, true);
                WriteLiteral("        <h1><a href=\"/Products\">Products</a> | | | | <a href=\"/Categories\">Categories</a></h1>\n        <h1>CATEGORY: ");
                EndContext();
                BeginContext(527, 23, false);
#line 14 "/home/dmkrebsbach/CodingDojo/CSharp/ENTITY/productsAndCategories/Views/Home/Category.cshtml"
                 Write(Model.thisCategory.Name);

#line default
#line hidden
                EndContext();
                BeginContext(550, 185, true);
                WriteLiteral("</h1>\n        <div class=\"container\">\n            <div class=\"formBox\">\n                <h1>Products In This Category:</h1>\n                <div class = \"listBox\">\n                    \n");
                EndContext();
                BeginContext(758, 29, true);
                WriteLiteral("                        <ul>\n");
                EndContext();
#line 22 "/home/dmkrebsbach/CodingDojo/CSharp/ENTITY/productsAndCategories/Views/Home/Category.cshtml"
                             foreach(Association assoc in Model.thisCategory.Associations){

#line default
#line hidden
                BeginContext(879, 36, true);
                WriteLiteral("                                <li>");
                EndContext();
                BeginContext(916, 18, false);
#line 23 "/home/dmkrebsbach/CodingDojo/CSharp/ENTITY/productsAndCategories/Views/Home/Category.cshtml"
                               Write(assoc.Product.Name);

#line default
#line hidden
                EndContext();
                BeginContext(934, 6, true);
                WriteLiteral("</li>\n");
                EndContext();
#line 24 "/home/dmkrebsbach/CodingDojo/CSharp/ENTITY/productsAndCategories/Views/Home/Category.cshtml"
                            }

#line default
#line hidden
                BeginContext(970, 30, true);
                WriteLiteral("                        </ul>\n");
                EndContext();
                BeginContext(1022, 243, true);
                WriteLiteral("                </div>\n            </div>\n            <div class = \"formBoxMessage\">\n                \n                \n            </div>\n            <div class = \"formBox\">\n                <h1>Add Product To Category</h1>\n                    ");
                EndContext();
                BeginContext(1265, 725, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "572f5c30b762f7a466d452677703e109aba0216211517", async() => {
                    BeginContext(1355, 25, true);
                    WriteLiteral("\n                        ");
                    EndContext();
                    BeginContext(1380, 60, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "572f5c30b762f7a466d452677703e109aba0216211939", async() => {
                        BeginContext(1419, 13, true);
                        WriteLiteral("Add Product: ");
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 36 "/home/dmkrebsbach/CodingDojo/CSharp/ENTITY/productsAndCategories/Views/Home/Category.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Association.ProductId);

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(1440, 25, true);
                    WriteLiteral("\n                        ");
                    EndContext();
                    BeginContext(1465, 417, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "572f5c30b762f7a466d452677703e109aba0216213796", async() => {
                        BeginContext(1505, 1, true);
                        WriteLiteral("\n");
                        EndContext();
#line 39 "/home/dmkrebsbach/CodingDojo/CSharp/ENTITY/productsAndCategories/Views/Home/Category.cshtml"
                                 foreach(Product prod in Model.thisProductList){

#line default
#line hidden
                        BeginContext(1618, 32, true);
                        WriteLiteral("                                ");
                        EndContext();
                        BeginContext(1650, 134, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "572f5c30b762f7a466d452677703e109aba0216214594", async() => {
                            BeginContext(1682, 45, true);
                            WriteLiteral("\n                                        <li>");
                            EndContext();
                            BeginContext(1728, 9, false);
#line 41 "/home/dmkrebsbach/CodingDojo/CSharp/ENTITY/productsAndCategories/Views/Home/Category.cshtml"
                                       Write(prod.Name);

#line default
#line hidden
                            EndContext();
                            BeginContext(1737, 38, true);
                            WriteLiteral("</li>\n                                ");
                            EndContext();
                        }
                        );
                        __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                        __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                        BeginWriteTagHelperAttribute();
#line 40 "/home/dmkrebsbach/CodingDojo/CSharp/ENTITY/productsAndCategories/Views/Home/Category.cshtml"
                                   WriteLiteral(prod.ProductId);

#line default
#line hidden
                        __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                        __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                        __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(1784, 1, true);
                        WriteLiteral("\n");
                        EndContext();
#line 43 "/home/dmkrebsbach/CodingDojo/CSharp/ENTITY/productsAndCategories/Views/Home/Category.cshtml"
                                }

#line default
#line hidden
                        BeginContext(1849, 24, true);
                        WriteLiteral("                        ");
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#line 37 "/home/dmkrebsbach/CodingDojo/CSharp/ENTITY/productsAndCategories/Views/Home/Category.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Association.ProductId);

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(1882, 101, true);
                    WriteLiteral("\n                        <input value=\"Add Product\" class = \"btn\" type=\"submit\">\n                    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1990, 39, true);
                WriteLiteral("\n            </div>\n        </div>\n    ");
                EndContext();
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
            EndContext();
            BeginContext(2036, 8, true);
            WriteLiteral("\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CategoryViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
