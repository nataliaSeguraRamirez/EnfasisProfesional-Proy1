// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Proy1.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\EProfesional\Proy1\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\EProfesional\Proy1\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\EProfesional\Proy1\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\EProfesional\Proy1\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\EProfesional\Proy1\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\EProfesional\Proy1\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\EProfesional\Proy1\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\EProfesional\Proy1\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\EProfesional\Proy1\Client\_Imports.razor"
using Proy1.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\EProfesional\Proy1\Client\_Imports.razor"
using Proy1.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\EProfesional\Proy1\Client\_Imports.razor"
using Proy1.Shared.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\EProfesional\Proy1\Client\_Imports.razor"
using Proy1.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\EProfesional\Proy1\Client\Pages\Actores.razor"
using Proy1.Client.Pages.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/actor")]
    public partial class Actores : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "C:\EProfesional\Proy1\Client\Pages\Actores.razor"
       
    private List<Actor> Actors;
        protected override void OnInitialized(){
            Actors = actor.GetActors();
        }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IActorService actor { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServiceMovie movie { get; set; }
    }
}
#pragma warning restore 1591
