#pragma checksum "C:\Users\dobre\OneDrive\Desktop\SEP3\SEP3 - TIER1\Gradebook\Pages\SecretaryTeacher.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df6f4ecaf32173fb08a2ce27a8ff26222113d09c"
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
#line 1 "C:\Users\dobre\OneDrive\Desktop\SEP3\SEP3 - TIER1\Gradebook\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dobre\OneDrive\Desktop\SEP3\SEP3 - TIER1\Gradebook\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\dobre\OneDrive\Desktop\SEP3\SEP3 - TIER1\Gradebook\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\dobre\OneDrive\Desktop\SEP3\SEP3 - TIER1\Gradebook\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\dobre\OneDrive\Desktop\SEP3\SEP3 - TIER1\Gradebook\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\dobre\OneDrive\Desktop\SEP3\SEP3 - TIER1\Gradebook\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\dobre\OneDrive\Desktop\SEP3\SEP3 - TIER1\Gradebook\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\dobre\OneDrive\Desktop\SEP3\SEP3 - TIER1\Gradebook\_Imports.razor"
using WebApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\dobre\OneDrive\Desktop\SEP3\SEP3 - TIER1\Gradebook\_Imports.razor"
using WebApplication.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dobre\OneDrive\Desktop\SEP3\SEP3 - TIER1\Gradebook\Pages\SecretaryTeacher.razor"
using WebApplication.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\dobre\OneDrive\Desktop\SEP3\SEP3 - TIER1\Gradebook\Pages\SecretaryTeacher.razor"
using WebApplication.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\dobre\OneDrive\Desktop\SEP3\SEP3 - TIER1\Gradebook\Pages\SecretaryTeacher.razor"
using WebApplication.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\dobre\OneDrive\Desktop\SEP3\SEP3 - TIER1\Gradebook\Pages\SecretaryTeacher.razor"
using WebApplication.NetworkPackages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\dobre\OneDrive\Desktop\SEP3\SEP3 - TIER1\Gradebook\Pages\SecretaryTeacher.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/SecretaryTeacher")]
    public partial class SecretaryTeacher : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<head>\r\n    <link rel=\"stylesheet\" href=\"css/overallTheme.css\">\r\n</head>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "blue-border container");
            __builder.AddMarkupContent(3, "\r\n    <br>\r\n    ");
            __builder.AddMarkupContent(4, "<div class=\"row\">\r\n        <div class=\"col\">\r\n            <h3 class=\"center-horiz\">Create Teacher</h3>\r\n        </div>\r\n    </div>\r\n    <br>\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "row");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "col-3 center-horiz form-group");
            __builder.AddMarkupContent(10, "\r\n            ");
            __builder.AddMarkupContent(11, "<label for=\"fname\">First name:</label>\r\n            ");
            __builder.OpenElement(12, "input");
            __builder.AddAttribute(13, "type", "text");
            __builder.AddAttribute(14, "class", "form-control");
            __builder.AddAttribute(15, "id", "fname");
            __builder.AddAttribute(16, "placeholder", "Adam");
            __builder.AddAttribute(17, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 24 "C:\Users\dobre\OneDrive\Desktop\SEP3\SEP3 - TIER1\Gradebook\Pages\SecretaryTeacher.razor"
                                                                                          createTeacherFirstName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => createTeacherFirstName = __value, createTeacherFirstName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n        ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "col-3 center-horiz form-group");
            __builder.AddMarkupContent(23, "\r\n            ");
            __builder.AddMarkupContent(24, "<label for=\"lname\">Last name:</label>\r\n            ");
            __builder.OpenElement(25, "input");
            __builder.AddAttribute(26, "type", "text");
            __builder.AddAttribute(27, "class", "form-control");
            __builder.AddAttribute(28, "id", "lname");
            __builder.AddAttribute(29, "placeholder", "Adam");
            __builder.AddAttribute(30, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 28 "C:\Users\dobre\OneDrive\Desktop\SEP3\SEP3 - TIER1\Gradebook\Pages\SecretaryTeacher.razor"
                                                                                          createTeacherLastName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(31, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => createTeacherLastName = __value, createTeacherLastName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n        ");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "col-3 center-horiz form-group");
            __builder.AddMarkupContent(36, "\r\n            ");
            __builder.AddMarkupContent(37, "<label for=\"password\">Password:</label>\r\n            ");
            __builder.OpenElement(38, "input");
            __builder.AddAttribute(39, "type", "password");
            __builder.AddAttribute(40, "class", "form-control");
            __builder.AddAttribute(41, "id", "password");
            __builder.AddAttribute(42, "placeholder", "********");
            __builder.AddAttribute(43, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 32 "C:\Users\dobre\OneDrive\Desktop\SEP3\SEP3 - TIER1\Gradebook\Pages\SecretaryTeacher.razor"
                                                                                                     createTeacherPassword

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(44, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => createTeacherPassword = __value, createTeacherPassword));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n    <br>\r\n    ");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "class", "row");
            __builder.AddMarkupContent(50, "\r\n        ");
            __builder.OpenElement(51, "div");
            __builder.AddAttribute(52, "class", "col center-horiz");
            __builder.AddMarkupContent(53, "\r\n            ");
            __builder.OpenElement(54, "button");
            __builder.AddAttribute(55, "class", "btn btn-default btn-success");
            __builder.AddAttribute(56, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 38 "C:\Users\dobre\OneDrive\Desktop\SEP3\SEP3 - TIER1\Gradebook\Pages\SecretaryTeacher.razor"
                                                                  CreateTeacher

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(57, "disabled", 
#nullable restore
#line 38 "C:\Users\dobre\OneDrive\Desktop\SEP3\SEP3 - TIER1\Gradebook\Pages\SecretaryTeacher.razor"
                                                                                            TeacherCreationBool()

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(58, "Create Teacher");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n    <br>\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n\r\n");
            __builder.OpenElement(63, "div");
            __builder.AddAttribute(64, "class", "container blue-border");
            __builder.AddAttribute(65, "style", "margin-top: 3em");
            __builder.AddMarkupContent(66, "\r\n    <br>\r\n    ");
            __builder.AddMarkupContent(67, "<div class=\"row\">\r\n        <div class=\"col\">\r\n            <h3 class=\"center-horiz\">Edit Teacher</h3>\r\n        </div>\r\n    </div>\r\n    <br>\r\n    ");
            __builder.OpenElement(68, "div");
            __builder.AddAttribute(69, "class", "row");
            __builder.AddMarkupContent(70, "\r\n        ");
            __builder.OpenElement(71, "div");
            __builder.AddAttribute(72, "class", "col center-horiz");
            __builder.AddMarkupContent(73, "\r\n            ");
            __builder.AddMarkupContent(74, "<label for=\"selectTeacher\">Select Teacher:</label>\r\n            ");
            __builder.OpenElement(75, "select");
            __builder.AddAttribute(76, "class", "form-control");
            __builder.AddAttribute(77, "id", "selectTeacher");
            __builder.AddAttribute(78, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 55 "C:\Users\dobre\OneDrive\Desktop\SEP3\SEP3 - TIER1\Gradebook\Pages\SecretaryTeacher.razor"
                                                                    selectedTeacherAsString

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(79, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => selectedTeacherAsString = __value, selectedTeacherAsString));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(80, "\r\n                ");
            __builder.OpenElement(81, "option");
            __builder.AddAttribute(82, "value", true);
            __builder.AddAttribute(83, "selected", true);
            __builder.AddAttribute(84, "disabled", true);
            __builder.AddAttribute(85, "hidden", true);
            __builder.AddContent(86, "Choose teacher...");
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n");
#nullable restore
#line 57 "C:\Users\dobre\OneDrive\Desktop\SEP3\SEP3 - TIER1\Gradebook\Pages\SecretaryTeacher.razor"
                 foreach (Teacher teacher in secretary.teachers)
                {
                    string teacherAsString = JsonSerializer.Serialize(teacher);

#line default
#line hidden
#nullable disable
            __builder.AddContent(88, "                    ");
            __builder.OpenElement(89, "option");
            __builder.AddAttribute(90, "value", 
#nullable restore
#line 60 "C:\Users\dobre\OneDrive\Desktop\SEP3\SEP3 - TIER1\Gradebook\Pages\SecretaryTeacher.razor"
                                    teacherAsString

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(91, 
#nullable restore
#line 60 "C:\Users\dobre\OneDrive\Desktop\SEP3\SEP3 - TIER1\Gradebook\Pages\SecretaryTeacher.razor"
                                                      teacher.id

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(92, " - ");
            __builder.AddContent(93, 
#nullable restore
#line 60 "C:\Users\dobre\OneDrive\Desktop\SEP3\SEP3 - TIER1\Gradebook\Pages\SecretaryTeacher.razor"
                                                                    teacher.firstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(94, " ");
            __builder.AddContent(95, 
#nullable restore
#line 60 "C:\Users\dobre\OneDrive\Desktop\SEP3\SEP3 - TIER1\Gradebook\Pages\SecretaryTeacher.razor"
                                                                                       teacher.lastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n");
#nullable restore
#line 61 "C:\Users\dobre\OneDrive\Desktop\SEP3\SEP3 - TIER1\Gradebook\Pages\SecretaryTeacher.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(97, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n            ");
            __builder.OpenElement(99, "button");
            __builder.AddAttribute(100, "class", "btn btn-default btn-danger");
            __builder.AddAttribute(101, "style", "margin-left: 1em");
            __builder.AddAttribute(102, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 63 "C:\Users\dobre\OneDrive\Desktop\SEP3\SEP3 - TIER1\Gradebook\Pages\SecretaryTeacher.razor"
                                                                                          DeleteTeacher

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(103, "disabled", 
#nullable restore
#line 63 "C:\Users\dobre\OneDrive\Desktop\SEP3\SEP3 - TIER1\Gradebook\Pages\SecretaryTeacher.razor"
                                                                                                                   teacherIsSelected()

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(104, "Delete Teacher");
            __builder.CloseElement();
            __builder.AddMarkupContent(105, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(106, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(107, "\r\n    <br>\r\n    ");
            __builder.OpenElement(108, "div");
            __builder.AddAttribute(109, "class", "row");
            __builder.AddMarkupContent(110, "\r\n        ");
            __builder.OpenElement(111, "div");
            __builder.AddAttribute(112, "class", "col center-horiz form-group");
            __builder.AddMarkupContent(113, "\r\n            ");
            __builder.AddMarkupContent(114, "<label for=\"password2\">Password:</label>\r\n            ");
            __builder.OpenElement(115, "input");
            __builder.AddAttribute(116, "type", "password");
            __builder.AddAttribute(117, "class", "form-control");
            __builder.AddAttribute(118, "id", "password2");
            __builder.AddAttribute(119, "placeholder", "********");
            __builder.AddAttribute(120, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 70 "C:\Users\dobre\OneDrive\Desktop\SEP3\SEP3 - TIER1\Gradebook\Pages\SecretaryTeacher.razor"
                                                                                                      editedTeacherPassword

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(121, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => editedTeacherPassword = __value, editedTeacherPassword));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(122, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(123, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(124, "\r\n    <br>\r\n    ");
            __builder.OpenElement(125, "div");
            __builder.AddAttribute(126, "class", "row");
            __builder.AddMarkupContent(127, "\r\n        ");
            __builder.OpenElement(128, "div");
            __builder.AddAttribute(129, "class", "col center-horiz");
            __builder.AddMarkupContent(130, "\r\n            ");
            __builder.OpenElement(131, "button");
            __builder.AddAttribute(132, "class", "btn btn-default btn-primary");
            __builder.AddAttribute(133, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 76 "C:\Users\dobre\OneDrive\Desktop\SEP3\SEP3 - TIER1\Gradebook\Pages\SecretaryTeacher.razor"
                                                                  EditTeacher

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(134, "disabled", 
#nullable restore
#line 76 "C:\Users\dobre\OneDrive\Desktop\SEP3\SEP3 - TIER1\Gradebook\Pages\SecretaryTeacher.razor"
                                                                                          TeacherEditBool()

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(135, "Edit Teacher");
            __builder.CloseElement();
            __builder.AddMarkupContent(136, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(137, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(138, "\r\n    <br>\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(139, "\r\n\r\n<br>\r\n");
            __builder.OpenElement(140, "p");
            __builder.AddAttribute(141, "class", "center-horiz");
            __builder.AddAttribute(142, "style", "color: #ff0000");
            __builder.AddContent(143, 
#nullable restore
#line 83 "C:\Users\dobre\OneDrive\Desktop\SEP3\SEP3 - TIER1\Gradebook\Pages\SecretaryTeacher.razor"
                                                ErrorLabel

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 85 "C:\Users\dobre\OneDrive\Desktop\SEP3\SEP3 - TIER1\Gradebook\Pages\SecretaryTeacher.razor"
       
    Secretary secretary = CustomAuthenticationStateProvider.CachedSecretary;
    ISecretaryService SecretaryService = new SecretaryService();
    string ErrorLabel;

    //Regarding creating a teacher
    string createTeacherFirstName;
    string createTeacherLastName;
    string createTeacherPassword;

    //Regarding editing a teacher
    Teacher selectedTeacher;
    string selectedTeacherAsString;
    string editedTeacherPassword;

    void ResetCreateFields()
    {
        createTeacherFirstName = "";
        createTeacherLastName = "";
        createTeacherPassword = "";
    }
    
    void ResetEditFields()
    {
        editedTeacherPassword = "";
    }

    bool TeacherCreationBool()
    {
        return !(createTeacherFirstName != null && createTeacherLastName != null && createTeacherPassword != null);
    }

    bool TeacherEditBool()
    {
        return (editedTeacherPassword == null);
    }

    bool teacherIsSelected()
    {
        return (selectedTeacherAsString == null);
    }

    async Task CreateTeacher()
    {
        if (!await JSRuntime.InvokeAsync<bool>("confirm", "Are you sure you want to create this teacher?")) return;
        NetworkPackage package = await SecretaryService.CreateTeacher(createTeacherFirstName, createTeacherLastName, createTeacherPassword);
        if (package != null)
        {
            SecretaryDataPackage secretaryDataPackage = (SecretaryDataPackage) package;
            CustomAuthenticationStateProvider.CachedSecretary = secretaryDataPackage.data;
            secretary = secretaryDataPackage.data;
            ResetCreateFields();
            ErrorLabel = "";
        }
        else if (package == null)
        {
            Console.WriteLine("BAD REQUEST - CREATE TEACHER");
            ErrorLabel = "There was an error";
        }
    }

    async Task EditTeacher()
    {
        if (!await JSRuntime.InvokeAsync<bool>("confirm", "Are you sure you want to edit this teacher?")) return;
        selectedTeacher = JsonSerializer.Deserialize<Teacher>(selectedTeacherAsString);
        NetworkPackage package = await SecretaryService.EditTeacher(selectedTeacher.id, editedTeacherPassword);
        if (package != null)
        {
            SecretaryDataPackage secretaryDataPackage = (SecretaryDataPackage) package;
            CustomAuthenticationStateProvider.CachedSecretary = secretaryDataPackage.data;
            secretary = secretaryDataPackage.data;
            ResetEditFields();
            ErrorLabel = "";
        }
        else if (package == null)
        {
            Console.WriteLine("BAD REQUEST - EDIT TEACHER");
            ErrorLabel = "There was an error";
        }
    }

    async Task DeleteTeacher()
    {
        if (!await JSRuntime.InvokeAsync<bool>("confirm", "Are you sure you want to delete this teacher?")) return;
        selectedTeacher = JsonSerializer.Deserialize<Teacher>(selectedTeacherAsString);
        NetworkPackage package = await SecretaryService.DeleteTeacher(selectedTeacher.id);
        Console.WriteLine(selectedTeacher.id);
        if (package != null)
        {
            SecretaryDataPackage secretaryDataPackage = (SecretaryDataPackage) package;
            CustomAuthenticationStateProvider.CachedSecretary = secretaryDataPackage.data;
            secretary = secretaryDataPackage.data;
            ErrorLabel = "";
        }
        else if (package == null)
        {
            Console.WriteLine("BAD REQUEST - DELETE TEACHER");
            ErrorLabel = "There was an error";
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
