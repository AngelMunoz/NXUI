// <auto-generated />
namespace MinimalAvalonia.Extensions;

public static partial class PopupRootExtensions
{
    // TransformProperty

    public static Avalonia.Controls.Primitives.PopupRoot Transform(this Avalonia.Controls.Primitives.PopupRoot obj, Avalonia.Media.Transform value)
    {
        obj[Avalonia.Controls.Primitives.PopupRoot.TransformProperty] = value;
        return obj;
    }

    public static Avalonia.Controls.Primitives.PopupRoot Transform(this Avalonia.Controls.Primitives.PopupRoot obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        obj[Avalonia.Controls.Primitives.PopupRoot.TransformProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Controls.Primitives.PopupRoot Transform(this Avalonia.Controls.Primitives.PopupRoot obj, IObservable<Avalonia.Media.Transform> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        obj[Avalonia.Controls.Primitives.PopupRoot.TransformProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindTransform(this Avalonia.Controls.Primitives.PopupRoot obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Primitives.PopupRoot.TransformProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Media.Transform> ObserveTransform(this Avalonia.Controls.Primitives.PopupRoot obj)
    {
        return obj.GetObservable(Avalonia.Controls.Primitives.PopupRoot.TransformProperty);
    }

    public static Avalonia.Controls.Primitives.PopupRoot OnTransform(this Avalonia.Controls.Primitives.PopupRoot obj, Action<IObservable<Avalonia.Media.Transform>> handler)
    {
        var observable = obj.GetObservable(Avalonia.Controls.Primitives.PopupRoot.TransformProperty);
        handler(observable);
        return obj;
    }
}
