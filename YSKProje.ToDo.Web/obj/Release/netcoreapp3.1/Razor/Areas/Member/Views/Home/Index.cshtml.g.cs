#pragma checksum "C:\Users\yskah\Desktop\UdemyToDo\YSKProje.ToDo.Web\Areas\Member\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "34320fafac448bcd0999f649deba087326d74c8f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Member_Views_Home_Index), @"mvc.1.0.view", @"/Areas/Member/Views/Home/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\yskah\Desktop\UdemyToDo\YSKProje.ToDo.Web\Areas\Member\Views\_ViewImports.cshtml"
using YSKProje.ToDo.DTO.DTOs.AciliyetDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\yskah\Desktop\UdemyToDo\YSKProje.ToDo.Web\Areas\Member\Views\_ViewImports.cshtml"
using YSKProje.ToDo.DTO.DTOs.BildirimDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\yskah\Desktop\UdemyToDo\YSKProje.ToDo.Web\Areas\Member\Views\_ViewImports.cshtml"
using YSKProje.ToDo.DTO.DTOs.GorevDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\yskah\Desktop\UdemyToDo\YSKProje.ToDo.Web\Areas\Member\Views\_ViewImports.cshtml"
using YSKProje.ToDo.DTO.DTOs.AppUserDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\yskah\Desktop\UdemyToDo\YSKProje.ToDo.Web\Areas\Member\Views\_ViewImports.cshtml"
using YSKProje.ToDo.DTO.DTOs.RaporDtos;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34320fafac448bcd0999f649deba087326d74c8f", @"/Areas/Member/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0730b6f3d996889f53a0ee815495fa95c948178", @"/Areas/Member/Views/_ViewImports.cshtml")]
    public class Areas_Member_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Gorev", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-light btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "IsEmri", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Bildirim", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\yskah\Desktop\UdemyToDo\YSKProje.ToDo.Web\Areas\Member\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Member/Views/Shared/_MemberLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <div class=""row mt-3"">


        <div class=""col-md-6"">
            <div class=""card text-white text-center bg-primary mb-3"">

                <div class=""card-body"">
                    <h4 class=""card-title"">Tamamladığınız Görev Sayısı</h4>

");
#nullable restore
#line 16 "C:\Users\yskah\Desktop\UdemyToDo\YSKProje.ToDo.Web\Areas\Member\Views\Home\Index.cshtml"
                     if (ViewBag.TamamlananGorevSayisi > 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p class=\"card-text display-4\">");
