#pragma checksum "C:\Users\xD\Desktop\PublicCenter\PublicCenter\Views\Worker\ClientList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c4bdd1c6f07541131b7412e13b443dfc022f832"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Worker_ClientList), @"mvc.1.0.view", @"/Views/Worker/ClientList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Worker/ClientList.cshtml", typeof(AspNetCore.Views_Worker_ClientList))]
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
#line 1 "C:\Users\xD\Desktop\PublicCenter\PublicCenter\Views\_ViewImports.cshtml"
using PublicCenter;

#line default
#line hidden
#line 2 "C:\Users\xD\Desktop\PublicCenter\PublicCenter\Views\_ViewImports.cshtml"
using PublicCenter.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c4bdd1c6f07541131b7412e13b443dfc022f832", @"/Views/Worker/ClientList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34ef7afb532408e97998ac6b010a646c4f8a29a0", @"/Views/_ViewImports.cshtml")]
    public class Views_Worker_ClientList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PublicCenter.Models.Client>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(48, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\xD\Desktop\PublicCenter\PublicCenter\Views\Worker\ClientList.cshtml"
  
    ViewData["Title"] = "ClientList";

#line default
#line hidden
            BeginContext(96, 34, true);
            WriteLiteral("\r\n<h2>ClientList</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(130, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0f55001b83ba460b9b62728897044a65", async() => {
                BeginContext(153, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(167, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(260, 46, false);
#line 16 "C:\Users\xD\Desktop\PublicCenter\PublicCenter\Views\Worker\ClientList.cshtml"
           Write(Html.DisplayNameFor(model => model.Department));

#line default
#line hidden
            EndContext();
            BeginContext(306, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(362, 46, false);
#line 19 "C:\Users\xD\Desktop\PublicCenter\PublicCenter\Views\Worker\ClientList.cshtml"
           Write(Html.DisplayNameFor(model => model.First_name));

#line default
#line hidden
            EndContext();
            BeginContext(408, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(464, 45, false);
#line 22 "C:\Users\xD\Desktop\PublicCenter\PublicCenter\Views\Worker\ClientList.cshtml"
           Write(Html.DisplayNameFor(model => model.Last_name));

#line default
#line hidden
            EndContext();
            BeginContext(509, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(565, 47, false);
#line 25 "C:\Users\xD\Desktop\PublicCenter\PublicCenter\Views\Worker\ClientList.cshtml"
           Write(Html.DisplayNameFor(model => model.Father_name));

#line default
#line hidden
            EndContext();
            BeginContext(612, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(668, 53, false);
#line 28 "C:\Users\xD\Desktop\PublicCenter\PublicCenter\Views\Worker\ClientList.cshtml"
           Write(Html.DisplayNameFor(model => model.Formal_address_id));

#line default
#line hidden
            EndContext();
            BeginContext(721, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(777, 51, false);
#line 31 "C:\Users\xD\Desktop\PublicCenter\PublicCenter\Views\Worker\ClientList.cshtml"
           Write(Html.DisplayNameFor(model => model.Real_address_id));

#line default
#line hidden
            EndContext();
            BeginContext(828, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(884, 46, false);
#line 34 "C:\Users\xD\Desktop\PublicCenter\PublicCenter\Views\Worker\ClientList.cshtml"
           Write(Html.DisplayNameFor(model => model.Phone_stat));

#line default
#line hidden
            EndContext();
            BeginContext(930, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(986, 48, false);
#line 37 "C:\Users\xD\Desktop\PublicCenter\PublicCenter\Views\Worker\ClientList.cshtml"
           Write(Html.DisplayNameFor(model => model.Mobile_phone));

#line default
#line hidden
            EndContext();
            BeginContext(1034, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1090, 56, false);
#line 40 "C:\Users\xD\Desktop\PublicCenter\PublicCenter\Views\Worker\ClientList.cshtml"
           Write(Html.DisplayNameFor(model => model.Personal_file_number));

#line default
#line hidden
            EndContext();
            BeginContext(1146, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1202, 46, false);
#line 43 "C:\Users\xD\Desktop\PublicCenter\PublicCenter\Views\Worker\ClientList.cshtml"
           Write(Html.DisplayNameFor(model => model.Date_birth));

#line default
#line hidden
            EndContext();
            BeginContext(1248, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1304, 39, false);
#line 46 "C:\Users\xD\Desktop\PublicCenter\PublicCenter\Views\Worker\ClientList.cshtml"
           Write(Html.DisplayNameFor(model => model.Age));

#line default
#line hidden
            EndContext();
            BeginContext(1343, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1399, 39, false);
#line 49 "C:\Users\xD\Desktop\PublicCenter\PublicCenter\Views\Worker\ClientList.cshtml"
           Write(Html.DisplayNameFor(model => model.Sex));

#line default
#line hidden
            EndContext();
            BeginContext(1438, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1494, 44, false);
#line 52 "C:\Users\xD\Desktop\PublicCenter\PublicCenter\Views\Worker\ClientList.cshtml"
           Write(Html.DisplayNameFor(model => model.Passport));

#line default
#line hidden
            EndContext();
            BeginContext(1538, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1594, 51, false);
#line 55 "C:\Users\xD\Desktop\PublicCenter\PublicCenter\Views\Worker\ClientList.cshtml"
           Write(Html.DisplayNameFor(model => model.Identify_number));

#line default
#line hidden
            EndContext();
            BeginContext(1645, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1701, 41, false);
#line 58 "C:\Users\xD\Desktop\PublicCenter\PublicCenter\Views\Worker\ClientList.cshtml"
           Write(Html.DisplayNameFor(model => model.Group));

#line default
#line hidden
            EndContext();
            BeginContext(1742, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1798, 42, false);
#line 61 "C:\Users\xD\Desktop\PublicCenter\PublicCenter\Views\Worker\ClientList.cshtml"
           Write(Html.DisplayNameFor(model => model.Period));

#line default
#line hidden
            EndContext();
            BeginContext(1840, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1896, 53, false);
#line 64 "C:\Users\xD\Desktop\PublicCenter\PublicCenter\Views\Worker\ClientList.cshtml"
           Write(Html.DisplayNameFor(model => model.Degree_Indiv_Need));

#line default
#line hidden
            EndContext();
            BeginContext(1949, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2005, 56, false);
#line 67 "C:\Users\xD\Desktop\PublicCenter\PublicCenter\Views\Worker\ClientList.cshtml"
           Write(Html.DisplayNameFor(model => model.Group_Motor_Activity));

#line default
#line hidden
            EndContext();
            BeginContext(2061, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2117, 56, false);
#line 70 "C:\Users\xD\Desktop\PublicCenter\PublicCenter\Views\Worker\ClientList.cshtml"
           Write(Html.DisplayNameFor(model => model.Ability_Self_Service));

#line default
#line hidden
            EndContext();
            BeginContext(2173, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2229, 60, false);
#line 73 "C:\Users\xD\Desktop\PublicCenter\PublicCenter\Views\Worker\ClientList.cshtml"
           Write(Html.DisplayNameFor(model => model.Condition_Giving_Service));

#line default
#line hidden
            EndContext();
            BeginContext(2289, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2345, 51, false);
#line 76 "C:\Users\xD\Desktop\PublicCenter\PublicCenter\Views\Worker\ClientList.cshtml"
           Write(Html.DisplayNameFor(model => model.Number_Of_Visit));

#line default
#line hidden
            EndContext();
            BeginContext(2396, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2452, 42, false);
#line 79 "C:\Users\xD\Desktop\PublicCenter\PublicCenter\Views\Worker\ClientList.cshtml"
           Write(Html.DisplayNameFor(model => model.Worker));

#line default
#line hidden
            EndContext();
            BeginContext(2494, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2550, 62, false);
#line 82 "C:\Users\xD\Desktop\PublicCenter\PublicCenter\Views\Worker\ClientList.cshtml"
           Write(Html.DisplayNameFor(model => model.Organization_Service_House));

#line default
#line hidden
            EndContext();
            BeginContext(2612, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2668, 45, false);
#line 85 "C:\Users\xD\Desktop\PublicCenter\PublicCenter\Views\Worker\ClientList.cshtml"
           Write(Html.DisplayNameFor(model => model.Is_active));

#line default
#line hidden
            EndContext();
            BeginContext(2713, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 91 "C:\Users\xD\Desktop\PublicCenter\PublicCenter\Views\Worker\ClientList.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(2831, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2880, 48, false);
#line 94 "C:\Users\xD\Desktop\PublicCenter\PublicCenter\Views\Worker\ClientList.cshtml"
           Write(Html.DisplayFor(modelItem => item.Department.ID));

#line default
#line hidden
            EndContext();
            BeginContext(2928, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2984, 45, false);
#line 97 "C:\Users\xD\Desktop\PublicCenter\PublicCenter\Views\Worker\ClientList.cshtml"
           Write(Html.DisplayFor(modelItem => item.First_name));

#line default
#line hidden
            EndContext();
            BeginContext(3029, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3085, 44, false);
#line 100 "C:\Users\xD\Desktop\PublicCenter\PublicCenter\Views\Worker\ClientList.cshtml"
           Write(Html.DisplayFor(modelItem => item.Last_name));

#line default
#line hidden
            EndContext();
            BeginContext(3129, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3185, 46, false);
#line 103 "C:\Users\xD\Desktop\PublicCenter\PublicCenter\Views\Worker\ClientList.cshtml"
           Write(Html.DisplayFor(modelItem => item.Father_name));

#line default
#line hidden
            EndContext();
            BeginContext(3231, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3287, 52, false);
#line 106 "C:\Users\xD\Desktop\PublicCenter\PublicCenter\Views\Worker\ClientList.cshtml"
           Write(Html.DisplayFor(modelItem => item.Formal_address_id));

#line default
#line hidden
            EndContext();
            BeginContext(3339, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3395, 50, false);
#line 109 "C:\Users\xD\Desktop\PublicCenter\PublicCenter\Views\Worker\ClientList.cshtml"
           Write(Html.DisplayFor(modelItem => item.Real_address_id));

#line default
#line hidden
            EndContext();
            BeginContext(3445, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3501, 45, false);
#line 112 "C:\Users\xD\Desktop\PublicCenter\PublicCenter\Views\Worker\ClientList.cshtml"
           Write(Html.DisplayFor(modelItem => item.Phone_stat));

#line default
#line hidden
            EndContext();
            BeginContext(3546, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3602, 47, false);
#line 115 "C:\Users\xD\Desktop\PublicCenter\PublicCenter\Views\Worker\ClientList.cshtml"
           Write(Html.DisplayFor(modelItem => item.Mobile_phone));

#line default
#line hidden
            EndContext();
            BeginContext(3649, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3705, 55, false);
#line 118 "C:\Users\xD\Desktop\PublicCenter\PublicCenter\Views\Worker\ClientList.cshtml"
           Write(Html.DisplayFor(modelItem => item.Personal_file_number));

#line default
#line hidden
            EndContext();
            BeginContext(3760, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3816, 45, false);
#line 121 "C:\Users\xD\Desktop\PublicCenter\PublicCenter\Views\Worker\ClientList.cshtml"
           Write(Html.DisplayFor(modelItem => item.Date_birth));

#line default
#line hidden
            EndContext();
            BeginContext(3861, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3917, 38, false);
#line 124 "C:\Users\xD\Desktop\PublicCenter\PublicCenter\Views\Worker\ClientList.cshtml"
           Write(Html.DisplayFor(modelItem => item.Age));

#line default
#line hidden
            EndContext();
            BeginContext(3955, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4011, 38, false);
#line 127 "C:\Users\xD\Desktop\PublicCenter\PublicCenter\Views\Worker\ClientList.cshtml"
           Write(Html.DisplayFor(modelItem => item.Sex));

#line default
#line hidden
            EndContext();
            BeginContext(4049, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4105, 43, false);
#line 130 "C:\Users\xD\Desktop\PublicCenter\PublicCenter\Views\Worker\ClientList.cshtml"
           Write(Html.DisplayFor(modelItem => item.Passport));

#line default
#line hidden
            EndContext();
            BeginContext(4148, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4204, 50, false);
#line 133 "C:\Users\xD\Desktop\PublicCenter\PublicCenter\Views\Worker\ClientList.cshtml"
           Write(Html.DisplayFor(modelItem => item.Identify_number));

#line default
#line hidden
            EndContext();
            BeginContext(4254, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4310, 40, false);
#line 136 "C:\Users\xD\Desktop\PublicCenter\PublicCenter\Views\Worker\ClientList.cshtml"
           Write(Html.DisplayFor(modelItem => item.Group));

#line default
#line hidden
            EndContext();
            BeginContext(4350, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4406, 41, false);
#line 139 "C:\Users\xD\Desktop\PublicCenter\PublicCenter\Views\Worker\ClientList.cshtml"
           Write(Html.DisplayFor(modelItem => item.Period));

#line default
#line hidden
            EndContext();
            BeginContext(4447, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4503, 52, false);
#line 142 "C:\Users\xD\Desktop\PublicCenter\PublicCenter\Views\Worker\ClientList.cshtml"
           Write(Html.DisplayFor(modelItem => item.Degree_Indiv_Need));

#line default
#line hidden
            EndContext();
            BeginContext(4555, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4611, 55, false);
#line 145 "C:\Users\xD\Desktop\PublicCenter\PublicCenter\Views\Worker\ClientList.cshtml"
           Write(Html.DisplayFor(modelItem => item.Group_Motor_Activity));

#line default
#line hidden
            EndContext();
            BeginContext(4666, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4722, 55, false);
#line 148 "C:\Users\xD\Desktop\PublicCenter\PublicCenter\Views\Worker\ClientList.cshtml"
           Write(Html.DisplayFor(modelItem => item.Ability_Self_Service));

#line default
#line hidden
            EndContext();
            BeginContext(4777, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4833, 59, false);
#line 151 "C:\Users\xD\Desktop\PublicCenter\PublicCenter\Views\Worker\ClientList.cshtml"
           Write(Html.DisplayFor(modelItem => item.Condition_Giving_Service));

#line default
#line hidden
            EndContext();
            BeginContext(4892, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4948, 50, false);
#line 154 "C:\Users\xD\Desktop\PublicCenter\PublicCenter\Views\Worker\ClientList.cshtml"
           Write(Html.DisplayFor(modelItem => item.Number_Of_Visit));

#line default
#line hidden
            EndContext();
            BeginContext(4998, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(5054, 44, false);
#line 157 "C:\Users\xD\Desktop\PublicCenter\PublicCenter\Views\Worker\ClientList.cshtml"
           Write(Html.DisplayFor(modelItem => item.Worker.ID));

#line default
#line hidden
            EndContext();
            BeginContext(5098, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(5154, 61, false);
#line 160 "C:\Users\xD\Desktop\PublicCenter\PublicCenter\Views\Worker\ClientList.cshtml"
           Write(Html.DisplayFor(modelItem => item.Organization_Service_House));

#line default
#line hidden
            EndContext();
            BeginContext(5215, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(5271, 44, false);
#line 163 "C:\Users\xD\Desktop\PublicCenter\PublicCenter\Views\Worker\ClientList.cshtml"
           Write(Html.DisplayFor(modelItem => item.Is_active));

#line default
#line hidden
            EndContext();
            BeginContext(5315, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 166 "C:\Users\xD\Desktop\PublicCenter\PublicCenter\Views\Worker\ClientList.cshtml"
}

#line default
#line hidden
            BeginContext(5354, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PublicCenter.Models.Client>> Html { get; private set; }
    }
}
#pragma warning restore 1591
