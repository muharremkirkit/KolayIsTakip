#pragma checksum "C:\Users\OKAN\Desktop\startbootstrap-blog-post-gh-pages\UdemyToDo\YSKProje.ToDo.Web\Areas\Admin\Views\IsEmri\AtaPersonel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c3fb5718d330607cd1442af5614b191ad735d61"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_IsEmri_AtaPersonel), @"mvc.1.0.view", @"/Areas/Admin/Views/IsEmri/AtaPersonel.cshtml")]
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
#line 3 "C:\Users\OKAN\Desktop\startbootstrap-blog-post-gh-pages\UdemyToDo\YSKProje.ToDo.Web\Areas\Admin\Views\_ViewImports.cshtml"
using YSKProje.ToDo.DTO.DTOs.AciliyetDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\OKAN\Desktop\startbootstrap-blog-post-gh-pages\UdemyToDo\YSKProje.ToDo.Web\Areas\Admin\Views\_ViewImports.cshtml"
using YSKProje.ToDo.DTO.DTOs.BildirimDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\OKAN\Desktop\startbootstrap-blog-post-gh-pages\UdemyToDo\YSKProje.ToDo.Web\Areas\Admin\Views\_ViewImports.cshtml"
using YSKProje.ToDo.DTO.DTOs.GorevDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\OKAN\Desktop\startbootstrap-blog-post-gh-pages\UdemyToDo\YSKProje.ToDo.Web\Areas\Admin\Views\_ViewImports.cshtml"
using YSKProje.ToDo.DTO.DTOs.AppUserDtos;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c3fb5718d330607cd1442af5614b191ad735d61", @"/Areas/Admin/Views/IsEmri/AtaPersonel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"485cdea07b7c67ddb81490814ca5ce6f140933fa", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_IsEmri_AtaPersonel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GorevListDto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AtaPersonel", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("float-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:240px;width:240px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GorevlendirPersonel", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-lg "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("page-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::YSKProje.ToDo.Web.TagHelpers.GorevAppUserIdTagHelper __YSKProje_ToDo_Web_TagHelpers_GorevAppUserIdTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\OKAN\Desktop\startbootstrap-blog-post-gh-pages\UdemyToDo\YSKProje.ToDo.Web\Areas\Admin\Views\IsEmri\AtaPersonel.cshtml"
  
    ViewData["Title"] = "AtaPersonel";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";
    string s = (string)ViewBag.Aranan;


#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row mt-2\">\r\n    <div class=\"col-md-12 mb-2\">\r\n\r\n");
#nullable restore
#line 11 "C:\Users\OKAN\Desktop\startbootstrap-blog-post-gh-pages\UdemyToDo\YSKProje.ToDo.Web\Areas\Admin\Views\IsEmri\AtaPersonel.cshtml"
         if (!string.IsNullOrWhiteSpace(s))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"border border-dark p-3 mb-2\">\r\n                <strong>\r\n                    ");
