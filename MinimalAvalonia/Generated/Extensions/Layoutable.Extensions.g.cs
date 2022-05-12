// <auto-generated />
namespace MinimalAvalonia.Extensions;

public static partial class LayoutableExtensions
{
    // DesiredSizeProperty

    public static Avalonia.Data.IBinding BindDesiredSize(this Avalonia.Layout.Layoutable obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.OneWay)
    {
        return obj[Avalonia.Layout.Layoutable.DesiredSizeProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Size> ObserveDesiredSize(this Avalonia.Layout.Layoutable obj)
    {
        return obj.GetObservable(Avalonia.Layout.Layoutable.DesiredSizeProperty);
    }

    public static Avalonia.Layout.Layoutable OnDesiredSize(this Avalonia.Layout.Layoutable obj, Action<IObservable<Avalonia.Size>> handler)
    {
        var observable = obj.GetObservable(Avalonia.Layout.Layoutable.DesiredSizeProperty);
        handler(observable);
        return obj;
    }

    // WidthProperty

    public static T Width<T>(this T obj, System.Double value) where T : Avalonia.Layout.Layoutable
    {
        obj[Avalonia.Layout.Layoutable.WidthProperty] = value;
        return obj;
    }

    public static T Width<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Layout.Layoutable
    {
        obj[Avalonia.Layout.Layoutable.WidthProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T Width<T>(this T obj, IObservable<System.Double> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Layout.Layoutable
    {
        obj[Avalonia.Layout.Layoutable.WidthProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindWidth(this Avalonia.Layout.Layoutable obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Layout.Layoutable.WidthProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Double> ObserveWidth(this Avalonia.Layout.Layoutable obj)
    {
        return obj.GetObservable(Avalonia.Layout.Layoutable.WidthProperty);
    }

    public static T OnWidth<T>(this T obj, Action<IObservable<System.Double>> handler) where T : Avalonia.Layout.Layoutable
    {
        var observable = obj.GetObservable(Avalonia.Layout.Layoutable.WidthProperty);
        handler(observable);
        return obj;
    }

    // HeightProperty

    public static T Height<T>(this T obj, System.Double value) where T : Avalonia.Layout.Layoutable
    {
        obj[Avalonia.Layout.Layoutable.HeightProperty] = value;
        return obj;
    }

    public static T Height<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Layout.Layoutable
    {
        obj[Avalonia.Layout.Layoutable.HeightProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T Height<T>(this T obj, IObservable<System.Double> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Layout.Layoutable
    {
        obj[Avalonia.Layout.Layoutable.HeightProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindHeight(this Avalonia.Layout.Layoutable obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Layout.Layoutable.HeightProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Double> ObserveHeight(this Avalonia.Layout.Layoutable obj)
    {
        return obj.GetObservable(Avalonia.Layout.Layoutable.HeightProperty);
    }

    public static T OnHeight<T>(this T obj, Action<IObservable<System.Double>> handler) where T : Avalonia.Layout.Layoutable
    {
        var observable = obj.GetObservable(Avalonia.Layout.Layoutable.HeightProperty);
        handler(observable);
        return obj;
    }

    // MinWidthProperty

    public static T MinWidth<T>(this T obj, System.Double value) where T : Avalonia.Layout.Layoutable
    {
        obj[Avalonia.Layout.Layoutable.MinWidthProperty] = value;
        return obj;
    }

    public static T MinWidth<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Layout.Layoutable
    {
        obj[Avalonia.Layout.Layoutable.MinWidthProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T MinWidth<T>(this T obj, IObservable<System.Double> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Layout.Layoutable
    {
        obj[Avalonia.Layout.Layoutable.MinWidthProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindMinWidth(this Avalonia.Layout.Layoutable obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Layout.Layoutable.MinWidthProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Double> ObserveMinWidth(this Avalonia.Layout.Layoutable obj)
    {
        return obj.GetObservable(Avalonia.Layout.Layoutable.MinWidthProperty);
    }

    public static T OnMinWidth<T>(this T obj, Action<IObservable<System.Double>> handler) where T : Avalonia.Layout.Layoutable
    {
        var observable = obj.GetObservable(Avalonia.Layout.Layoutable.MinWidthProperty);
        handler(observable);
        return obj;
    }

    // MaxWidthProperty

    public static T MaxWidth<T>(this T obj, System.Double value) where T : Avalonia.Layout.Layoutable
    {
        obj[Avalonia.Layout.Layoutable.MaxWidthProperty] = value;
        return obj;
    }

    public static T MaxWidth<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Layout.Layoutable
    {
        obj[Avalonia.Layout.Layoutable.MaxWidthProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T MaxWidth<T>(this T obj, IObservable<System.Double> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Layout.Layoutable
    {
        obj[Avalonia.Layout.Layoutable.MaxWidthProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindMaxWidth(this Avalonia.Layout.Layoutable obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Layout.Layoutable.MaxWidthProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Double> ObserveMaxWidth(this Avalonia.Layout.Layoutable obj)
    {
        return obj.GetObservable(Avalonia.Layout.Layoutable.MaxWidthProperty);
    }

    public static T OnMaxWidth<T>(this T obj, Action<IObservable<System.Double>> handler) where T : Avalonia.Layout.Layoutable
    {
        var observable = obj.GetObservable(Avalonia.Layout.Layoutable.MaxWidthProperty);
        handler(observable);
        return obj;
    }

    // MinHeightProperty

    public static T MinHeight<T>(this T obj, System.Double value) where T : Avalonia.Layout.Layoutable
    {
        obj[Avalonia.Layout.Layoutable.MinHeightProperty] = value;
        return obj;
    }

    public static T MinHeight<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Layout.Layoutable
    {
        obj[Avalonia.Layout.Layoutable.MinHeightProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T MinHeight<T>(this T obj, IObservable<System.Double> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Layout.Layoutable
    {
        obj[Avalonia.Layout.Layoutable.MinHeightProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindMinHeight(this Avalonia.Layout.Layoutable obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Layout.Layoutable.MinHeightProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Double> ObserveMinHeight(this Avalonia.Layout.Layoutable obj)
    {
        return obj.GetObservable(Avalonia.Layout.Layoutable.MinHeightProperty);
    }

    public static T OnMinHeight<T>(this T obj, Action<IObservable<System.Double>> handler) where T : Avalonia.Layout.Layoutable
    {
        var observable = obj.GetObservable(Avalonia.Layout.Layoutable.MinHeightProperty);
        handler(observable);
        return obj;
    }

    // MaxHeightProperty

    public static T MaxHeight<T>(this T obj, System.Double value) where T : Avalonia.Layout.Layoutable
    {
        obj[Avalonia.Layout.Layoutable.MaxHeightProperty] = value;
        return obj;
    }

    public static T MaxHeight<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Layout.Layoutable
    {
        obj[Avalonia.Layout.Layoutable.MaxHeightProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T MaxHeight<T>(this T obj, IObservable<System.Double> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Layout.Layoutable
    {
        obj[Avalonia.Layout.Layoutable.MaxHeightProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindMaxHeight(this Avalonia.Layout.Layoutable obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Layout.Layoutable.MaxHeightProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Double> ObserveMaxHeight(this Avalonia.Layout.Layoutable obj)
    {
        return obj.GetObservable(Avalonia.Layout.Layoutable.MaxHeightProperty);
    }

    public static T OnMaxHeight<T>(this T obj, Action<IObservable<System.Double>> handler) where T : Avalonia.Layout.Layoutable
    {
        var observable = obj.GetObservable(Avalonia.Layout.Layoutable.MaxHeightProperty);
        handler(observable);
        return obj;
    }

    // MarginProperty

    public static T Margin<T>(this T obj, Avalonia.Thickness value) where T : Avalonia.Layout.Layoutable
    {
        obj[Avalonia.Layout.Layoutable.MarginProperty] = value;
        return obj;
    }

    public static T Margin<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Layout.Layoutable
    {
        obj[Avalonia.Layout.Layoutable.MarginProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T Margin<T>(this T obj, IObservable<Avalonia.Thickness> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Layout.Layoutable
    {
        obj[Avalonia.Layout.Layoutable.MarginProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindMargin(this Avalonia.Layout.Layoutable obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Layout.Layoutable.MarginProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Thickness> ObserveMargin(this Avalonia.Layout.Layoutable obj)
    {
        return obj.GetObservable(Avalonia.Layout.Layoutable.MarginProperty);
    }

    public static T OnMargin<T>(this T obj, Action<IObservable<Avalonia.Thickness>> handler) where T : Avalonia.Layout.Layoutable
    {
        var observable = obj.GetObservable(Avalonia.Layout.Layoutable.MarginProperty);
        handler(observable);
        return obj;
    }

    // HorizontalAlignmentProperty

    public static T HorizontalAlignment<T>(this T obj, Avalonia.Layout.HorizontalAlignment value) where T : Avalonia.Layout.Layoutable
    {
        obj[Avalonia.Layout.Layoutable.HorizontalAlignmentProperty] = value;
        return obj;
    }

    public static T HorizontalAlignment<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Layout.Layoutable
    {
        obj[Avalonia.Layout.Layoutable.HorizontalAlignmentProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T HorizontalAlignment<T>(this T obj, IObservable<Avalonia.Layout.HorizontalAlignment> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Layout.Layoutable
    {
        obj[Avalonia.Layout.Layoutable.HorizontalAlignmentProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindHorizontalAlignment(this Avalonia.Layout.Layoutable obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Layout.Layoutable.HorizontalAlignmentProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Layout.HorizontalAlignment> ObserveHorizontalAlignment(this Avalonia.Layout.Layoutable obj)
    {
        return obj.GetObservable(Avalonia.Layout.Layoutable.HorizontalAlignmentProperty);
    }

    public static T OnHorizontalAlignment<T>(this T obj, Action<IObservable<Avalonia.Layout.HorizontalAlignment>> handler) where T : Avalonia.Layout.Layoutable
    {
        var observable = obj.GetObservable(Avalonia.Layout.Layoutable.HorizontalAlignmentProperty);
        handler(observable);
        return obj;
    }

    public static T HorizontalAlignmentStretch<T>(this T obj) where T : Avalonia.Layout.Layoutable
    {
        obj[Avalonia.Layout.Layoutable.HorizontalAlignmentProperty] = Avalonia.Layout.HorizontalAlignment.Stretch;
        return obj;
    }

    public static T HorizontalAlignmentLeft<T>(this T obj) where T : Avalonia.Layout.Layoutable
    {
        obj[Avalonia.Layout.Layoutable.HorizontalAlignmentProperty] = Avalonia.Layout.HorizontalAlignment.Left;
        return obj;
    }

    public static T HorizontalAlignmentCenter<T>(this T obj) where T : Avalonia.Layout.Layoutable
    {
        obj[Avalonia.Layout.Layoutable.HorizontalAlignmentProperty] = Avalonia.Layout.HorizontalAlignment.Center;
        return obj;
    }

    public static T HorizontalAlignmentRight<T>(this T obj) where T : Avalonia.Layout.Layoutable
    {
        obj[Avalonia.Layout.Layoutable.HorizontalAlignmentProperty] = Avalonia.Layout.HorizontalAlignment.Right;
        return obj;
    }

    // VerticalAlignmentProperty

    public static T VerticalAlignment<T>(this T obj, Avalonia.Layout.VerticalAlignment value) where T : Avalonia.Layout.Layoutable
    {
        obj[Avalonia.Layout.Layoutable.VerticalAlignmentProperty] = value;
        return obj;
    }

    public static T VerticalAlignment<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Layout.Layoutable
    {
        obj[Avalonia.Layout.Layoutable.VerticalAlignmentProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T VerticalAlignment<T>(this T obj, IObservable<Avalonia.Layout.VerticalAlignment> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Layout.Layoutable
    {
        obj[Avalonia.Layout.Layoutable.VerticalAlignmentProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindVerticalAlignment(this Avalonia.Layout.Layoutable obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Layout.Layoutable.VerticalAlignmentProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Layout.VerticalAlignment> ObserveVerticalAlignment(this Avalonia.Layout.Layoutable obj)
    {
        return obj.GetObservable(Avalonia.Layout.Layoutable.VerticalAlignmentProperty);
    }

    public static T OnVerticalAlignment<T>(this T obj, Action<IObservable<Avalonia.Layout.VerticalAlignment>> handler) where T : Avalonia.Layout.Layoutable
    {
        var observable = obj.GetObservable(Avalonia.Layout.Layoutable.VerticalAlignmentProperty);
        handler(observable);
        return obj;
    }

    public static T VerticalAlignmentStretch<T>(this T obj) where T : Avalonia.Layout.Layoutable
    {
        obj[Avalonia.Layout.Layoutable.VerticalAlignmentProperty] = Avalonia.Layout.VerticalAlignment.Stretch;
        return obj;
    }

    public static T VerticalAlignmentTop<T>(this T obj) where T : Avalonia.Layout.Layoutable
    {
        obj[Avalonia.Layout.Layoutable.VerticalAlignmentProperty] = Avalonia.Layout.VerticalAlignment.Top;
        return obj;
    }

    public static T VerticalAlignmentCenter<T>(this T obj) where T : Avalonia.Layout.Layoutable
    {
        obj[Avalonia.Layout.Layoutable.VerticalAlignmentProperty] = Avalonia.Layout.VerticalAlignment.Center;
        return obj;
    }

    public static T VerticalAlignmentBottom<T>(this T obj) where T : Avalonia.Layout.Layoutable
    {
        obj[Avalonia.Layout.Layoutable.VerticalAlignmentProperty] = Avalonia.Layout.VerticalAlignment.Bottom;
        return obj;
    }

    // UseLayoutRoundingProperty

    public static T UseLayoutRounding<T>(this T obj, System.Boolean value) where T : Avalonia.Layout.Layoutable
    {
        obj[Avalonia.Layout.Layoutable.UseLayoutRoundingProperty] = value;
        return obj;
    }

    public static T UseLayoutRounding<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Layout.Layoutable
    {
        obj[Avalonia.Layout.Layoutable.UseLayoutRoundingProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T UseLayoutRounding<T>(this T obj, IObservable<System.Boolean> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Layout.Layoutable
    {
        obj[Avalonia.Layout.Layoutable.UseLayoutRoundingProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindUseLayoutRounding(this Avalonia.Layout.Layoutable obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Layout.Layoutable.UseLayoutRoundingProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Boolean> ObserveUseLayoutRounding(this Avalonia.Layout.Layoutable obj)
    {
        return obj.GetObservable(Avalonia.Layout.Layoutable.UseLayoutRoundingProperty);
    }

    public static T OnUseLayoutRounding<T>(this T obj, Action<IObservable<System.Boolean>> handler) where T : Avalonia.Layout.Layoutable
    {
        var observable = obj.GetObservable(Avalonia.Layout.Layoutable.UseLayoutRoundingProperty);
        handler(observable);
        return obj;
    }
}
