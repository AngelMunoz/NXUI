// <auto-generated />
namespace MinimalAvalonia.Extensions;

public static partial class SpinnerExtensions
{
    // ValidSpinDirectionProperty

    public static T ValidSpinDirection<T>(this T obj, Avalonia.Controls.ValidSpinDirections value) where T : Avalonia.Controls.Spinner
    {
        obj[Avalonia.Controls.Spinner.ValidSpinDirectionProperty] = value;
        return obj;
    }

    public static T ValidSpinDirection<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Spinner
    {
        obj[Avalonia.Controls.Spinner.ValidSpinDirectionProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T ValidSpinDirection<T>(this T obj, IObservable<Avalonia.Controls.ValidSpinDirections> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Spinner
    {
        obj[Avalonia.Controls.Spinner.ValidSpinDirectionProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindValidSpinDirection(this Avalonia.Controls.Spinner obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Spinner.ValidSpinDirectionProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Controls.ValidSpinDirections> ObserveValidSpinDirection(this Avalonia.Controls.Spinner obj)
    {
        return obj.GetObservable(Avalonia.Controls.Spinner.ValidSpinDirectionProperty);
    }

    public static T OnValidSpinDirection<T>(this T obj, Action<Avalonia.Controls.Spinner, IObservable<Avalonia.Controls.ValidSpinDirections>> handler) where T : Avalonia.Controls.Spinner
    {
        var observable = obj.GetObservable(Avalonia.Controls.Spinner.ValidSpinDirectionProperty);
        handler(obj, observable);
        return obj;
    }

    public static T ValidSpinDirectionNone<T>(this T obj) where T : Avalonia.Controls.Spinner
    {
        obj[Avalonia.Controls.Spinner.ValidSpinDirectionProperty] = Avalonia.Controls.ValidSpinDirections.None;
        return obj;
    }

    public static T ValidSpinDirectionIncrease<T>(this T obj) where T : Avalonia.Controls.Spinner
    {
        obj[Avalonia.Controls.Spinner.ValidSpinDirectionProperty] = Avalonia.Controls.ValidSpinDirections.Increase;
        return obj;
    }

    public static T ValidSpinDirectionDecrease<T>(this T obj) where T : Avalonia.Controls.Spinner
    {
        obj[Avalonia.Controls.Spinner.ValidSpinDirectionProperty] = Avalonia.Controls.ValidSpinDirections.Decrease;
        return obj;
    }

    // SpinEvent

    public static Avalonia.Controls.Spinner OnSpinHandler(this Avalonia.Controls.Spinner obj, Action<Avalonia.Controls.Spinner, Avalonia.Controls.SpinEventArgs> action, Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Bubble)
    {
        obj.AddHandler(Avalonia.Controls.Spinner.SpinEvent, (_, args) => action(obj, args), routes);
        return obj;
    }

    public static Avalonia.Controls.Spinner OnSpin(this Avalonia.Controls.Spinner obj, Action<Avalonia.Controls.Spinner, IObservable<Avalonia.Controls.SpinEventArgs>> handler,  Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Bubble)
    {
        var observable = obj.GetObservable(Avalonia.Controls.Spinner.SpinEvent, routes);
        handler(obj, observable);
        return obj;
    }

    public static IObservable<Avalonia.Controls.SpinEventArgs> ObserveOnSpin(this Avalonia.Controls.Spinner obj)
    {
        return Observable
            .FromEventPattern<EventHandler<Avalonia.Controls.SpinEventArgs>, Avalonia.Controls.SpinEventArgs>(
                h => obj.Spin += h, 
                h => obj.Spin -= h)
            .Select(x => x.EventArgs);
    }
}
