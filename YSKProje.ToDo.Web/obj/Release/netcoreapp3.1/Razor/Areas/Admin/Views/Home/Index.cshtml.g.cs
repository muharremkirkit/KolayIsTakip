#pragma checksum "C:\Users\yskah\Desktop\UdemyToDo\YSKProje.ToDo.Web\Areas\Admin\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b3f5b267a0b77ecc9246d7330861662b4b66f40"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Home_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Home/Index.cshtml")]
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
#line 3 "C:\Users\yskah\Desktop\UdemyToDo\YSKProje.ToDo.Web\Areas\Admin\Views\_ViewImports.cshtml"
using YSKProje.ToDo.DTO.DTOs.AciliyetDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\yskah\Desktop\UdemyToDo\YSKProje.ToDo.Web\Areas\Admin\Views\_ViewImports.cshtml"
using YSKProje.ToDo.DTO.DTOs.BildirimDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\yskah\Desktop\UdemyToDo\YSKProje.ToDo.Web\Areas\Admin\Views\_ViewImports.cshtml"
using YSKProje.ToDo.DTO.DTOs.GorevDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\yskah\Desktop\UdemyToDo\YSKProje.ToDo.Web\Areas\Admin\Views\_ViewImports.cshtml"
using YSKProje.ToDo.DTO.DTOs.AppUserDtos;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b3f5b267a0b77ecc9246d7330861662b4b66f40", @"/Areas/Admin/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"485cdea07b7c67ddb81490814ca5ce6f140933fa", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Bildirim", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-light btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "IsEmri", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\yskah\Desktop\UdemyToDo\YSKProje.ToDo.Web\Areas\Admin\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row mt-3\">\r\n\r\n\r\n    <div class=\"col-md-6\">\r\n        <div class=\"card text-white text-center bg-primary mb-3\">\r\n\r\n\r\n\r\n            <div class=\"card-body\">\r\n                <h4 class=\"card-title\">Okunmamış Bildirim Sayısı</h4>\r\n\r\n");
#nullable restore
#line 17 "C:\Users\yskah\Desktop\UdemyToDo\YSKProje.ToDo.Web\Areas\Admin\Views\Home\Index.cshtml"
                 if (ViewBag.OkunmamisBildirimSayisi > 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p class=\"card-text display-4\">");
#nullable restore
#line 19 "C:\Users\yskah\Desktop\UdemyToDo\YSKProje.ToDo.Web\Areas\Admin\Views\Home\Index.cshtml"
                                              Write(ViewBag.OkunmamisBildirimSayisi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p");
            BeginWriteAttribute("class", " class=\"", 535, "\"", 543, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b3f5b267a0b77ecc9246d7330861662b4b66f406271", async() => {
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
            WriteLiteral("\r\n                    </p>\r\n");
#nullable restore
#line 23 "C:\Users\yskah\Desktop\UdemyToDo\YSKProje.ToDo.Web\Areas\Admin\Views\Home\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p class=\"card-text lead\">\r\n                       Tüm bildirimleriniz okunmuş.\r\n                    </p>\r\n");
#nullable restore
#line 29 "C:\Users\yskah\Desktop\UdemyToDo\YSKProje.ToDo.Web\Areas\Admin\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>
    </div>



    <div class=""col-md-6"">
        <div class=""card text-white text-center bg-primary mb-3"">



            <div class=""card-body"">
                <h4 class=""card-title"">Atanma Bekleyen Görev Sayısı</h4>

");
#nullable restore
#line 44 "C:\Users\yskah\Desktop\UdemyToDo\YSKProje.ToDo.Web\Areas\Admin\Views\Home\Index.cshtml"
                 if (ViewBag.AtanmayiBekleyenGorevSayisi > 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p class=\"card-text display-4\">");
#nullable restore
#line 46 "C:\Users\yskah\Desktop\UdemyToDo\YSKProje.ToDo.Web\Areas\Admin\Views\Home\Index.cshtml"
                                              Write(ViewBag.AtanmayiBekleyenGorevSayisi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p");
            BeginWriteAttribute("class", " class=\"", 1401, "\"", 1409, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b3f5b267a0b77ecc9246d7330861662b4b66f409503", async() => {
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
            WriteLiteral("\r\n                    </p>\r\n");
#nullable restore
#line 50 "C:\Users\yskah\Desktop\UdemyToDo\YSKProje.ToDo.Web\Areas\Admin\Views\Home\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p class=\"card-text lead\">\r\n                        Bütün görevlerinizde personelleriniz çalışmakta ya da herhangi bir görev bulunmamakta.\r\n                    </p>\r\n");
#nullable restore
#line 56 "C:\Users\yskah\Desktop\UdemyToDo\YSKProje.ToDo.Web\Areas\Admin\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>
    </div>

    <div class=""col-md-6"">
        <div class=""card text-white text-center bg-primary mb-3"">

            <div class=""card-body"">
                <h4 class=""card-title"">Tamamlanmış Görev Sayısı</h4>

");
#nullable restore
#line 67 "C:\Users\yskah\Desktop\UdemyToDo\YSKProje.ToDo.Web\Areas\Admin\Views\Home\Index.cshtml"
                 if (ViewBag.TamamlanmisGorevSayisi > 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p class=\"card-text display-4\">");
#nullable restore
#line 69 "C:\Users\yskah\Desktop\UdemyToDo\YSKProje.ToDo.Web\Areas\Admin\Views\Home\Index.cshtml"
                                              Write(ViewBag.TamamlanmisGorevSayisi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 70 "C:\Users\yskah\Desktop\UdemyToDo\YSKProje.ToDo.Web\Areas\Admin\Views\Home\Index.cshtml"

                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p class=\"card-text lead\">\r\n                        Herhangi bir görev henüz tamamlanmamış.\r\n                    </p>\r\n");
#nullable restore
#line 77 "C:\Users\yskah\Desktop\UdemyToDo\YSKProje.ToDo.Web\Areas\Admin\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>
    </div>



    <div class=""col-md-6"">
        <div class=""card text-white text-center bg-primary mb-3"">

            <div class=""card-body"">
                <h4 class=""card-title"">Yazılmış Rapor Sayısı</h4>

");
#nullable restore
#line 90 "C:\Users\yskah\Desktop\UdemyToDo\YSKProje.ToDo.Web\Areas\Admin\Views\Home\Index.cshtml"
                 if (ViewBag.ToplamRaporSayisi > 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p class=\"card-text display-4\">");
#nullable restore
#line 92 "C:\Users\yskah\Desktop\UdemyToDo\YSKProje.ToDo.Web\Areas\Admin\Views\Home\Index.cshtml"
                                              Write(ViewBag.ToplamRaporSayisi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 93 "C:\Users\yskah\Desktop\UdemyToDo\YSKProje.ToDo.Web\Areas\Admin\Views\Home\Index.cshtml"

                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p class=\"card-text lead\">\r\n                        Hiçbir rapor yazılmamış.\r\n                    </p>\r\n");
#nullable restore
#line 100 "C:\Users\yskah\Desktop\UdemyToDo\YSKProje.ToDo.Web\Areas\Admin\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n\r\n\r\n");
            WriteLiteral("</div>\r\n");
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
