// <auto-generated />
namespace MinimalAvalonia.Extensions;

public static partial class ProgressBarExtensions
{
    // IsIndeterminateProperty

    public static T IsIndeterminate<T>(this T obj, System.Boolean value) where T : Avalonia.Controls.ProgressBar
    {
        obj[Avalonia.Controls.ProgressBar.IsIndeterminateProperty] = value;
        return obj;
    }

    public static T IsIndeterminate<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.ProgressBar
    {
        obj[Avalonia.Controls.ProgressBar.IsIndeterminateProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T IsIndeterminate<T>(this T obj, IObservable<System.Boolean> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.ProgressBar
    {
        obj[Avalonia.Controls.ProgressBar.IsIndeterminateProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindIsIndeterminate(this Avalonia.Controls.ProgressBar obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.ProgressBar.IsIndeterminateProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Boolean> ObserveIsIndeterminate(this Avalonia.Controls.ProgressBar obj)
    {
        return obj.GetObservable(Avalonia.Controls.ProgressBar.IsIndeterminateProperty);
    }

    public static T OnIsIndeterminate<T>(this T obj, Action<IObservable<System.Boolean>> handler) where T : Avalonia.Controls.ProgressBar
    {
        var observable = obj.GetObservable(Avalonia.Controls.ProgressBar.IsIndeterminateProperty);
        handler(observable);
        return obj;
    }

    // ShowProgressTextProperty

    public static T ShowProgressText<T>(this T obj, System.Boolean value) where T : Avalonia.Controls.ProgressBar
    {
        obj[Avalonia.Controls.ProgressBar.ShowProgressTextProperty] = value;
        return obj;
    }

    public static T ShowProgressText<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.ProgressBar
    {
        obj[Avalonia.Controls.ProgressBar.ShowProgressTextProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T ShowProgressText<T>(this T obj, IObservable<System.Boolean> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.ProgressBar
    {
        obj[Avalonia.Controls.ProgressBar.ShowProgressTextProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindShowProgressText(this Avalonia.Controls.ProgressBar obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.ProgressBar.ShowProgressTextProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Boolean> ObserveShowProgressText(this Avalonia.Controls.ProgressBar obj)
    {
        return obj.GetObservable(Avalonia.Controls.ProgressBar.ShowProgressTextProperty);
    }

    public static T OnShowProgressText<T>(this T obj, Action<IObservable<System.Boolean>> handler) where T : Avalonia.Controls.ProgressBar
    {
        var observable = obj.GetObservable(Avalonia.Controls.ProgressBar.ShowProgressTextProperty);
        handler(observable);
        return obj;
    }

    // OrientationProperty

    public static T Orientation<T>(this T obj, Avalonia.Layout.Orientation value) where T : Avalonia.Controls.ProgressBar
    {
        obj[Avalonia.Controls.ProgressBar.OrientationProperty] = value;
        return obj;
    }

    public static T Orientation<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.ProgressBar
    {
        obj[Avalonia.Controls.ProgressBar.OrientationProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T Orientation<T>(this T obj, IObservable<Avalonia.Layout.Orientation> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.ProgressBar
    {
        obj[Avalonia.Controls.ProgressBar.OrientationProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindOrientation(this Avalonia.Controls.ProgressBar obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.ProgressBar.OrientationProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Layout.Orientation> ObserveOrientation(this Avalonia.Controls.ProgressBar obj)
    {
        return obj.GetObservable(Avalonia.Controls.ProgressBar.OrientationProperty);
    }

    public static T OnOrientation<T>(this T obj, Action<IObservable<Avalonia.Layout.Orientation>> handler) where T : Avalonia.Controls.ProgressBar
    {
        var observable = obj.GetObservable(Avalonia.Controls.ProgressBar.OrientationProperty);
        handler(observable);
        return obj;
    }

    public static T OrientationHorizontal<T>(this T obj) where T : Avalonia.Controls.ProgressBar
    {
        obj[Avalonia.Controls.ProgressBar.OrientationProperty] = Avalonia.Layout.Orientation.Horizontal;
        return obj;
    }

    public static T OrientationVertical<T>(this T obj) where T : Avalonia.Controls.ProgressBar
    {
        obj[Avalonia.Controls.ProgressBar.OrientationProperty] = Avalonia.Layout.Orientation.Vertical;
        return obj;
    }
}
