#pragma checksum "C:\Users\Sony\Desktop\CICLO1_2022\LAB_ADS\ADSProject2022-master\ADSProject\Views\AsignacionGrupo\Form.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8442403703aace7efbe2d12fd0ccca6cde2f90a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AsignacionGrupo_Form), @"mvc.1.0.view", @"/Views/AsignacionGrupo/Form.cshtml")]
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
#line 1 "C:\Users\Sony\Desktop\CICLO1_2022\LAB_ADS\ADSProject2022-master\ADSProject\Views\_ViewImports.cshtml"
using ADSProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Sony\Desktop\CICLO1_2022\LAB_ADS\ADSProject2022-master\ADSProject\Views\_ViewImports.cshtml"
using ADSProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8442403703aace7efbe2d12fd0ccca6cde2f90a", @"/Views/AsignacionGrupo/Form.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4753125e59cb16e11bbf2182c17d774c3ab5f631", @"/Views/_ViewImports.cshtml")]
    public class Views_AsignacionGrupo_Form : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ADSProject.Models.GrupoViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Form", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Grupo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Sony\Desktop\CICLO1_2022\LAB_ADS\ADSProject2022-master\ADSProject\Views\AsignacionGrupo\Form.cshtml"
  
    ViewData["Title"] = "Form";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h4>Asignacion de grupo</h4>\r\n<hr />\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f8442403703aace7efbe2d12fd0ccca6cde2f90a4738", async() => {
                WriteLiteral("\r\n    <input type=\"hidden\" id=\"IdGrupo\"");
                BeginWriteAttribute("value", " value=\"", 235, "\"", 257, 1);
#nullable restore
#line 12 "C:\Users\Sony\Desktop\CICLO1_2022\LAB_ADS\ADSProject2022-master\ADSProject\Views\AsignacionGrupo\Form.cshtml"
WriteAttributeValue("", 243, Model.idGrupo, 243, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"Id\" />\r\n    <input type=\"hidden\" id=\"_redirectURL\"");
                BeginWriteAttribute("value", " value=\'", 315, "\'", 352, 1);
#nullable restore
#line 13 "C:\Users\Sony\Desktop\CICLO1_2022\LAB_ADS\ADSProject2022-master\ADSProject\Views\AsignacionGrupo\Form.cshtml"
WriteAttributeValue("", 323, Url.Action("Index", "Grupo"), 323, 29, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <div class=\"form-horizontal\">\r\n        <div class=\"row\">\r\n            <div class=\"col-md-2\">\r\n                <label class=\"font-weight-bold\">Anio:</label>\r\n                <span>");
#nullable restore
#line 18 "C:\Users\Sony\Desktop\CICLO1_2022\LAB_ADS\ADSProject2022-master\ADSProject\Views\AsignacionGrupo\Form.cshtml"
                 Write(Model.anio);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n            </div>\r\n\r\n            <div class=\"col-md-2\">\r\n                <label class=\"font-weight-bold\">Ciclo:</label>\r\n                <span>");
#nullable restore
#line 23 "C:\Users\Sony\Desktop\CICLO1_2022\LAB_ADS\ADSProject2022-master\ADSProject\Views\AsignacionGrupo\Form.cshtml"
                 Write(Model.ciclo);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n            </div>\r\n\r\n            <div class=\"col-md-2\">\r\n                <label class=\"font-weight-bold\">Profesor:</label>\r\n                <span>");
#nullable restore
#line 28 "C:\Users\Sony\Desktop\CICLO1_2022\LAB_ADS\ADSProject2022-master\ADSProject\Views\AsignacionGrupo\Form.cshtml"
                 Write(Model.Profesores.nombreProfesor);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 28 "C:\Users\Sony\Desktop\CICLO1_2022\LAB_ADS\ADSProject2022-master\ADSProject\Views\AsignacionGrupo\Form.cshtml"
                                                  Write(Model.Profesores.apellidoProfesor);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n            </div>\r\n\r\n            <div class=\"col-md-4\">\r\n                <label class=\"font-weight-bold\">Materia:</label>\r\n                <span>");
#nullable restore
#line 33 "C:\Users\Sony\Desktop\CICLO1_2022\LAB_ADS\ADSProject2022-master\ADSProject\Views\AsignacionGrupo\Form.cshtml"
                 Write(Model.Materias.nombreMateria);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n            </div>\r\n        </div>\r\n\r\n        <br />\r\n        <div class=\"row\">\r\n            <div class=\"col-md-4\">\r\n                <label class=\"font-weight-bold\">Carrera:</label>\r\n                <span>");
