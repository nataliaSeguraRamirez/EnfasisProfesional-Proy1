#pragma checksum "C:\EProfesional\Proy1\Client\Pages\Components\MovieComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a759af7f391793654bfda2bf12ab137f44d5a9f"
// <auto-generated/>
#pragma warning disable 1591
namespace Proy1.Client.Pages.Components
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
    public partial class MovieComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "jumbotron");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "container-fluid");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "row");
#nullable restore
#line 4 "C:\EProfesional\Proy1\Client\Pages\Components\MovieComponent.razor"
             foreach (var movie in Movies)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "col-md-4");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", " card flex-md-row mb-4 box-shadow h-md-300");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "card-body d-flex flex-column align-items-center");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "card");
            __builder.OpenElement(14, "img");
            __builder.AddAttribute(15, "src", 
#nullable restore
#line 11 "C:\EProfesional\Proy1\Client\Pages\Components\MovieComponent.razor"
                                           movie.Image

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(16, "alt");
            __builder.AddAttribute(17, "class", "img-thumbnail");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                                ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "m-5");
            __builder.OpenElement(21, "h5");
            __builder.AddAttribute(22, "class", "card-title");
            __builder.AddContent(23, 
#nullable restore
#line 13 "C:\EProfesional\Proy1\Client\Pages\Components\MovieComponent.razor"
                                                            movie.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                                    ");
            __builder.OpenElement(25, "p");
            __builder.AddAttribute(26, "class", "card-text");
            __builder.AddContent(27, 
#nullable restore
#line 14 "C:\EProfesional\Proy1\Client\Pages\Components\MovieComponent.razor"
                                                          movie.Sinopsis

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                                    ");
            __builder.OpenElement(29, "p");
            __builder.AddAttribute(30, "class", "card-text");
            __builder.AddContent(31, 
#nullable restore
#line 15 "C:\EProfesional\Proy1\Client\Pages\Components\MovieComponent.razor"
                                                          movie.Category

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n\r\n                                ");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "card-footer");
            __builder.OpenElement(35, "p");
            __builder.AddAttribute(36, "class", "card-text");
            __builder.AddContent(37, 
#nullable restore
#line 19 "C:\EProfesional\Proy1\Client\Pages\Components\MovieComponent.razor"
                                                          movie.Premier.ToString("dd/MM/yyyy")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 26 "C:\EProfesional\Proy1\Client\Pages\Components\MovieComponent.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "C:\EProfesional\Proy1\Client\Pages\Components\MovieComponent.razor"
       
    [Parameter] public List<Movie> Movies{get; set;}

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
