#pragma checksum "D:\Univer\SEP\SEP3\SEP3 - TIER1\Gradebook\Pages\SecretaryClass.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c0277580cea156feefad8b1ced3705d36a582ebd"
// <auto-generated/>
#pragma warning disable 1591
namespace WebApplication.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Univer\SEP\SEP3\SEP3 - TIER1\Gradebook\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Univer\SEP\SEP3\SEP3 - TIER1\Gradebook\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Univer\SEP\SEP3\SEP3 - TIER1\Gradebook\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Univer\SEP\SEP3\SEP3 - TIER1\Gradebook\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Univer\SEP\SEP3\SEP3 - TIER1\Gradebook\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Univer\SEP\SEP3\SEP3 - TIER1\Gradebook\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Univer\SEP\SEP3\SEP3 - TIER1\Gradebook\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Univer\SEP\SEP3\SEP3 - TIER1\Gradebook\_Imports.razor"
using WebApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Univer\SEP\SEP3\SEP3 - TIER1\Gradebook\_Imports.razor"
using WebApplication.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/SecretaryClass")]
    public partial class SecretaryClass : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<head><link rel=\"stylesheet\" href=\"css/overallTheme.css\"></head>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "blue-border container");
            __builder.AddMarkupContent(3, "<br>\r\n    ");
            __builder.AddMarkupContent(4, "<div class=\"row\"><div class=\"col\"><h3 class=\"center-horiz\">Create Class</h3></div></div>\r\n    <br>\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "row");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "col-4 center-horiz form-group");
            __builder.AddMarkupContent(9, "<label for=\"classNumber\">Class number:</label>\r\n            ");
            __builder.OpenElement(10, "select");
            __builder.AddAttribute(11, "class", "form-control");
            __builder.AddAttribute(12, "id", "classNumber");
            __builder.OpenElement(13, "option");
            __builder.AddAttribute(14, "value", true);
            __builder.AddAttribute(15, "selected", true);
            __builder.AddAttribute(16, "disabled", true);
            __builder.AddAttribute(17, "hidden", true);
            __builder.AddContent(18, "Choose number...");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                ");
            __builder.OpenElement(20, "option");
            __builder.AddAttribute(21, "value", "12");
            __builder.AddContent(22, "12");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                ");
            __builder.OpenElement(24, "option");
            __builder.AddAttribute(25, "value", "11");
            __builder.AddContent(26, "11");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                ");
            __builder.OpenElement(28, "option");
            __builder.AddAttribute(29, "value", "10");
            __builder.AddContent(30, "10");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                ");
            __builder.OpenElement(32, "option");
            __builder.AddAttribute(33, "value", "9");
            __builder.AddContent(34, "9");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                ");
            __builder.OpenElement(36, "option");
            __builder.AddAttribute(37, "value", "8");
            __builder.AddContent(38, "8");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                ");
            __builder.OpenElement(40, "option");
            __builder.AddAttribute(41, "value", "7");
            __builder.AddContent(42, "7");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                ");
            __builder.OpenElement(44, "option");
            __builder.AddAttribute(45, "value", "6");
            __builder.AddContent(46, "6");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                ");
            __builder.OpenElement(48, "option");
            __builder.AddAttribute(49, "value", "5");
            __builder.AddContent(50, "5");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n                ");
            __builder.OpenElement(52, "option");
            __builder.AddAttribute(53, "value", "4");
            __builder.AddContent(54, "4");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n                ");
            __builder.OpenElement(56, "option");
            __builder.AddAttribute(57, "value", "3");
            __builder.AddContent(58, "3");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n                ");
            __builder.OpenElement(60, "option");
            __builder.AddAttribute(61, "value", "2");
            __builder.AddContent(62, "2");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n                ");
            __builder.OpenElement(64, "option");
            __builder.AddAttribute(65, "value", "1");
            __builder.AddContent(66, "1");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n        ");
            __builder.OpenElement(68, "div");
            __builder.AddAttribute(69, "class", "col-4 center-horiz form-group");
            __builder.AddMarkupContent(70, "<label for=\"classLetter\">Class letter:</label>\r\n            ");
            __builder.OpenElement(71, "select");
            __builder.AddAttribute(72, "class", "form-control");
            __builder.AddAttribute(73, "id", "classLetter");
            __builder.OpenElement(74, "option");
            __builder.AddAttribute(75, "value", true);
            __builder.AddAttribute(76, "selected", true);
            __builder.AddAttribute(77, "disabled", true);
            __builder.AddAttribute(78, "hidden", true);
            __builder.AddContent(79, "Choose letter...");
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n                ");
            __builder.OpenElement(81, "option");
            __builder.AddAttribute(82, "value", "A");
            __builder.AddContent(83, "A");
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n                ");
            __builder.OpenElement(85, "option");
            __builder.AddAttribute(86, "value", "B");
            __builder.AddContent(87, "B");
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n                ");
            __builder.OpenElement(89, "option");
            __builder.AddAttribute(90, "value", "C");
            __builder.AddContent(91, "C");
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\r\n                ");
            __builder.OpenElement(93, "option");
            __builder.AddAttribute(94, "value", "D");
            __builder.AddContent(95, "D");
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n                ");
            __builder.OpenElement(97, "option");
            __builder.AddAttribute(98, "value", "E");
            __builder.AddContent(99, "E");
            __builder.CloseElement();
            __builder.AddMarkupContent(100, "\r\n                ");
            __builder.OpenElement(101, "option");
            __builder.AddAttribute(102, "value", "F");
            __builder.AddContent(103, "F");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(104, "\r\n        ");
            __builder.OpenElement(105, "div");
            __builder.AddAttribute(106, "class", "col-4 center-horiz form-group");
            __builder.AddMarkupContent(107, "<label for=\"classTeacher\">Class teacher:</label>\r\n            ");
            __builder.OpenElement(108, "select");
            __builder.AddAttribute(109, "class", "form-control");
            __builder.AddAttribute(110, "id", "classTeacher");
            __builder.OpenElement(111, "option");
            __builder.AddAttribute(112, "value", true);
            __builder.AddAttribute(113, "selected", true);
            __builder.AddAttribute(114, "disabled", true);
            __builder.AddAttribute(115, "hidden", true);
            __builder.AddContent(116, "Choose teacher...");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(117, "\r\n    <br>\r\n    ");
            __builder.AddMarkupContent(118, "<div class=\"row\"><div class=\"col center-horiz\"><button class=\"btn btn-default btn-success\">Create Class</button></div></div>\r\n    <br>");
            __builder.CloseElement();
            __builder.AddMarkupContent(119, "\r\n\r\n");
            __builder.OpenElement(120, "div");
            __builder.AddAttribute(121, "class", "container blue-border");
            __builder.AddAttribute(122, "style", "margin-top: 3em");
            __builder.AddMarkupContent(123, "<br>\r\n    ");
            __builder.AddMarkupContent(124, "<div class=\"row\"><div class=\"col\"><h3 class=\"center-horiz\">Edit Class</h3></div></div>\r\n    <br>\r\n    ");
            __builder.AddMarkupContent(125, @"<div class=""row""><div class=""col center-horiz""><label for=""selectClass"">Select Class:</label>
            <select class=""form-control"" id=""selectClass""></select>
            <option value selected disabled hidden>Choose class...</option>
            <button class=""btn btn-default btn-danger"" style=""margin-left: 1em"">Delete Class</button>
            <p style=""margin-top: 1em"">Class average: ?</p></div></div>
    <br>
    ");
            __builder.OpenElement(126, "div");
            __builder.AddAttribute(127, "class", "row");
            __builder.OpenElement(128, "div");
            __builder.AddAttribute(129, "class", "col-6 center-horiz");
            __builder.OpenElement(130, "div");
            __builder.AddAttribute(131, "class", "row");
            __builder.OpenElement(132, "div");
            __builder.AddAttribute(133, "class", "col form-group");
            __builder.AddMarkupContent(134, "<label for=\"addStudent\">Student:</label>\r\n                    ");
            __builder.OpenElement(135, "select");
            __builder.AddAttribute(136, "class", "form-control");
            __builder.AddAttribute(137, "id", "addStudent");
            __builder.OpenElement(138, "option");
            __builder.AddAttribute(139, "value", true);
            __builder.AddAttribute(140, "selected", true);
            __builder.AddAttribute(141, "disabled", true);
            __builder.AddAttribute(142, "hidden", true);
            __builder.AddContent(143, "Choose student...");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(144, "\r\n                    ");
            __builder.AddMarkupContent(145, "<button class=\"btn btn-default btn-success\" style=\"margin-left: 1em\">Add Student</button>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(146, "\r\n            <br>\r\n            ");
            __builder.OpenElement(147, "div");
            __builder.AddAttribute(148, "class", "row form-group");
            __builder.OpenElement(149, "div");
            __builder.AddAttribute(150, "class", "col form-group");
            __builder.AddMarkupContent(151, "<label for=\"removeStudent\">Student:</label>\r\n                    ");
            __builder.OpenElement(152, "select");
            __builder.AddAttribute(153, "class", "form-control");
            __builder.AddAttribute(154, "id", "removeStudent");
            __builder.OpenElement(155, "option");
            __builder.AddAttribute(156, "value", true);
            __builder.AddAttribute(157, "selected", true);
            __builder.AddAttribute(158, "disabled", true);
            __builder.AddAttribute(159, "hidden", true);
            __builder.AddContent(160, "Choose student...");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(161, "\r\n                    ");
            __builder.AddMarkupContent(162, "<button class=\"btn btn-default btn-danger\" style=\"margin-left: 1em\">Remove Student</button>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(163, "\r\n        ");
            __builder.OpenElement(164, "div");
            __builder.AddAttribute(165, "class", "col-6 center-horiz form-group");
            __builder.OpenElement(166, "div");
            __builder.AddAttribute(167, "class", "row");
            __builder.OpenElement(168, "div");
            __builder.AddAttribute(169, "class", "col form-group");
            __builder.AddMarkupContent(170, "<label for=\"addCourse\">Course:</label>\r\n                    ");
            __builder.OpenElement(171, "select");
            __builder.AddAttribute(172, "class", "form-control");
            __builder.AddAttribute(173, "id", "addCourse");
            __builder.OpenElement(174, "option");
            __builder.AddAttribute(175, "value", true);
            __builder.AddAttribute(176, "selected", true);
            __builder.AddAttribute(177, "disabled", true);
            __builder.AddAttribute(178, "hidden", true);
            __builder.AddContent(179, "Choose course...");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(180, "\r\n                    ");
            __builder.AddMarkupContent(181, "<button class=\"btn btn-default btn-success\" style=\"margin-left: 1em\">Add Course</button>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(182, "\r\n            <br>\r\n            ");
            __builder.OpenElement(183, "div");
            __builder.AddAttribute(184, "class", "row form-group");
            __builder.OpenElement(185, "div");
            __builder.AddAttribute(186, "class", "col form-group");
            __builder.AddMarkupContent(187, "<label for=\"removeCourse\">Course:</label>\r\n                    ");
            __builder.OpenElement(188, "select");
            __builder.AddAttribute(189, "class", "form-control");
            __builder.AddAttribute(190, "id", "removeCourse");
            __builder.OpenElement(191, "option");
            __builder.AddAttribute(192, "value", true);
            __builder.AddAttribute(193, "selected", true);
            __builder.AddAttribute(194, "disabled", true);
            __builder.AddAttribute(195, "hidden", true);
            __builder.AddContent(196, "Choose course...");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(197, "\r\n                    ");
            __builder.AddMarkupContent(198, "<button class=\"btn btn-default btn-danger\" style=\"margin-left: 1em\">Remove Course</button>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(199, "\r\n    <br>");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
