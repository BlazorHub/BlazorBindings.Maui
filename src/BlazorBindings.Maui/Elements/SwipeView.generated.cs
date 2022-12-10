// <auto-generated>
//     This code was generated by a BlazorBindings.Maui component generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>

using BlazorBindings.Core;
using BlazorBindings.Maui.Elements.Handlers;
using MC = Microsoft.Maui.Controls;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using System.Threading.Tasks;

namespace BlazorBindings.Maui.Elements
{
    public partial class SwipeView : ContentView
    {
        static SwipeView()
        {
            ElementHandlerRegistry.RegisterPropertyContentHandler<SwipeView>(nameof(BottomItems),
                (renderer, parent, component) => new ContentPropertyHandler<MC.SwipeView>((x, value) => x.BottomItems = (MC.SwipeItems)value));
            ElementHandlerRegistry.RegisterPropertyContentHandler<SwipeView>(nameof(LeftItems),
                (renderer, parent, component) => new ContentPropertyHandler<MC.SwipeView>((x, value) => x.LeftItems = (MC.SwipeItems)value));
            ElementHandlerRegistry.RegisterPropertyContentHandler<SwipeView>(nameof(RightItems),
                (renderer, parent, component) => new ContentPropertyHandler<MC.SwipeView>((x, value) => x.RightItems = (MC.SwipeItems)value));
            ElementHandlerRegistry.RegisterPropertyContentHandler<SwipeView>(nameof(TopItems),
                (renderer, parent, component) => new ContentPropertyHandler<MC.SwipeView>((x, value) => x.TopItems = (MC.SwipeItems)value));
            RegisterAdditionalHandlers();
        }

        [Parameter] public double? Threshold { get; set; }
        [Parameter] public RenderFragment BottomItems { get; set; }
        [Parameter] public RenderFragment LeftItems { get; set; }
        [Parameter] public RenderFragment RightItems { get; set; }
        [Parameter] public RenderFragment TopItems { get; set; }
        [Parameter] public EventCallback<MC.SwipeStartedEventArgs> OnSwipeStarted { get; set; }
        [Parameter] public EventCallback<MC.SwipeChangingEventArgs> OnSwipeChanging { get; set; }
        [Parameter] public EventCallback<MC.SwipeEndedEventArgs> OnSwipeEnded { get; set; }

        public new MC.SwipeView NativeControl => (MC.SwipeView)((BindableObject)this).NativeControl;

        protected override MC.SwipeView CreateNativeElement() => new();

        protected override void HandleParameter(string name, object value)
        {
            switch (name)
            {
                case nameof(Threshold):
                    if (!Equals(Threshold, value))
                    {
                        Threshold = (double?)value;
                        NativeControl.Threshold = Threshold ?? (double)MC.SwipeView.ThresholdProperty.DefaultValue;
                    }
                    break;
                case nameof(BottomItems):
                    BottomItems = (RenderFragment)value;
                    break;
                case nameof(LeftItems):
                    LeftItems = (RenderFragment)value;
                    break;
                case nameof(RightItems):
                    RightItems = (RenderFragment)value;
                    break;
                case nameof(TopItems):
                    TopItems = (RenderFragment)value;
                    break;
                case nameof(OnSwipeStarted):
                    if (!Equals(OnSwipeStarted, value))
                    {
                        void NativeControlSwipeStarted(object sender, MC.SwipeStartedEventArgs e) => InvokeEventCallback(OnSwipeStarted, e);

                        OnSwipeStarted = (EventCallback<MC.SwipeStartedEventArgs>)value;
                        NativeControl.SwipeStarted -= NativeControlSwipeStarted;
                        NativeControl.SwipeStarted += NativeControlSwipeStarted;
                    }
                    break;
                case nameof(OnSwipeChanging):
                    if (!Equals(OnSwipeChanging, value))
                    {
                        void NativeControlSwipeChanging(object sender, MC.SwipeChangingEventArgs e) => InvokeEventCallback(OnSwipeChanging, e);

                        OnSwipeChanging = (EventCallback<MC.SwipeChangingEventArgs>)value;
                        NativeControl.SwipeChanging -= NativeControlSwipeChanging;
                        NativeControl.SwipeChanging += NativeControlSwipeChanging;
                    }
                    break;
                case nameof(OnSwipeEnded):
                    if (!Equals(OnSwipeEnded, value))
                    {
                        void NativeControlSwipeEnded(object sender, MC.SwipeEndedEventArgs e) => InvokeEventCallback(OnSwipeEnded, e);

                        OnSwipeEnded = (EventCallback<MC.SwipeEndedEventArgs>)value;
                        NativeControl.SwipeEnded -= NativeControlSwipeEnded;
                        NativeControl.SwipeEnded += NativeControlSwipeEnded;
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
            RenderTreeBuilderHelper.AddContentProperty(builder, sequence++, typeof(SwipeView), BottomItems);
            RenderTreeBuilderHelper.AddContentProperty(builder, sequence++, typeof(SwipeView), LeftItems);
            RenderTreeBuilderHelper.AddContentProperty(builder, sequence++, typeof(SwipeView), RightItems);
            RenderTreeBuilderHelper.AddContentProperty(builder, sequence++, typeof(SwipeView), TopItems);
        }

        static partial void RegisterAdditionalHandlers();
    }
}