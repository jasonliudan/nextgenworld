#pragma checksum "E:\Blockchain\OASIS-BLAZOR\OASIS-BLAZOR\Popups\AvatarUpload.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "57ae2c27f579f10f277a87d4ca670426bd716751"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace OASIS_BLAZOR.Popups
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
    public partial class AvatarUpload : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "E:\Blockchain\OASIS-BLAZOR\OASIS-BLAZOR\Popups\AvatarUpload.razor"
       


    public Guid Guid = Guid.NewGuid();
    public string ModalDisplay = "none;";
    public string ModalClass = "";
    public bool ShowBackdrop = false;


    public void uploadPhoto()
    {

    }

    public void Open()
    {
        ModalDisplay = "block;";
        ModalClass = "Show";
        ShowBackdrop = true;
        StateHasChanged();
    }

    public void Close()
    {
        ModalDisplay = "none";
        ModalClass = "";
        ShowBackdrop = false;
        StateHasChanged();
    }

   

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
