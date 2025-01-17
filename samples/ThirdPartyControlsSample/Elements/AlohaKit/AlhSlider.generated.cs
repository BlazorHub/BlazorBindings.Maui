// <auto-generated>
//     This code was generated by a BlazorBindings.Maui component generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>

using AC = AlohaKit.Controls;
using BlazorBindings.Core;
using BlazorBindings.Maui.Elements;
using MC = Microsoft.Maui.Controls;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.Maui.Graphics;
using System.Threading.Tasks;

#pragma warning disable CA2252

namespace BlazorBindings.Maui.Elements.AlohaKit
{
    public partial class AlhSlider : BlazorBindings.Maui.Elements.GraphicsView
    {
        static AlhSlider()
        {
            RegisterAdditionalHandlers();
        }

        [Parameter] public double? Maximum { get; set; }
        [Parameter] public Color MaximumColor { get; set; }
        [Parameter] public double? Minimum { get; set; }
        [Parameter] public Color MinimumColor { get; set; }
        [Parameter] public AC.SliderDrawable SliderDrawable { get; set; }
        [Parameter] public Color ThumbColor { get; set; }
        [Parameter] public AC.ThumbShape? ThumbShape { get; set; }
        [Parameter] public double? Value { get; set; }
        [Parameter] public RenderFragment MaximumBrush { get; set; }
        [Parameter] public RenderFragment MinimumBrush { get; set; }
        [Parameter] public RenderFragment ThumbBrush { get; set; }
        [Parameter] public EventCallback<double> ValueChanged { get; set; }

        public new AC.Slider NativeControl => (AC.Slider)((BindableObject)this).NativeControl;

        protected override AC.Slider CreateNativeElement() => new();

        protected override void HandleParameter(string name, object value)
        {
            switch (name)
            {
                case nameof(Maximum):
                    if (!Equals(Maximum, value))
                    {
                        Maximum = (double?)value;
                        NativeControl.Maximum = Maximum ?? (double)AC.Slider.MaximumProperty.DefaultValue;
                    }
                    break;
                case nameof(MaximumColor):
                    if (!Equals(MaximumColor, value))
                    {
                        MaximumColor = (Color)value;
                        NativeControl.MaximumBrush = MaximumColor;
                    }
                    break;
                case nameof(Minimum):
                    if (!Equals(Minimum, value))
                    {
                        Minimum = (double?)value;
                        NativeControl.Minimum = Minimum ?? (double)AC.Slider.MinimumProperty.DefaultValue;
                    }
                    break;
                case nameof(MinimumColor):
                    if (!Equals(MinimumColor, value))
                    {
                        MinimumColor = (Color)value;
                        NativeControl.MinimumBrush = MinimumColor;
                    }
                    break;
                case nameof(SliderDrawable):
                    if (!Equals(SliderDrawable, value))
                    {
                        SliderDrawable = (AC.SliderDrawable)value;
                        NativeControl.SliderDrawable = SliderDrawable;
                    }
                    break;
                case nameof(ThumbColor):
                    if (!Equals(ThumbColor, value))
                    {
                        ThumbColor = (Color)value;
                        NativeControl.ThumbBrush = ThumbColor;
                    }
                    break;
                case nameof(ThumbShape):
                    if (!Equals(ThumbShape, value))
                    {
                        ThumbShape = (AC.ThumbShape?)value;
                        NativeControl.ThumbShape = ThumbShape ?? (AC.ThumbShape)AC.Slider.ThumbShapeProperty.DefaultValue;
                    }
                    break;
                case nameof(Value):
                    if (!Equals(Value, value))
                    {
                        Value = (double?)value;
                        NativeControl.Value = Value ?? (double)AC.Slider.ValueProperty.DefaultValue;
                    }
                    break;
                case nameof(Background):
                    Background = (RenderFragment)value;
                    break;
                case nameof(MaximumBrush):
                    MaximumBrush = (RenderFragment)value;
                    break;
                case nameof(MinimumBrush):
                    MinimumBrush = (RenderFragment)value;
                    break;
                case nameof(ThumbBrush):
                    ThumbBrush = (RenderFragment)value;
                    break;
                case nameof(ValueChanged):
                    if (!Equals(ValueChanged, value))
                    {
                        void NativeControlValueChanged(object sender, MC.ValueChangedEventArgs e)
                        {
                            var value = NativeControl.Value;
                            Value = value;
                            InvokeEventCallback(ValueChanged, value);
                        }

                        ValueChanged = (EventCallback<double>)value;
                        NativeControl.ValueChanged -= NativeControlValueChanged;
                        NativeControl.ValueChanged += NativeControlValueChanged;
                    }
                    break;

                default:
                    base.HandleParameter(name, value);
                    break;
            }
        }

        protected override void RenderAdditionalElementContent(RenderTreeBuilder builder, ref int sequence)
        {
            base.RenderAdditionalElementContent(builder, ref sequence);
            RenderTreeBuilderHelper.AddContentProperty<AC.Slider>(builder, sequence++, Background, (x, value) => x.Background = (MC.Brush)value);
            RenderTreeBuilderHelper.AddContentProperty<AC.Slider>(builder, sequence++, MaximumBrush, (x, value) => x.MaximumBrush = (MC.Brush)value);
            RenderTreeBuilderHelper.AddContentProperty<AC.Slider>(builder, sequence++, MinimumBrush, (x, value) => x.MinimumBrush = (MC.Brush)value);
            RenderTreeBuilderHelper.AddContentProperty<AC.Slider>(builder, sequence++, ThumbBrush, (x, value) => x.ThumbBrush = (MC.Brush)value);
        }

        static partial void RegisterAdditionalHandlers();
    }
}