#nullable restore
#line 15 "C:\Users\OKAN\Desktop\startbootstrap-blog-post-gh-pages\UdemyToDo\YSKProje.ToDo.Web\Areas\Admin\Views\IsEmri\AtaPersonel.cshtml"
               Write(s);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </strong> kelimesi için sonuçları görüyorsunuz.\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0c3fb5718d330607cd1442af5614b191ad735d618617", async() => {
                WriteLiteral("Filtreyi kaldır");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 17 "C:\Users\OKAN\Desktop\startbootstrap-blog-post-gh-pages\UdemyToDo\YSKProje.ToDo.Web\Areas\Admin\Views\IsEmri\AtaPersonel.cshtml"
                                              WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 19 "C:\Users\OKAN\Desktop\startbootstrap-blog-post-gh-pages\UdemyToDo\YSKProje.ToDo.Web\Areas\Admin\Views\IsEmri\AtaPersonel.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0c3fb5718d330607cd1442af5614b191ad735d6111203", async() => {
                WriteLiteral("\r\n            <input type=\"text\" name=\"s\" class=\"form-control-lg border border-primary border-top-0 border-left-0 border-right-0\" />\r\n            <button type=\"submit\" class=\"btn btn-primary btn-lg\">Çalısan Ara</button>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n\r\n\r\n    <div class=\"col-md-5 \">\r\n\r\n\r\n\r\n");
            WriteLiteral(@"
        <div class=""card card-pricing bg-gradient-success border-0 text-center mb-4"">
            <div class=""card-header bg-transparent"">
                <h4 class=""text-center lead pt-2"" style=""font-family:Farro;font-size:25px"">Görev Bilgileri</h4>
            </div>
            <div class=""card-body pl-3 pr-3"">

                <style>
                            ");
            WriteLiteral("@media only screen and (max-width: 600px) {\r\n                             \r\n                                }\r\n                </style>     \r\n                <ul class=\"list-group bg-gradient-success\"");
            BeginWriteAttribute("style", " style=\"", 2420, "\"", 2428, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <li class=\"list-group-item\" style=\"font-family: Roboto Slab;font-size:20px\">");
#nullable restore
#line 72 "C:\Users\OKAN\Desktop\startbootstrap-blog-post-gh-pages\UdemyToDo\YSKProje.ToDo.Web\Areas\Admin\Views\IsEmri\AtaPersonel.cshtml"
                                                                                           Write(Model.Ad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                    <li class=\"list-group-item\" style=\"font-family: Roboto Slab;font-size:20px\">");
#nullable restore
#line 73 "C:\Users\OKAN\Desktop\startbootstrap-blog-post-gh-pages\UdemyToDo\YSKProje.ToDo.Web\Areas\Admin\Views\IsEmri\AtaPersonel.cshtml"
                                                                                           Write(Model.Aciklama);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                    <li class=\"list-group-item\" style=\"font-family: Roboto Slab;color:crimson;font-size:25px\">");
#nullable restore
#line 74 "C:\Users\OKAN\Desktop\startbootstrap-blog-post-gh-pages\UdemyToDo\YSKProje.ToDo.Web\Areas\Admin\Views\IsEmri\AtaPersonel.cshtml"
                                                                                                         Write(Model.Aciliyet.Tanim);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                    <li class=\"list-group-item\" style=\"font-family: Roboto Slab\">");
