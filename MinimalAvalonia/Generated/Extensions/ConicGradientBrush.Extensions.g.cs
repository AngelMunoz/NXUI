// <auto-generated />
namespace MinimalAvalonia.Extensions;

public static partial class ConicGradientBrushExtensions
{
    // CenterProperty

    public static Avalonia.Media.ConicGradientBrush Center(this Avalonia.Media.ConicGradientBrush obj, Avalonia.RelativePoint value)
    {
        obj[Avalonia.Media.ConicGradientBrush.CenterProperty] = value;
        return obj;
    }

    public static Avalonia.Media.ConicGradientBrush Center(this Avalonia.Media.ConicGradientBrush obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        obj[Avalonia.Media.ConicGradientBrush.CenterProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Media.ConicGradientBrush Center(this Avalonia.Media.ConicGradientBrush obj, IObservable<Avalonia.RelativePoint> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        obj[Avalonia.Media.ConicGradientBrush.CenterProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindCenter(this Avalonia.Media.ConicGradientBrush obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Media.ConicGradientBrush.CenterProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.RelativePoint> ObserveCenter(this Avalonia.Media.ConicGradientBrush obj)
    {
        return obj.GetObservable(Avalonia.Media.ConicGradientBrush.CenterProperty);
    }

    public static Avalonia.Media.ConicGradientBrush OnCenter(this Avalonia.Media.ConicGradientBrush obj, Action<IObservable<Avalonia.RelativePoint>> handler)
    {
        var observable = obj.GetObservable(Avalonia.Media.ConicGradientBrush.CenterProperty);
        handler(observable);
        return obj;
    }

    // AngleProperty

    public static Avalonia.Media.ConicGradientBrush Angle(this Avalonia.Media.ConicGradientBrush obj, System.Double value)
    {
        obj[Avalonia.Media.ConicGradientBrush.AngleProperty] = value;
        return obj;
    }

    public static Avalonia.Media.ConicGradientBrush Angle(this Avalonia.Media.ConicGradientBrush obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        obj[Avalonia.Media.ConicGradientBrush.AngleProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Media.ConicGradientBrush Angle(this Avalonia.Media.ConicGradientBrush obj, IObservable<System.Double> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        obj[Avalonia.Media.ConicGradientBrush.AngleProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindAngle(this Avalonia.Media.ConicGradientBrush obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Media.ConicGradientBrush.AngleProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Double> ObserveAngle(this Avalonia.Media.ConicGradientBrush obj)
    {
        return obj.GetObservable(Avalonia.Media.ConicGradientBrush.AngleProperty);
    }

    public static Avalonia.Media.ConicGradientBrush OnAngle(this Avalonia.Media.ConicGradientBrush obj, Action<IObservable<System.Double>> handler)
    {
        var observable = obj.GetObservable(Avalonia.Media.ConicGradientBrush.AngleProperty);
        handler(observable);
        return obj;
    }
}
