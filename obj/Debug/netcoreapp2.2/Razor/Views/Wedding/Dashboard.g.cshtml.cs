#pragma checksum "C:\Users\Bryan\Desktop\Coding_Dojo\C Sharp\Assignments\RedBeltPreview\Views\Wedding\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a710be3a41736a0e2941ab86cf89da56456b9d59"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Wedding_Dashboard), @"mvc.1.0.view", @"/Views/Wedding/Dashboard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Wedding/Dashboard.cshtml", typeof(AspNetCore.Views_Wedding_Dashboard))]
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
#line 1 "C:\Users\Bryan\Desktop\Coding_Dojo\C Sharp\Assignments\RedBeltPreview\Views\_ViewImports.cshtml"
using RedBeltPreview;

#line default
#line hidden
#line 2 "C:\Users\Bryan\Desktop\Coding_Dojo\C Sharp\Assignments\RedBeltPreview\Views\_ViewImports.cshtml"
using RedBeltPreview.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a710be3a41736a0e2941ab86cf89da56456b9d59", @"/Views/Wedding/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8557367b2f657a01f4585578f3efe09470984a03", @"/Views/_ViewImports.cshtml")]
    public class Views_Wedding_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Wedding>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "NewWedding", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Wedding", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(22, 43, true);
            WriteLiteral("\r\n<h1>Welcome to the Wedding Planner</h1>\r\n");
            EndContext();
            BeginContext(65, 78, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a710be3a41736a0e2941ab86cf89da56456b9d594890", async() => {
                BeginContext(133, 6, true);
                WriteLiteral("logout");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(143, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(145, 90, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a710be3a41736a0e2941ab86cf89da56456b9d596548", async() => {
                BeginContext(220, 11, true);
                WriteLiteral("New Wedding");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(235, 178, true);
            WriteLiteral("\r\n\r\n<hr>\r\n<table style = \"width: 50%; border: 2px solid black;\">\r\n<tr>\r\n        <th>Wedding</th>\r\n        <th>Date</th>\r\n        <th>Guests</th>\r\n        <th>Action</th>\r\n</tr>\r\n");
            EndContext();
#line 15 "C:\Users\Bryan\Desktop\Coding_Dojo\C Sharp\Assignments\RedBeltPreview\Views\Wedding\Dashboard.cshtml"
 foreach( var w in @Model)
{
    
    

#line default
#line hidden
            BeginContext(456, 24, true);
            WriteLiteral("    <tr>\r\n        <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 480, "\"", 508, 2);
            WriteAttributeValue("", 487, "/Wedding/", 487, 9, true);
#line 20 "C:\Users\Bryan\Desktop\Coding_Dojo\C Sharp\Assignments\RedBeltPreview\Views\Wedding\Dashboard.cshtml"
WriteAttributeValue("", 496, w.WeddingID, 496, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(509, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(511, 11, false);
#line 20 "C:\Users\Bryan\Desktop\Coding_Dojo\C Sharp\Assignments\RedBeltPreview\Views\Wedding\Dashboard.cshtml"
                                       Write(w.WedderOne);

#line default
#line hidden
            EndContext();
            BeginContext(522, 3, true);
            WriteLiteral(" & ");
            EndContext();
            BeginContext(526, 11, false);
#line 20 "C:\Users\Bryan\Desktop\Coding_Dojo\C Sharp\Assignments\RedBeltPreview\Views\Wedding\Dashboard.cshtml"
                                                      Write(w.WedderTwo);

#line default
#line hidden
            EndContext();
            BeginContext(537, 23, true);
            WriteLiteral("</a></td>\r\n        <td>");
            EndContext();
            BeginContext(561, 20, false);
#line 21 "C:\Users\Bryan\Desktop\Coding_Dojo\C Sharp\Assignments\RedBeltPreview\Views\Wedding\Dashboard.cshtml"
       Write(w.Date.ToString("d"));

#line default
#line hidden
            EndContext();
            BeginContext(581, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(601, 17, false);
#line 22 "C:\Users\Bryan\Desktop\Coding_Dojo\C Sharp\Assignments\RedBeltPreview\Views\Wedding\Dashboard.cshtml"
       Write(w.GuestList.Count);

#line default
#line hidden
            EndContext();
            BeginContext(618, 9, true);
            WriteLiteral("</td>\r\n\r\n");
            EndContext();
#line 24 "C:\Users\Bryan\Desktop\Coding_Dojo\C Sharp\Assignments\RedBeltPreview\Views\Wedding\Dashboard.cshtml"
         if(ViewBag.UserId == @w.UserId)
        
        {

#line default
#line hidden
            BeginContext(690, 18, true);
            WriteLiteral("            <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 708, "\"", 736, 2);
            WriteAttributeValue("", 715, "/Destroy/", 715, 9, true);
#line 27 "C:\Users\Bryan\Desktop\Coding_Dojo\C Sharp\Assignments\RedBeltPreview\Views\Wedding\Dashboard.cshtml"
WriteAttributeValue("", 724, w.WeddingID, 724, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(737, 18, true);
            WriteLiteral(">Delete</a></td>\r\n");
            EndContext();
#line 28 "C:\Users\Bryan\Desktop\Coding_Dojo\C Sharp\Assignments\RedBeltPreview\Views\Wedding\Dashboard.cshtml"
        }
        else
        {
            

#line default
#line hidden
#line 31 "C:\Users\Bryan\Desktop\Coding_Dojo\C Sharp\Assignments\RedBeltPreview\Views\Wedding\Dashboard.cshtml"
             if(w.GuestList.All(r => r.UserId != ViewBag.UserId))
            {

#line default
#line hidden
            BeginContext(873, 22, true);
            WriteLiteral("                <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 895, "\"", 924, 3);
            WriteAttributeValue("", 902, "/rsvp/", 902, 6, true);
#line 33 "C:\Users\Bryan\Desktop\Coding_Dojo\C Sharp\Assignments\RedBeltPreview\Views\Wedding\Dashboard.cshtml"
WriteAttributeValue("", 908, w.WeddingID, 908, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 920, "/add", 920, 4, true);
            EndWriteAttribute();
            BeginContext(925, 16, true);
            WriteLiteral(">RSVP</a></td>\r\n");
            EndContext();
#line 34 "C:\Users\Bryan\Desktop\Coding_Dojo\C Sharp\Assignments\RedBeltPreview\Views\Wedding\Dashboard.cshtml"
            }

#line default
#line hidden
#line 35 "C:\Users\Bryan\Desktop\Coding_Dojo\C Sharp\Assignments\RedBeltPreview\Views\Wedding\Dashboard.cshtml"
             if(w.GuestList.Any(r => r.UserId == ViewBag.UserId))
            {

#line default
#line hidden
            BeginContext(1038, 22, true);
            WriteLiteral("                <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1060, "\"", 1092, 3);
            WriteAttributeValue("", 1067, "/rsvp/", 1067, 6, true);
#line 37 "C:\Users\Bryan\Desktop\Coding_Dojo\C Sharp\Assignments\RedBeltPreview\Views\Wedding\Dashboard.cshtml"
WriteAttributeValue("", 1073, w.WeddingID, 1073, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 1085, "/remove", 1085, 7, true);
            EndWriteAttribute();
            BeginContext(1093, 21, true);
            WriteLiteral(" >Back Out</a></td>\r\n");
            EndContext();
#line 38 "C:\Users\Bryan\Desktop\Coding_Dojo\C Sharp\Assignments\RedBeltPreview\Views\Wedding\Dashboard.cshtml"
            }

#line default
#line hidden
#line 38 "C:\Users\Bryan\Desktop\Coding_Dojo\C Sharp\Assignments\RedBeltPreview\Views\Wedding\Dashboard.cshtml"
             
        }

#line default
#line hidden
            BeginContext(1140, 21, true);
            WriteLiteral("        \r\n    </tr>\r\n");
            EndContext();
#line 42 "C:\Users\Bryan\Desktop\Coding_Dojo\C Sharp\Assignments\RedBeltPreview\Views\Wedding\Dashboard.cshtml"

}

#line default
#line hidden
            BeginContext(1166, 12, true);
            WriteLiteral("</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Wedding>> Html { get; private set; }
    }
}
#pragma warning restore 1591
