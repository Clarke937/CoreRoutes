#pragma checksum "C:\Storage\Develop\Aspnet\CoreRoutes\Views\Choose\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f2e7df87d31e55fb96758bed1024c0fee0c8db1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Choose_Index), @"mvc.1.0.view", @"/Views/Choose/Index.cshtml")]
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
#line 1 "C:\Storage\Develop\Aspnet\CoreRoutes\Views\_ViewImports.cshtml"
using CoreRoutes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Storage\Develop\Aspnet\CoreRoutes\Views\_ViewImports.cshtml"
using CoreRoutes.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Storage\Develop\Aspnet\CoreRoutes\Views\_ViewImports.cshtml"
using CoreRoutes.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f2e7df87d31e55fb96758bed1024c0fee0c8db1", @"/Views/Choose/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32c40dca3b18a506423cc0730a589c4fa01ef996", @"/Views/_ViewImports.cshtml")]
    public class Views_Choose_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DeliveryChecking>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/undraw/avatar.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid rounded-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Choose", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "GET", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mt-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ChooseDelivery", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/undraw/choose.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Storage\Develop\Aspnet\CoreRoutes\Views\Choose\Index.cshtml"
  
    string today = DateTime.Now.ToString("dddd, dd MMMM yyyy").ToUpper();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"<div class=""row"">
    <div class=""col-8"">
        <div class=""card"">
            <div class=""card-header"">
                <i class=""fa fa-map-marked-alt mr-2""></i>
                <b>Select a Route</b>
            </div>
            <div class=""card-body"">
                <div class=""row mt-4"">
                    <div class=""col-4"">
                        <div class=""border rounded-lg p-5 text-center"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0f2e7df87d31e55fb96758bed1024c0fee0c8db18416", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            <h5 class=\"mt-3 mb-0\">");
#nullable restore
#line 18 "C:\Storage\Develop\Aspnet\CoreRoutes\Views\Choose\Index.cshtml"
                                             Write(ViewBag.Driver.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                            <b class=\"text-indigo\">");
#nullable restore
#line 19 "C:\Storage\Develop\Aspnet\CoreRoutes\Views\Choose\Index.cshtml"
                                              Write(ViewBag.Driver.Role.UserRole);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"col-8\">\r\n                        <b class=\"text-success\">TODAY: ");
#nullable restore
#line 23 "C:\Storage\Develop\Aspnet\CoreRoutes\Views\Choose\Index.cshtml"
                                                  Write(today);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0f2e7df87d31e55fb96758bed1024c0fee0c8db110685", async() => {
                WriteLiteral("\r\n                            <div class=\"form-group\">\r\n                                <label");
                BeginWriteAttribute("for", " for=\"", 1162, "\"", 1168, 0);
                EndWriteAttribute();
                WriteLiteral(@">Service Date</label>
                                <input type=""date"" class=""form-control form-control-solid"" name=""date"">
                            </div>
                            <div class=""form-group"">
                                <label");
                BeginWriteAttribute("for", " for=\"", 1425, "\"", 1431, 0);
                EndWriteAttribute();
                WriteLiteral(">Service Type</label>\r\n                                <select class=\"form-control form-control-solid\" name=\"service\">\r\n");
#nullable restore
#line 32 "C:\Storage\Develop\Aspnet\CoreRoutes\Views\Choose\Index.cshtml"
                                     foreach (ServiceType st in ViewBag.Services)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0f2e7df87d31e55fb96758bed1024c0fee0c8db112074", async() => {
#nullable restore
#line 34 "C:\Storage\Develop\Aspnet\CoreRoutes\Views\Choose\Index.cshtml"
                                                          Write(st.ServiceName);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 34 "C:\Storage\Develop\Aspnet\CoreRoutes\Views\Choose\Index.cshtml"
                                           WriteLiteral(st.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 35 "C:\Storage\Develop\Aspnet\CoreRoutes\Views\Choose\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                </select>
                            </div>
                            <div class=""form-group mt-5"">
                                <button type=""submit"" class=""btn btn-primary rounded-pill"">
                                    Show me the route
                                </button>
                            </div>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"row mt-5\">\r\n                    <div class=\"col-12\">\r\n                        <table class=\"table table-bordered\">\r\n");
#nullable restore
#line 49 "C:\Storage\Develop\Aspnet\CoreRoutes\Views\Choose\Index.cshtml"
                             for(int i = 0; i < ViewBag.SearchRoutes.Count; i++){
                                Route route = ViewBag.SearchRoutes[i];

                                if(i == 0){

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <th colspan=\"5\" class=\"text-primary\">\r\n                                            <p class=\"text-bold m-0\">");
#nullable restore
#line 55 "C:\Storage\Develop\Aspnet\CoreRoutes\Views\Choose\Index.cshtml"
                                                                Write(route.ServiceType.ServiceName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                                            <span class=\"m-0 small text-muted\">Delivery Route for ");
#nullable restore
#line 56 "C:\Storage\Develop\Aspnet\CoreRoutes\Views\Choose\Index.cshtml"
                                                                                             Write(ViewBag.SearchDate.ToString("dddd, dd MMMM yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> \r\n                                            \r\n");
#nullable restore
#line 58 "C:\Storage\Develop\Aspnet\CoreRoutes\Views\Choose\Index.cshtml"
                                             if(ViewBag.RouteState.Id == 1){

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <span class=\"badge badge-success ml-2\">");
#nullable restore
#line 59 "C:\Storage\Develop\Aspnet\CoreRoutes\Views\Choose\Index.cshtml"
                                                                                  Write(ViewBag.RouteState.State);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 60 "C:\Storage\Develop\Aspnet\CoreRoutes\Views\Choose\Index.cshtml"
                                            }else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <span class=\"badge bg-light ml-2\">");
#nullable restore
#line 61 "C:\Storage\Develop\Aspnet\CoreRoutes\Views\Choose\Index.cshtml"
                                                                             Write(ViewBag.RouteState.State);

#line default
#line hidden
#nullable disable
            WriteLiteral(" by ");
#nullable restore
#line 61 "C:\Storage\Develop\Aspnet\CoreRoutes\Views\Choose\Index.cshtml"
                                                                                                          Write(ViewBag.RouteUser.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 62 "C:\Storage\Develop\Aspnet\CoreRoutes\Views\Choose\Index.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </th>\r\n                                    </tr>\r\n");
#nullable restore
#line 65 "C:\Storage\Develop\Aspnet\CoreRoutes\Views\Choose\Index.cshtml"
                                }


