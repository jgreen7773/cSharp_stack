#pragma checksum "/Users/James/c#_stack/c#_aspmvc_2/dojo_survey_validation/Dojo_Survey/Views/Survey/RequestSurvey.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b23dc8fe04c8c45b1081e90de80d3d7c7921082"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MyApp.Namespace.Survey.Views_Survey_RequestSurvey), @"mvc.1.0.view", @"/Views/Survey/RequestSurvey.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Survey/RequestSurvey.cshtml", typeof(MyApp.Namespace.Survey.Views_Survey_RequestSurvey))]
namespace MyApp.Namespace.Survey
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 2 "/Users/James/c#_stack/c#_aspmvc_2/dojo_survey_validation/Dojo_Survey/Views/_ViewImports.cshtml"
using Dojo_Survey;

#line default
#line hidden
#line 3 "/Users/James/c#_stack/c#_aspmvc_2/dojo_survey_validation/Dojo_Survey/Views/Survey/RequestSurvey.cshtml"
using Dojo_Survey.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b23dc8fe04c8c45b1081e90de80d3d7c7921082", @"/Views/Survey/RequestSurvey.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b01e3f2afe10c7434de49ab52f22434ccd308901", @"/Views/_ViewImports.cshtml")]
    public class Views_Survey_RequestSurvey : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SurveyUser>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 17, true);
            WriteLiteral("<!DOCTYPE html>\n\n");
            EndContext();
            BeginContext(61, 1285, true);
            WriteLiteral(@"<form asp-action=""displaysurvey"" asp-controller=""Survey"" method=""POST"" style=""width:888px;height:777px;border:2px solid gold;border-radius:50px;padding:30px;"">
    <span asp-validation-for=""name""></span>
    <label asp-for=""name""></label>
    Your Name: <input type=""input"" asp-for=""name"">
    <span asp-validation-for=""location""></span>
    <label asp-for=""location""></label>
    Dojo Location: <select asp-for=""location"">
        <option>Select Location</option>
        <option value=""Seattle"">Seattle</option>
        <option value=""Dallas"">Dallas Texas</option>
        <option value=""Kansas City"">Kansas City</option>
        <option value=""Mystical Swamp"">Mystical Swamp</option>
    </select>
    <span asp-validation-for=""language""></span>
    <label asp-for=""language""></label>
    Favorite Language: <select asp-for=""language"">
        <option>Select Language</option>
        <option value=""Python"">Python</option>
        <option value=""C#"">C#</option>
        <option value=""MEAN"">MEAN</option>
        <option");
            WriteLiteral(@" value=""ReactJS"">ReactJS</option>
    </select>
    <p>Comment (optional):</p>
    <span asp-validation-for=""comments""></span>
    <label asp-for=""comments""></label>
    <input type=""textarea"" asp-for=""comments"">
    <input type=""submit"" value=""Submit"">
</form>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SurveyUser> Html { get; private set; }
    }
}
#pragma warning restore 1591
