// <auto-generated>
//     This code was generated by a BlazorBindings.Maui component generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>

using BlazorBindings.Core;
using MC = Microsoft.Maui.Controls;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

#pragma warning disable CA2252

namespace BlazorBindings.Maui.Elements
{
    /// <summary>
    /// An element that can respond to gestures.
    /// </summary>
    public partial class GestureElement : Element
    {
        static GestureElement()
        {
            RegisterAdditionalHandlers();
        }

        public new MC.GestureElement NativeControl => (MC.GestureElement)((BindableObject)this).NativeControl;

        protected override MC.GestureElement CreateNativeElement() => new();


        static partial void RegisterAdditionalHandlers();
    }
}
