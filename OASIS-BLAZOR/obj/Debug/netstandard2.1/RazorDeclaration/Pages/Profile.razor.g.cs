#pragma checksum "E:\Blockchain\OASIS-BLAZOR\OASIS-BLAZOR\Pages\Profile.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6fe44e8fe1cb2ecd65d61d7b4b731ea3909afbe0"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace OASIS_BLAZOR.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\Blockchain\OASIS-BLAZOR\OASIS-BLAZOR\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Blockchain\OASIS-BLAZOR\OASIS-BLAZOR\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Blockchain\OASIS-BLAZOR\OASIS-BLAZOR\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Blockchain\OASIS-BLAZOR\OASIS-BLAZOR\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Blockchain\OASIS-BLAZOR\OASIS-BLAZOR\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Blockchain\OASIS-BLAZOR\OASIS-BLAZOR\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Blockchain\OASIS-BLAZOR\OASIS-BLAZOR\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Blockchain\OASIS-BLAZOR\OASIS-BLAZOR\_Imports.razor"
using OASIS_BLAZOR;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\Blockchain\OASIS-BLAZOR\OASIS-BLAZOR\_Imports.razor"
using OASIS_BLAZOR.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\Blockchain\OASIS-BLAZOR\OASIS-BLAZOR\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Blockchain\OASIS-BLAZOR\OASIS-BLAZOR\Pages\Profile.razor"
using OASIS_BLAZOR.Popups;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/profile/{userId}")]
    public partial class Profile : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 121 "E:\Blockchain\OASIS-BLAZOR\OASIS-BLAZOR\Pages\Profile.razor"
       
    [Parameter]
    public string userId { get; set; }
    public string firstName { get; set; }
    public string lastName { get; set; }
    public int karma { get; set; }

    private string karmaString;
    private OASIS_BLAZOR.Popups.AvatarUpload AvtarUploadModal { get; set; }

    protected override void OnInitialized()
    {
        userId = "dellams";
        firstName = "David";
        lastName = "Ellams";
        karma = 9999999;

        karmaString = karma.ToString("##,##0");
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
