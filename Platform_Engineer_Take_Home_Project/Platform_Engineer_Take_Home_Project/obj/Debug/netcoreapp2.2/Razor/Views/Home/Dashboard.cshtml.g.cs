#pragma checksum "/Users/jaime/Projects/Home rent estimate/Platform_Engineer_Take_Home_Project/Platform_Engineer_Take_Home_Project/Views/Home/Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ca4df2711966c7a676368b2d5ce47e820ffa34d5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Dashboard), @"mvc.1.0.view", @"/Views/Home/Dashboard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Dashboard.cshtml", typeof(AspNetCore.Views_Home_Dashboard))]
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
#line 1 "/Users/jaime/Projects/Home rent estimate/Platform_Engineer_Take_Home_Project/Platform_Engineer_Take_Home_Project/Views/_ViewImports.cshtml"
using Platform_Engineer_Take_Home_Project;

#line default
#line hidden
#line 2 "/Users/jaime/Projects/Home rent estimate/Platform_Engineer_Take_Home_Project/Platform_Engineer_Take_Home_Project/Views/_ViewImports.cshtml"
using Platform_Engineer_Take_Home_Project.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca4df2711966c7a676368b2d5ce47e820ffa34d5", @"/Views/Home/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b2feafe70c31ee5b1bf840e4c147d3d2ec39320", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Platform_Engineer_Take_Home_Project.Models.User>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(55, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "/Users/jaime/Projects/Home rent estimate/Platform_Engineer_Take_Home_Project/Platform_Engineer_Take_Home_Project/Views/Home/Dashboard.cshtml"
  
    ViewData["Title"] = $"Welcome {@Model.FullName} to the Dashboard";

#line default
#line hidden
            BeginContext(132, 1522, true);
            WriteLiteral(@"
<main class=""tr-profile section-padding"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-md-4 col-lg-3"">
                    <div class=""tr-sidebar"">
                        <ul class=""nav nav-tabs profile-tabs section"" role=""tablist"">
                            <li role=""presentation""><a class=""#"" href=""#account-info"" aria-controls=""account-info"" role=""tab"" data-toggle=""tab""><i class=""fa fa-life-ring"" aria-hidden=""true""></i> Account Info</a></li>
                            <li role=""presentation""><a href=""#"" role=""tab"" data-toggle=""tab""><span><i class=""fas fa-envelope-open-text""></i></span> My Messages</a></li>
                            <li role=""presentation""><a href=""#"" role=""tab"" data-toggle=""tab""><span><i class=""fas fa-user-alt""></i></span> Contact an Agent</a></li>
                            <li role=""presentation""><a href=""#"" role=""tab"" data-toggle=""tab""><span><i class=""fas fa-dizzy""></i></span> Close Account</a></li>
                        </ul>	  ");
            WriteLiteral(@"      			
                    </div><!-- /.tr-sidebar -->        		
                </div>
                <div class=""col-md-8 col-lg-9"">
                    <div class=""tab-content"">
                        <div role=""tabpanel"" class=""tab-pane fade in show active account-info"" id=""account-info"">	

                            <div class=""section display-information"">
                                <ul class=""tr-list account-details"">
                                    <li>Display Name<span>");
            EndContext();
            BeginContext(1655, 14, false);
#line 26 "/Users/jaime/Projects/Home rent estimate/Platform_Engineer_Take_Home_Project/Platform_Engineer_Take_Home_Project/Views/Home/Dashboard.cshtml"
                                                     Write(Model.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(1669, 71, true);
            WriteLiteral("</span></li>\n                                    <li>Phone Number<span>");
            EndContext();
            BeginContext(1741, 11, false);
#line 27 "/Users/jaime/Projects/Home rent estimate/Platform_Engineer_Take_Home_Project/Platform_Engineer_Take_Home_Project/Views/Home/Dashboard.cshtml"
                                                     Write(Model.Phone);

#line default
#line hidden
            EndContext();
            BeginContext(1752, 79, true);
            WriteLiteral("</span></li>\n                                    <li>Email Id<span><a href=\"#\">");
            EndContext();
            BeginContext(1832, 11, false);
#line 28 "/Users/jaime/Projects/Home rent estimate/Platform_Engineer_Take_Home_Project/Platform_Engineer_Take_Home_Project/Views/Home/Dashboard.cshtml"
                                                             Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(1843, 70, true);
            WriteLiteral("</a></span></li>\n                                    <li>Address<span>");
            EndContext();
            BeginContext(1914, 17, false);
#line 29 "/Users/jaime/Projects/Home rent estimate/Platform_Engineer_Take_Home_Project/Platform_Engineer_Take_Home_Project/Views/Home/Dashboard.cshtml"
                                                Write(Model.FullAddress);

#line default
#line hidden
            EndContext();
            BeginContext(1931, 74, true);
            WriteLiteral("</span></li>\n                                    <li>Property price<span>$");
            EndContext();
            BeginContext(2006, 19, false);
#line 30 "/Users/jaime/Projects/Home rent estimate/Platform_Engineer_Take_Home_Project/Platform_Engineer_Take_Home_Project/Views/Home/Dashboard.cshtml"
                                                        Write(Model.PropertyPrice);

#line default
#line hidden
            EndContext();
            BeginContext(2025, 73, true);
            WriteLiteral("</span></li>\n                                    <li>Rent expected<span>$");
            EndContext();
            BeginContext(2099, 18, false);
#line 31 "/Users/jaime/Projects/Home rent estimate/Platform_Engineer_Take_Home_Project/Platform_Engineer_Take_Home_Project/Views/Home/Dashboard.cshtml"
                                                       Write(Model.RentExpected);

#line default
#line hidden
            EndContext();
            BeginContext(2117, 89, true);
            WriteLiteral("</span></li>\n                                    <li>Rent estimate of your house is<span>");
            EndContext();
            BeginContext(2207, 24, false);
#line 32 "/Users/jaime/Projects/Home rent estimate/Platform_Engineer_Take_Home_Project/Platform_Engineer_Take_Home_Project/Views/Home/Dashboard.cshtml"
                                                                       Write(Model.RangeRentEstimated);

#line default
#line hidden
            EndContext();
            BeginContext(2231, 172, true);
            WriteLiteral("</span></li>\n                                </ul>\t\t\t\t\t\t\t\t\n                            </div>\n                        </div>\n                    </div>\n                    ");
            EndContext();
            BeginContext(2403, 89, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ca4df2711966c7a676368b2d5ce47e820ffa34d59994", async() => {
                BeginContext(2471, 17, true);
                WriteLiteral("Return to Sign Up");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
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
            BeginContext(2492, 70, true);
            WriteLiteral("\n                </div>\n            </div>\n        </div>\n    </main>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Platform_Engineer_Take_Home_Project.Models.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
