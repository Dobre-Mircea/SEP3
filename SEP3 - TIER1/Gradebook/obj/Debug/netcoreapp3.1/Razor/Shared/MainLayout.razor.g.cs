#pragma checksum "D:\Univer\SEP\SEP3\SEP3 - TIER1\Gradebook\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12a6d26ecab4c6b83157405a97c2555a356628c6"
// <auto-generated/>
#pragma warning disable 1591
namespace WebApplication.Shared
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
#nullable restore
#line 1 "D:\Univer\SEP\SEP3\SEP3 - TIER1\Gradebook\Shared\MainLayout.razor"
using WebApplication.Authentication;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "sidebar");
            __builder.OpenComponent<WebApplication.Shared.SecretarySidebar>(2);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n \r\n\r\n");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "main");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "top-row px-4");
            __builder.OpenElement(8, "Authorized");
            __builder.OpenElement(9, "a");
            __builder.AddAttribute(10, "href", "");
            __builder.AddAttribute(11, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "D:\Univer\SEP\SEP3\SEP3 - TIER1\Gradebook\Shared\MainLayout.razor"
                                       PerformLogout

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(12, "\r\n                    Log out\r\n                    ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n    \r\n\r\n    ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "content px-4");
            __builder.AddContent(16, 
#nullable restore
#line 24 "D:\Univer\SEP\SEP3\SEP3 - TIER1\Gradebook\Shared\MainLayout.razor"
         Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "D:\Univer\SEP\SEP3\SEP3 - TIER1\Gradebook\Shared\MainLayout.razor"
       

    [CascadingParameter] protected Task<AuthenticationState> AuthStat { get; set; }
    
    public async Task PerformLogout()
    {
        try
        {
            ((CustomAuthenticationStateProvider) AuthenticationStateProvider).Logout();
            NavigationManager.NavigateTo("/");
        }
        catch (Exception e)
        {
        }
    }

    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();
        var user = (await AuthStat).User;
        if(!user.Identity.IsAuthenticated)
        {
            NavigationManager.NavigateTo($"/login");
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
