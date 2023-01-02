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
using Microsoft.Maui;
using Microsoft.Maui.Graphics;
using System;
using System.Threading.Tasks;

namespace BlazorBindings.Maui.Elements.AlohaKit
{
    public partial class Button : BlazorBindings.Maui.Elements.GraphicsView
    {
        static Button()
        {
            RegisterAdditionalHandlers();
        }

        [Parameter] public AC.ButtonDrawable ButtonDrawable { get; set; }
        [Parameter] public CornerRadius? CornerRadius { get; set; }
        [Parameter] public bool? HasShadow { get; set; }
        [Parameter] public TextAlignment? HorizontalTextAlignment { get; set; }
        [Parameter] public Color ShadowColor { get; set; }
        [Parameter] public Color StrokeColor { get; set; }
        [Parameter] public double? StrokeThickness { get; set; }
        [Parameter] public string Text { get; set; }
        [Parameter] public Color TextColor { get; set; }
        [Parameter] public TextAlignment? VerticalTextAlignment { get; set; }
        [Parameter] public RenderFragment Stroke { get; set; }
        [Parameter] public EventCallback OnPress { get; set; }
        [Parameter] public EventCallback OnRelease { get; set; }
        [Parameter] public EventCallback OnClick { get; set; }

        public new AC.Button NativeControl => (AC.Button)((BindableObject)this).NativeControl;

        protected override AC.Button CreateNativeElement() => new();

        protected override void HandleParameter(string name, object value)
        {
            switch (name)
            {
                case nameof(ButtonDrawable):
                    if (!Equals(ButtonDrawable, value))
                    {
                        ButtonDrawable = (AC.ButtonDrawable)value;
                        NativeControl.ButtonDrawable = ButtonDrawable;
                    }
                    break;
                case nameof(CornerRadius):
                    if (!Equals(CornerRadius, value))
                    {
                        CornerRadius = (CornerRadius?)value;
                        NativeControl.CornerRadius = CornerRadius ?? (CornerRadius)AC.Button.CornerRadiusProperty.DefaultValue;
                    }
                    break;
                case nameof(HasShadow):
                    if (!Equals(HasShadow, value))
                    {
                        HasShadow = (bool?)value;
                        NativeControl.HasShadow = HasShadow ?? (bool)AC.Button.HasShadowProperty.DefaultValue;
                    }
                    break;
                case nameof(HorizontalTextAlignment):
                    if (!Equals(HorizontalTextAlignment, value))
                    {
                        HorizontalTextAlignment = (TextAlignment?)value;
                        NativeControl.HorizontalTextAlignment = HorizontalTextAlignment ?? (TextAlignment)AC.Button.HorizontalTextAlignmentProperty.DefaultValue;
                    }
                    break;
                case nameof(ShadowColor):
                    if (!Equals(ShadowColor, value))
                    {
                        ShadowColor = (Color)value;
                        NativeControl.ShadowColor = ShadowColor;
                    }
                    break;
                case nameof(StrokeColor):
                    if (!Equals(StrokeColor, value))
                    {
                        StrokeColor = (Color)value;
                        NativeControl.Stroke = StrokeColor;
                    }
                    break;
                case nameof(StrokeThickness):
                    if (!Equals(StrokeThickness, value))
                    {
                        StrokeThickness = (double?)value;
                        NativeControl.StrokeThickness = StrokeThickness ?? (double)AC.Button.StrokeThicknessProperty.DefaultValue;
                    }
                    break;
                case nameof(Text):
                    if (!Equals(Text, value))
                    {
                        Text = (string)value;
                        NativeControl.Text = Text;
                    }
                    break;
                case nameof(TextColor):
                    if (!Equals(TextColor, value))
                    {
                        TextColor = (Color)value;
                        NativeControl.TextColor = TextColor;
                    }
                    break;
                case nameof(VerticalTextAlignment):
                    if (!Equals(VerticalTextAlignment, value))
                    {
                        VerticalTextAlignment = (TextAlignment?)value;
                        NativeControl.VerticalTextAlignment = VerticalTextAlignment ?? (TextAlignment)AC.Button.VerticalTextAlignmentProperty.DefaultValue;
                    }
                    break;
                case nameof(Background):
                    Background = (RenderFragment)value;
                    break;
                case nameof(Stroke):
                    Stroke = (RenderFragment)value;
                    break;
                case nameof(OnPress):
                    if (!Equals(OnPress, value))
                    {
                        void NativeControlPressed(object sender, EventArgs e) => InvokeEventCallback(OnPress);

                        OnPress = (EventCallback)value;
                        NativeControl.Pressed -= NativeControlPressed;
                        NativeControl.Pressed += NativeControlPressed;
                    }
                    break;
                case nameof(OnRelease):
                    if (!Equals(OnRelease, value))
                    {
                        void NativeControlReleased(object sender, EventArgs e) => InvokeEventCallback(OnRelease);

                        OnRelease = (EventCallback)value;
                        NativeControl.Released -= NativeControlReleased;
                        NativeControl.Released += NativeControlReleased;
                    }
                    break;
                case nameof(OnClick):
                    if (!Equals(OnClick, value))
                    {
                        void NativeControlClicked(object sender, EventArgs e) => InvokeEventCallback(OnClick);

                        OnClick = (EventCallback)value;
                        NativeControl.Clicked -= NativeControlClicked;
                        NativeControl.Clicked += NativeControlClicked;
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
            RenderTreeBuilderHelper.AddContentProperty<AC.Button>(builder, sequence++, Background, (x, value) => x.Background = (MC.Brush)value);
            RenderTreeBuilderHelper.AddContentProperty<AC.Button>(builder, sequence++, Stroke, (x, value) => x.Stroke = (MC.Brush)value);
        }

        static partial void RegisterAdditionalHandlers();
    }
}
