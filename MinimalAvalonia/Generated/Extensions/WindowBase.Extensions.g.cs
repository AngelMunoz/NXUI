// <auto-generated />
namespace MinimalAvalonia.Extensions;

public static partial class WindowBaseExtensions
{
    // IsActiveProperty

    public static Avalonia.Data.IBinding BindIsActive(this Avalonia.Controls.WindowBase obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.OneWay)
    {
        return obj[Avalonia.Controls.WindowBase.IsActiveProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Boolean> ObserveIsActive(this Avalonia.Controls.WindowBase obj)
    {
        return obj.GetObservable(Avalonia.Controls.WindowBase.IsActiveProperty);
    }

    public static Avalonia.Controls.WindowBase OnIsActive(this Avalonia.Controls.WindowBase obj, Action<IObservable<System.Boolean>> handler)
    {
        var observable = obj.GetObservable(Avalonia.Controls.WindowBase.IsActiveProperty);
        handler(observable);
        return obj;
    }

    // OwnerProperty

    public static T Owner<T>(this T obj, Avalonia.Controls.WindowBase value) where T : Avalonia.Controls.WindowBase
    {
        obj[Avalonia.Controls.WindowBase.OwnerProperty] = value;
        return obj;
    }

    public static T Owner<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.WindowBase
    {
        obj[Avalonia.Controls.WindowBase.OwnerProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T Owner<T>(this T obj, IObservable<Avalonia.Controls.WindowBase> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.WindowBase
    {
        obj[Avalonia.Controls.WindowBase.OwnerProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindOwner(this Avalonia.Controls.WindowBase obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.WindowBase.OwnerProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Controls.WindowBase> ObserveOwner(this Avalonia.Controls.WindowBase obj)
    {
        return obj.GetObservable(Avalonia.Controls.WindowBase.OwnerProperty);
    }

    public static T OnOwner<T>(this T obj, Action<IObservable<Avalonia.Controls.WindowBase>> handler) where T : Avalonia.Controls.WindowBase
    {
        var observable = obj.GetObservable(Avalonia.Controls.WindowBase.OwnerProperty);
        handler(observable);
        return obj;
    }

    // TopmostProperty

    public static T Topmost<T>(this T obj, System.Boolean value) where T : Avalonia.Controls.WindowBase
    {
        obj[Avalonia.Controls.WindowBase.TopmostProperty] = value;
        return obj;
    }

    public static T Topmost<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.WindowBase
    {
        obj[Avalonia.Controls.WindowBase.TopmostProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T Topmost<T>(this T obj, IObservable<System.Boolean> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.WindowBase
    {
        obj[Avalonia.Controls.WindowBase.TopmostProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindTopmost(this Avalonia.Controls.WindowBase obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.WindowBase.TopmostProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Boolean> ObserveTopmost(this Avalonia.Controls.WindowBase obj)
    {
        return obj.GetObservable(Avalonia.Controls.WindowBase.TopmostProperty);
    }

    public static T OnTopmost<T>(this T obj, Action<IObservable<System.Boolean>> handler) where T : Avalonia.Controls.WindowBase
    {
        var observable = obj.GetObservable(Avalonia.Controls.WindowBase.TopmostProperty);
        handler(observable);
        return obj;
    }
}
