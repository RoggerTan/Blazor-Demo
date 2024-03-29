#pragma checksum "D:\ASP.NET\BlazorDemo\BlazorDemo\Pages\MyName.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1359a39eee8ede8419679247234b84f55605f430"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorDemo.Pages
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
    using System.Web;
    using Microsoft.AspNetCore.Blazor.Services;
    [Microsoft.AspNetCore.Blazor.Layouts.LayoutAttribute(typeof(MainLayout))]

    [Microsoft.AspNetCore.Blazor.Components.RouteAttribute("/myname/{Name}")]
    [Microsoft.AspNetCore.Blazor.Components.RouteAttribute("/myname")]
    public class MyName : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.OpenElement(0, "h1");
            builder.AddContent(1, "Đã nhận được thông tin! Tên bạn là ");
            builder.AddContent(2, Name);
            builder.CloseElement();
        }
        #pragma warning restore 1998
#line 11 "D:\ASP.NET\BlazorDemo\BlazorDemo\Pages\MyName.cshtml"
 
    [Parameter]
    private string Name { get; set; }

    protected override async Task OnInitAsync()
    {
        var curUri = UriHelper.GetAbsoluteUri();
        var queryString = new Uri(curUri).Query;
        var queryDict = HttpUtility.ParseQueryString(queryString);
        if (string.IsNullOrEmpty(queryDict["name"])) return;
        Name = queryDict["name"];
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Blazor.Components.InjectAttribute] private IUriHelper UriHelper { get; set; }
    }
}
#pragma warning restore 1591
