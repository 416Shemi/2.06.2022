#pragma checksum "C:\Users\Acer\Desktop\task3\NestCod\NestCod\Areas\Area\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d02352e78b56f0049f9d1706075dca3f65a940a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Area_Views_Product_Index), @"mvc.1.0.view", @"/Areas/Area/Views/Product/Index.cshtml")]
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
#line 1 "C:\Users\Acer\Desktop\task3\NestCod\NestCod\Areas\Area\Views\_ViewImports.cshtml"
using NestCod;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Acer\Desktop\task3\NestCod\NestCod\Areas\Area\Views\_ViewImports.cshtml"
using NestCod.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Acer\Desktop\task3\NestCod\NestCod\Areas\Area\Views\_ViewImports.cshtml"
using NestCod.Controllers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Acer\Desktop\task3\NestCod\NestCod\Areas\Area\Views\_ViewImports.cshtml"
using NestCod.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Acer\Desktop\task3\NestCod\NestCod\Areas\Area\Views\_ViewImports.cshtml"
using NestCod.ViewModels.ProductsVM;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d02352e78b56f0049f9d1706075dca3f65a940a", @"/Areas/Area/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2da7ebf8e2c2f795fcc488485e1d5b6e14fe2371", @"/Areas/Area/Views/_ViewImports.cshtml")]
    public class Areas_Area_Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ProductVM>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Product"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Acer\Desktop\task3\NestCod\NestCod\Areas\Area\Views\Product\Index.cshtml"
   ViewData["Title"] = "Index"; 

