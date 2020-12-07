// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WebApplication.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "W:\Univer\SEP\SEP3\SEP3 - TIER1\Gradebook\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "W:\Univer\SEP\SEP3\SEP3 - TIER1\Gradebook\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "W:\Univer\SEP\SEP3\SEP3 - TIER1\Gradebook\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "W:\Univer\SEP\SEP3\SEP3 - TIER1\Gradebook\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "W:\Univer\SEP\SEP3\SEP3 - TIER1\Gradebook\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "W:\Univer\SEP\SEP3\SEP3 - TIER1\Gradebook\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "W:\Univer\SEP\SEP3\SEP3 - TIER1\Gradebook\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "W:\Univer\SEP\SEP3\SEP3 - TIER1\Gradebook\_Imports.razor"
using WebApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "W:\Univer\SEP\SEP3\SEP3 - TIER1\Gradebook\_Imports.razor"
using WebApplication.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "W:\Univer\SEP\SEP3\SEP3 - TIER1\Gradebook\Pages\SecretaryClass.razor"
using WebApplication.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "W:\Univer\SEP\SEP3\SEP3 - TIER1\Gradebook\Pages\SecretaryClass.razor"
using WebApplication.NetworkPackages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "W:\Univer\SEP\SEP3\SEP3 - TIER1\Gradebook\Pages\SecretaryClass.razor"
using WebApplication.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "W:\Univer\SEP\SEP3\SEP3 - TIER1\Gradebook\Pages\SecretaryClass.razor"
using WebApplication.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "W:\Univer\SEP\SEP3\SEP3 - TIER1\Gradebook\Pages\SecretaryClass.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "W:\Univer\SEP\SEP3\SEP3 - TIER1\Gradebook\Pages\SecretaryClass.razor"
using System.Security.Principal;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/SecretaryClass")]
    public partial class SecretaryClass : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 176 "W:\Univer\SEP\SEP3\SEP3 - TIER1\Gradebook\Pages\SecretaryClass.razor"
       
    Secretary secretary = CustomAuthenticationStateProvider.CachedSecretary;
    ISecretaryService SecretaryService = new SecretaryService();
    string ErrorLabel;

    //Class creation
    string classNumber;
    string classLetter;
    string classTeacherId;

    Class selectedClass = new Class();
    string selectedClassAsString;
    Student selectedAddStudent = new Student();
    string selectedAddStudentAsString;
    Student selectedRemoveStudent = new Student();
    string selectedRemoveStudentAsString;
    List<Student> studentsFromSelectedClass = new List<Student>();
    List<Course> coursesFromSelectedClass = new List<Course>();
    string selectedAddCourse;
    string selectedDeleteCourse;
    string selectedClassAverage;

    bool CreateClassButtonDisabled()
    {
        return (classNumber == null || classLetter == null || classTeacherId == null);
    }
    
    bool DeleteClassButtonDisabled()
    {
        return (selectedClassAsString==null);
    }
    
    bool AddStudentButtonDisabled()
    {
        return (selectedAddStudentAsString == null);
    }
    
    bool RemoveStudentButtonDisabled()
    {
        return (selectedRemoveStudentAsString == null);
    }
    
    bool AddCourseButtonDisabled()
    {
        return (selectedAddCourse == null);
    }
    
    bool RemoveCourseButtonDisabled()
    {
        return (selectedDeleteCourse == null);
    }
    
    void ConstructSelectedClass(ChangeEventArgs e)
    {
        selectedClassAsString = e.Value.ToString();
        selectedClass = JsonSerializer.Deserialize<Class>(selectedClassAsString);
        
        if(selectedClass.Students!=null)
            studentsFromSelectedClass = selectedClass.Students;
        else studentsFromSelectedClass = new List<Student>();
        
        if(selectedClass.Courses!=null)
            coursesFromSelectedClass = selectedClass.Courses;
        else coursesFromSelectedClass= new List<Course>();
    }

    async Task CreateClass()
    {
        NetworkPackage package = await SecretaryService.CreateClass(classNumber, classLetter, classTeacherId);
        if (package != null)
        {
            SecretaryDataPackage secretaryDataPackage = (SecretaryDataPackage) package;
            CustomAuthenticationStateProvider.CachedSecretary = secretaryDataPackage.data;
            secretary = secretaryDataPackage.data;
            ErrorLabel = "";
        }
        else if (package == null)
        {
            Console.WriteLine("BAD REQUEST - CREATE CLASS");
            ErrorLabel = "There was an error";
        }
    }
    
    async Task DeleteClass()
    {
        string letter = selectedClass.Letter.ToString();
        string year = selectedClass.Year.ToString();
        if (!await JSRuntime.InvokeAsync<bool>("confirm", "Are you sure you want to delete class " + @year + @letter + "?")) return;
        NetworkPackage package = await SecretaryService.DeleteClass(letter,year);
        Console.WriteLine(selectedClass.Year.ToString() + " " + selectedClass.Letter.ToString());
        if (package != null)
        {
            SecretaryDataPackage secretaryDataPackage = (SecretaryDataPackage) package;
            CustomAuthenticationStateProvider.CachedSecretary = secretaryDataPackage.data;
            secretary = secretaryDataPackage.data;
            ErrorLabel = "";
        }
        else if (package == null)
        {
            Console.WriteLine("BAD REQUEST - DELETE CLASS");
            ErrorLabel = "There was an error";
        }
    }
    
    async Task AddStudentToClass()
    {
        if (!await JSRuntime.InvokeAsync<bool>("confirm", "Are you sure you want to add this student?")) return;
        NetworkPackage package = await SecretaryService.AddStudentToClass(selectedClass.Letter.ToString(), selectedClass.Year.ToString(), selectedAddStudentAsString);
        if (package != null)
        {
            SecretaryDataPackage secretaryDataPackage = (SecretaryDataPackage) package;
            CustomAuthenticationStateProvider.CachedSecretary = secretaryDataPackage.data;
            secretary = secretaryDataPackage.data;
            ErrorLabel = "";
        }
        else if (package == null)
        {
            Console.WriteLine("BAD REQUEST - ADD STUDENT");
            ErrorLabel = "There was an error";
        }
    }

    async Task DeleteStudentFromClass()
    {
        if (!await JSRuntime.InvokeAsync<bool>("confirm", "Are you sure you want to remove this student?")) return;
        NetworkPackage package = await SecretaryService.RemoveStudentFromClass(selectedClass.Letter.ToString(), selectedClass.Year.ToString(), selectedRemoveStudentAsString);
        if (package != null)
        {
            SecretaryDataPackage secretaryDataPackage = (SecretaryDataPackage) package;
            CustomAuthenticationStateProvider.CachedSecretary = secretaryDataPackage.data;
            secretary = secretaryDataPackage.data;
            ErrorLabel = "";
        }
        else if (package == null)
        {
            Console.WriteLine("BAD REQUEST - DELETE STUDENT");
            ErrorLabel = "There was an error";
        }
    }
    
    async Task AddCourseToClass()
    {
        if (!await JSRuntime.InvokeAsync<bool>("confirm", "Are you sure you want to add this course?")) return;
        NetworkPackage package = await SecretaryService.AddCourseToClass(selectedClass.Letter.ToString(), selectedClass.Year.ToString(), selectedAddCourse);
        if (package != null)
        {
            SecretaryDataPackage secretaryDataPackage = (SecretaryDataPackage) package;
            CustomAuthenticationStateProvider.CachedSecretary = secretaryDataPackage.data;
            secretary = secretaryDataPackage.data;
            ErrorLabel = "";
        }
        else if (package == null)
        {
            Console.WriteLine("BAD REQUEST - ADD COURSE");
            ErrorLabel = "There was an error";
        }
    }
    
    async Task RemoveCourseFromClass()
    {
        if (!await JSRuntime.InvokeAsync<bool>("confirm", "Are you sure you want to remove this course?")) return;
        NetworkPackage package = await SecretaryService.RemoveCourseFromClass(selectedClass.Letter.ToString(), selectedClass.Year.ToString(), selectedDeleteCourse);
        if (package != null)
        {
            SecretaryDataPackage secretaryDataPackage = (SecretaryDataPackage) package;
            CustomAuthenticationStateProvider.CachedSecretary = secretaryDataPackage.data;
            secretary = secretaryDataPackage.data;
            ErrorLabel = "";
        }
        else if (package == null)
        {
            Console.WriteLine("BAD REQUEST - DELETE COURSE");
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
