#pragma checksum "D:\New folder (2)\WebBlog\NowSaiGon\NowSaiGon\Views\Home\ShowAllProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e3567c73490e8d3de3d7c5569785bd87a4942cf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ShowAllProduct), @"mvc.1.0.view", @"/Views/Home/ShowAllProduct.cshtml")]
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
#line 1 "D:\New folder (2)\WebBlog\NowSaiGon\NowSaiGon\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\New folder (2)\WebBlog\NowSaiGon\NowSaiGon\Views\_ViewImports.cshtml"
using NowSaiGon;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\New folder (2)\WebBlog\NowSaiGon\NowSaiGon\Views\_ViewImports.cshtml"
using NowSaiGon.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\New folder (2)\WebBlog\NowSaiGon\NowSaiGon\Views\Home\ShowAllProduct.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e3567c73490e8d3de3d7c5569785bd87a4942cf", @"/Views/Home/ShowAllProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48325dbde43ade3d5f8f46a20c57f9aeb2ffd391", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_ShowAllProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<X.PagedList.IPagedList<TblProduct>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ProductDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\New folder (2)\WebBlog\NowSaiGon\NowSaiGon\Views\Home\ShowAllProduct.cshtml"
  
    ViewData["Title"] = "ShowAllProduct";
    Layout = "~/Views/Shared/_LayoutPrd_Detail.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"