#line default
#line hidden
#nullable disable
            DefineSection("styles", async() => {
                WriteLiteral("\n    <style>\n        .card-product-grid .img-wrap {\n            height: 300px;\n        }\n    </style>\n");
            }
            );
            WriteLiteral(@"
<!-- Modal -->
<div class=""modal fade"" id=""deleteModal"" tabindex=""-1"" aria-labelledby=""deleteModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""deleteModalLabel"">Silmək istədiyinizə əminsinizmi?</h5>
                <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
            </div>
            <form method=""post"" asp-action=""Delete"" class=""modal-footer"">
                <button type=""submit"" class=""btn btn-google"">Sil</button>
                <button type=""button"" class=""btn btn-brand"" data-bs-dismiss=""modal"">Ləğv et</button>
            </form>
        </div>
    </div>
</div>
<header class=""main-header navbar"">
    <div class=""col-search"">
        <form class=""searchform"">
            <div class=""input-group"">
                <input list=""search_terms"" type=""text"" class=""form-control"" placeholder=""Search term"" />
                <but");
            WriteLiteral(@"ton class=""btn btn-light bg"" type=""button""><i class=""material-icons md-search""></i></button>
            </div>
        </form>
    </div>
    <div class=""col-nav"">
        <button class=""btn btn-icon btn-mobile me-auto"" data-trigger=""#offcanvas_aside""><i class=""material-icons md-apps""></i></button>
        <ul class=""nav"">
            <li class=""nav-item"">
                <a class=""nav-link btn-icon"" href=""#"">
                    <i class=""material-icons md-notifications animation-shake""></i>
                    <span class=""badge rounded-pill"">3</span>
                </a>
            </li>
            <li class=""nav-item"">
                <a class=""nav-link btn-icon darkmode"" href=""#""> <i class=""material-icons md-nights_stay""></i> </a>
            </li>
            <li class=""nav-item"">
                <a href=""#"" class=""requestfullscreen nav-link btn-icon""><i class=""material-icons md-cast""></i></a>
            </li>
            <li class=""dropdown nav-item"">
                <a class=""dropdown-toggle"" data");
            WriteLiteral(@"-bs-toggle=""dropdown"" href=""#"" id=""dropdownLanguage"" aria-expanded=""false""><i class=""material-icons md-public""></i></a>
                <div class=""dropdown-menu dropdown-menu-end"" aria-labelledby=""dropdownLanguage"">
                    <a class=""dropdown-item text-brand"" href=""#""><img src=""assets/imgs/theme/flag-us.png"" alt=""English"" />English</a>
                    <a class=""dropdown-item"" href=""#""><img src=""assets/imgs/theme/flag-fr.png"" alt=""Français"" />Français</a>
                    <a class=""dropdown-item"" href=""#""><img src=""assets/imgs/theme/flag-jp.png"" alt=""Français"" />日本語</a>
                    <a class=""dropdown-item"" href=""#""><img src=""assets/imgs/theme/flag-cn.png"" alt=""Français"" />中国人</a>
                </div>
            </li>
            <li class=""dropdown nav-item"">
                <a class=""dropdown-toggle"" data-bs-toggle=""dropdown"" href=""#"" id=""dropdownAccount"" aria-expanded=""false""> <img class=""img-xs rounded-circle"" src=""assets/imgs/people/avatar-2.png"" alt=""User"" /></a>
           ");
            WriteLiteral(@"     <div class=""dropdown-menu dropdown-menu-end"" aria-labelledby=""dropdownAccount"">
                    <a class=""dropdown-item"" href=""#""><i class=""material-icons md-perm_identity""></i>Edit Profile</a>
                    <a class=""dropdown-item"" href=""#""><i class=""material-icons md-settings""></i>Account Settings</a>
                    <a class=""dropdown-item"" href=""#""><i class=""material-icons md-account_balance_wallet""></i>Wallet</a>
                    <a class=""dropdown-item"" href=""#""><i class=""material-icons md-receipt""></i>Billing</a>
                    <a class=""dropdown-item"" href=""#""><i class=""material-icons md-help_outline""></i>Help center</a>
                    <div class=""dropdown-divider""></div>
                    <a class=""dropdown-item text-danger"" href=""#""><i class=""material-icons md-exit_to_app""></i>Logout</a>
                </div>
            </li>
        </ul>
    </div>
</header>
<section class=""content-main"">
    <div class=""content-header"">
        <div>
            <h2 class=""cont");
            WriteLiteral(@"ent-title card-title"">Products grid</h2>
            <p>Lorem ipsum dolor sit amet.</p>
        </div>
        <div>
            <a asp-action=""Create"" class=""btn btn-primary btn-sm rounded"">Create new</a>
        </div>
    </div>
    <div class=""card mb-4"">
        <header class=""card-header"">
            <div class=""row gx-3"">
                <div class=""col-lg-4 col-md-6 me-auto"">
                    <input type=""text"" placeholder=""Search..."" class=""form-control"" />
                </div>
            </div>
        </header>
        <!-- card-header end// -->
        <div class=""card-body"">
            <div class=""row gx-3 row-cols-1 row-cols-sm-2 row-cols-md-3 row-cols-xl-4 row-cols-xxl-5"">
");
#nullable restore
#line 95 "C:\Users\Acer\Desktop\task3\NestCod\NestCod\Areas\Area\Views\Product\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col\">\n        <div class=\"card card-product-grid\">\n            <a href=\"#\" class=\"img-wrap\"> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4d02352e78b56f0049f9d1706075dca3f65a940a10045", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5160, "~/assets/imgs/shop/", 5160, 19, true);
#nullable restore
#line 99 "C:\Users\Acer\Desktop\task3\NestCod\NestCod\Areas\Area\Views\Product\Index.cshtml"
AddHtmlAttributeValue("", 5179, item.Image, 5179, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" </a>\n            <div class=\"info-wrap\">\n                <span class=\"d-flex justify-content-sm-between\"><a href=\"#\" class=\"title text-truncate\">");
#nullable restore
#line 101 "C:\Users\Acer\Desktop\task3\NestCod\NestCod\Areas\Area\Views\Product\Index.cshtml"
                                                                                                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 101 "C:\Users\Acer\Desktop\task3\NestCod\NestCod\Areas\Area\Views\Product\Index.cshtml"
                                                                                                               Write(item.IsDeleted==false?Html.Raw("<i style='font-size:16px;vertical-align:middle' class='material-icons md-check_circle_outline text-success'></i>"): Html.Raw("<i style='font-size:16px;vertical-align:middle' class='material-icons md-do_not_disturb text-danger'></i>"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a><small class=\"text-muted\">");
#nullable restore
#line 101 "C:\Users\Acer\Desktop\task3\NestCod\NestCod\Areas\Area\Views\Product\Index.cshtml"
                                                                                                                                                                                                                                                                                                                                                                                                                         Write(item.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small></span>\n                <div class=\"price mb-2\">$");
#nullable restore
#line 102 "C:\Users\Acer\Desktop\task3\NestCod\NestCod\Areas\Area\Views\Product\Index.cshtml"
                                    Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n                <!-- price.// -->\n                <a asp-action=\"Update\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 5825, "\"", 5848, 1);
#nullable restore
#line 104 "C:\Users\Acer\Desktop\task3\NestCod\NestCod\Areas\Area\Views\Product\Index.cshtml"
WriteAttributeValue("", 5840, item.Id, 5840, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-sm font-sm rounded btn-brand\"> <i class=\"material-icons md-edit\"></i> Edit </a>\n                <a data-bs-toggle=\"modal\" data-bs-target=\"#deleteModal\" data-id=\"");
#nullable restore
#line 105 "C:\Users\Acer\Desktop\task3\NestCod\NestCod\Areas\Area\Views\Product\Index.cshtml"
                                                                            Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"btn btn-sm font-sm btn-light rounded\"> <i class=\"material-icons md-delete_forever\"></i> Delete </a>\n            </div>\n        </div>\n        <!-- card-product  end// -->\n    </div> <!-- col.// -->");
#nullable restore
#line 109 "C:\Users\Acer\Desktop\task3\NestCod\NestCod\Areas\Area\Views\Product\Index.cshtml"
                          }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
            <!-- row.// -->
        </div>
        <!-- card-body end// -->
    </div>
    <!-- card end// -->
    <div class=""pagination-area mt-30 mb-50"">
        <nav aria-label=""Page navigation example"">
            <ul class=""pagination justify-content-start"">
                <li class=""page-item active""><a class=""page-link"" href=""#"">01</a></li>
                <li class=""page-item""><a class=""page-link"" href=""#"">02</a></li>
                <li class=""page-item""><a class=""page-link"" href=""#"">03</a></li>
                <li class=""page-item""><a class=""page-link dot"" href=""#"">...</a></li>
                <li class=""page-item""><a class=""page-link"" href=""#"">16</a></li>
                <li class=""page-item"">
                    <a class=""page-link"" href=""#""><i class=""material-icons md-chevron_right""></i></a>
                </li>
            </ul>
        </nav>
    </div>
</section>
");
            DefineSection("scripts", async() => {
                WriteLiteral("\n    <script>let deleteUrl = $(\"#deleteModal form\").attr(\"action\")\n        $(\"a[data-bs-target=\'#deleteModal\']\").click(function () {\n            $(\"#deleteModal form\").attr(\"action\", deleteUrl + \"/\" + $(this).attr(\"data-id\"))\n        })</script>\n");
            }
            );
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ProductVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
