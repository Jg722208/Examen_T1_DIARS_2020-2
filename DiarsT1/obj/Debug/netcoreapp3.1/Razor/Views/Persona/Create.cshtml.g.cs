#pragma checksum "C:\Users\DELL\source\repos\DiarsT1\DiarsT1\Views\Persona\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "22d05512a8946acc1b128f06ce71b3bc9a214b4e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Persona_Create), @"mvc.1.0.view", @"/Views/Persona/Create.cshtml")]
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
#line 1 "C:\Users\DELL\source\repos\DiarsT1\DiarsT1\Views\_ViewImports.cshtml"
using DiarsT1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DELL\source\repos\DiarsT1\DiarsT1\Views\_ViewImports.cshtml"
using DiarsT1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22d05512a8946acc1b128f06ce71b3bc9a214b4e", @"/Views/Persona/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12d8c02eda97c0f88daab15f19ef6814c7421505", @"/Views/_ViewImports.cshtml")]
    public class Views_Persona_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Seleccionar Ciudad", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/persona/create"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\DELL\source\repos\DiarsT1\DiarsT1\Views\Persona\Create.cshtml"
   var person = (Persona)Model; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Registrar Persona</h1>\n\n<div class=\"row\">\n    <div class=\"col-6 offset-3\">\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "22d05512a8946acc1b128f06ce71b3bc9a214b4e4561", async() => {
                WriteLiteral("\n            <div class=\"form-group\">\n                <label>Nombre</label>\n                <input class=\"form-control\" required name=\"Nombre\"");
                BeginWriteAttribute("value", " value=\"", 309, "\"", 331, 1);
