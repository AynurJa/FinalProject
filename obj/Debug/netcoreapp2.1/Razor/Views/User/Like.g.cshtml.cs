#pragma checksum "C:\Users\code\Desktop\HomeProject\MagicHome\MagicHome\Views\User\Like.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d56872293ea055d7c1207b03630075e602cef31b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Like), @"mvc.1.0.view", @"/Views/User/Like.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/Like.cshtml", typeof(AspNetCore.Views_User_Like))]
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
#line 1 "C:\Users\code\Desktop\HomeProject\MagicHome\MagicHome\Views\_ViewImports.cshtml"
using MagicHome;

#line default
#line hidden
#line 2 "C:\Users\code\Desktop\HomeProject\MagicHome\MagicHome\Views\_ViewImports.cshtml"
using MagicHome.Models;

#line default
#line hidden
#line 3 "C:\Users\code\Desktop\HomeProject\MagicHome\MagicHome\Views\_ViewImports.cshtml"
using MagicHome.ViewModel;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d56872293ea055d7c1207b03630075e602cef31b", @"/Views/User/Like.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f65b455e9c178856c2b8f7b2d56ac0730b078567", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Like : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<MagicHome.Models.Advert>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("..."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(38, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\code\Desktop\HomeProject\MagicHome\MagicHome\Views\User\Like.cshtml"
  
    ViewBag.Title = "Like";
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(101, 134, true);
            WriteLiteral("\r\n<section id=\"userpage\">\r\n    <div class=\"userpage\">\r\n        <div class=\"container\">\r\n            <div id=\"forappend\" class=\"row\">\r\n");
            EndContext();
#line 12 "C:\Users\code\Desktop\HomeProject\MagicHome\MagicHome\Views\User\Like.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(300, 131, true);
            WriteLiteral("                    <div class=\"foritem col-md-4\">\r\n                        <div class=\"card item\">\r\n                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 431, "\"", 489, 1);