#nullable restore
#line 75 "C:\Users\OKAN\Desktop\startbootstrap-blog-post-gh-pages\UdemyToDo\YSKProje.ToDo.Web\Areas\Admin\Views\IsEmri\AtaPersonel.cshtml"
                                                                            Write(Model.OlusturulmaTarih.ToString("D"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                </ul>\r\n                \r\n\r\n");
            WriteLiteral("\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"col-md-7 \">\r\n\r\n\r\n\r\n");
#nullable restore
#line 127 "C:\Users\OKAN\Desktop\startbootstrap-blog-post-gh-pages\UdemyToDo\YSKProje.ToDo.Web\Areas\Admin\Views\IsEmri\AtaPersonel.cshtml"
         foreach (var item in (List<AppUserListDto>)ViewBag.Personeller)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"card  mb-3 p-2\">\r\n                <div class=\"row align-items-center\">\r\n                    <div class=\"col-auto\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0c3fb5718d330607cd1442af5614b191ad735d6116603", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4904, "~/img/", 4904, 6, true);
#nullable restore
#line 132 "C:\Users\OKAN\Desktop\startbootstrap-blog-post-gh-pages\UdemyToDo\YSKProje.ToDo.Web\Areas\Admin\Views\IsEmri\AtaPersonel.cshtml"
AddHtmlAttributeValue("", 4910, item.Picture, 4910, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 132 "C:\Users\OKAN\Desktop\startbootstrap-blog-post-gh-pages\UdemyToDo\YSKProje.ToDo.Web\Areas\Admin\Views\IsEmri\AtaPersonel.cshtml"
AddHtmlAttributeValue("", 4981, item.Name, 4981, 10, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col card\">\r\n                        <div class=\"card-body\">\r\n                            <h5 class=\"card-title\" style=\"font-family: Roboto Slab; font-size: 20px\">");
#nullable restore
#line 136 "C:\Users\OKAN\Desktop\startbootstrap-blog-post-gh-pages\UdemyToDo\YSKProje.ToDo.Web\Areas\Admin\Views\IsEmri\AtaPersonel.cshtml"
                                                                                                Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 136 "C:\Users\OKAN\Desktop\startbootstrap-blog-post-gh-pages\UdemyToDo\YSKProje.ToDo.Web\Areas\Admin\Views\IsEmri\AtaPersonel.cshtml"
                                                                                                           Write(item.SurName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                            <p class=\"card-text\" style=\"font-family: Roboto Slab; font-size: 20px\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("getirGorevAppUserId", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0c3fb5718d330607cd1442af5614b191ad735d6119915", async() => {
            }
            );
            __YSKProje_ToDo_Web_TagHelpers_GorevAppUserIdTagHelper = CreateTagHelper<global::YSKProje.ToDo.Web.TagHelpers.GorevAppUserIdTagHelper>();
            __tagHelperExecutionContext.Add(__YSKProje_ToDo_Web_TagHelpers_GorevAppUserIdTagHelper);
#nullable restore
#line 138 "C:\Users\OKAN\Desktop\startbootstrap-blog-post-gh-pages\UdemyToDo\YSKProje.ToDo.Web\Areas\Admin\Views\IsEmri\AtaPersonel.cshtml"
__YSKProje_ToDo_Web_TagHelpers_GorevAppUserIdTagHelper.AppUserId = item.Id;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("app-user-id", __YSKProje_ToDo_Web_TagHelpers_GorevAppUserIdTagHelper.AppUserId, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </p>\r\n                            <p class=\"card-text\">\r\n                                <small class=\"text-muted\">");
#nullable restore
#line 141 "C:\Users\OKAN\Desktop\startbootstrap-blog-post-gh-pages\UdemyToDo\YSKProje.ToDo.Web\Areas\Admin\Views\IsEmri\AtaPersonel.cshtml"
                                                     Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0c3fb5718d330607cd1442af5614b191ad735d6121874", async() => {
                WriteLiteral("Görevlendir");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-PersonelId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 142 "C:\Users\OKAN\Desktop\startbootstrap-blog-post-gh-pages\UdemyToDo\YSKProje.ToDo.Web\Areas\Admin\Views\IsEmri\AtaPersonel.cshtml"
                                                                               WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["PersonelId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-PersonelId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["PersonelId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 142 "C:\Users\OKAN\Desktop\startbootstrap-blog-post-gh-pages\UdemyToDo\YSKProje.ToDo.Web\Areas\Admin\Views\IsEmri\AtaPersonel.cshtml"
                                                                                                            WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["GorevId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-GorevId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["GorevId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </p>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 148 "C:\Users\OKAN\Desktop\startbootstrap-blog-post-gh-pages\UdemyToDo\YSKProje.ToDo.Web\Areas\Admin\Views\IsEmri\AtaPersonel.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <nav aria-label=\"Page navigation example\">\r\n\r\n            <ul class=\"pagination\">\r\n");
#nullable restore
#line 153 "C:\Users\OKAN\Desktop\startbootstrap-blog-post-gh-pages\UdemyToDo\YSKProje.ToDo.Web\Areas\Admin\Views\IsEmri\AtaPersonel.cshtml"
                 if (!string.IsNullOrWhiteSpace(s))
                {
                    for (int i = 1; i <= ViewBag.ToplamSayfa; i++)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li");
            BeginWriteAttribute("class", " class=\"", 6225, "\"", 6279, 2);
            WriteAttributeValue("", 6233, "page-item", 6233, 9, true);
#nullable restore
#line 157 "C:\Users\OKAN\Desktop\startbootstrap-blog-post-gh-pages\UdemyToDo\YSKProje.ToDo.Web\Areas\Admin\Views\IsEmri\AtaPersonel.cshtml"
WriteAttributeValue(" ", 6242, ViewBag.AktifSayfa==i?"active":"", 6243, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0c3fb5718d330607cd1442af5614b191ad735d6126542", async() => {
#nullable restore
#line 158 "C:\Users\OKAN\Desktop\startbootstrap-blog-post-gh-pages\UdemyToDo\YSKProje.ToDo.Web\Areas\Admin\Views\IsEmri\AtaPersonel.cshtml"
                                                                                                                                    Write(i);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 158 "C:\Users\OKAN\Desktop\startbootstrap-blog-post-gh-pages\UdemyToDo\YSKProje.ToDo.Web\Areas\Admin\Views\IsEmri\AtaPersonel.cshtml"
                                                                            WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 158 "C:\Users\OKAN\Desktop\startbootstrap-blog-post-gh-pages\UdemyToDo\YSKProje.ToDo.Web\Areas\Admin\Views\IsEmri\AtaPersonel.cshtml"
                                                                                                        WriteLiteral(i);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sayfa"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sayfa", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sayfa"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 158 "C:\Users\OKAN\Desktop\startbootstrap-blog-post-gh-pages\UdemyToDo\YSKProje.ToDo.Web\Areas\Admin\Views\IsEmri\AtaPersonel.cshtml"
                                                                                                                         WriteLiteral(s);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["s"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-s", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["s"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </li>\r\n");
#nullable restore
#line 160 "C:\Users\OKAN\Desktop\startbootstrap-blog-post-gh-pages\UdemyToDo\YSKProje.ToDo.Web\Areas\Admin\Views\IsEmri\AtaPersonel.cshtml"
                    }
                }
                else
                {
                    for (int i = 1; i <= ViewBag.ToplamSayfa; i++)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li");
            BeginWriteAttribute("class", " class=\"", 6660, "\"", 6714, 2);
            WriteAttributeValue("", 6668, "page-item", 6668, 9, true);
#nullable restore
#line 166 "C:\Users\OKAN\Desktop\startbootstrap-blog-post-gh-pages\UdemyToDo\YSKProje.ToDo.Web\Areas\Admin\Views\IsEmri\AtaPersonel.cshtml"
WriteAttributeValue(" ", 6677, ViewBag.AktifSayfa==i?"active":"", 6678, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0c3fb5718d330607cd1442af5614b191ad735d6131824", async() => {
#nullable restore
#line 167 "C:\Users\OKAN\Desktop\startbootstrap-blog-post-gh-pages\UdemyToDo\YSKProje.ToDo.Web\Areas\Admin\Views\IsEmri\AtaPersonel.cshtml"
                                                                                                                   Write(i);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 167 "C:\Users\OKAN\Desktop\startbootstrap-blog-post-gh-pages\UdemyToDo\YSKProje.ToDo.Web\Areas\Admin\Views\IsEmri\AtaPersonel.cshtml"
                                                                            WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 167 "C:\Users\OKAN\Desktop\startbootstrap-blog-post-gh-pages\UdemyToDo\YSKProje.ToDo.Web\Areas\Admin\Views\IsEmri\AtaPersonel.cshtml"
                                                                                                        WriteLiteral(i);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sayfa"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sayfa", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sayfa"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </li>\r\n");
#nullable restore
#line 169 "C:\Users\OKAN\Desktop\startbootstrap-blog-post-gh-pages\UdemyToDo\YSKProje.ToDo.Web\Areas\Admin\Views\IsEmri\AtaPersonel.cshtml"
                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </ul>\r\n        </nav>\r\n\r\n    </div>\r\n\r\n\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GorevListDto> Html { get; private set; }
    }
}
#pragma warning restore 1591