#nullable restore
#line 10 "C:\Users\DELL\source\repos\DiarsT1\DiarsT1\Views\Persona\Create.cshtml"
WriteAttributeValue("", 317, person.Nombre, 317, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n                ");
#nullable restore
#line 11 "C:\Users\DELL\source\repos\DiarsT1\DiarsT1\Views\Persona\Create.cshtml"
           Write(Html.ValidationMessage("Nombre"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            </div>\n\n            <div class=\"form-group\">\n                <label>Apellido</label>\n                <input class=\"form-control\" required name=\"Apellido\"");
                BeginWriteAttribute("value", " value=\"", 551, "\"", 575, 1);
#nullable restore
#line 16 "C:\Users\DELL\source\repos\DiarsT1\DiarsT1\Views\Persona\Create.cshtml"
WriteAttributeValue("", 559, person.Apellido, 559, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n                ");
#nullable restore
#line 17 "C:\Users\DELL\source\repos\DiarsT1\DiarsT1\Views\Persona\Create.cshtml"
           Write(Html.ValidationMessage("Apellido"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            </div>\n\n            <div class=\"form-group\">\n                <label>FechaNacimiento</label>\n                <input class=\"form-control\" required name=\"FechaNacimiento\"");
                BeginWriteAttribute("value", " value=\"", 811, "\"", 842, 1);
#nullable restore
#line 22 "C:\Users\DELL\source\repos\DiarsT1\DiarsT1\Views\Persona\Create.cshtml"
WriteAttributeValue("", 819, person.FechaNacimiento, 819, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n                ");
#nullable restore
#line 23 "C:\Users\DELL\source\repos\DiarsT1\DiarsT1\Views\Persona\Create.cshtml"
           Write(Html.ValidationMessage("FechaNacimiento"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            </div>\n\n            <div class=\"form-group\">\n                <label>Dni</label>\n                <input class=\"form-control\" required name=\"Dni\"");
                BeginWriteAttribute("value", " value=\"", 1061, "\"", 1080, 1);
#nullable restore
#line 28 "C:\Users\DELL\source\repos\DiarsT1\DiarsT1\Views\Persona\Create.cshtml"
WriteAttributeValue("", 1069, person.Dni, 1069, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n                ");
#nullable restore
#line 29 "C:\Users\DELL\source\repos\DiarsT1\DiarsT1\Views\Persona\Create.cshtml"
           Write(Html.ValidationMessage("Dni"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            </div>\n\n            <div class=\"form-group\">\n                <label>Genero</label>\n                <input class=\"form-control\" required name=\"Genero\"");
                BeginWriteAttribute("value", " value=\"", 1293, "\"", 1315, 1);
#nullable restore
#line 34 "C:\Users\DELL\source\repos\DiarsT1\DiarsT1\Views\Persona\Create.cshtml"
WriteAttributeValue("", 1301, person.Genero, 1301, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n                ");
#nullable restore
#line 35 "C:\Users\DELL\source\repos\DiarsT1\DiarsT1\Views\Persona\Create.cshtml"
           Write(Html.ValidationMessage("Genero"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            </div>\n\n            <select class=\"form-control\" name=\"Ciudad\">\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "22d05512a8946acc1b128f06ce71b3bc9a214b4e8934", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
#nullable restore
#line 40 "C:\Users\DELL\source\repos\DiarsT1\DiarsT1\Views\Persona\Create.cshtml"
                 foreach (var item in ViewBag.Ciudades)
                {
                    if (item.Id == Model.IdCiudad)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                     ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "22d05512a8946acc1b128f06ce71b3bc9a214b4e10465", async() => {
#nullable restore
#line 44 "C:\Users\DELL\source\repos\DiarsT1\DiarsT1\Views\Persona\Create.cshtml"
                                                  Write(item.Nombre);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 44 "C:\Users\DELL\source\repos\DiarsT1\DiarsT1\Views\Persona\Create.cshtml"
                                 WriteLiteral(item.Id);

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
                WriteLiteral("\n");
#nullable restore
#line 45 "C:\Users\DELL\source\repos\DiarsT1\DiarsT1\Views\Persona\Create.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                     ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "22d05512a8946acc1b128f06ce71b3bc9a214b4e12923", async() => {
#nullable restore
#line 48 "C:\Users\DELL\source\repos\DiarsT1\DiarsT1\Views\Persona\Create.cshtml"
                                      Write(item.Nombre);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 48 "C:\Users\DELL\source\repos\DiarsT1\DiarsT1\Views\Persona\Create.cshtml"
                        WriteLiteral(item);

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
                WriteLiteral("\n");
#nullable restore
#line 49 "C:\Users\DELL\source\repos\DiarsT1\DiarsT1\Views\Persona\Create.cshtml"
                    }
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </select>\n\n            <div class=\"form-group\">\n                <label>Username</label>\n                <input class=\"form-control\" required name=\"Username\"");
                BeginWriteAttribute("value", " value=\"", 2073, "\"", 2097, 1);
#nullable restore
#line 55 "C:\Users\DELL\source\repos\DiarsT1\DiarsT1\Views\Persona\Create.cshtml"
WriteAttributeValue("", 2081, person.Username, 2081, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n                ");
#nullable restore
#line 56 "C:\Users\DELL\source\repos\DiarsT1\DiarsT1\Views\Persona\Create.cshtml"
           Write(Html.ValidationMessage("Username"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            </div>\n\n            <div class=\"form-group\">\n                <label>Correo</label>\n                <input class=\"form-control\" required name=\"Correo\"");
                BeginWriteAttribute("value", " value=\"", 2315, "\"", 2337, 1);
#nullable restore
#line 61 "C:\Users\DELL\source\repos\DiarsT1\DiarsT1\Views\Persona\Create.cshtml"
WriteAttributeValue("", 2323, person.Correo, 2323, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n                ");
#nullable restore
#line 62 "C:\Users\DELL\source\repos\DiarsT1\DiarsT1\Views\Persona\Create.cshtml"
           Write(Html.ValidationMessage("Correo"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            </div>\n\n            <div class=\"form-group\">\n                <label>Password</label>\n                <input class=\"form-control\" required name=\"Password\"");
                BeginWriteAttribute("value", " value=\"", 2557, "\"", 2581, 1);
#nullable restore
#line 67 "C:\Users\DELL\source\repos\DiarsT1\DiarsT1\Views\Persona\Create.cshtml"
WriteAttributeValue("", 2565, person.Password, 2565, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n                ");
#nullable restore
#line 68 "C:\Users\DELL\source\repos\DiarsT1\DiarsT1\Views\Persona\Create.cshtml"
           Write(Html.ValidationMessage("Password"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            </div>\n\n            <button class=\"btn btn-primary\">Registrar</button>\n\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </div>\n</div>\n");
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