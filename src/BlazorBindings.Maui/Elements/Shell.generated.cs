// <auto-generated>
//     This code was generated by a BlazorBindings.Maui component generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>

using BlazorBindings.Core;
using MC = Microsoft.Maui.Controls;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.Maui;
using Microsoft.Maui.Graphics;
using System.Threading.Tasks;

namespace BlazorBindings.Maui.Elements
{
    /// <summary>
    /// A <see cref="T:Microsoft.Maui.Controls.Page" /> that provides fundamental UI features that most applications require, leaving you to focus on the application's core workload.
    /// </summary>
    public partial class Shell : Page
    {
        static Shell()
        {
            RegisterAdditionalHandlers();
        }

        [Parameter] public Color FlyoutBackdropColor { get; set; }
        /// <summary>
        /// Gets or sets the background color of the <see cref="P:Microsoft.Maui.Controls.Shell" /> Flyout.
        /// </summary>
        [Parameter] public Color FlyoutBackgroundColor { get; set; }
        [Parameter] public MC.ImageSource FlyoutBackgroundImage { get; set; }
        [Parameter] public Aspect? FlyoutBackgroundImageAspect { get; set; }
        /// <summary>
        /// Setting the <see cref="T:Microsoft.Maui.FlyoutBehavior" /> property to Disabled hides the flyout, which is useful when you only have one ShellItem. The other valid FlyoutBehavior values are Flyout (default), and Locked.
        /// </summary>
        [Parameter] public FlyoutBehavior? FlyoutBehavior { get; set; }
        /// <summary>
        /// Setting the FlyoutHeaderBehavior to CollapseOnScroll collapses the flyout as scrolling occurs. The other valid FlyoutHeaderBehavior values are Default, Fixed, and Scroll (scroll with the menu items).
        /// </summary>
        [Parameter] public MC.FlyoutHeaderBehavior? FlyoutHeaderBehavior { get; set; }
        [Parameter] public double? FlyoutHeight { get; set; }
        /// <summary>
        /// Gets or sets the icon that, when pressed, opens the <see cref="P:Microsoft.Maui.Controls.Shell" /> Flyout.
        /// </summary>
        /// <value>
        /// The default icon is a "hamburger" icon.
        /// </value>
        [Parameter] public MC.ImageSource FlyoutIcon { get; set; }
        /// <summary>
        /// Gets or sets the visible status of the <see cref="P:Microsoft.Maui.Controls.Shell" /> Flyout.
        /// </summary>
        [Parameter] public bool? FlyoutIsPresented { get; set; }
        [Parameter] public MC.ScrollMode? FlyoutVerticalScrollMode { get; set; }
        [Parameter] public double? FlyoutWidth { get; set; }
        [Parameter] public RenderFragment FlyoutBackdrop { get; set; }
        [Parameter] public RenderFragment FlyoutBackground { get; set; }
        [Parameter] public RenderFragment FlyoutContent { get; set; }
        [Parameter] public RenderFragment FlyoutFooter { get; set; }
        /// <summary>
        /// The flyout header appearance can be defined by setting the <see cref="P:Microsoft.Maui.Controls.Shell.FlyoutHeaderTemplate" /> property to a <see cref="P:Microsoft.Maui.Controls.DataTemplate" />.
        /// </summary>
        [Parameter] public RenderFragment FlyoutHeader { get; set; }
        /// <summary>
        /// Gets or sets <see cref="T:Microsoft.Maui.Controls.DataTemplate" /> applied to each of the <see cref="P:Microsoft.Maui.Controls.Shell.Items" />.
        /// </summary>
        [Parameter] public RenderFragment<MC.BaseShellItem> ItemTemplate { get; set; }
        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.Maui.Controls.DataTemplate" /> applied to <see cref="T:Microsoft.Maui.Controls.MenuItem" /> objects in the <see cref="P:Microsoft.Maui.Controls.ShellContent.MenuItems" /> collection.
        /// </summary>
        [Parameter] public RenderFragment<MC.BaseShellItem> MenuItemTemplate { get; set; }
        [Parameter] public EventCallback<MC.ShellNavigatedEventArgs> OnNavigated { get; set; }
        [Parameter] public EventCallback<MC.ShellNavigatingEventArgs> OnNavigating { get; set; }

        public new MC.Shell NativeControl => (MC.Shell)((BindableObject)this).NativeControl;

        protected override MC.Shell CreateNativeElement() => new();