#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <tr>
                                    <th>Company Site</th>
                                    <th>State</th>
                                    <th>City</th>
                                    <th>Address</th>
                                </tr>
");
            WriteLiteral("                                <tr>\r\n                                    <td>");
#nullable restore
#line 76 "C:\Storage\Develop\Aspnet\CoreRoutes\Views\Choose\Index.cshtml"
                                   Write(route.CompanySite.SiteName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 77 "C:\Storage\Develop\Aspnet\CoreRoutes\Views\Choose\Index.cshtml"
                                   Write(route.CompanySite.State);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 78 "C:\Storage\Develop\Aspnet\CoreRoutes\Views\Choose\Index.cshtml"
                                   Write(route.CompanySite.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td colspan=\"3\">");
#nullable restore
#line 79 "C:\Storage\Develop\Aspnet\CoreRoutes\Views\Choose\Index.cshtml"
                                               Write(route.CompanySite.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                </tr>\r\n");
#nullable restore
#line 81 "C:\Storage\Develop\Aspnet\CoreRoutes\Views\Choose\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </table>\r\n                    </div>\r\n                    <div class=\"col-12 mt-2\">\r\n");
#nullable restore
#line 85 "C:\Storage\Develop\Aspnet\CoreRoutes\Views\Choose\Index.cshtml"
                         if(ViewBag.SearchRoutes.Count > 0){
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 86 "C:\Storage\Develop\Aspnet\CoreRoutes\Views\Choose\Index.cshtml"
                             if(ViewBag.RouteState.Id == 1){
                                int weekid = ViewBag.SearchDate.DayOfWeek == 0 ? 7 : (int) ViewBag.SearchDate.DayOfWeek;


#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0f2e7df87d31e55fb96758bed1024c0fee0c8db122431", async() => {
                WriteLiteral("\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0f2e7df87d31e55fb96758bed1024c0fee0c8db122726", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
#nullable restore
#line 90 "C:\Storage\Develop\Aspnet\CoreRoutes\Views\Choose\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.DeliveryDate);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 90 "C:\Storage\Develop\Aspnet\CoreRoutes\Views\Choose\Index.cshtml"
                                                                           WriteLiteral(ViewBag.SearchDate);

#line default
#line hidden
#nullable disable
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
                WriteLiteral("\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0f2e7df87d31e55fb96758bed1024c0fee0c8db125164", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
#nullable restore
#line 91 "C:\Storage\Develop\Aspnet\CoreRoutes\Views\Choose\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.UserFK);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 91 "C:\Storage\Develop\Aspnet\CoreRoutes\Views\Choose\Index.cshtml"
                                                                     WriteLiteral(ViewBag.Driver.Id);

#line default
#line hidden
#nullable disable
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
                WriteLiteral("\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0f2e7df87d31e55fb96758bed1024c0fee0c8db127589", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
#nullable restore
#line 92 "C:\Storage\Develop\Aspnet\CoreRoutes\Views\Choose\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ServiceTypeFK);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 92 "C:\Storage\Develop\Aspnet\CoreRoutes\Views\Choose\Index.cshtml"
                                                                            WriteLiteral(ViewBag.SearchRoutes[0].ServiceTypeFK);

#line default
#line hidden
#nullable disable
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
                WriteLiteral(@"
                                    
                                    <button class=""btn btn-success rounded-pill"" type=""submit"">
                                        <i class=""fal fa-check mr-2""></i> Choose this route
                                    </button>
                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 98 "C:\Storage\Develop\Aspnet\CoreRoutes\Views\Choose\Index.cshtml"
                            }else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <button class=\"btn btn-light rounded-pill\" disabled>\r\n                                    <i class=\"fal fa-times mr-2\"></i> Choose this route\r\n                                </button>\r\n");
#nullable restore
#line 102 "C:\Storage\Develop\Aspnet\CoreRoutes\Views\Choose\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 102 "C:\Storage\Develop\Aspnet\CoreRoutes\Views\Choose\Index.cshtml"
                             
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"col-4\">\r\n        <div class=\"card\">\r\n            <div class=\"card-body py-5 text-center\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0f2e7df87d31e55fb96758bed1024c0fee0c8db132995", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DeliveryChecking> Html { get; private set; }
    }
}
#pragma warning restore 1591
