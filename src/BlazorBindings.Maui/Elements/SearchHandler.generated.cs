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
using Microsoft.Maui;
using Microsoft.Maui.Graphics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;

namespace BlazorBindings.Maui.Elements
{
    public partial class SearchHandler<T> : BindableObject
    {
        static SearchHandler()
        {
            ElementHandlerRegistry.RegisterPropertyContentHandler<SearchHandler<T>>(nameof(ItemTemplate),
                (renderer, parent, component) => new DataTemplatePropertyHandler<MC.SearchHandler, T>(component,
                    (x, dataTemplate) => x.ItemTemplate = dataTemplate));
            RegisterAdditionalHandlers();
        }

        [Parameter] public string AutomationId { get; set; }
        [Parameter] public Color BackgroundColor { get; set; }
        [Parameter] public Color CancelButtonColor { get; set; }
        [Parameter] public double? CharacterSpacing { get; set; }
        [Parameter] public MC.ImageSource ClearIcon { get; set; }
        [Parameter] public string ClearIconHelpText { get; set; }
        [Parameter] public string ClearIconName { get; set; }
        [Parameter] public bool? ClearPlaceholderEnabled { get; set; }
        [Parameter] public string ClearPlaceholderHelpText { get; set; }
        [Parameter] public MC.ImageSource ClearPlaceholderIcon { get; set; }
        [Parameter] public string ClearPlaceholderName { get; set; }
        [Parameter] public string DisplayMemberName { get; set; }
        [Parameter] public MC.FontAttributes? FontAttributes { get; set; }
        [Parameter] public bool? FontAutoScalingEnabled { get; set; }
        [Parameter] public string FontFamily { get; set; }
        [Parameter] public double? FontSize { get; set; }
        [Parameter] public TextAlignment? HorizontalTextAlignment { get; set; }
        [Parameter] public bool? IsSearchEnabled { get; set; }
        [Parameter] public IEnumerable<T> ItemsSource { get; set; }
        [Parameter] public Keyboard Keyboard { get; set; }
        [Parameter] public string Placeholder { get; set; }
        [Parameter] public Color PlaceholderColor { get; set; }
        [Parameter] public string Query { get; set; }
        [Parameter] public MC.ImageSource QueryIcon { get; set; }
        [Parameter] public string QueryIconHelpText { get; set; }
        [Parameter] public string QueryIconName { get; set; }
        [Parameter] public MC.SearchBoxVisibility? SearchBoxVisibility { get; set; }
        [Parameter] public bool? ShowsResults { get; set; }
        [Parameter] public Color TextColor { get; set; }
        [Parameter] public TextTransform? TextTransform { get; set; }
        [Parameter] public TextAlignment? VerticalTextAlignment { get; set; }
        [Parameter] public RenderFragment<T> ItemTemplate { get; set; }
        [Parameter] public EventCallback<string> QueryChanged { get; set; }
        [Parameter] public EventCallback<T> SelectedItemChanged { get; set; }
        [Parameter] public EventCallback OnFocused { get; set; }
        [Parameter] public EventCallback OnUnfocused { get; set; }

        public new MC.SearchHandler NativeControl => (MC.SearchHandler)((BindableObject)this).NativeControl;

        protected override MC.SearchHandler CreateNativeElement() => new();

