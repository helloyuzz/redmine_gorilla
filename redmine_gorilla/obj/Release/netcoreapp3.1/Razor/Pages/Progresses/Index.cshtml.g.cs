#pragma checksum "D:\GitHub\redmine_gorilla\redmine_gorilla\Pages\Progresses\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "84112ed12cc0e372a9ef485dad09596d3c58ee8d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(wx_razor_project.Pages.Progresses.Pages_Progresses_Index), @"mvc.1.0.razor-page", @"/Pages/Progresses/Index.cshtml")]
namespace wx_razor_project.Pages.Progresses
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
#line 1 "D:\GitHub\redmine_gorilla\redmine_gorilla\Pages\_ViewImports.cshtml"
using wx_razor_project;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84112ed12cc0e372a9ef485dad09596d3c58ee8d", @"/Pages/Progresses/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a4a39469024f973696f787c8517c8bd248e4889c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Progresses_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("searchForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\GitHub\redmine_gorilla\redmine_gorilla\Pages\Progresses\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("<style>\r\n    td {\r\n        vertical-align: middle !important;\r\n    }\r\n    .main_div {\r\n        height:600px;\r\n        overflow-y:scroll;\r\n    }\r\n</style>\r\n");
            WriteLiteral("<div class=\"transprantBackground\" style=\"padding:8px;\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "84112ed12cc0e372a9ef485dad09596d3c58ee8d4213", async() => {
                WriteLiteral("\r\n        <div class=\"main_div\">\r\n            <table class=\"table table-hover\">\r\n                <thead>\r\n                    <tr>\r\n                        <th>\r\n                            ");
#nullable restore
#line 24 "D:\GitHub\redmine_gorilla\redmine_gorilla\Pages\Progresses\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.AllVersion[0].Version));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 27 "D:\GitHub\redmine_gorilla\redmine_gorilla\Pages\Progresses\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.AllVersion[0].Status));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 30 "D:\GitHub\redmine_gorilla\redmine_gorilla\Pages\Progresses\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.AllVersion[0].StartPrograming));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 33 "D:\GitHub\redmine_gorilla\redmine_gorilla\Pages\Progresses\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.AllVersion[0].PlanComplete));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 36 "D:\GitHub\redmine_gorilla\redmine_gorilla\Pages\Progresses\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.AllVersion[0].RealComplete));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 39 "D:\GitHub\redmine_gorilla\redmine_gorilla\Pages\Progresses\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.AllVersion[0].PublishBy));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </th>\r\n                        <th style=\"width:300px;\">\r\n                            ");
#nullable restore
#line 42 "D:\GitHub\redmine_gorilla\redmine_gorilla\Pages\Progresses\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.AllVersion[0].Desc));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 45 "D:\GitHub\redmine_gorilla\redmine_gorilla\Pages\Progresses\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.AllVersion[0].RequirementURL));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 48 "D:\GitHub\redmine_gorilla\redmine_gorilla\Pages\Progresses\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.AllVersion[0].PrototypeURL));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </th>\r\n                        <th style=\"width:18%;\">\r\n                            ");
#nullable restore
#line 51 "D:\GitHub\redmine_gorilla\redmine_gorilla\Pages\Progresses\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.AllVersion[0].EmployeeList));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 54 "D:\GitHub\redmine_gorilla\redmine_gorilla\Pages\Progresses\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.AllVersion[0].ReleasePath));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </th>\r\n                        <th></th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
#nullable restore
#line 60 "D:\GitHub\redmine_gorilla\redmine_gorilla\Pages\Progresses\Index.cshtml"
                     foreach (var item in Model.AllVersion) {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 63 "D:\GitHub\redmine_gorilla\redmine_gorilla\Pages\Progresses\Index.cshtml"
                       Write(Html.Raw(item.Version));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 66 "D:\GitHub\redmine_gorilla\redmine_gorilla\Pages\Progresses\Index.cshtml"
                       Write(Html.Raw(item.Status));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 69 "D:\GitHub\redmine_gorilla\redmine_gorilla\Pages\Progresses\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.StartPrograming));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 72 "D:\GitHub\redmine_gorilla\redmine_gorilla\Pages\Progresses\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.PlanComplete));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 75 "D:\GitHub\redmine_gorilla\redmine_gorilla\Pages\Progresses\Index.cshtml"
                       Write(Html.Raw(item.RealComplete));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 78 "D:\GitHub\redmine_gorilla\redmine_gorilla\Pages\Progresses\Index.cshtml"
                       Write(Html.Raw(item.PublishBy));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 81 "D:\GitHub\redmine_gorilla\redmine_gorilla\Pages\Progresses\Index.cshtml"
                       Write(Html.Raw(item.Desc));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 84 "D:\GitHub\redmine_gorilla\redmine_gorilla\Pages\Progresses\Index.cshtml"
                       Write(Html.Raw(item.RequirementURL));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 87 "D:\GitHub\redmine_gorilla\redmine_gorilla\Pages\Progresses\Index.cshtml"
                       Write(Html.Raw(item.PrototypeURL));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 90 "D:\GitHub\redmine_gorilla\redmine_gorilla\Pages\Progresses\Index.cshtml"
                       Write(Html.Raw(item.EmployeeList));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 93 "D:\GitHub\redmine_gorilla\redmine_gorilla\Pages\Progresses\Index.cshtml"
                       Write(Html.Raw(item.ReleasePath));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
                WriteLiteral(@"                        </td>
                        <td align=""right"">
                            <div class=""dropdown"">
                                <button type=""button"" class=""btn btn-primary dropdown-toggle btn-xs""
                                        data-toggle=""dropdown"">
                                    操作
                                </button>
                                <ul class=""dropdown-menu pull-right"" role=""menu"" aria-labelledby=""dropdownMenu1"">
                                    <li role=""presentation"">
                                        ");
#nullable restore
#line 104 "D:\GitHub\redmine_gorilla\redmine_gorilla\Pages\Progresses\Index.cshtml"
                                   Write(Html.Raw(item.RequirementURL));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    </li>\r\n                                    <li role=\"presentation\" class=\"divider\"></li>\r\n                                    <li role=\"presentation\">\r\n                                        <a");
                BeginWriteAttribute("href", " href=\"", 4723, "\"", 4778, 3);
#nullable restore
#line 108 "D:\GitHub\redmine_gorilla\redmine_gorilla\Pages\Progresses\Index.cshtml"
WriteAttributeValue("", 4730, com.redmine.gorilla.Globals.VersionURL, 4730, 39, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 4769, "/", 4769, 1, true);
#nullable restore
#line 108 "D:\GitHub\redmine_gorilla\redmine_gorilla\Pages\Progresses\Index.cshtml"
WriteAttributeValue("", 4770, item.Id, 4770, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" target=\"_blank\">打开 ");
#nullable restore
#line 108 "D:\GitHub\redmine_gorilla\redmine_gorilla\Pages\Progresses\Index.cshtml"
                                                                                                                 Write(item.Name1);

#line default
#line hidden
#nullable disable
                WriteLiteral(" 主页</a>\r\n                                    </li>\r\n");
                WriteLiteral("                                </ul>\r\n                            </div>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 117 "D:\GitHub\redmine_gorilla\redmine_gorilla\Pages\Progresses\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n        <div style=\"margin:0px;\" class=\"row\">\r\n            <div class=\"col-1\">\r\n            </div>\r\n            <div class=\"col-xl-2\">\r\n\r\n            </div>\r\n        </div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    <script>\r\n        function NaviToPage(pageIndex) {\r\n            $(\"#htmlPageIndex\").val(pageIndex);\r\n            $(\"#searchForm\").submit();\r\n        }\r\n    </script>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<com.redmine.gorilla.Pages.Progresses.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<com.redmine.gorilla.Pages.Progresses.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<com.redmine.gorilla.Pages.Progresses.IndexModel>)PageContext?.ViewData;
        public com.redmine.gorilla.Pages.Progresses.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
