// <auto-generated />
namespace MinimalAvalonia.Extensions;

public static partial class LineGeometryExtensions
{
    // StartPointProperty

    public static T StartPoint<T>(this T obj, Avalonia.Point value) where T : Avalonia.Media.LineGeometry
    {
        obj[Avalonia.Media.LineGeometry.StartPointProperty] = value;
        return obj;
    }

    public static T StartPoint<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Media.LineGeometry
    {
        obj[Avalonia.Media.LineGeometry.StartPointProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T StartPoint<T>(this T obj, IObservable<Avalonia.Point> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Media.LineGeometry
    {
        obj[Avalonia.Media.LineGeometry.StartPointProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindStartPoint(this Avalonia.Media.LineGeometry obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Media.LineGeometry.StartPointProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Point> ObserveStartPoint(this Avalonia.Media.LineGeometry obj)
    {
        return obj.GetObservable(Avalonia.Media.LineGeometry.StartPointProperty);
    }

    // EndPointProperty

    public static T EndPoint<T>(this T obj, Avalonia.Point value) where T : Avalonia.Media.LineGeometry
    {
        obj[Avalonia.Media.LineGeometry.EndPointProperty] = value;
        return obj;
    }

    public static T EndPoint<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Media.LineGeometry
    {
        obj[Avalonia.Media.LineGeometry.EndPointProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T EndPoint<T>(this T obj, IObservable<Avalonia.Point> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Media.LineGeometry
    {
        obj[Avalonia.Media.LineGeometry.EndPointProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindEndPoint(this Avalonia.Media.LineGeometry obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Media.LineGeometry.EndPointProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Point> ObserveEndPoint(this Avalonia.Media.LineGeometry obj)
    {
        return obj.GetObservable(Avalonia.Media.LineGeometry.EndPointProperty);
    }
}