#pragma checksum "D:\2021unity\VisualStudio_Study\Server\BlazorApp\BlazorApp\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01e596c066edbcbab69aaa342accce260d445839"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\2021unity\VisualStudio_Study\Server\BlazorApp\BlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\2021unity\VisualStudio_Study\Server\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\2021unity\VisualStudio_Study\Server\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\2021unity\VisualStudio_Study\Server\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\2021unity\VisualStudio_Study\Server\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\2021unity\VisualStudio_Study\Server\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\2021unity\VisualStudio_Study\Server\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\2021unity\VisualStudio_Study\Server\BlazorApp\BlazorApp\_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\2021unity\VisualStudio_Study\Server\BlazorApp\BlazorApp\_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\2021unity\VisualStudio_Study\Server\BlazorApp\BlazorApp\Pages\Counter.razor"
using System.Threading;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h1");
            __builder.AddAttribute(1, "style", "color:" + (
#nullable restore
#line 5 "D:\2021unity\VisualStudio_Study\Server\BlazorApp\BlazorApp\Pages\Counter.razor"
                  Color

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(2, "Counter");
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n\r\n");
            __builder.OpenElement(4, "p");
            __builder.AddContent(5, "Current count: ");
            __builder.OpenElement(6, "label");
            __builder.AddAttribute(7, "style", "color:" + (
#nullable restore
#line 7 "D:\2021unity\VisualStudio_Study\Server\BlazorApp\BlazorApp\Pages\Counter.razor"
                                       Color

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(8, 
#nullable restore
#line 7 "D:\2021unity\VisualStudio_Study\Server\BlazorApp\BlazorApp\Pages\Counter.razor"
                                               currentCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddContent(9, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n\r\n");
            __builder.OpenElement(11, "button");
            __builder.AddAttribute(12, "class", "btn btn-primary");
            __builder.AddAttribute(13, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "D:\2021unity\VisualStudio_Study\Server\BlazorApp\BlazorApp\Pages\Counter.razor"
                                          IncrementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(14, "Click me");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n");
            __builder.OpenElement(16, "button");
            __builder.AddAttribute(17, "class", "btn btn-secondary");
            __builder.AddAttribute(18, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "D:\2021unity\VisualStudio_Study\Server\BlazorApp\BlazorApp\Pages\Counter.razor"
                                            AutoIncrement

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(19, "Auto Increment");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "D:\2021unity\VisualStudio_Study\Server\BlazorApp\BlazorApp\Pages\Counter.razor"
       
    [CascadingParameter(Name = "ThemeColor")]
    string Color { get; set; }

    private int currentCount = 0;

    private void IncrementCount()
    {
        currentCount++;
    }

    void AutoIncrement()
    {
        var timer = new Timer(x =>
        {
            InvokeAsync(() =>
            {
                IncrementCount();
                StateHasChanged();
            });
        }, null, 1000, 1000);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
