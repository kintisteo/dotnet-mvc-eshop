#pragma checksum "C:\Dev\EPaper\EPaper\EPaper\Views\Cart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b576be4d5444b213ab9f2e41d21141226b867b8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Index), @"mvc.1.0.view", @"/Views/Cart/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cart/Index.cshtml", typeof(AspNetCore.Views_Cart_Index))]
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
#line 1 "C:\Dev\EPaper\EPaper\EPaper\Views\_ViewImports.cshtml"
using EPaper;

#line default
#line hidden
#line 2 "C:\Dev\EPaper\EPaper\EPaper\Views\_ViewImports.cshtml"
using EPaper.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b576be4d5444b213ab9f2e41d21141226b867b8", @"/Views/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fcbef54089d113057c99e9ef6210b5ba6468efca", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<EPaper.Models.Cart>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control text-center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdateQuantity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CheckOut", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Dev\EPaper\EPaper\EPaper\Views\Cart\Index.cshtml"
  
    ViewBag.Title = "Index";

#line default
#line hidden
            BeginContext(70, 436, true);
            WriteLiteral(@"
<h2>Index</h2>

<div>
    <table id=""cart"" class=""table table-hover table-condensed"">
        <thead>
            <tr>
                <th style=""width:50%"">Product</th>
                <th style=""width:10%"">Price</th>
                <th style=""width:8%"">Quantity</th>
                <th style=""width:22%"" class=""text-center"">Subtotal</th>
                <th style=""width:10%""></th>
            </tr>
        </thead>
");
            EndContext();
#line 19 "C:\Dev\EPaper\EPaper\EPaper\Views\Cart\Index.cshtml"
           double total = 0;

#line default
#line hidden
            BeginContext(537, 17, true);
            WriteLiteral("        <tbody>\r\n");
            EndContext();
#line 21 "C:\Dev\EPaper\EPaper\EPaper\Views\Cart\Index.cshtml"
             if (User.Identity.IsAuthenticated)
            {
                

#line default
#line hidden
#line 23 "C:\Dev\EPaper\EPaper\EPaper\Views\Cart\Index.cshtml"
                 foreach (var cart in Model)
                {

#line default
#line hidden
            BeginContext(683, 452, true);
            WriteLiteral(@"                    <tr>
                        <div class=""col-lg-12"">
                            <td data-th=""Product"">

                                <div class=""row"">
                                    <div class=""col-sm-2 hidden-xs""><img src=""http://placehold.it/100x100"" alt=""..."" class=""img-responsive"" /></div>
                                    <div class=""col-sm-10"">
                                        <h4 class=""nomargin"">");
            EndContext();
            BeginContext(1136, 17, false);
#line 32 "C:\Dev\EPaper\EPaper\EPaper\Views\Cart\Index.cshtml"
                                                        Write(cart.Product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1153, 50, true);
            WriteLiteral("</h4>\r\n                                        <p>");
            EndContext();
            BeginContext(1204, 24, false);
#line 33 "C:\Dev\EPaper\EPaper\EPaper\Views\Cart\Index.cshtml"
                                      Write(cart.Product.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1228, 173, true);
            WriteLiteral("</p>\r\n                                    </div>\r\n                                </div>\r\n                            </td>\r\n                            <td data-th=\"Price\">");
            EndContext();
            BeginContext(1402, 18, false);
#line 37 "C:\Dev\EPaper\EPaper\EPaper\Views\Cart\Index.cshtml"
                                           Write(cart.Product.Price);

#line default
#line hidden
            EndContext();
            BeginContext(1420, 94, true);
            WriteLiteral("</td>\r\n\r\n                            <td data-th=\"Quantity\">\r\n                                ");
            EndContext();
            BeginContext(1514, 500, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a17d1da198f440a993774f6eb0796217", async() => {
                BeginContext(1548, 38, true);
                WriteLiteral("\r\n                                    ");
                EndContext();
                BeginContext(1586, 88, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "dbd7079ca1664c49985a5d5c9a541bfe", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 41 "C:\Dev\EPaper\EPaper\EPaper\Views\Cart\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => cart.Quantity);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                BeginWriteTagHelperAttribute();
#line 41 "C:\Dev\EPaper\EPaper\EPaper\Views\Cart\Index.cshtml"
                                                                                                WriteLiteral(cart.Quantity);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1674, 38, true);
                WriteLiteral("\r\n                                    ");
                EndContext();
                BeginContext(1712, 42, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2dece75d819c48bdb12ea9a7e8f52c7b", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 42 "C:\Dev\EPaper\EPaper\EPaper\Views\Cart\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => cart.Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1754, 38, true);
                WriteLiteral("\r\n                                    ");
                EndContext();
                BeginContext(1792, 69, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a0ef8702999b44e69e17ee9d2415c5f0", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 43 "C:\Dev\EPaper\EPaper\EPaper\Views\Cart\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => cart.Quantity);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1861, 146, true);
                WriteLiteral("\r\n                                    <button class=\"btn btn-info btn-sm\"><i class=\"fa fa-refresh\"></i></button>\r\n                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2014, 108, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td data-th=\"Subtotal\" class=\"text-center\">");
            EndContext();
            BeginContext(2124, 34, false);
#line 47 "C:\Dev\EPaper\EPaper\EPaper\Views\Cart\Index.cshtml"
                                                                   Write(cart.Product.Price * cart.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(2159, 138, true);
            WriteLiteral("</td>\r\n                            <td class=\"actions\" data-th=\"\">\r\n\r\n                              \r\n\r\n\r\n                                ");
            EndContext();
            BeginContext(2297, 234, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6dcde127b40d4d8e852ab6831b04741d", async() => {
                BeginContext(2376, 148, true);
                WriteLiteral("\r\n                                    <button class=\"btn btn-danger btn-sm\"><i class=\"fa fa-trash-o\"></i></button>\r\n                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 53 "C:\Dev\EPaper\EPaper\EPaper\Views\Cart\Index.cshtml"
                                                            WriteLiteral(cart.Product.ProductId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2531, 100, true);
            WriteLiteral("\r\n\r\n                            </td>\r\n                        </div>\r\n\r\n                    </tr>\r\n");
            EndContext();
#line 61 "C:\Dev\EPaper\EPaper\EPaper\Views\Cart\Index.cshtml"
                    total += (cart.Product.Price * cart.Quantity);
                }

#line default
#line hidden
#line 62 "C:\Dev\EPaper\EPaper\EPaper\Views\Cart\Index.cshtml"
                 
            }
            else
            {
                foreach (var item in ViewBag.cart)
                {

#line default
#line hidden
            BeginContext(2837, 452, true);
            WriteLiteral(@"                    <tr>
                        <div class=""col-lg-12"">
                            <td data-th=""Product"">

                                <div class=""row"">
                                    <div class=""col-sm-2 hidden-xs""><img src=""http://placehold.it/100x100"" alt=""..."" class=""img-responsive"" /></div>
                                    <div class=""col-sm-10"">
                                        <h4 class=""nomargin"">");
            EndContext();
            BeginContext(3290, 17, false);
#line 75 "C:\Dev\EPaper\EPaper\EPaper\Views\Cart\Index.cshtml"
                                                        Write(item.Product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(3307, 50, true);
            WriteLiteral("</h4>\r\n                                        <p>");
            EndContext();
            BeginContext(3358, 24, false);
#line 76 "C:\Dev\EPaper\EPaper\EPaper\Views\Cart\Index.cshtml"
                                      Write(item.Product.Description);

#line default
#line hidden
            EndContext();
            BeginContext(3382, 173, true);
            WriteLiteral("</p>\r\n                                    </div>\r\n                                </div>\r\n                            </td>\r\n                            <td data-th=\"Price\">");
            EndContext();
            BeginContext(3556, 18, false);
#line 80 "C:\Dev\EPaper\EPaper\EPaper\Views\Cart\Index.cshtml"
                                           Write(item.Product.Price);

#line default
#line hidden
            EndContext();
            BeginContext(3574, 145, true);
            WriteLiteral("</td>\r\n                            <td data-th=\"Quantity\">\r\n                                <input type=\"number\" class=\"form-control text-center\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3719, "\"", 3741, 1);
#line 82 "C:\Dev\EPaper\EPaper\EPaper\Views\Cart\Index.cshtml"
WriteAttributeValue("", 3727, item.Quantity, 3727, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3742, 109, true);
            WriteLiteral(">\r\n                            </td>\r\n                            <td data-th=\"Subtotal\" class=\"text-center\">");
            EndContext();
            BeginContext(3853, 34, false);
#line 84 "C:\Dev\EPaper\EPaper\EPaper\Views\Cart\Index.cshtml"
                                                                   Write(item.Product.Price * item.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(3888, 382, true);
            WriteLiteral(@"</td>
                            <td class=""actions"" data-th="""">
                                <button class=""btn btn-info btn-sm""><i class=""fa fa-refresh""></i></button>
                                <button class=""btn btn-danger btn-sm""><i class=""fa fa-trash-o""></i></button>
                            </td>
                        </div>

                    </tr>
");
            EndContext();
#line 92 "C:\Dev\EPaper\EPaper\EPaper\Views\Cart\Index.cshtml"
                    total += (item.Product.Price * item.Quantity);
                }
            }

#line default
#line hidden
            BeginContext(4372, 291, true);
            WriteLiteral(@"
        </tbody>

        <tfoot>

            <tr>
                <td><a href=""#"" class=""btn btn-warning""><i class=""fa fa-angle-left""></i> Continue Shopping</a></td>
                <td colspan=""2"" class=""hidden-xs""></td>
                <td class=""hidden-xs text-center""><strong>");
            EndContext();
            BeginContext(4664, 5, false);
#line 103 "C:\Dev\EPaper\EPaper\EPaper\Views\Cart\Index.cshtml"
                                                     Write(total);

#line default
#line hidden
            EndContext();
            BeginContext(4669, 38, true);
            WriteLiteral(" $</strong></td>\r\n                <td>");
            EndContext();
            BeginContext(4707, 139, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "38a89aabf90d496fb7c47299cfb911fa", async() => {
                BeginContext(4800, 42, true);
                WriteLiteral("Checkout <i class=\"fa fa-angle-right\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4846, 66, true);
            WriteLiteral("</td>\r\n            </tr>\r\n        </tfoot>\r\n    </table>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<EPaper.Models.Cart>> Html { get; private set; }
    }
}
#pragma warning restore 1591