        protected override void HandleParameter(string name, object value)
        {
            switch (name)
            {
                case nameof(FlyoutBackdropColor):
                    if (!Equals(FlyoutBackdropColor, value))
                    {
                        FlyoutBackdropColor = (Color)value;
                        NativeControl.FlyoutBackdrop = FlyoutBackdropColor;
                    }
                    break;
                case nameof(FlyoutBackgroundColor):
                    if (!Equals(FlyoutBackgroundColor, value))
                    {
                        FlyoutBackgroundColor = (Color)value;
                        NativeControl.FlyoutBackgroundColor = FlyoutBackgroundColor;
                    }
                    break;
                case nameof(FlyoutBackgroundImage):
                    if (!Equals(FlyoutBackgroundImage, value))
                    {
                        FlyoutBackgroundImage = (MC.ImageSource)value;
                        NativeControl.FlyoutBackgroundImage = FlyoutBackgroundImage;
                    }
                    break;
                case nameof(FlyoutBackgroundImageAspect):
                    if (!Equals(FlyoutBackgroundImageAspect, value))
                    {
                        FlyoutBackgroundImageAspect = (Aspect?)value;
                        NativeControl.FlyoutBackgroundImageAspect = FlyoutBackgroundImageAspect ?? (Aspect)MC.Shell.FlyoutBackgroundImageAspectProperty.DefaultValue;
                    }
                    break;
                case nameof(FlyoutBehavior):
                    if (!Equals(FlyoutBehavior, value))
                    {
                        FlyoutBehavior = (FlyoutBehavior?)value;
                        NativeControl.FlyoutBehavior = FlyoutBehavior ?? (FlyoutBehavior)MC.Shell.FlyoutBehaviorProperty.DefaultValue;
                    }
                    break;
                case nameof(FlyoutHeaderBehavior):
                    if (!Equals(FlyoutHeaderBehavior, value))
                    {
                        FlyoutHeaderBehavior = (MC.FlyoutHeaderBehavior?)value;
                        NativeControl.FlyoutHeaderBehavior = FlyoutHeaderBehavior ?? (MC.FlyoutHeaderBehavior)MC.Shell.FlyoutHeaderBehaviorProperty.DefaultValue;
                    }
                    break;
                case nameof(FlyoutHeight):
                    if (!Equals(FlyoutHeight, value))
                    {
                        FlyoutHeight = (double?)value;
                        NativeControl.FlyoutHeight = FlyoutHeight ?? (double)MC.Shell.FlyoutHeightProperty.DefaultValue;
                    }
                    break;
                case nameof(FlyoutIcon):
                    if (!Equals(FlyoutIcon, value))
                    {
                        FlyoutIcon = (MC.ImageSource)value;
                        NativeControl.FlyoutIcon = FlyoutIcon;
                    }
                    break;
                case nameof(FlyoutIsPresented):
                    if (!Equals(FlyoutIsPresented, value))
                    {
                        FlyoutIsPresented = (bool?)value;
                        NativeControl.FlyoutIsPresented = FlyoutIsPresented ?? (bool)MC.Shell.FlyoutIsPresentedProperty.DefaultValue;
                    }
                    break;
                case nameof(FlyoutVerticalScrollMode):
                    if (!Equals(FlyoutVerticalScrollMode, value))
                    {
                        FlyoutVerticalScrollMode = (MC.ScrollMode?)value;
                        NativeControl.FlyoutVerticalScrollMode = FlyoutVerticalScrollMode ?? (MC.ScrollMode)MC.Shell.FlyoutVerticalScrollModeProperty.DefaultValue;
                    }
                    break;
                case nameof(FlyoutWidth):
                    if (!Equals(FlyoutWidth, value))
                    {
                        FlyoutWidth = (double?)value;
                        NativeControl.FlyoutWidth = FlyoutWidth ?? (double)MC.Shell.FlyoutWidthProperty.DefaultValue;
                    }
                    break;
                case nameof(FlyoutBackdrop):
                    FlyoutBackdrop = (RenderFragment)value;
                    break;
                case nameof(FlyoutBackground):
                    FlyoutBackground = (RenderFragment)value;
                    break;
                case nameof(FlyoutContent):
                    FlyoutContent = (RenderFragment)value;
                    break;
                case nameof(FlyoutFooter):
                    FlyoutFooter = (RenderFragment)value;
                    break;
                case nameof(FlyoutHeader):
                    FlyoutHeader = (RenderFragment)value;
                    break;
                case nameof(ItemTemplate):
                    ItemTemplate = (RenderFragment<MC.BaseShellItem>)value;
                    break;
                case nameof(MenuItemTemplate):
                    MenuItemTemplate = (RenderFragment<MC.BaseShellItem>)value;
                    break;
                case nameof(OnNavigated):
                    if (!Equals(OnNavigated, value))
                    {
                        void NativeControlNavigated(object sender, MC.ShellNavigatedEventArgs e) => InvokeEventCallback(OnNavigated, e);

                        OnNavigated = (EventCallback<MC.ShellNavigatedEventArgs>)value;
                        NativeControl.Navigated -= NativeControlNavigated;
                        NativeControl.Navigated += NativeControlNavigated;
                    }
                    break;
                case nameof(OnNavigating):
                    if (!Equals(OnNavigating, value))
                    {
                        void NativeControlNavigating(object sender, MC.ShellNavigatingEventArgs e) => InvokeEventCallback(OnNavigating, e);

                        OnNavigating = (EventCallback<MC.ShellNavigatingEventArgs>)value;
                        NativeControl.Navigating -= NativeControlNavigating;
                        NativeControl.Navigating += NativeControlNavigating;
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
            RenderTreeBuilderHelper.AddContentProperty<MC.Shell>(builder, sequence++, FlyoutBackdrop, (x, value) => x.FlyoutBackdrop = (MC.Brush)value);
            RenderTreeBuilderHelper.AddContentProperty<MC.Shell>(builder, sequence++, FlyoutBackground, (x, value) => x.FlyoutBackground = (MC.Brush)value);
            RenderTreeBuilderHelper.AddDataTemplateProperty<MC.Shell>(builder, sequence++, FlyoutContent, (x, template) => x.FlyoutContentTemplate = template);
            RenderTreeBuilderHelper.AddDataTemplateProperty<MC.Shell>(builder, sequence++, FlyoutFooter, (x, template) => x.FlyoutFooterTemplate = template);
            RenderTreeBuilderHelper.AddDataTemplateProperty<MC.Shell>(builder, sequence++, FlyoutHeader, (x, template) => x.FlyoutHeaderTemplate = template);
            RenderTreeBuilderHelper.AddDataTemplateProperty<MC.Shell, MC.BaseShellItem>(builder, sequence++, ItemTemplate, (x, template) => x.ItemTemplate = template);
            RenderTreeBuilderHelper.AddDataTemplateProperty<MC.Shell, MC.BaseShellItem>(builder, sequence++, MenuItemTemplate, (x, template) => x.MenuItemTemplate = template);
        }

        static partial void RegisterAdditionalHandlers();
    }
}
