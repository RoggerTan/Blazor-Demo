#pragma checksum "D:\ASP.NET\BlazorDemo\BlazorDemo\Pages\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0adba86ae0658007972ee31053df9b9d795d7aa2"
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
    using Microsoft.AspNetCore.Blazor.Services;
    [Microsoft.AspNetCore.Blazor.Layouts.LayoutAttribute(typeof(MainLayout))]

    [Microsoft.AspNetCore.Blazor.Components.RouteAttribute("/about")]
    public class About : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.OpenComponent<BlazorDemo.Components.About.AboutHelloWorld>(0);
            builder.CloseComponent();
            builder.AddContent(1, "\n\n");
            builder.OpenElement(2, "link");
            builder.AddAttribute(3, "rel", "stylesheet");
            builder.AddAttribute(4, "href", "css/about.css");
            builder.CloseElement();
            builder.AddContent(5, "\n\n");
            builder.OpenElement(6, "h1");
            builder.AddContent(7, "Demo 1");
            builder.CloseElement();
            builder.AddContent(8, "\n\n");
            builder.OpenElement(9, "p");
            builder.AddContent(10, "\n    Điều hướng bằng UriHelper.NavigateTo (không load lại toàn bộ trang).\n    Nhập tên vào textbox phía dưới rồi bấm nút gửi nhé.\n");
            builder.CloseElement();
            builder.AddContent(11, "\n\n");
            builder.OpenElement(12, "input");
            builder.AddAttribute(13, "type", "text");
            builder.AddAttribute(14, "name", "name");
            builder.AddAttribute(15, "onchange", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetEventHandlerValue<Microsoft.AspNetCore.Blazor.UIChangeEventArgs>(NameChanged));
            builder.CloseElement();
            builder.AddContent(16, "\n");
            builder.OpenElement(17, "button");
            builder.AddAttribute(18, "onclick", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetEventHandlerValue<Microsoft.AspNetCore.Blazor.UIMouseEventArgs>(BtnSendClick));
            builder.AddContent(19, "Gửi");
            builder.CloseElement();
            builder.AddContent(20, "\n\n");
            builder.OpenElement(21, "div");
            builder.AddAttribute(22, "style", "height: 30px");
            builder.CloseElement();
            builder.AddContent(23, "\n");
            builder.OpenElement(24, "h1");
            builder.AddContent(25, "Demo 2");
            builder.CloseElement();
            builder.AddContent(26, "\n\n");
            builder.OpenElement(27, "p");
            builder.AddContent(28, "\n    Điều hướng bằng form request. Hạn chế điều hướng bằng form request, vì phải load lại toàn bộ trang. Ta có thể thay thế GET form bằng cách gọi NavigateTo và truyền url có query string \"?...\" vào. \n");
            builder.CloseElement();
            builder.AddContent(29, "\n\n");
            builder.OpenElement(30, "form");
            builder.AddAttribute(31, "method", "get");
            builder.AddAttribute(32, "action", "/myname");
            builder.AddContent(33, "\n    ");
            builder.OpenElement(34, "label");
            builder.AddContent(35, "Xin hãy nhập họ tên: ");
            builder.CloseElement();
            builder.AddContent(36, "\n    ");
            builder.OpenElement(37, "input");
            builder.AddAttribute(38, "type", "text");
            builder.AddAttribute(39, "name", "name");
            builder.CloseElement();
            builder.AddContent(40, "\n    ");
            builder.OpenElement(41, "input");
            builder.AddAttribute(42, "type", "submit");
            builder.AddAttribute(43, "value", "Xong!");
            builder.CloseElement();
            builder.AddContent(44, "\n");
            builder.CloseElement();
            builder.AddContent(45, "\n\n");
            builder.OpenElement(46, "h1");
            builder.AddContent(47, "Demo 3");
            builder.CloseElement();
            builder.AddContent(48, "\n");
            builder.OpenElement(49, "label");
            builder.AddContent(50, "Nhập mã màu (ví dụ: #000) để thấy điều kỳ diệu");
            builder.CloseElement();
            builder.OpenElement(51, "br");
            builder.CloseElement();
            builder.AddContent(52, "\n");
            builder.OpenElement(53, "input");
            builder.AddAttribute(54, "type", "text");
            builder.AddAttribute(55, "id", "color");
            builder.AddAttribute(56, "onkeyup", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetEventHandlerValue<Microsoft.AspNetCore.Blazor.UIKeyboardEventArgs>(ColorKeyUp));
            builder.CloseElement();
            builder.AddContent(57, "\n");
            builder.OpenElement(58, "div");
            builder.AddAttribute(59, "style", "background-color:" + " " + (_color) + ";" + " height:" + " 30px");
            builder.CloseElement();
            builder.AddContent(60, "\n\n");
            builder.OpenElement(61, "h1");
            builder.AddContent(62, "Demo 4");
            builder.CloseElement();
            builder.AddContent(63, "\nHai checkbox đồng bộ theo kiểu bind\n");
            builder.OpenElement(64, "input");
            builder.AddAttribute(65, "type", "checkbox");
            builder.AddAttribute(66, "checked", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetValue(_checkboxstatus));
            builder.AddAttribute(67, "onchange", Microsoft.AspNetCore.Blazor.Components.BindMethods.SetValueHandler(__value => _checkboxstatus = __value, _checkboxstatus));
            builder.CloseElement();
            builder.AddContent(68, "\n");
            builder.OpenElement(69, "input");
            builder.AddAttribute(70, "type", "checkbox");
            builder.AddAttribute(71, "checked", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetValue(_checkboxstatus));
            builder.AddAttribute(72, "onchange", Microsoft.AspNetCore.Blazor.Components.BindMethods.SetValueHandler(__value => _checkboxstatus = __value, _checkboxstatus));
            builder.CloseElement();
            builder.AddContent(73, "\n\n");
            builder.OpenElement(74, "h1");
            builder.AddContent(75, "Demo 5");
            builder.CloseElement();
            builder.AddContent(76, "\nHai checkbox đồng bộ theo kiểu value/checked/... + onchange\n");
            builder.OpenElement(77, "input");
            builder.AddAttribute(78, "type", "checkbox");
            builder.AddAttribute(79, "checked", _checkboxstatus);
            builder.AddAttribute(80, "onchange", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetEventHandlerValue<Microsoft.AspNetCore.Blazor.UIChangeEventArgs>((UIChangeEventArgs e) => _checkboxstatus = (bool) e.Value));
            builder.CloseElement();
            builder.AddContent(81, "\n");
            builder.OpenElement(82, "input");
            builder.AddAttribute(83, "type", "checkbox");
            builder.AddAttribute(84, "checked", _checkboxstatus);
            builder.AddAttribute(85, "onchange", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetEventHandlerValue<Microsoft.AspNetCore.Blazor.UIChangeEventArgs>((UIChangeEventArgs e) => _checkboxstatus = (bool) e.Value));
            builder.CloseElement();
        }
        #pragma warning restore 1998
#line 49 "D:\ASP.NET\BlazorDemo\BlazorDemo\Pages\About.cshtml"
 

private string _name;
private string _color = "#fff";
private bool _checkboxstatus = true;

private void NameChanged(UIChangeEventArgs e)
{
    _name = e.Value as string;
}

private void BtnSendClick()
{
    UriHelper.NavigateTo($"/myname/{_name}");
}

private void ColorKeyUp(UIKeyboardEventArgs e)
{
    _color = RegisteredFunction.Invoke<string>("GetDOMValue", "color");
}

#line default
#line hidden
        [global::Microsoft.AspNetCore.Blazor.Components.InjectAttribute] private IUriHelper UriHelper { get; set; }
    }
}
#pragma warning restore 1591