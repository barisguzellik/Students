#pragma checksum "C:\Users\baris\source\repos\Students.UI\Students.UI\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "86cb0587b4067f26bba3bb5c01b6718cb8afddfe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 1 "C:\Users\baris\source\repos\Students.UI\Students.UI\Views\_ViewImports.cshtml"
using Students.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\baris\source\repos\Students.UI\Students.UI\Views\_ViewImports.cshtml"
using Students.UI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86cb0587b4067f26bba3bb5c01b6718cb8afddfe", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29001f54128949122a12e5aca2701511f32e8ec1", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("small-navigation"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"tr\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "86cb0587b4067f26bba3bb5c01b6718cb8afddfe3618", async() => {
                WriteLiteral("\r\n    <title>");
#nullable restore
#line 4 "C:\Users\baris\source\repos\Students.UI\Students.UI\Views\Shared\_Layout.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</title>
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <meta http-equiv=""X-UA-Compatible"" content=""ie=edge"">
    <link rel=""shortcut icon"" href=""/assets/media/image/favicon.png"" />
    <link rel=""stylesheet"" href=""/vendors/bundle.css"" type=""text/css"">
    <link rel=""stylesheet"" href=""/vendors/prism/prism.css"" type=""text/css"">
    <link rel=""stylesheet"" href=""/assets/css/app.min.css"" type=""text/css"">
    <link rel=""stylesheet"" href=""/assets/css/pager.css"" type=""text/css"">
    <link rel=""stylesheet"" href=""/vendors/dataTable/datatables.min.css"" type=""text/css"">
    <link rel=""stylesheet"" href=""/vendors/select2/css/select2.min.css"" type=""text/css"">
    <!--[if lt IE 9]>
    <script src=""https://oss.maxcdn.com/html5shiv/3.7.3/html5shiv.min.js""></script>
    <script src=""https://oss.maxcdn.com/respond/1.4.2/respond.min.js""></script>
    <![endif]-->
    <script src=""/vendors/bundle.js""></script>
    <script src=""/assets/js/examples/sweet-alert.js""></script>
    <script");
                WriteLiteral(@" src=""/vendors/input-mask/jquery.mask.js""></script>
    <script src=""/vendors/dataTable/datatables.min.js""></script>
    <script src=""/vendors/select2/js/select2.min.js""></script>


    <style>
        .pagination {
            display: -ms-flexbox;
            display: flex;
        }

        .dataTables_filter {
            float: right;
        }

        .dataTables_info {
            float: left;
        }
    </style>
");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "86cb0587b4067f26bba3bb5c01b6718cb8afddfe6394", async() => {
                WriteLiteral(@"
    <div class=""preloader"">
        <div class=""preloader-icon""></div>
    </div>
    <div class=""layout-wrapper"">
        <!-- Header -->
        <div class=""header d-print-none"">
            <div class=""header-container"">
                <div class=""header-left"">
                    <div class=""navigation-toggler"">
                        <a href=""#"" data-action=""navigation-toggler"">
                            <i data-feather=""menu""></i>
                        </a>
                    </div>
                    <div class=""header-logo"">
                        <a href=""/dashboard"">
                            <span style=""color: #fff; font-size: 25px; font-weight: bold;"">Student</span>
                        </a>
                    </div>
                </div>
                <div class=""header-body"">
                    <div class=""header-body-left"">
                        <ul class=""navbar-nav"">
                            <li class=""nav-item"">
                              ");
                WriteLiteral(@"  <div class=""header-search-form"">
                                    <div class=""input-group"">
                                        <div class=""input-group-prepend"">
                                            <button class=""btn"">
                                                <i data-feather=""search""></i>
                                            </button>
                                        </div>
                                        <input type=""text"" placeholder=""Öğrenci ara..."" class=""form-control"" id=""searchItem"" />
                                        <div class=""input-group-append"">
                                            <button class=""btn header-search-close-btn"">
                                                <i data-feather=""x""></i>
                                            </button>
                                        </div>
                                    </div>
                                </div>
                            </li>
             ");
                WriteLiteral("               <li class=\"nav-item dropdown\">\r\n                                <a href=\"#\" class=\"nav-link\"");
                BeginWriteAttribute("title", " title=\"", 3739, "\"", 3747, 0);
                EndWriteAttribute();
                WriteLiteral(@" data-toggle=""dropdown"">
                                    <i data-feather=""plus-circle""></i>
                                </a>
                                <div class=""dropdown-menu"">
                                    <a href=""/student"" class=""dropdown-item"">Öğrenci</a>
                                    <a href=""/lesson"" class=""dropdown-item"">Ders</a>
                                    <a href=""/class"" class=""dropdown-item"">Sınıf</a>
                                </div>
                            </li>
                        </ul>
                    </div>
                    <div class=""header-body-right"">
                        <ul class=""navbar-nav"">
                            <li class=""nav-item"">
                                <a href=""#"" class=""nav-link mobile-header-search-btn"" title=""Arama..."">
                                    <i data-feather=""search""></i>
                                </a>
                            </li>
                            <li c");
                WriteLiteral(@"lass=""nav-item dropdown"">
                                <a href=""#"" class=""nav-link"" title=""Tam Ekran"" data-toggle=""fullscreen"">
                                    <i class=""maximize"" data-feather=""maximize""></i>
                                    <i class=""minimize"" data-feather=""minimize""></i>
                                </a>
                            </li>
                            <li class=""nav-item dropdown"">
                                <a href=""#"" class=""nav-link dropdown-toggle""");
                BeginWriteAttribute("title", " title=\"", 5286, "\"", 5294, 0);
                EndWriteAttribute();
                WriteLiteral(@" data-toggle=""dropdown"">
                                    <figure class=""avatar avatar-sm"">
                                        <img src=""/assets/media/image/user/man_avatar3.jpg"" class=""rounded-circle""
                                             alt=""avatar"">
                                    </figure>
                                    <span class=""ml-2 d-sm-inline d-none"">Admin</span>
                                </a>
                                <div class=""dropdown-menu dropdown-menu-right dropdown-menu-big"">
                                    <div class=""text-center py-4"" data-background-image=""/assets/media/image/image1.jpg"">
                                        <figure class=""avatar avatar-lg mb-3 border-0"">
                                            <img src=""/assets/media/image/user/man_avatar3.jpg"" class=""rounded-circle"" alt=""image"">
                                        </figure>
                                        <h5 class=""mb-0"">Admin</h5>
              ");
                WriteLiteral(@"                      </div>
                                    <div class=""list-group list-group-flush"">
                                        <a href=""/logout"" class=""list-group-item text-danger"">Oturumu Kapat</a>
                                    </div>
                                </div>
                            </li>
                        </ul>
                    </div>
                </div>
                <ul class=""navbar-nav ml-auto"">
                    <li class=""nav-item header-toggler"">
                        <a href=""#"" class=""nav-link"">
                            <i data-feather=""arrow-down""></i>
                        </a>
                    </li>
                </ul>
            </div>
        </div>
        <!-- ./ Header -->
        <!-- Content wrapper -->
        <div class=""content-wrapper"">
            <!-- begin::navigation -->
            <div class=""navigation"">
                <div class=""navigation-menu-body"">
                    <ul>
  ");
                WriteLiteral(@"                      <li>
                            <a href=""/dashboard"">
                                <span class=""nav-link-icon"">
                                    <i data-feather=""pie-chart""></i>
                                </span>
                                <span>Gösterge</span>
                            </a>
                        </li>
                        <li>
                            <a href=""/class"">
                                <span class=""nav-link-icon"">
                                    <i data-feather=""list""></i>
                                </span>
                                <span>Sınıflar</span>
                            </a>
                        </li>
                        <li>
                            <a href=""/lesson"">
                                <span class=""nav-link-icon"">
                                    <i data-feather=""book""></i>
                                </span>
                                <span>Der");
                WriteLiteral(@"sler</span>
                            </a>
                        </li>
                        <li>
                            <a href=""/student"">
                                <span class=""nav-link-icon"">
                                    <i data-feather=""users""></i>
                                </span>
                                <span>Öğrenciler</span>
                            </a>
                        </li>

                        <li>
                            <a href=""/log"">
                                <span class=""nav-link-icon"">
                                    <i data-feather=""eye""></i>
                                </span>
                                <span>Log</span>
                            </a>
                        </li>
                        <li>
                            <a href=""/logout"">
                                <span class=""nav-link-icon"">
                                    <i data-feather=""log-out""></i>
         ");
                WriteLiteral(@"                       </span>
                                <span>Oturumu Kapat</span>
                            </a>
                        </li>
                    </ul>
                </div>
            </div>
            <!-- Content body -->
            <div class=""content-body"">
                ");
#nullable restore
#line 198 "C:\Users\baris\source\repos\Students.UI\Students.UI\Views\Shared\_Layout.cshtml"
           Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                <!-- Footer -->
                <footer class=""content-footer"">
                    <div>© 2020</div>
                    <div>
                        <nav class=""nav"">
                            <a href=""#"" class=""nav-link"">ADMIN</a>
                        </nav>
                    </div>
                </footer>
                <!-- ./ Footer -->
            </div>
        </div>
    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</html>
<script src=""/vendors/prism/prism.js""></script>
<script src=""/assets/js/app.min.js""></script>

<script>
    var currentLink = window.location.href;
    var links = document.querySelectorAll(""a"");
    links.forEach(function (e) {
        if (e.href == currentLink) {
            e.className = ""active"";
        }
    });
</script>
<script>
    document.getElementById(""searchItem"").addEventListener(""keydown"", search);
    function search(e) {
        if (e.code == ""Enter"") {
            var q = document.getElementById(""searchItem"").value;
            if (q.length > 1) {
                location.href = ""/student?q="" + q;
            }
        }
    }
    var url = new URL(location.href);
    var params = url.searchParams.get('q');
    if (params != null) {
        document.getElementById(""searchItem"").value = params;
    }
</script>
");
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