#nullable restore
#line 41 "C:\Users\Sony\Desktop\CICLO1_2022\LAB_ADS\ADSProject2022-master\ADSProject\Views\AsignacionGrupo\Form.cshtml"
                 Write(Model.Carreras.NombreCarrera);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span>
            </div>
        </div>

        <br />

        <div class=""row"">
            <div class=""col-md-1"">
                <label for=""IdEstudiante"" class=""control-label font-weight-bold"">Estudiante:</label>
            </div>
            <div class=""col-md-3"">
                ");
#nullable restore
#line 52 "C:\Users\Sony\Desktop\CICLO1_2022\LAB_ADS\ADSProject2022-master\ADSProject\Views\AsignacionGrupo\Form.cshtml"
           Write(Html.DropDownList("IdEstudiante", new SelectList(ViewBag.estudiantes, "idEstudiante", "nombresEstudiante"), "[Seleccione una opción]", htmlAttributes: new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

                <span class=""text-danger"" style=""display:none;"" id=""validationEstudiante"">Este campo es requerido</span>

                <span class=""text-danger"" style=""display:none;"" id=""validationIdEstudiante"">El estudiante ya fue agregado</span>

            </div>
            <div class=""col-md-2"">
                <button id=""btnAgregar"" type=""button"" value=""Agregar"" class=""btn btn-success"" onclick=""agregarFila()"">Agregar</button>
            </div>
        </div>
        <hr />

        <table class=""table table-bordered table-striped"">
            <thead>
                <tr>
                    <th>Nombre completo del estudiante</th>
                    <th>Accion</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 73 "C:\Users\Sony\Desktop\CICLO1_2022\LAB_ADS\ADSProject2022-master\ADSProject\Views\AsignacionGrupo\Form.cshtml"
                  
                    int index = 0;

                    foreach (var item in Model.AsignacionGrupos)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <tr>\r\n                            <td>\r\n                                <span>");
#nullable restore
#line 80 "C:\Users\Sony\Desktop\CICLO1_2022\LAB_ADS\ADSProject2022-master\ADSProject\Views\AsignacionGrupo\Form.cshtml"
                                  Write(item.Estudiantes.nombresEstudiante);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                                <input type=\"hidden\"");
                BeginWriteAttribute("name", " name=\"", 2973, "\"", 3017, 3);
                WriteAttributeValue("", 2980, "AsignacionGrupos[", 2980, 17, true);
#nullable restore
#line 81 "C:\Users\Sony\Desktop\CICLO1_2022\LAB_ADS\ADSProject2022-master\ADSProject\Views\AsignacionGrupo\Form.cshtml"
WriteAttributeValue("", 2997, index, 2997, 6, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 3003, "].idEstudiante", 3003, 14, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 3018, "\"", 3056, 1);
#nullable restore
#line 81 "C:\Users\Sony\Desktop\CICLO1_2022\LAB_ADS\ADSProject2022-master\ADSProject\Views\AsignacionGrupo\Form.cshtml"
WriteAttributeValue("", 3026, item.Estudiantes.idEstudiante, 3026, 30, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("\r\n                                       class=\"IdEstudiante\" />\r\n                                <input type=\"hidden\"");
                BeginWriteAttribute("name", " name=\"", 3175, "\"", 3214, 3);
                WriteAttributeValue("", 3182, "AsignacionGrupos[", 3182, 17, true);
#nullable restore
#line 83 "C:\Users\Sony\Desktop\CICLO1_2022\LAB_ADS\ADSProject2022-master\ADSProject\Views\AsignacionGrupo\Form.cshtml"
WriteAttributeValue("", 3199, index, 3199, 6, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 3205, "].idGrupo", 3205, 9, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 3215, "\"", 3237, 1);
#nullable restore
#line 83 "C:\Users\Sony\Desktop\CICLO1_2022\LAB_ADS\ADSProject2022-master\ADSProject\Views\AsignacionGrupo\Form.cshtml"
WriteAttributeValue("", 3223, Model.idGrupo, 3223, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""IdGrupo"" />
                            </td>

                            <td>
                                <button class=""btn btn-xs btn-danger"" onclick=""quitarFila(this)"">Eliminar</button>
                            </td>
                        </tr>
");
#nullable restore
#line 90 "C:\Users\Sony\Desktop\CICLO1_2022\LAB_ADS\ADSProject2022-master\ADSProject\Views\AsignacionGrupo\Form.cshtml"

                        index++;
                    }
                

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </tbody>\r\n        </table>\r\n        <div class=\"row\">\r\n            <div class=\"col-md-2\">\r\n                <input id=\"btnGuardar\" type=\"submit\" value=\"Guardar\" class=\"btn btn-primary\" />\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f8442403703aace7efbe2d12fd0ccca6cde2f90a15015", async() => {
                WriteLiteral("Regresar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n\r\n\r\n<style>\r\n    .table td:last-child, th:last-child {\r\n        text-align: center;\r\n    }\r\n</style>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 119 "C:\Users\Sony\Desktop\CICLO1_2022\LAB_ADS\ADSProject2022-master\ADSProject\Views\AsignacionGrupo\Form.cshtml"
      
        await Html.RenderPartialAsync("_ValidationScriptsPartial");
    

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    <script>
    // Se inicia con el boton agregar deshabilitado
    if ($(""#IdEstudiante option:selected"").text() === ""[Seleccione una opción]"") {
        $('#btnAgregar').prop('disabled', true);
    }
    // Funcion anonima que deshabilita el primer elemento del dropdown
    $(function () {
        $(""select[id='IdEstudiante'] option:first-child"").attr(""disabled"", ""disabled"");
    })
    // Se deshabilita el boton para guardar (ya que se requiere que se seleccione un elemento)
    if($(""select[id='IdEstudiante'] option:first-child"")){
        $('#btnGuardar').prop('disabled', true);
    }
    function customValidate() {
       // 1. Se valida si un elemento fue seleccionado en el dropdown
        if ($(""#IdEstudiante option:selected"").text() === ""[Seleccione una opción]"") {

            $('#validationEstudiante').css('display', 'inline');
            $('#btnAgregar').prop('disabled', true);
            $('#btnGuardar').prop('disabled', true);
            return false;
        } else {");
                WriteLiteral(@"
            $('#validationEstudiante').css('display', 'none');
            $('#btnAgregar').removeAttr('disabled');
            $('#btnGuardar').removeAttr('disabled');
        }
        var currentID = $(""#IdEstudiante"").val();
        var encontrado = false;
       // 2. Se valida si un elemento ya fue insertado en la tabla (previo a guardar)
        $("".IdEstudiante"").each(function (e) {
            if ($(this).val() == currentID) {
                $('#validationIdEstudiante').css('display', 'inline');
                encontrado = true;
            }
        });
        // Si el elemento no existe (se procede a habilitar los botones)
        if (!encontrado) {
            $('#validationIdEstudiante').css('display', 'none');
            $('#btnAgregar').removeAttr('disabled');
            $('#btnGuardar').removeAttr('disabled');
            return true;
        } else {
             $('#btnAgregar').prop('disabled', true);
             $('#btnGuardar').prop('disabled', true);
       ");
                WriteLiteral(@"     return false;
        }
    }
    // Cuando se selecciona un elemento del dropdown
      $(""#IdEstudiante"").change(function () {
        customValidate(); // llamado a la funcion personalizada.
    });
    // Cuando se selecciona el boton eliminar de la tabla
    function quitarFila(elemento) {
        $(elemento).parent().closest(""tr"").remove();
        recalcularIndices();
    }

    // Agregar un registro a la tabla
    function agregarFila() {
        var fila = $(""<tr><td><span>"" + $(""#IdEstudiante option:selected"").text() + ""</span><input type='hidden' value='"" + $(""#IdEstudiante"").val() + ""' class='IdEstudiante' /><input type='hidden' value='"" + $(""#IdGrupo"").val() + ""' class='IdGrupo' /></td><td><button class='btn btn-xs btn-danger' onclick='quitarFila(this)'>Eliminar</button></td></tr>"");
        $(""tbody"").append(fila);
        recalcularIndices();
    }
    // Cuando se elimina un registro de la tabla es necesario recalcular los indices
    function recalcularIndices() {
 ");
                WriteLiteral(@"       var i = 0;
        $("".IdEstudiante"").each(function () {
            $(this).attr(""name"", ""AsignacionGrupos["" + i + ""].IdEstudiante"");
            i++;
        });
        i = 0;
        $("".IdGrupo"").each(function () {
            $(this).attr(""name"", ""AsignacionGrupos["" + i + ""].idGrupo"");
            i++;
        });
        // Se regresa el valor del select al primer indice es decir ([Seleccione una opcion])
        $(""#IdEstudiante"").prop('selectedIndex',0);
        // Se deshabilita el boton para agregar.
        $('#btnAgregar').prop('disabled', true);

        // Se deshabilita el boton para guardar un elemento
        $('#btnGuardar').prop('disabled', true);
    }
    $(document).ready(function () {
        //Agregamos a los formularios la clase form-ajax
        //La cual activa el formulario para trabajar con Ajax
        $(""form"").addClass(""form-ajax"");
        //Activamos Ajax
        initAjaxForm();
    });
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ADSProject.Models.GrupoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
