#pragma checksum "C:\Users\code\Desktop\HomeProject\MagicHome\MagicHome\Views\User\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a1cba532d4f0234807e39bf777b929133ad24cb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Detail), @"mvc.1.0.view", @"/Views/User/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/Detail.cshtml", typeof(AspNetCore.Views_User_Detail))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a1cba532d4f0234807e39bf777b929133ad24cb", @"/Views/User/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f65b455e9c178856c2b8f7b2d56ac0730b078567", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MagicHome.Models.Advert>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\code\Desktop\HomeProject\MagicHome\MagicHome\Views\User\Detail.cshtml"
  
    ViewBag.Title = "Detail";
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(97, 233, true);
            WriteLiteral("<section id=\"homedetail\">\r\n    <div class=\"homedetail my-5\">\r\n        <div class=\"container\">\r\n            <div class=\"row\">\r\n                <div class=\"col-md-6\">\r\n                    <div class=\"wrapper\">\r\n                        ");
            EndContext();
            BeginContext(330, 40, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2f04f5da4a2a447fa8b29b540e9dc83b", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 340, "~/Images/", 340, 9, true);
#line 13 "C:\Users\code\Desktop\HomeProject\MagicHome\MagicHome\Views\User\Detail.cshtml"
AddHtmlAttributeValue("", 349, Model.Image, 349, 12, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(370, 218, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-md-6\">\r\n                    <div class=\"overview\">\r\n                        <div class=\"modbuttons\">\r\n                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 588, "\"", 645, 1);
#line 19 "C:\Users\code\Desktop\HomeProject\MagicHome\MagicHome\Views\User\Detail.cshtml"
WriteAttributeValue("", 595, Url.Action("Edit","Advert",new { id = Model.Id }), 595, 50, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(646, 713, true);
            WriteLiteral(@"><i class=""btn btn-warning fas fa-edit""></i></a>
                            <a href=""#"" data-toggle=""modal"" data-target=""#exampleModalCenter""><i class=""btn btn-danger  fas fa-trash""></i></a>
                            <div class=""modal fade"" id=""exampleModalCenter"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalCenterTitle"" aria-hidden=""true"">
                                <div class=""modal-dialog modal-dialog-centered"" role=""document"">
                                    <div class=""modal-content"">
                                        <div class=""modal-header"">
                                            <h5 class=""modal-title"" id=""exampleModalLongTitle"">  <span style=""color:red"">");
            EndContext();
            BeginContext(1360, 19, false);
#line 25 "C:\Users\code\Desktop\HomeProject\MagicHome\MagicHome\Views\User\Detail.cshtml"
                                                                                                                    Write(Model.City.CityName);

#line default
#line hidden
            EndContext();
            BeginContext(1379, 812, true);
            WriteLiteral(@"</span> Do you want  this City advert?</h5>
                                            <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                                                <span aria-hidden=""true"">&times;</span>
                                            </button>
                                        </div>
                                        <div class=""modal-body"">
                                            ""Are you sure""
                                        </div>
                                        <div class=""modal-footer"">
                                            <button type=""button"" class=""btn btn-success"" data-dismiss=""modal"">No</button>
                                            <button type=""button"" id=""deladv"" data-id=""");
            EndContext();
            BeginContext(2192, 8, false);
#line 35 "C:\Users\code\Desktop\HomeProject\MagicHome\MagicHome\Views\User\Detail.cshtml"
                                                                                  Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(2200, 535, true);
            WriteLiteral(@""" class=""btn btn-danger"">Delete</button>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <h4>
                            Comman Info
                            <hr>
                        </h4>

                        <div class=""d-flex"">
                            <p class=""first-p"">Qiyməti:</p>
                            <p class=""second-p"">");
            EndContext();
            BeginContext(2736, 11, false);
#line 48 "C:\Users\code\Desktop\HomeProject\MagicHome\MagicHome\Views\User\Detail.cshtml"
                                           Write(Model.Price);

#line default
#line hidden
            EndContext();
            BeginContext(2747, 211, true);
            WriteLiteral(" <SUP>₼</SUP> </p>\r\n                        </div>\r\n                        <div class=\"d-flex\">\r\n                            <p class=\"first-p\">Yataq Otağı:</p>\r\n                            <p class=\"second-p\">");
            EndContext();
            BeginContext(2959, 13, false);
#line 52 "C:\Users\code\Desktop\HomeProject\MagicHome\MagicHome\Views\User\Detail.cshtml"
                                           Write(Model.BedRoom);

#line default
#line hidden
            EndContext();
            BeginContext(2972, 197, true);
            WriteLiteral("</p>\r\n                        </div>\r\n                        <div class=\"d-flex\">\r\n                            <p class=\"first-p\">Hamam Otağı:</p>\r\n                            <p class=\"second-p\">");
            EndContext();
            BeginContext(3170, 14, false);
#line 56 "C:\Users\code\Desktop\HomeProject\MagicHome\MagicHome\Views\User\Detail.cshtml"
                                           Write(Model.BathRoom);

#line default
#line hidden
            EndContext();
            BeginContext(3184, 192, true);
            WriteLiteral("</p>\r\n                        </div>\r\n                        <div class=\"d-flex\">\r\n                            <p class=\"first-p\">Sahəsi:</p>\r\n                            <p class=\"second-p\">");
            EndContext();
            BeginContext(3377, 14, false);
#line 60 "C:\Users\code\Desktop\HomeProject\MagicHome\MagicHome\Views\User\Detail.cshtml"
                                           Write(Model.RoomArea);

#line default
#line hidden
            EndContext();
            BeginContext(3391, 205, true);
            WriteLiteral(" m <sup>2</sup></p>\r\n                        </div>\r\n                        <div class=\"d-flex\">\r\n                            <p class=\"first-p\">Növü:</p>\r\n                            <p class=\"second-p\">");
            EndContext();
            BeginContext(3597, 25, false);
#line 64 "C:\Users\code\Desktop\HomeProject\MagicHome\MagicHome\Views\User\Detail.cshtml"
                                           Write(Model.AdvertType.SaleType);

#line default
#line hidden
            EndContext();
            BeginContext(3622, 192, true);
            WriteLiteral("</p>\r\n                        </div>\r\n                        <div class=\"d-flex\">\r\n                            <p class=\"first-p\">Adresi:</p>\r\n                            <p class=\"second-p\">");
            EndContext();
            BeginContext(3815, 19, false);
#line 68 "C:\Users\code\Desktop\HomeProject\MagicHome\MagicHome\Views\User\Detail.cshtml"
                                           Write(Model.City.CityName);

#line default
#line hidden
            EndContext();
            BeginContext(3834, 1, true);
            WriteLiteral(",");
            EndContext();
            BeginContext(3836, 13, false);
#line 68 "C:\Users\code\Desktop\HomeProject\MagicHome\MagicHome\Views\User\Detail.cshtml"
                                                                Write(Model.Address);

#line default
#line hidden
            EndContext();
            BeginContext(3849, 318, true);
            WriteLiteral(@" </p>
                        </div>

                    </div>
                    <div class=""description"">
                        <h4>
                           About
                            <hr>
                        </h4>
                        <p class=""descrip"">
                            ");
            EndContext();
            BeginContext(4168, 17, false);
#line 78 "C:\Users\code\Desktop\HomeProject\MagicHome\MagicHome\Views\User\Detail.cshtml"
                       Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(4185, 150, true);
            WriteLiteral("\r\n                        </p>\r\n\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(4352, 1094, true);
                WriteLiteral(@" 
<script>

    $(function () {
        $(document).on(""click"", ""#deladv"", function () {
            var delid = $(""#deladv"").attr(""data-id"")
            $.ajax({
                url: ""/Ajax/DeletAdvert"",
                data: { deleteid: delid },
                type: ""GET"",
                success: function (res) {
                    if (res.status === ""400"") {
                        swal({
                            title: ""Wrong"",
                            text: ""Advert doesn't delet!"",
                            icon: ""error"",
                            button: ""Ok"",
                        });
                    }
                    else {
                        swal(""Good"", ""Advert deleted"", ""success"")
                            .then(willRedirect => {
                                if (willRedirect) {
                                    window.location.href = res.data;
                                }
                            })
                    }
        ");
                WriteLiteral("        }\r\n            })\r\n        })\r\n    })\r\n\r\n\r\n\r\n\r\n    </script>\r\n");
                EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MagicHome.Models.Advert> Html { get; private set; }
    }
}
#pragma warning restore 1591
