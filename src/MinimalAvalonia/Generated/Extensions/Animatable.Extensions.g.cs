// <auto-generated />
namespace MinimalAvalonia.Extensions;

public static partial class AnimatableExtensions
{
    // ClockProperty

    public static T Clock<T>(this T obj, Avalonia.Animation.IClock value) where T : Avalonia.Animation.Animatable
    {
        obj[Avalonia.Animation.Animatable.ClockProperty] = value;
        return obj;
    }

    public static T Clock<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Animation.Animatable
    {
        obj[Avalonia.Animation.Animatable.ClockProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T Clock<T>(this T obj, IObservable<Avalonia.Animation.IClock> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Animation.Animatable
    {
        obj[Avalonia.Animation.Animatable.ClockProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindClock(this Avalonia.Animation.Animatable obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Animation.Animatable.ClockProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Animation.IClock> ObserveClock(this Avalonia.Animation.Animatable obj)
    {
        return obj.GetObservable(Avalonia.Animation.Animatable.ClockProperty);
    }

    public static T OnClock<T>(this T obj, Action<IObservable<Avalonia.Animation.IClock>> handler) where T : Avalonia.Animation.Animatable
    {
        var observable = obj.GetObservable(Avalonia.Animation.Animatable.ClockProperty);
        handler(observable);
        return obj;
    }

    // TransitionsProperty

    public static T Transitions<T>(this T obj, Avalonia.Animation.Transitions value) where T : Avalonia.Animation.Animatable
    {
        obj[Avalonia.Animation.Animatable.TransitionsProperty] = value;
        return obj;
    }

    public static T Transitions<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Animation.Animatable
    {
        obj[Avalonia.Animation.Animatable.TransitionsProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T Transitions<T>(this T obj, IObservable<Avalonia.Animation.Transitions> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Animation.Animatable
    {
        obj[Avalonia.Animation.Animatable.TransitionsProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindTransitions(this Avalonia.Animation.Animatable obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Animation.Animatable.TransitionsProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Animation.Transitions> ObserveTransitions(this Avalonia.Animation.Animatable obj)
    {
        return obj.GetObservable(Avalonia.Animation.Animatable.TransitionsProperty);
    }

    public static T OnTransitions<T>(this T obj, Action<IObservable<Avalonia.Animation.Transitions>> handler) where T : Avalonia.Animation.Animatable
    {
        var observable = obj.GetObservable(Avalonia.Animation.Animatable.TransitionsProperty);
        handler(observable);
        return obj;
    }
}