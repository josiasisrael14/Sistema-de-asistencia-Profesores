#pragma checksum "C:\Users\LAPTOP HPP\Desktop\sistemas_c\REGISTROASISTENCIA\REGISTROASISTENCIA\Views\ListarAsistencia\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f4db421ea120d79b441cf99bc65b6a4e04cc06a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ListarAsistencia_Index), @"mvc.1.0.view", @"/Views/ListarAsistencia/Index.cshtml")]
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
#line 1 "C:\Users\LAPTOP HPP\Desktop\sistemas_c\REGISTROASISTENCIA\REGISTROASISTENCIA\Views\_ViewImports.cshtml"
using REGISTROASISTENCIA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\LAPTOP HPP\Desktop\sistemas_c\REGISTROASISTENCIA\REGISTROASISTENCIA\Views\_ViewImports.cshtml"
using REGISTROASISTENCIA.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\LAPTOP HPP\Desktop\sistemas_c\REGISTROASISTENCIA\REGISTROASISTENCIA\Views\ListarAsistencia\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4db421ea120d79b441cf99bc65b6a4e04cc06a4", @"/Views/ListarAsistencia/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8133141301bfb4c033d5904f4e33041df456a636", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_ListarAsistencia_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("hold-transition sidebar-mini layout-fixed layout-navbar-fixed layout-footer-fixed"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
            DefineSection("ESTILOS", async() => {
                WriteLiteral(@"

    <link  href=""https://cdn.datatables.net/1.13.1/css/jquery.dataTables.min.css""rel=""stylesheet"" />
    <link  href=""https://cdn.datatables.net/buttons/2.3.2/css/buttons.dataTables.min.css"" rel=""stylesheet""/>

    <style>

  .btn-excel{

      background-color:#198754 !important;
      color: white !important;
  }
  .pdf{
     
       background-color:red !important;

  }

  .print{

        background-color:yellow !important;
      color: white !important;
  }



    </style>
");
            }
            );
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f4db421ea120d79b441cf99bc65b6a4e04cc06a45399", async() => {
                WriteLiteral(@"

    <style>
        .sidebar-dark-primary{

            background: #455279 !important;




        }

        #modalCajaMov{
           /* background-color:rgba(0,0,0,0.5)!important;*/

           background-color:white;


        }

    </style>
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <title>AdminLTE 3 | Dashboard 2</title>

    <!-- Google Font: Source Sans Pro -->
    <link rel=""stylesheet"" href=""https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,400i,700&display=fallback"">
    <!-- Font Awesome Icons -->
    <link rel=""stylesheet"" href=""plugins/fontawesome-free/css/all.min.css"">
    <!-- overlayScrollbars -->
    <link rel=""stylesheet"" href=""plugins/overlayScrollbars/css/OverlayScrollbars.min.css"">
    <!-- Theme style -->
    <link rel=""stylesheet"" href=""administrador/dist/css/adminlte.min.css"">


");
                WriteLiteral("\r\n\r\n\r\n     < link rel=\"stylesheet\" type=\"text/css\" href=\"https://cdn.datatables.net/buttons/2.0.1/css/buttons.dataTables.min.css\" />\r\n\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f4db421ea120d79b441cf99bc65b6a4e04cc06a47500", async() => {
                WriteLiteral("\r\n    <div class=\"wrapper\">\r\n\r\n        <!-- Preloader -->\r\n        <div class=\"preloader flex-column justify-content-center align-items-center\">\r\n");
                WriteLiteral(@"        </div>

        <!-- Navbar -->
        <nav class=""main-header navbar navbar-expand navbar-dark"">
            <!-- Left navbar links -->
            <ul class=""navbar-nav"">
                <li class=""nav-item"">
                    <a class=""nav-link"" data-widget=""pushmenu"" href=""#"" role=""button""><i class=""fas fa-bars""></i></a>
                </li>
                <li class=""nav-item d-none d-sm-inline-block"">
");
                WriteLiteral("                </li>\r\n                <li class=\"nav-item d-none d-sm-inline-block\">\r\n");
                WriteLiteral(@"                </li>
            </ul>

            <!-- Right navbar links -->
            <ul class=""navbar-nav ml-auto"">
                <!-- Navbar Search -->
                <li class=""nav-item"">
                    <a class=""nav-link"" data-widget=""navbar-search"" href=""#"" role=""button"">
");
                WriteLiteral("                    </a>\r\n                    <div class=\"navbar-search-block\">\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f4db421ea120d79b441cf99bc65b6a4e04cc06a49025", async() => {
                    WriteLiteral(@"
                            <div class=""input-group input-group-sm"">
                                <input class=""form-control form-control-navbar"" type=""search"" placeholder=""Search"" aria-label=""Search"">
                                <div class=""input-group-append"">
                                    <button class=""btn btn-navbar"" type=""submit"">
");
                    WriteLiteral(@"                                    </button>
                                    <button class=""btn btn-navbar"" type=""button"" data-widget=""navbar-search"">
                                        <i class=""fas fa-times""></i>
                                    </button>
                                </div>
                            </div>
                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    </div>\r\n                </li>\r\n\r\n                <!-- Messages Dropdown Menu -->\r\n                <li class=\"nav-item dropdown\">\r\n                    <a class=\"nav-link\" data-toggle=\"dropdown\" href=\"#\">\r\n");
                WriteLiteral(@"                    </a>
                    <div class=""dropdown-menu dropdown-menu-lg dropdown-menu-right"">
                        <a href=""#"" class=""dropdown-item"">
                            <!-- Message Start -->
                            <div class=""media"">
                                <img src=""administrador/dist/img/user1-128x128.jpg"" alt=""User Avatar"" class=""img-size-50 mr-3 img-circle"">
                                <div class=""media-body"">
                                    <h3 class=""dropdown-item-title"">
                                        Brad Diesel
                                        <span class=""float-right text-sm text-danger""><i class=""fas fa-star""></i></span>
                                    </h3>
                                    <p class=""text-sm"">Call me whenever you can...</p>
                                    <p class=""text-sm text-muted""><i class=""far fa-clock mr-1""></i> 4 Hours Ago</p>
                                </div>
                    ");
                WriteLiteral(@"        </div>
                            <!-- Message End -->
                        </a>
                        <div class=""dropdown-divider""></div>
                        <a href=""#"" class=""dropdown-item"">
                            <!-- Message Start -->
                            <div class=""media"">
                                <img src=""administrador/dist/img/user8-128x128.jpg"" alt=""User Avatar"" class=""img-size-50 img-circle mr-3"">
                                <div class=""media-body"">
                                    <h3 class=""dropdown-item-title"">
                                        John Pierce
                                        <span class=""float-right text-sm text-muted""><i class=""fas fa-star""></i></span>
                                    </h3>
                                    <p class=""text-sm"">I got your message bro</p>
                                    <p class=""text-sm text-muted""><i class=""far fa-clock mr-1""></i> 4 Hours Ago</p>
                    ");
                WriteLiteral(@"            </div>
                            </div>
                            <!-- Message End -->
                        </a>
                        <div class=""dropdown-divider""></div>
                        <a href=""#"" class=""dropdown-item"">
                            <!-- Message Start -->
                            <div class=""media"">
                                <img src=""administrador/dist/img/user3-128x128.jpg"" alt=""User Avatar"" class=""img-size-50 img-circle mr-3"">
                                <div class=""media-body"">
                                    <h3 class=""dropdown-item-title"">
                                        Nora Silvester
                                        <span class=""float-right text-sm text-warning""><i class=""fas fa-star""></i></span>
                                    </h3>
                                    <p class=""text-sm"">The subject goes here</p>
                                    <p class=""text-sm text-muted""><i class=""far fa-clock mr-1");
                WriteLiteral(@"""></i> 4 Hours Ago</p>
                                </div>
                            </div>
                            <!-- Message End -->
                        </a>
                        <div class=""dropdown-divider""></div>
                        <a href=""#"" class=""dropdown-item dropdown-footer"">See All Messages</a>
                    </div>
                </li>
                <!-- Notifications Dropdown Menu -->
                <li class=""nav-item dropdown"">
                    <a class=""nav-link"" data-toggle=""dropdown"" href=""#"">
");
                WriteLiteral(@"                    </a>
                    <div class=""dropdown-menu dropdown-menu-lg dropdown-menu-right"">
                        <span class=""dropdown-item dropdown-header"">15 Notifications</span>
                        <div class=""dropdown-divider""></div>
                        <a href=""#"" class=""dropdown-item"">
                            <i class=""fas fa-envelope mr-2""></i> 4 new messages
                            <span class=""float-right text-muted text-sm"">3 mins</span>
                        </a>
                        <div class=""dropdown-divider""></div>
                        <a href=""#"" class=""dropdown-item"">
                            <i class=""fas fa-users mr-2""></i> 8 friend requests
                            <span class=""float-right text-muted text-sm"">12 hours</span>
                        </a>
                        <div class=""dropdown-divider""></div>
                        <a href=""#"" class=""dropdown-item"">
                            <i class=""fas fa-file mr-");
                WriteLiteral(@"2""></i> 3 new reports
                            <span class=""float-right text-muted text-sm"">2 days</span>
                        </a>
                        <div class=""dropdown-divider""></div>
                        <a href=""#"" class=""dropdown-item dropdown-footer"">See All Notifications</a>
                    </div>
                </li>
                <li class=""nav-item"">
                    <a class=""nav-link"" data-widget=""fullscreen"" href=""#"" role=""button"">
");
                WriteLiteral("                    </a>\r\n                </li>\r\n                <li class=\"nav-item\">\r\n                    <a class=\"nav-link\" data-widget=\"control-sidebar\" data-slide=\"true\" href=\"#\" role=\"button\">\r\n");
                WriteLiteral(@"                    </a>
                </li>
            </ul>
        </nav>
        <!-- /.navbar -->
        <!-- Main Sidebar Container -->
        <aside class=""main-sidebar sidebar-dark-primary elevation-4"">
            <!-- Brand Logo -->
            <a href=""index3.html"" class=""brand-link"">
                
");
                WriteLiteral(@"                <span class=""brand-text font-weight-light"">Web Genius J.P</span>
            </a>

            <!-- Sidebar -->
            <div class=""sidebar"">
                <!-- Sidebar user panel (optional) -->
                <div class=""user-panel mt-3 pb-3 mb-3 d-flex"">
                    <div class=""image"">
                        <img");
                BeginWriteAttribute("src", " src=\"", 11176, "\"", 11197, 1);
#nullable restore
#line 243 "C:\Users\LAPTOP HPP\Desktop\sistemas_c\REGISTROASISTENCIA\REGISTROASISTENCIA\Views\ListarAsistencia\Index.cshtml"
WriteAttributeValue("", 11182, ViewBag.imagen, 11182, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"img-circle elevation-2\" style=\"width: 50px; height: 50px;\" />\r\n                    </div>\r\n                    <div class=\"info\">\r\n");
                WriteLiteral("                        <li>");
#nullable restore
#line 248 "C:\Users\LAPTOP HPP\Desktop\sistemas_c\REGISTROASISTENCIA\REGISTROASISTENCIA\Views\ListarAsistencia\Index.cshtml"
                       Write(Context.Session.GetString("sess_1"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                  <a class=\"btn btn btn-primary btn-xs\" title=\"SALIR\"");
                BeginWriteAttribute("href", " href=\"", 11625, "\"", 11671, 1);
#nullable restore
#line 249 "C:\Users\LAPTOP HPP\Desktop\sistemas_c\REGISTROASISTENCIA\REGISTROASISTENCIA\Views\ListarAsistencia\Index.cshtml"
WriteAttributeValue("", 11632, Url.Action("salir","ListarAsistencia"), 11632, 39, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@"><span class=""fas fa-sign-out-alt""></span> </a>
                    </div>
                </div>

              
                <nav class=""mt-2"">
                    <ul class=""nav nav-pills nav-sidebar flex-column"" data-widget=""treeview"" role=""menu"" data-accordion=""false"">
                        <!-- Add icons to the links using the .nav-icon class
                        with font-awesome or any other icon font library -->
                           <li class=""header"">MENÚ DE NAVEGACIÓN</li>
                        <li class=""nav-item menu-open"">
");
                WriteLiteral("                            <ul class=\"nav nav-treeview\">\r\n                                <li class=\"nav-item\">\r\n                                     <a");
                BeginWriteAttribute("href", " href=\"", 12774, "\"", 12809, 1);
#nullable restore
#line 269 "C:\Users\LAPTOP HPP\Desktop\sistemas_c\REGISTROASISTENCIA\REGISTROASISTENCIA\Views\ListarAsistencia\Index.cshtml"
WriteAttributeValue("", 12781, Url.Action("index","Panel"), 12781, 28, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"nav-link active\">\r\n                                      <i class=\"fa fa-home\" aria-hidden=\"true\"></i>\r\n");
                WriteLiteral("                                        <p>Escritorio</p>\r\n                                    </a>\r\n                                </li>\r\n                                <li class=\"nav-item\">\r\n                                   <a");
                BeginWriteAttribute("href", " href=\"", 13238, "\"", 13278, 1);
#nullable restore
#line 276 "C:\Users\LAPTOP HPP\Desktop\sistemas_c\REGISTROASISTENCIA\REGISTROASISTENCIA\Views\ListarAsistencia\Index.cshtml"
WriteAttributeValue("", 13245, Url.Action("index","escritorio"), 13245, 33, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"nav-link active\">\r\n");
                WriteLiteral(@"                                       <i class=""fa fa-user"" aria-hidden=""true""></i>
                                        <p>Usuarios</p>
                                    </a>
                                </li>
                                <li class=""nav-item"">
                                   <a");
                BeginWriteAttribute("href", " href=\"", 13706, "\"", 13748, 1);
#nullable restore
#line 283 "C:\Users\LAPTOP HPP\Desktop\sistemas_c\REGISTROASISTENCIA\REGISTROASISTENCIA\Views\ListarAsistencia\Index.cshtml"
WriteAttributeValue("", 13713, Url.Action("index","departamento"), 13713, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"nav-link active\">\r\n");
                WriteLiteral(@"                                         <i class='fas fa-book-open'></i>
                                        <p>Departamento</p>
                                    </a>
                                </li>

                                    <li class=""nav-item"">
                                    <a");
                BeginWriteAttribute("href", " href=\"", 14176, "\"", 14213, 1);
#nullable restore
#line 291 "C:\Users\LAPTOP HPP\Desktop\sistemas_c\REGISTROASISTENCIA\REGISTROASISTENCIA\Views\ListarAsistencia\Index.cshtml"
WriteAttributeValue("", 14183, Url.Action("index","Horario"), 14183, 30, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""nav-link active"">
                                          <i class='fas fa-chalkboard-teacher'></i>
                                        <p>Horarios</p>
                                    </a>
                                </li>

                                <li class=""nav-item"">
                                     <a");
                BeginWriteAttribute("href", " href=\"", 14560, "\"", 14606, 1);
#nullable restore
#line 298 "C:\Users\LAPTOP HPP\Desktop\sistemas_c\REGISTROASISTENCIA\REGISTROASISTENCIA\Views\ListarAsistencia\Index.cshtml"
WriteAttributeValue("", 14567, Url.Action("index","ListarAsistencia"), 14567, 39, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"nav-link active\">\r\n");
                WriteLiteral(@"                                        <i class='fas fa-chalkboard-teacher'></i>
                                        <p>Asistencias</p>
                                    </a>
                                </li>

                                <li class=""nav-item"">
                                   <a");
                BeginWriteAttribute("href", " href=\"", 15036, "\"", 15083, 1);
#nullable restore
#line 306 "C:\Users\LAPTOP HPP\Desktop\sistemas_c\REGISTROASISTENCIA\REGISTROASISTENCIA\Views\ListarAsistencia\Index.cshtml"
WriteAttributeValue("", 15043, Url.Action("index","ReporteAsistencia"), 15043, 40, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"nav-link active\">\r\n");
                WriteLiteral(@"                                       <i class=""fa fa-file"" aria-hidden=""true""></i>
                                        <p>reporte</p>
                                    </a>
                                </li>

                            </ul>
                        </li>
                            </ul>
                       
                    
                  
                </nav>
                <!-- /.sidebar-menu -->
            </div>
            <!-- /.sidebar -->
        </aside>



");
#nullable restore
#line 327 "C:\Users\LAPTOP HPP\Desktop\sistemas_c\REGISTROASISTENCIA\REGISTROASISTENCIA\Views\ListarAsistencia\Index.cshtml"
         if(ViewBag.entidad==null){


#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"content-wrapper\">\r\n\r\n           <div id=\"jairo\"></div>\r\n");
                WriteLiteral("           \r\n            <div class=\"panel-body table-responsive\" id=\"listadoregistros\">\r\n                 <table id=\"tabla\" class=\"display\" style=\"width:100%\">\r\n");
                WriteLiteral(@"                    <thead>
                        <tr>
                         
                             <th>id</th>
                           <th>nombre</th>
                            <th>apellidos</th>
                            <th>nombreD</th>
                            <th>asistencia</th>
                            <th>fechahora</th>
                            <th>codigoempleado</th>
                            <th>Puntual</th>
                            
                        </tr>
                    </thead>


                    <tbody>
                       
                    </tbody>

                </table>
            </div>





            


        </div>
");
#nullable restore
#line 368 "C:\Users\LAPTOP HPP\Desktop\sistemas_c\REGISTROASISTENCIA\REGISTROASISTENCIA\Views\ListarAsistencia\Index.cshtml"



        }




        else{


        


#line default
#line hidden
#nullable disable
                WriteLiteral("          <div class=\"content-wrapper\">\r\n\r\n\r\n\r\n\r\n           \r\n\r\n\r\n           <div id=\"jairo\"></div>\r\n");
                WriteLiteral("           \r\n            <div class=\"panel-body table-responsive\" id=\"listadoregistros\">\r\n                 <table id=\"tabla\" class=\"display\" style=\"width:100%\">\r\n");
                WriteLiteral(@"                    <thead>
                        <tr>
                         
                             <th>id</th>
                           <th>nombre</th>
                            <th>apellidos</th>
                            <th>nombreD</th>
                            <th>asistencia</th>
                            <th>fechahora</th>
                            <th>codigoempleado</th>
                            <th>Puntual</th>
                            
                        </tr>
                    </thead>


                    <tbody>
                       

");
#nullable restore
#line 414 "C:\Users\LAPTOP HPP\Desktop\sistemas_c\REGISTROASISTENCIA\REGISTROASISTENCIA\Views\ListarAsistencia\Index.cshtml"
                         foreach (var item in ViewBag.entidad)
                        {
                            

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <tr>\r\n                                  <td>");
#nullable restore
#line 418 "C:\Users\LAPTOP HPP\Desktop\sistemas_c\REGISTROASISTENCIA\REGISTROASISTENCIA\Views\ListarAsistencia\Index.cshtml"
                                 Write(item.idasistencias);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 419 "C:\Users\LAPTOP HPP\Desktop\sistemas_c\REGISTROASISTENCIA\REGISTROASISTENCIA\Views\ListarAsistencia\Index.cshtml"
                               Write(item.nombre);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 420 "C:\Users\LAPTOP HPP\Desktop\sistemas_c\REGISTROASISTENCIA\REGISTROASISTENCIA\Views\ListarAsistencia\Index.cshtml"
                               Write(item.apellidos);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 421 "C:\Users\LAPTOP HPP\Desktop\sistemas_c\REGISTROASISTENCIA\REGISTROASISTENCIA\Views\ListarAsistencia\Index.cshtml"
                               Write(item.nombreD);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 422 "C:\Users\LAPTOP HPP\Desktop\sistemas_c\REGISTROASISTENCIA\REGISTROASISTENCIA\Views\ListarAsistencia\Index.cshtml"
                               Write(item.tipo);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                 <td>");
#nullable restore
#line 423 "C:\Users\LAPTOP HPP\Desktop\sistemas_c\REGISTROASISTENCIA\REGISTROASISTENCIA\Views\ListarAsistencia\Index.cshtml"
                                Write(item.fechahora);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                 <td>");
#nullable restore
#line 424 "C:\Users\LAPTOP HPP\Desktop\sistemas_c\REGISTROASISTENCIA\REGISTROASISTENCIA\Views\ListarAsistencia\Index.cshtml"
                                Write(item.codigoempleado);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                 <td>");
#nullable restore
#line 425 "C:\Users\LAPTOP HPP\Desktop\sistemas_c\REGISTROASISTENCIA\REGISTROASISTENCIA\Views\ListarAsistencia\Index.cshtml"
                                      if(@item.TardeTemprano=="Tarde"){

#line default
#line hidden
#nullable disable
                WriteLiteral(" <button type=\"button\" class=\"btn btn-danger\">Tarde</button>");
#nullable restore
#line 425 "C:\Users\LAPTOP HPP\Desktop\sistemas_c\REGISTROASISTENCIA\REGISTROASISTENCIA\Views\ListarAsistencia\Index.cshtml"
                                                                                                                                   }

#line default
#line hidden
#nullable disable
#nullable restore
#line 425 "C:\Users\LAPTOP HPP\Desktop\sistemas_c\REGISTROASISTENCIA\REGISTROASISTENCIA\Views\ListarAsistencia\Index.cshtml"
                                                                                                                                     if(@item.TardeTemprano=="Temprano"){

#line default
#line hidden
#nullable disable
                WriteLiteral("<button type=\"button\" class=\"btn btn-primary\">Temprano</button>");
#nullable restore
#line 425 "C:\Users\LAPTOP HPP\Desktop\sistemas_c\REGISTROASISTENCIA\REGISTROASISTENCIA\Views\ListarAsistencia\Index.cshtml"
                                                                                                                                                                                                                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                 \r\n                            </tr>\r\n");
#nullable restore
#line 428 "C:\Users\LAPTOP HPP\Desktop\sistemas_c\REGISTROASISTENCIA\REGISTROASISTENCIA\Views\ListarAsistencia\Index.cshtml"
                           

                               
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\r\n                    </tbody>\r\n\r\n                </table>\r\n            </div>\r\n\r\n\r\n\r\n\r\n\r\n            \r\n\r\n\r\n          </div>\r\n");
#nullable restore
#line 448 "C:\Users\LAPTOP HPP\Desktop\sistemas_c\REGISTROASISTENCIA\REGISTROASISTENCIA\Views\ListarAsistencia\Index.cshtml"

        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
       
    </div>


    <!-- ./wrapper -->
    <!-- REQUIRED SCRIPTS -->
    <!-- jQuery -->

    <script src=""plugins/jquery/jquery.min.js""></script>
    
    <!-- Bootstrap -->
    <script src=""plugins/bootstrap/js/bootstrap.bundle.min.js""></script>
    <!-- overlayScrollbars -->
    <script src=""plugins/overlayScrollbars/js/jquery.overlayScrollbars.min.js""></script>
    <!-- AdminLTE App -->
    <script src=""administrador/dist/js/adminlte.js""></script>

    <!-- PAGE PLUGINS -->
    <!-- jQuery Mapael -->
    <script src=""plugins/jquery-mousewheel/jquery.mousewheel.js""></script>
    <script src=""plugins/raphael/raphael.min.js""></script>
    <script src=""plugins/jquery-mapael/jquery.mapael.min.js""></script>
    <script src=""plugins/jquery-mapael/maps/usa_states.min.js""></script>
    <!-- ChartJS -->
    <script src=""plugins/chart.js/Chart.min.js""></script>

    <!-- AdminLTE for demo purposes -->
");
                WriteLiteral("    <!-- AdminLTE dashboard demo (This is only for demo purposes) -->\r\n    <script src=\"administrador/dist/js/pages/dashboard2.js\"></script>\r\n\r\n\r\n");
                WriteLiteral("\r\n   \r\n    \r\n   \r\n   \r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
 <!-- usando pruebas con url cdn para reportes con  DataTables-->

 <script src=""https://cdn.datatables.net/1.13.1/js/jquery.dataTables.min.js""></script>
 <script src=""https://cdn.datatables.net/buttons/2.3.2/js/dataTables.buttons.min.js""></script>

");
                WriteLiteral(@"
   <script src=""https://cdnjs.cloudflare.com/ajax/libs/jszip/3.1.3/jszip.min.js"">  </script>
   <script src=""https://cdn.datatables.net/buttons/2.2.3/js/buttons.html5.min.js"">  </script>


   <script src=""https://cdnjs.cloudflare.com/ajax/libs/pdfmake/0.1.53/pdfmake.min.js"">  </script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/pdfmake/0.1.53/vfs_fonts.js"">  </script> 
    <script src=""https://cdn.datatables.net/buttons/2.3.2/js/buttons.print.min.js""></script>
");
                WriteLiteral(@"

<script type=""text/javascript"">
    


$(document).ready(function () {
     $('#tabla').DataTable({

         ""language"":{
             url:""https://cdn.datatables.net/plug-ins/1.13.1/i18n/es-ES.json""
         },
         dom:""Bfrtip"",
         buttons:[
             {
             extend:""excelHtml5"",
             text:""Excel"",
             filename:""Reporte Asistencia"",
             title:"""",
             className:""btn-excel""
            },
            //""pageLength"",
             {
             extend:""pdfHtml5"",
             text:""Pdf"",
             filename:""Reporte Asistencia"",
             title:"""",
             className:""pdf""
            },

            {
             extend:""print"",
             text:""imprimir"",
             filename:""Reporte Asistencia"",
             title:"""",
             className:""print""
            },



             ""pageLength"",


           
         ]


         });
       

        

    });

</script>


   ");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