        protected override void HandleParameter(string name, object value)
        {
            switch (name)
            {
                case nameof(AutomationId):
                    if (!Equals(AutomationId, value))
                    {
                        AutomationId = (string)value;
                        NativeControl.AutomationId = AutomationId;
                    }
                    break;
                case nameof(BackgroundColor):
                    if (!Equals(BackgroundColor, value))
                    {
                        BackgroundColor = (Color)value;
                        NativeControl.BackgroundColor = BackgroundColor;
                    }
                    break;
                case nameof(CancelButtonColor):
                    if (!Equals(CancelButtonColor, value))
                    {
                        CancelButtonColor = (Color)value;
                        NativeControl.CancelButtonColor = CancelButtonColor;
                    }
                    break;
                case nameof(CharacterSpacing):
                    if (!Equals(CharacterSpacing, value))
                    {
                        CharacterSpacing = (double?)value;
                        NativeControl.CharacterSpacing = CharacterSpacing ?? (double)MC.SearchHandler.CharacterSpacingProperty.DefaultValue;
                    }
                    break;
                case nameof(ClearIcon):
                    if (!Equals(ClearIcon, value))
                    {
                        ClearIcon = (MC.ImageSource)value;
                        NativeControl.ClearIcon = ClearIcon;
                    }
                    break;
                case nameof(ClearIconHelpText):
                    if (!Equals(ClearIconHelpText, value))
                    {
                        ClearIconHelpText = (string)value;
                        NativeControl.ClearIconHelpText = ClearIconHelpText;
                    }
                    break;
                case nameof(ClearIconName):
                    if (!Equals(ClearIconName, value))
                    {
                        ClearIconName = (string)value;
                        NativeControl.ClearIconName = ClearIconName;
                    }
                    break;
                case nameof(ClearPlaceholderEnabled):
                    if (!Equals(ClearPlaceholderEnabled, value))
                    {
                        ClearPlaceholderEnabled = (bool?)value;
                        NativeControl.ClearPlaceholderEnabled = ClearPlaceholderEnabled ?? (bool)MC.SearchHandler.ClearPlaceholderEnabledProperty.DefaultValue;
                    }
                    break;
                case nameof(ClearPlaceholderHelpText):
                    if (!Equals(ClearPlaceholderHelpText, value))
                    {
                        ClearPlaceholderHelpText = (string)value;
                        NativeControl.ClearPlaceholderHelpText = ClearPlaceholderHelpText;
                    }
                    break;
                case nameof(ClearPlaceholderIcon):
                    if (!Equals(ClearPlaceholderIcon, value))
                    {
                        ClearPlaceholderIcon = (MC.ImageSource)value;
                        NativeControl.ClearPlaceholderIcon = ClearPlaceholderIcon;
                    }
                    break;
                case nameof(ClearPlaceholderName):
                    if (!Equals(ClearPlaceholderName, value))
                    {
                        ClearPlaceholderName = (string)value;
                        NativeControl.ClearPlaceholderName = ClearPlaceholderName;
                    }
                    break;
                case nameof(DisplayMemberName):
                    if (!Equals(DisplayMemberName, value))
                    {
                        DisplayMemberName = (string)value;
                        NativeControl.DisplayMemberName = DisplayMemberName;
                    }
                    break;
                case nameof(FontAttributes):
                    if (!Equals(FontAttributes, value))
                    {
                        FontAttributes = (MC.FontAttributes?)value;
                        NativeControl.FontAttributes = FontAttributes ?? (MC.FontAttributes)MC.SearchHandler.FontAttributesProperty.DefaultValue;
                    }
                    break;
                case nameof(FontAutoScalingEnabled):
                    if (!Equals(FontAutoScalingEnabled, value))
                    {
                        FontAutoScalingEnabled = (bool?)value;
                        NativeControl.FontAutoScalingEnabled = FontAutoScalingEnabled ?? (bool)MC.SearchHandler.FontAutoScalingEnabledProperty.DefaultValue;
                    }
                    break;
                case nameof(FontFamily):
                    if (!Equals(FontFamily, value))
                    {
                        FontFamily = (string)value;
                        NativeControl.FontFamily = FontFamily;
                    }
                    break;
                case nameof(FontSize):
                    if (!Equals(FontSize, value))
                    {
                        FontSize = (double?)value;
                        NativeControl.FontSize = FontSize ?? (double)MC.SearchHandler.FontSizeProperty.DefaultValue;
                    }
                    break;
                case nameof(HorizontalTextAlignment):
                    if (!Equals(HorizontalTextAlignment, value))
                    {
                        HorizontalTextAlignment = (TextAlignment?)value;
                        NativeControl.HorizontalTextAlignment = HorizontalTextAlignment ?? (TextAlignment)MC.SearchHandler.HorizontalTextAlignmentProperty.DefaultValue;
                    }
                    break;
                case nameof(IsSearchEnabled):
                    if (!Equals(IsSearchEnabled, value))
                    {
                        IsSearchEnabled = (bool?)value;
                        NativeControl.IsSearchEnabled = IsSearchEnabled ?? (bool)MC.SearchHandler.IsSearchEnabledProperty.DefaultValue;
                    }
                    break;
                case nameof(ItemsSource):
                    if (!Equals(ItemsSource, value))
                    {
                        ItemsSource = (IEnumerable<T>)value;
                        NativeControl.ItemsSource = ItemsSource;
                    }
                    break;
                case nameof(Keyboard):
                    if (!Equals(Keyboard, value))
                    {
                        Keyboard = (Keyboard)value;
                        NativeControl.Keyboard = Keyboard;
                    }
                    break;
                case nameof(Placeholder):
                    if (!Equals(Placeholder, value))
                    {
                        Placeholder = (string)value;
                        NativeControl.Placeholder = Placeholder;
                    }
                    break;
                case nameof(PlaceholderColor):
                    if (!Equals(PlaceholderColor, value))
                    {
                        PlaceholderColor = (Color)value;
                        NativeControl.PlaceholderColor = PlaceholderColor;
                    }
                    break;
                case nameof(Query):
                    if (!Equals(Query, value))
                    {
                        Query = (string)value;
                        NativeControl.Query = Query;
                    }
                    break;
                case nameof(QueryIcon):
                    if (!Equals(QueryIcon, value))
                    {
                        QueryIcon = (MC.ImageSource)value;
                        NativeControl.QueryIcon = QueryIcon;
                    }
                    break;
                case nameof(QueryIconHelpText):
                    if (!Equals(QueryIconHelpText, value))
                    {
                        QueryIconHelpText = (string)value;
                        NativeControl.QueryIconHelpText = QueryIconHelpText;
                    }
                    break;
                case nameof(QueryIconName):
                    if (!Equals(QueryIconName, value))
                    {
                        QueryIconName = (string)value;
                        NativeControl.QueryIconName = QueryIconName;
                    }
                    break;
                case nameof(SearchBoxVisibility):
                    if (!Equals(SearchBoxVisibility, value))
                    {
                        SearchBoxVisibility = (MC.SearchBoxVisibility?)value;
                        NativeControl.SearchBoxVisibility = SearchBoxVisibility ?? (MC.SearchBoxVisibility)MC.SearchHandler.SearchBoxVisibilityProperty.DefaultValue;
                    }
                    break;
                case nameof(ShowsResults):
                    if (!Equals(ShowsResults, value))
                    {
                        ShowsResults = (bool?)value;
                        NativeControl.ShowsResults = ShowsResults ?? (bool)MC.SearchHandler.ShowsResultsProperty.DefaultValue;
                    }
                    break;
                case nameof(TextColor):
                    if (!Equals(TextColor, value))
                    {
                        TextColor = (Color)value;
                        NativeControl.TextColor = TextColor;
                    }
                    break;
                case nameof(TextTransform):
                    if (!Equals(TextTransform, value))
                    {
                        TextTransform = (TextTransform?)value;
                        NativeControl.TextTransform = TextTransform ?? (TextTransform)MC.SearchHandler.TextTransformProperty.DefaultValue;
                    }
                    break;
                case nameof(VerticalTextAlignment):
                    if (!Equals(VerticalTextAlignment, value))
                    {
                        VerticalTextAlignment = (TextAlignment?)value;
                        NativeControl.VerticalTextAlignment = VerticalTextAlignment ?? (TextAlignment)MC.SearchHandler.VerticalTextAlignmentProperty.DefaultValue;
                    }
                    break;
                case nameof(ItemTemplate):
                    ItemTemplate = (RenderFragment<T>)value;
                    break;
                case nameof(QueryChanged):
                    if (!Equals(QueryChanged, value))
                    {
                        void NativeControlPropertyChanged(object sender, PropertyChangedEventArgs e)
                        {
                            if (e.PropertyName == nameof(NativeControl.Query))
                            {
                                var value = NativeControl.Query;
                                Query = value;
                                InvokeAsync(() => QueryChanged.InvokeAsync(value));
                            }
                        }

                        QueryChanged = (EventCallback<string>)value;
                        NativeControl.PropertyChanged -= NativeControlPropertyChanged;
                        NativeControl.PropertyChanged += NativeControlPropertyChanged;
                    }
                    break;
                case nameof(SelectedItemChanged):
                    if (!Equals(SelectedItemChanged, value))
                    {
                        void NativeControlPropertyChanged(object sender, PropertyChangedEventArgs e)
                        {
                            if (e.PropertyName == nameof(NativeControl.SelectedItem))
                            {
                                var value = (T)NativeControl.SelectedItem;
                                SelectedItem = value;
                                InvokeAsync(() => SelectedItemChanged.InvokeAsync(value));
                            }
                        }

                        SelectedItemChanged = (EventCallback<T>)value;
                        NativeControl.PropertyChanged -= NativeControlPropertyChanged;
                        NativeControl.PropertyChanged += NativeControlPropertyChanged;
                    }
                    break;
                case nameof(OnFocused):
                    if (!Equals(OnFocused, value))
                    {
                        void NativeControlFocused(object sender, EventArgs e) => InvokeAsync(() => OnFocused.InvokeAsync(e));

                        OnFocused = (EventCallback)value;
                        NativeControl.Focused -= NativeControlFocused;
                        NativeControl.Focused += NativeControlFocused;
                    }
                    break;
                case nameof(OnUnfocused):
                    if (!Equals(OnUnfocused, value))
                    {
                        void NativeControlUnfocused(object sender, EventArgs e) => InvokeAsync(() => OnUnfocused.InvokeAsync(e));

                        OnUnfocused = (EventCallback)value;
                        NativeControl.Unfocused -= NativeControlUnfocused;
                        NativeControl.Unfocused += NativeControlUnfocused;
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
            RenderTreeBuilderHelper.AddDataTemplateProperty(builder, sequence++, typeof(SearchHandler<T>), ItemTemplate);
        }

        static partial void RegisterAdditionalHandlers();
    }
}
