#pragma checksum "/Users/James/c#_stack/c#_orm/Entity/CRUDelicious/Views/Dishes/MyDish.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6147c38da6f1ec5d5f9d146d8b837e89436d56e1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dishes_MyDish), @"mvc.1.0.view", @"/Views/Dishes/MyDish.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Dishes/MyDish.cshtml", typeof(AspNetCore.Views_Dishes_MyDish))]
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
#line 1 "/Users/James/c#_stack/c#_orm/Entity/CRUDelicious/Views/_ViewImports.cshtml"
using CRUDelicious;

#line default
#line hidden
#line 1 "/Users/James/c#_stack/c#_orm/Entity/CRUDelicious/Views/Dishes/MyDish.cshtml"
using CRUDelicious.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6147c38da6f1ec5d5f9d146d8b837e89436d56e1", @"/Views/Dishes/MyDish.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"815eae4269ab1eac71e8261ccfa9294c33285639", @"/Views/_ViewImports.cshtml")]
    public class Views_Dishes_MyDish : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Dishes>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-right:55px;display:inline-block;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-image:url (\'124.jpg\');margin:auto;width:970;height:auto;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(42, 33, true);
            WriteLiteral("<!DOCTYPE html>\n<html lang=\"en\">\n");
            EndContext();
            BeginContext(75, 207, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6147c38da6f1ec5d5f9d146d8b837e89436d56e14663", async() => {
                BeginContext(81, 194, true);
                WriteLiteral("\n    <meta charset=\"UTF-8\">\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\n    <meta http-equiv=\"X-UA-Compatible\" content=\"ie=edge\">\n    <title>CRUDelicious!</title>\n");
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
            BeginContext(282, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(283, 882, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6147c38da6f1ec5d5f9d146d8b837e89436d56e16028", async() => {
                BeginContext(365, 127, true);
                WriteLiteral("\n    <a href=\"/\">Home</a>\n    <div style=\"width:555px;height:100px;border-bottom:1px solid black;margin-bottom:55px;\">\n    <h1>");
                EndContext();
                BeginContext(493, 10, false);
#line 14 "/Users/James/c#_stack/c#_orm/Entity/CRUDelicious/Views/Dishes/MyDish.cshtml"
   Write(Model.Name);

#line default
#line hidden
                EndContext();
                BeginContext(503, 14, true);
                WriteLiteral("</h1>\n    <h3>");
                EndContext();
                BeginContext(518, 10, false);
#line 15 "/Users/James/c#_stack/c#_orm/Entity/CRUDelicious/Views/Dishes/MyDish.cshtml"
   Write(Model.Chef);

#line default
#line hidden
                EndContext();
                BeginContext(528, 89, true);
                WriteLiteral("</h3>\n    </div>\n    <!-- <p>PLACEHOLDER HERE Description</p> -->\n    <p>Calories: <span>");
                EndContext();
                BeginContext(618, 14, false);
#line 18 "/Users/James/c#_stack/c#_orm/Entity/CRUDelicious/Views/Dishes/MyDish.cshtml"
                  Write(Model.Calories);

#line default
#line hidden
                EndContext();
                BeginContext(632, 36, true);
                WriteLiteral("</span></p>\n    <p>Tastiness: <span>");
                EndContext();
                BeginContext(669, 15, false);
#line 19 "/Users/James/c#_stack/c#_orm/Entity/CRUDelicious/Views/Dishes/MyDish.cshtml"
                   Write(Model.Tastiness);

#line default
#line hidden
                EndContext();
                BeginContext(684, 71, true);
                WriteLiteral("</span></p>\n    <p>Description:<br><br><span style=\"margin-left:55px;\">");
                EndContext();
                BeginContext(756, 17, false);
#line 20 "/Users/James/c#_stack/c#_orm/Entity/CRUDelicious/Views/Dishes/MyDish.cshtml"
                                                      Write(Model.Description);

#line default
#line hidden
                EndContext();
                BeginContext(773, 117, true);
                WriteLiteral("</span></p>\n    <div style=\"display:block;height:175px;border-bottom:1px solid black;margin-bottom:33px;\"></div>\n    ");
                EndContext();
                BeginContext(890, 156, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6147c38da6f1ec5d5f9d146d8b837e89436d56e18585", async() => {
                    BeginContext(989, 50, true);
                    WriteLiteral("\n        <input type=\"submit\" value=\"Delete\">\n    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 904, "/Delete/", 904, 8, true);
#line 22 "/Users/James/c#_stack/c#_orm/Entity/CRUDelicious/Views/Dishes/MyDish.cshtml"
AddHtmlAttributeValue("", 912, Model.DishId, 912, 13, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1046, 7, true);
                WriteLiteral("\n    <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1053, "\"", 1083, 2);
                WriteAttributeValue("", 1060, "/EditDish/", 1060, 10, true);
#line 25 "/Users/James/c#_stack/c#_orm/Entity/CRUDelicious/Views/Dishes/MyDish.cshtml"
WriteAttributeValue("", 1070, Model.DishId, 1070, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1084, 74, true);
                WriteLiteral(" style=\"margin-left:55px;display:inline-block;\"><button>Edit</button></a>\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1165, 8, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Dishes> Html { get; private set; }
    }
}
#pragma warning restore 1591
