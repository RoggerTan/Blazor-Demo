#pragma checksum "D:\ASP.NET\BlazorDemo\BlazorDemo\Components\Home\HomeHelloWorld.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff0c4edff6319ca673771efd13d988260ca8abbc"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorDemo.Components.Home
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Net.Http;
    using Microsoft.AspNetCore.Blazor;
    using Microsoft.AspNetCore.Blazor.Components;
    using Microsoft.AspNetCore.Blazor.Layouts;
    using Microsoft.AspNetCore.Blazor.Routing;
    using Microsoft.AspNetCore.Blazor.Browser.Interop;
    using BlazorDemo;
    using BlazorDemo.Shared;
    public class HomeHelloWorld : Microsoft.AspNetCore.Blazor.Components.BlazorComponent, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.OpenElement(0, "h1");
            builder.AddContent(1, "Hello ");
            builder.AddContent(2, Name);
            builder.AddContent(3, " from home");
            builder.CloseElement();
        }
        #pragma warning restore 1998
#line 6 "D:\ASP.NET\BlazorDemo\BlazorDemo\Components\Home\HomeHelloWorld.cshtml"
 
    //Parameter luôn là property
    [Parameter]
    private string Name { get; set; }

    public void Dispose()
    {
        Console.WriteLine("Đã dispose");
    }


#line default
#line hidden
    }
}
#pragma warning restore 1591
