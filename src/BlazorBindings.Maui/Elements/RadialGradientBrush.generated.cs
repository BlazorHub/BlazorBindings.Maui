// <auto-generated>
//     This code was generated by a BlazorBindings.Maui component generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>

using BlazorBindings.Core;
using MC = Microsoft.Maui.Controls;
using Microsoft.AspNetCore.Components;
using Microsoft.Maui.Graphics;
using System.Threading.Tasks;

namespace BlazorBindings.Maui.Elements
{
    public partial class RadialGradientBrush : GradientBrush
    {
        static RadialGradientBrush()
        {
            RegisterAdditionalHandlers();
        }

        [Parameter] public Point? Center { get; set; }
        [Parameter] public double? Radius { get; set; }

        public new MC.RadialGradientBrush NativeControl => (MC.RadialGradientBrush)((Element)this).NativeControl;

        protected override MC.Element CreateNativeElement() => new MC.RadialGradientBrush();

        protected override void HandleParameter(string name, object value)
        {
            switch (name)
            {
                case nameof(Center):
                    if (!Equals(Center, value))
                    {
                        Center = (Point?)value;
                        NativeControl.Center = Center ?? (Point)MC.RadialGradientBrush.CenterProperty.DefaultValue;
                    }
                    break;
                case nameof(Radius):
                    if (!Equals(Radius, value))
                    {
                        Radius = (double?)value;
                        NativeControl.Radius = Radius ?? (double)MC.RadialGradientBrush.RadiusProperty.DefaultValue;
                    }
                    break;

                default:
                    base.HandleParameter(name, value);
                    break;
            }
        }

        static partial void RegisterAdditionalHandlers();
    }
}