#nullable restore
#line 18 "C:\Users\yskah\Desktop\UdemyToDo\YSKProje.ToDo.Web\Areas\Member\Views\Home\Index.cshtml"
                                                  Write(ViewBag.TamamlananGorevSayisi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p");
            BeginWriteAttribute("class", " class=\"", 569, "\"", 577, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "34320fafac448bcd0999f649deba087326d74c8f6820", async() => {
                WriteLiteral("<i class=\"fas fa-chevron-circle-right\"></i> İncele");
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
            WriteLiteral("\r\n                        </p>\r\n");
#nullable restore
#line 22 "C:\Users\yskah\Desktop\UdemyToDo\YSKProje.ToDo.Web\Areas\Member\Views\Home\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p class=\"card-text lead\">\r\n                            Herhangi bir görev tamamlamamışsınız\r\n                        </p>\r\n");
#nullable restore
#line 28 "C:\Users\yskah\Desktop\UdemyToDo\YSKProje.ToDo.Web\Areas\Member\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
            </div>
        </div>

        <div class=""col-md-6"">
            <div class=""card text-white text-center bg-primary mb-3"">

                <div class=""card-body"">
                    <h4 class=""card-title"">Tamamlamanız Gereken Görev Sayısı</h4>

");
#nullable restore
#line 39 "C:\Users\yskah\Desktop\UdemyToDo\YSKProje.ToDo.Web\Areas\Member\Views\Home\Index.cshtml"
                     if (ViewBag.TamamlanmasiGerekenGorevSayisi > 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p class=\"card-text display-4\">");
#nullable restore
#line 41 "C:\Users\yskah\Desktop\UdemyToDo\YSKProje.ToDo.Web\Areas\Member\Views\Home\Index.cshtml"
                                                  Write(ViewBag.TamamlanmasiGerekenGorevSayisi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p");
            BeginWriteAttribute("class", " class=\"", 1524, "\"", 1532, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "34320fafac448bcd0999f649deba087326d74c8f10152", async() => {
                WriteLiteral("<i class=\"fas fa-chevron-circle-right\"></i> İncele");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </p>\r\n");
#nullable restore
#line 45 "C:\Users\yskah\Desktop\UdemyToDo\YSKProje.ToDo.Web\Areas\Member\Views\Home\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p class=\"card-text lead\">\r\n                            Herhangi bir iş emriniz bulunmamaktadır.\r\n                        </p>\r\n");
#nullable restore
#line 51 "C:\Users\yskah\Desktop\UdemyToDo\YSKProje.ToDo.Web\Areas\Member\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
            </div>
        </div>

        <div class=""col-md-6"">
            <div class=""card text-white text-center bg-primary mb-3"">

                <div class=""card-body"">
                    <h4 class=""card-title"">Okumadığınız Bildirimler</h4>

");
#nullable restore
#line 62 "C:\Users\yskah\Desktop\UdemyToDo\YSKProje.ToDo.Web\Areas\Member\Views\Home\Index.cshtml"
                     if (ViewBag.OkunmamisBildirimSayisi > 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p class=\"card-text display-4\">");
#nullable restore
#line 64 "C:\Users\yskah\Desktop\UdemyToDo\YSKProje.ToDo.Web\Areas\Member\Views\Home\Index.cshtml"
                                                  Write(ViewBag.OkunmamisBildirimSayisi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p");
            BeginWriteAttribute("class", " class=\"", 2461, "\"", 2469, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "34320fafac448bcd0999f649deba087326d74c8f13466", async() => {
                WriteLiteral("<i class=\"fas fa-chevron-circle-right\"></i> İncele");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
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
            WriteLiteral("\r\n                        </p>\r\n");
#nullable restore
#line 68 "C:\Users\yskah\Desktop\UdemyToDo\YSKProje.ToDo.Web\Areas\Member\Views\Home\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p class=\"card-text lead\">\r\n                            Bütün bildirimler görüldü.\r\n                        </p>\r\n");
#nullable restore
#line 74 "C:\Users\yskah\Desktop\UdemyToDo\YSKProje.ToDo.Web\Areas\Member\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
            </div>
        </div>


        <div class=""col-md-6"">
            <div class=""card text-white bg-primary text-center mb-3"">

                <div class=""card-body"">
                    <h4 class=""card-title"">Yazdığınız Rapor Sayısı</h4>
");
#nullable restore
#line 85 "C:\Users\yskah\Desktop\UdemyToDo\YSKProje.ToDo.Web\Areas\Member\Views\Home\Index.cshtml"
                     if (ViewBag.RaporSayisi > 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p class=\"card-text display-4\">");
#nullable restore
#line 87 "C:\Users\yskah\Desktop\UdemyToDo\YSKProje.ToDo.Web\Areas\Member\Views\Home\Index.cshtml"
                                                  Write(ViewBag.RaporSayisi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 88 "C:\Users\yskah\Desktop\UdemyToDo\YSKProje.ToDo.Web\Areas\Member\Views\Home\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p class=\"card-text lead\">\r\n                            Herhangi bir rapor yazmamışsınız.\r\n                        </p>\r\n");
#nullable restore
#line 94 "C:\Users\yskah\Desktop\UdemyToDo\YSKProje.ToDo.Web\Areas\Member\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n\r\n\r\n");
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