#line 16 "C:\Users\code\Desktop\HomeProject\MagicHome\MagicHome\Views\User\Like.cshtml"
WriteAttributeValue("", 438, Url.Action("Detail","Advert",new { id = item.Id }), 438, 51, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(490, 157, true);
            WriteLiteral(">\r\n                                <div class=\"card\">\r\n\r\n                                    <div class=\"forimage\">\r\n                                        ");
            EndContext();
            BeginContext(647, 109, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ba2647ed8a0d4559a92419a8ba8e05dd", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 657, "~/Images/", 657, 9, true);
#line 20 "C:\Users\code\Desktop\HomeProject\MagicHome\MagicHome\Views\User\Like.cshtml"
AddHtmlAttributeValue("", 666, item.Image, 666, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
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
            BeginContext(756, 46, true);
            WriteLiteral("\r\n                                    </div>\r\n");
            EndContext();
#line 23 "C:\Users\code\Desktop\HomeProject\MagicHome\MagicHome\Views\User\Like.cshtml"
                                      
                                        if (item.IsNew == true)
                                        {

#line default
#line hidden
            BeginContext(950, 177, true);
            WriteLiteral("                                            <div class=\"new\">\r\n                                                <h4>New</h4>\r\n                                            </div>\r\n");
            EndContext();
#line 29 "C:\Users\code\Desktop\HomeProject\MagicHome\MagicHome\Views\User\Like.cshtml"
                                        }
                                        if (item.IsVip)
                                        {

#line default
#line hidden
            BeginContext(1270, 206, true);
            WriteLiteral("                                            <div class=\"vip\">\r\n                                                <span><i class=\"fas fa-crown\"></i></span>\r\n                                            </div>\r\n");
            EndContext();
#line 35 "C:\Users\code\Desktop\HomeProject\MagicHome\MagicHome\Views\User\Like.cshtml"
                                        }
                                    

#line default
#line hidden
            BeginContext(1558, 210, true);
            WriteLiteral("\r\n                                            <div class=\"card-body\">\r\n                                                <div class=\"liked\">\r\n                                                    <span><i data-id=\"");
            EndContext();
            BeginContext(1769, 7, false);
#line 40 "C:\Users\code\Desktop\HomeProject\MagicHome\MagicHome\Views\User\Like.cshtml"
                                                                 Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1776, 171, true);
            WriteLiteral("\" class=\"fas fa-thumbs-down\"></i></span>\r\n                                                </div>\r\n                                                <h5 class=\"card-title\">₼ ");
            EndContext();
            BeginContext(1948, 10, false);
#line 42 "C:\Users\code\Desktop\HomeProject\MagicHome\MagicHome\Views\User\Like.cshtml"
                                                                    Write(item.Price);

#line default
#line hidden
            EndContext();
            BeginContext(1958, 161, true);
            WriteLiteral("</h5>\r\n                                                <div class=\"icons\">\r\n                                                    <i class=\"fas fa-bed\"></i> <span>");
            EndContext();
            BeginContext(2120, 12, false);
#line 44 "C:\Users\code\Desktop\HomeProject\MagicHome\MagicHome\Views\User\Like.cshtml"
                                                                                Write(item.BedRoom);

#line default
#line hidden
            EndContext();
            BeginContext(2132, 99, true);
            WriteLiteral(" y.o</span>\r\n                                                    <i class=\"fas fa-bath\"></i> <span>");
            EndContext();
            BeginContext(2232, 13, false);
#line 45 "C:\Users\code\Desktop\HomeProject\MagicHome\MagicHome\Views\User\Like.cshtml"
                                                                                 Write(item.BathRoom);

#line default
#line hidden
            EndContext();
            BeginContext(2245, 111, true);
            WriteLiteral(" h.o</span>\r\n                                                    <i class=\"fas fa-ruler-horizontal\"></i> <span>");
            EndContext();
            BeginContext(2357, 13, false);
#line 46 "C:\Users\code\Desktop\HomeProject\MagicHome\MagicHome\Views\User\Like.cshtml"
                                                                                             Write(item.RoomArea);

#line default
#line hidden
            EndContext();
            BeginContext(2370, 130, true);
            WriteLiteral(" m<sup>2</sup></span>\r\n                                                </div>\r\n                                                <p>");
            EndContext();
            BeginContext(2501, 18, false);
#line 48 "C:\Users\code\Desktop\HomeProject\MagicHome\MagicHome\Views\User\Like.cshtml"
                                              Write(item.City.CityName);

#line default
#line hidden
            EndContext();
            BeginContext(2519, 57, true);
            WriteLiteral("</p>\r\n                                                <p>");
            EndContext();
            BeginContext(2577, 12, false);
#line 49 "C:\Users\code\Desktop\HomeProject\MagicHome\MagicHome\Views\User\Like.cshtml"
                                              Write(item.Address);

#line default
#line hidden
            EndContext();
            BeginContext(2589, 148, true);
            WriteLiteral("</p>\r\n                                                \r\n                                                <p class=\"text-warning text-center bg-info\">");
            EndContext();
            BeginContext(2738, 24, false);
#line 51 "C:\Users\code\Desktop\HomeProject\MagicHome\MagicHome\Views\User\Like.cshtml"
                                                                                       Write(item.AdvertType.SaleType);

#line default
#line hidden
            EndContext();
            BeginContext(2762, 192, true);
            WriteLiteral("</p>\r\n                                            </div>\r\n                                </div>\r\n                            </a>\r\n                        </div>\r\n                    </div>\r\n");
            EndContext();
#line 57 "C:\Users\code\Desktop\HomeProject\MagicHome\MagicHome\Views\User\Like.cshtml"
                }

#line default
#line hidden
            BeginContext(2973, 62, true);
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<MagicHome.Models.Advert>> Html { get; private set; }
    }
}
#pragma warning restore 1591
