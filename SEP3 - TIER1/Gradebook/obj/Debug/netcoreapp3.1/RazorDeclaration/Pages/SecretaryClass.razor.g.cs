#pragma checksum "W:\Univer\SEP\SEP3\SEP3 - TIER1\Gradebook\Pages\SecretaryClass.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5592f75cc808fb63fbeed16a84ed9e5f566f2526"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/SecretaryClass")]
    public partial class SecretaryClass : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 154 "W:\Univer\SEP\SEP3\SEP3 - TIER1\Gradebook\Pages\SecretaryClass.razor"
       
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
        
        if(selectedClass.students!=null)
            studentsFromSelectedClass = selectedClass.students;
        else studentsFromSelectedClass = new List<Student>();
        
        if(selectedClass.courses!=null)
            coursesFromSelectedClass = selectedClass.courses;
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
            // ResetCreateFields();
            // ExtractStudents();
        }
        else if (package == null)
        {
            Console.WriteLine("BAD REQUEST - CREATE CLASS");
            ErrorLabel = "There was an error";
        }
    }
    
    async Task DeleteClass()
    {
        string letter = selectedClass.letter.ToString();
        string year = selectedClass.year.ToString();
        NetworkPackage package = await SecretaryService.DeleteClass(letter,year);
        Console.WriteLine(selectedClass.year.ToString() + " " + selectedClass.letter.ToString());
        if (package != null)
        {
            SecretaryDataPackage secretaryDataPackage = (SecretaryDataPackage) package;
            CustomAuthenticationStateProvider.CachedSecretary = secretaryDataPackage.data;
            secretary = secretaryDataPackage.data;
            ErrorLabel = "";
            //ExtractStudents();
        }
        else if (package == null)
        {
            Console.WriteLine("BAD REQUEST - DELETE CLASS");
            ErrorLabel = "There was an error";
        }
    }
    
    async Task AddStudentToClass()
    {
        NetworkPackage package = await SecretaryService.AddStudentToClass(selectedClass.letter.ToString(), selectedClass.year.ToString(), selectedAddStudent.id);
        if (package != null)
        {
            SecretaryDataPackage secretaryDataPackage = (SecretaryDataPackage) package;
            CustomAuthenticationStateProvider.CachedSecretary = secretaryDataPackage.data;
            secretary = secretaryDataPackage.data;
            ErrorLabel = "";
            //ExtractStudents();
        }
        else if (package == null)
        {
            Console.WriteLine("BAD REQUEST - ADD STUDENT");
            ErrorLabel = "There was an error";
        }
    }

    async Task DeleteStudentFromClass()
    {
        NetworkPackage package = await SecretaryService.RemoveStudentFromClass(selectedClass.letter.ToString(), selectedClass.year.ToString(), selectedRemoveStudent.id);
        if (package != null)
        {
            SecretaryDataPackage secretaryDataPackage = (SecretaryDataPackage) package;
            CustomAuthenticationStateProvider.CachedSecretary = secretaryDataPackage.data;
            secretary = secretaryDataPackage.data;
            ErrorLabel = "";
    //ExtractStudents();
        }
        else if (package == null)
        {
            Console.WriteLine("BAD REQUEST - DELETE STUDENT");
            ErrorLabel = "There was an error";
        }
    }
    
    async Task AddCourseToClass()
    {
        NetworkPackage package = await SecretaryService.AddCourseToClass(selectedClass.letter.ToString(), selectedClass.year.ToString(), selectedAddCourse);
        if (package != null)
        {
            SecretaryDataPackage secretaryDataPackage = (SecretaryDataPackage) package;
            CustomAuthenticationStateProvider.CachedSecretary = secretaryDataPackage.data;
            secretary = secretaryDataPackage.data;
            ErrorLabel = "";
    //ExtractStudents();
        }
        else if (package == null)
        {
            Console.WriteLine("BAD REQUEST - ADD COURSE");
            ErrorLabel = "There was an error";
        }
    }
    
    async Task RemoveCourseFromClass()
    {
        NetworkPackage package = await SecretaryService.RemoveCourseFromClass(selectedClass.letter.ToString(), selectedClass.year.ToString(), selectedDeleteCourse);
        if (package != null)
        {
            SecretaryDataPackage secretaryDataPackage = (SecretaryDataPackage) package;
            CustomAuthenticationStateProvider.CachedSecretary = secretaryDataPackage.data;
            secretary = secretaryDataPackage.data;
            ErrorLabel = "";
    //ExtractStudents();
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
    }
}
#pragma warning restore 1591