<section class=""product spad"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-3 col-md-5"">
                <div class=""sidebar"">
                    <div class=""sidebar__item"">
                        <h4>Department</h4>
                        <ul>
                            <li><a href=""#"">Fresh Meat</a></li>
                            <li><a href=""#"">Vegetables</a></li>
                            <li><a href=""#"">Fruit & Nut Gifts</a></li>
                            <li><a href=""#"">Fresh Berries</a></li>
                            <li><a href=""#"">Ocean Foods</a></li>
                            <li><a href=""#"">Butter & Eggs</a></li>
                            <li><a href=""#"">Fastfood</a></li>
                            <li><a href=""#"">Fresh Onion</a></li>
                            <li><a href=""#"">Papayaya & Crisps</a></li>
                            <li><a href=""#"">Oatmeal</a></li>
                        </ul>
                    </div>");
            WriteLiteral(@"
                    <div class=""sidebar__item"">
                        <h4>Price</h4>
                        <div class=""price-range-wrap"">
                            <div class=""price-range ui-slider ui-corner-all ui-slider-horizontal ui-widget ui-widget-content""
                                 data-min=""10"" data-max=""540"">
                                <div class=""ui-slider-range ui-corner-all ui-widget-header""></div>
                                <span tabindex=""0"" class=""ui-slider-handle ui-corner-all ui-state-default""></span>
                                <span tabindex=""0"" class=""ui-slider-handle ui-corner-all ui-state-default""></span>
                            </div>
                            <div class=""range-slider"">
                                <div class=""price-input"">
                                    <input type=""text"" id=""minamount"">
                                    <input type=""text"" id=""maxamount"">
                                </div>
                   ");
            WriteLiteral(@"         </div>
                        </div>
                    </div>
                    <div class=""sidebar__item sidebar__item__color--option"">
                        <h4>Colors</h4>
                        <div class=""sidebar__item__color sidebar__item__color--white"">
                            <label for=""white"">
                                White
                                <input type=""radio"" id=""white"">
                            </label>
                        </div>
                        <div class=""sidebar__item__color sidebar__item__color--gray"">
                            <label for=""gray"">
                                Gray
                                <input type=""radio"" id=""gray"">
                            </label>
                        </div>
                        <div class=""sidebar__item__color sidebar__item__color--red"">
                            <label for=""red"">
                                Red
                                <input t");
            WriteLiteral(@"ype=""radio"" id=""red"">
                            </label>
                        </div>
                        <div class=""sidebar__item__color sidebar__item__color--black"">
                            <label for=""black"">
                                Black
                                <input type=""radio"" id=""black"">
                            </label>
                        </div>
                        <div class=""sidebar__item__color sidebar__item__color--blue"">
                            <label for=""blue"">
                                Blue
                                <input type=""radio"" id=""blue"">
                            </label>
                        </div>
                        <div class=""sidebar__item__color sidebar__item__color--green"">
                            <label for=""green"">
                                Green
                                <input type=""radio"" id=""green"">
                            </label>
                        </div>
  ");
            WriteLiteral(@"                  </div>
                    <div class=""sidebar__item"">
                        <h4>Popular Size</h4>
                        <div class=""sidebar__item__size"">
                            <label for=""large"">
                                Large
                                <input type=""radio"" id=""large"">
                            </label>
                        </div>
                        <div class=""sidebar__item__size"">
                            <label for=""medium"">
                                Medium
                                <input type=""radio"" id=""medium"">
                            </label>
                        </div>
                        <div class=""sidebar__item__size"">
                            <label for=""small"">
                                Small
                                <input type=""radio"" id=""small"">
                            </label>
                        </div>
                        <div class=""sidebar__item__si");
            WriteLiteral(@"ze"">
                            <label for=""tiny"">
                                Tiny
                                <input type=""radio"" id=""tiny"">
                            </label>
                        </div>
                    </div>
                    <div class=""sidebar__item"">
                        <div class=""latest-product__text"">
                            <h4>Latest Products</h4>
                            <div class=""latest-product__slider owl-carousel"">
                                <div class=""latest-prdouct__slider__item"">
                                    <a href=""#"" class=""latest-product__item"">
                                        <div class=""latest-product__item__pic"">
                                            <img src=""img/latest-product/lp-1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 6118, "\"", 6124, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                        </div>
                                        <div class=""latest-product__item__text"">
                                            <h6>Crab Pool Security</h6>
                                            <span>$30.00</span>
                                        </div>
                                    </a>
                                    <a href=""#"" class=""latest-product__item"">
                                        <div class=""latest-product__item__pic"">
                                            <img src=""img/latest-product/lp-2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 6728, "\"", 6734, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                        </div>
                                        <div class=""latest-product__item__text"">
                                            <h6>Crab Pool Security</h6>
                                            <span>$30.00</span>
                                        </div>
                                    </a>
                                    <a href=""#"" class=""latest-product__item"">
                                        <div class=""latest-product__item__pic"">
                                            <img src=""img/latest-product/lp-3.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 7338, "\"", 7344, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                        </div>
                                        <div class=""latest-product__item__text"">
                                            <h6>Crab Pool Security</h6>
                                            <span>$30.00</span>
                                        </div>
                                    </a>
                                </div>
                                <div class=""latest-prdouct__slider__item"">
                                    <a href=""#"" class=""latest-product__item"">
                                        <div class=""latest-product__item__pic"">
                                            <img src=""img/latest-product/lp-1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 8064, "\"", 8070, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                        </div>
                                        <div class=""latest-product__item__text"">
                                            <h6>Crab Pool Security</h6>
                                            <span>$30.00</span>
                                        </div>
                                    </a>
                                    <a href=""#"" class=""latest-product__item"">
                                        <div class=""latest-product__item__pic"">
                                            <img src=""img/latest-product/lp-2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 8674, "\"", 8680, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                        </div>
                                        <div class=""latest-product__item__text"">
                                            <h6>Crab Pool Security</h6>
                                            <span>$30.00</span>
                                        </div>
                                    </a>
                                    <a href=""#"" class=""latest-product__item"">
                                        <div class=""latest-product__item__pic"">
                                            <img src=""img/latest-product/lp-3.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 9284, "\"", 9290, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                        </div>
                                        <div class=""latest-product__item__text"">
                                            <h6>Crab Pool Security</h6>
                                            <span>$30.00</span>
                                        </div>
                                    </a>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-lg-9 col-md-7"">
                <div class=""product__discount"">
                    <div class=""section-title product__discount__title"">
                        <h2>Sale Off</h2>
                    </div>
                    <div class=""row"">
                        <div class=""product__discount__slider owl-carousel"">
");
#nullable restore
#line 188 "D:\New folder (2)\WebBlog\NowSaiGon\NowSaiGon\Views\Home\ShowAllProduct.cshtml"
                             foreach(var item in Model)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 190 "D:\New folder (2)\WebBlog\NowSaiGon\NowSaiGon\Views\Home\ShowAllProduct.cshtml"
                                 if(@item.PriceSale != @item.Price)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    <div class=""col-lg-4"">
                                        <div class=""product__discount__item"">
                                            <div class=""product__discount__item__pic set-bg""
                                                 data-setbg=""");
#nullable restore
#line 195 "D:\New folder (2)\WebBlog\NowSaiGon\NowSaiGon\Views\Home\ShowAllProduct.cshtml"
                                                        Write(item.Avatar);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""">
                                                <div class=""product__discount__percent"">Sale</div>
                                                <ul class=""product__item__pic__hover"">
                                                    <li><a href=""#""><i class=""fa fa-heart""></i></a></li>
                                                    <li><a href=""#""><i class=""fa fa-retweet""></i></a></li>
                                                    <li><a href=""#""><i class=""fa fa-shopping-cart""></i></a></li>
                                                </ul>
                                            </div>
                                            <div class=""product__discount__item__text"">
                                                <span>");
#nullable restore
#line 204 "D:\New folder (2)\WebBlog\NowSaiGon\NowSaiGon\Views\Home\ShowAllProduct.cshtml"
                                                 Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                                <h5>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2e3567c73490e8d3de3d7c5569785bd87a4942cf18337", async() => {
#nullable restore
#line 205 "D:\New folder (2)\WebBlog\NowSaiGon\NowSaiGon\Views\Home\ShowAllProduct.cshtml"
                                                                                                                                      Write(item.ProName);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-productId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 205 "D:\New folder (2)\WebBlog\NowSaiGon\NowSaiGon\Views\Home\ShowAllProduct.cshtml"
                                                                                                                  WriteLiteral(item.ProId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-productId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</h5>\r\n                                                <div class=\"product__item__price\">");
#nullable restore
#line 206 "D:\New folder (2)\WebBlog\NowSaiGon\NowSaiGon\Views\Home\ShowAllProduct.cshtml"
                                                                             Write(item.PriceSale);

#line default
#line hidden
#nullable disable
            WriteLiteral(" VNĐ <span>");
#nullable restore
#line 206 "D:\New folder (2)\WebBlog\NowSaiGon\NowSaiGon\Views\Home\ShowAllProduct.cshtml"
                                                                                                       Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" VNĐ</span></div>\r\n                                            </div>\r\n                                        </div>\r\n                                    </div>\r\n");
#nullable restore
#line 210 "D:\New folder (2)\WebBlog\NowSaiGon\NowSaiGon\Views\Home\ShowAllProduct.cshtml"
                                    
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 211 "D:\New folder (2)\WebBlog\NowSaiGon\NowSaiGon\Views\Home\ShowAllProduct.cshtml"
                                 
                               
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            
                           
                        </div>
                    </div>
                </div>
                <div class=""filter__item"">
                    <div class=""row"">
                        <div class=""col-lg-4 col-md-5"">
                            <div class=""filter__sort"">
                                <span>Sort By</span>
                                <select>
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2e3567c73490e8d3de3d7c5569785bd87a4942cf22959", async() => {
                WriteLiteral("Default");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2e3567c73490e8d3de3d7c5569785bd87a4942cf24156", async() => {
                WriteLiteral("Default");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                </select>
                            </div>
                        </div>
                        <div class=""col-lg-4 col-md-4"">
                            <div class=""filter__found"">
                                <h6><span>16</span> Products found</h6>
                            </div>
                        </div>
                        <div class=""col-lg-4 col-md-3"">
                            <div class=""filter__option"">
                                <span class=""icon_grid-2x2""></span>
                                <span class=""icon_ul""></span>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""row"">
");
#nullable restore
#line 244 "D:\New folder (2)\WebBlog\NowSaiGon\NowSaiGon\Views\Home\ShowAllProduct.cshtml"
                     foreach(var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-lg-4 col-md-6 col-sm-6\">\r\n                            <div class=\"product__item\">\r\n                                <div class=\"product__item__pic set-bg\" data-setbg=\"");
#nullable restore
#line 248 "D:\New folder (2)\WebBlog\NowSaiGon\NowSaiGon\Views\Home\ShowAllProduct.cshtml"
                                                                              Write(item.Avatar);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""">
                                    <ul class=""product__item__pic__hover"">
                                        <li><a href=""#""><i class=""fa fa-heart""></i></a></li>
                                        <li><a href=""#""><i class=""fa fa-retweet""></i></a></li>
                                        <li><a href=""#""><i class=""fa fa-shopping-cart""></i></a></li>
                                    </ul>
                                </div>
                                <div class=""product__item__text"">
                                    <h6>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2e3567c73490e8d3de3d7c5569785bd87a4942cf27450", async() => {
#nullable restore
#line 256 "D:\New folder (2)\WebBlog\NowSaiGon\NowSaiGon\Views\Home\ShowAllProduct.cshtml"
                                                                                                                          Write(item.ProName);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-productId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 256 "D:\New folder (2)\WebBlog\NowSaiGon\NowSaiGon\Views\Home\ShowAllProduct.cshtml"
                                                                                                      WriteLiteral(item.ProId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-productId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</h6>\r\n                                    <h5>");
#nullable restore
#line 257 "D:\New folder (2)\WebBlog\NowSaiGon\NowSaiGon\Views\Home\ShowAllProduct.cshtml"
                                   Write(item.PriceSale);

#line default
#line hidden
#nullable disable
            WriteLiteral(" VNĐ</h5>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 261 "D:\New folder (2)\WebBlog\NowSaiGon\NowSaiGon\Views\Home\ShowAllProduct.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                   \r\n                    \r\n                </div>\r\n                <div class=\"product__pagination\">\r\n                    ");
#nullable restore
#line 266 "D:\New folder (2)\WebBlog\NowSaiGon\NowSaiGon\Views\Home\ShowAllProduct.cshtml"
               Write(Html.PagedListPager(Model,page=>Url.Action("ShowAllProduct",new{page=page})));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </div>\r\n                \r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<X.PagedList.IPagedList<TblProduct>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
