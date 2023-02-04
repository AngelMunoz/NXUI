// <auto-generated />
namespace NXUI.Extensions;

/// <summary>
/// The avalonia <see cref="Avalonia.Media.RadialGradientBrush"/> class property extension methods.
/// </summary>
public static partial class RadialGradientBrushExtensions
{
    // Avalonia.Media.RadialGradientBrush.CenterProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Media.RadialGradientBrush.CenterProperty"/> value on an object of type <see cref="Avalonia.Media.RadialGradientBrush"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value to set for the property.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Media.RadialGradientBrush Center(this Avalonia.Media.RadialGradientBrush obj, Avalonia.RelativePoint value)
    {
        obj[Avalonia.Media.RadialGradientBrush.CenterProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Media.RadialGradientBrush.CenterProperty"/> on an object of type <see cref="Avalonia.Media.RadialGradientBrush"/> with a source binding specified as a parameter.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Media.RadialGradientBrush Center(
        this Avalonia.Media.RadialGradientBrush obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.RadialGradientBrush.CenterProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Media.RadialGradientBrush.CenterProperty"/> on an object of type <see cref="Avalonia.Media.RadialGradientBrush"/> with a source binding specified as an observable.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Media.RadialGradientBrush Center(
        this Avalonia.Media.RadialGradientBrush obj,
        IObservable<Avalonia.RelativePoint> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.RadialGradientBrush.CenterProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Media.RadialGradientBrush.CenterProperty"/> binding on an object of type <see cref="Avalonia.Media.RadialGradientBrush"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Media.RadialGradientBrush.CenterProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindCenter(
        this Avalonia.Media.RadialGradientBrush obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.RadialGradientBrush.CenterProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Media.RadialGradientBrush.CenterProperty"/> on an object of type <see cref="Avalonia.Media.RadialGradientBrush"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the object, and thereafter whenever the property changes.
    /// </returns>
    public static IObservable<Avalonia.RelativePoint> ObserveCenter(this Avalonia.Media.RadialGradientBrush obj)
    {
        return obj.GetObservable(Avalonia.Media.RadialGradientBrush.CenterProperty);
    }

    /// <summary>
    /// Registers a handler for the <see cref="Avalonia.Media.RadialGradientBrush.CenterProperty"/> property on an object of type <see cref="Avalonia.Media.RadialGradientBrush"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler to be called when the property changes.</param>
    /// <returns>The target object.</returns>
    public static Avalonia.Media.RadialGradientBrush OnCenter(this Avalonia.Media.RadialGradientBrush obj, Action<Avalonia.Media.RadialGradientBrush, IObservable<Avalonia.RelativePoint>> handler)
    {
        var observable = obj.GetObservable(Avalonia.Media.RadialGradientBrush.CenterProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Media.RadialGradientBrush.GradientOriginProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Media.RadialGradientBrush.GradientOriginProperty"/> value on an object of type <see cref="Avalonia.Media.RadialGradientBrush"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value to set for the property.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Media.RadialGradientBrush GradientOrigin(this Avalonia.Media.RadialGradientBrush obj, Avalonia.RelativePoint value)
    {
        obj[Avalonia.Media.RadialGradientBrush.GradientOriginProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Media.RadialGradientBrush.GradientOriginProperty"/> on an object of type <see cref="Avalonia.Media.RadialGradientBrush"/> with a source binding specified as a parameter.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Media.RadialGradientBrush GradientOrigin(
        this Avalonia.Media.RadialGradientBrush obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.RadialGradientBrush.GradientOriginProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Media.RadialGradientBrush.GradientOriginProperty"/> on an object of type <see cref="Avalonia.Media.RadialGradientBrush"/> with a source binding specified as an observable.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Media.RadialGradientBrush GradientOrigin(
        this Avalonia.Media.RadialGradientBrush obj,
        IObservable<Avalonia.RelativePoint> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.RadialGradientBrush.GradientOriginProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Media.RadialGradientBrush.GradientOriginProperty"/> binding on an object of type <see cref="Avalonia.Media.RadialGradientBrush"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Media.RadialGradientBrush.GradientOriginProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindGradientOrigin(
        this Avalonia.Media.RadialGradientBrush obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.RadialGradientBrush.GradientOriginProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Media.RadialGradientBrush.GradientOriginProperty"/> on an object of type <see cref="Avalonia.Media.RadialGradientBrush"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the object, and thereafter whenever the property changes.
    /// </returns>
    public static IObservable<Avalonia.RelativePoint> ObserveGradientOrigin(this Avalonia.Media.RadialGradientBrush obj)
    {
        return obj.GetObservable(Avalonia.Media.RadialGradientBrush.GradientOriginProperty);
    }

    /// <summary>
    /// Registers a handler for the <see cref="Avalonia.Media.RadialGradientBrush.GradientOriginProperty"/> property on an object of type <see cref="Avalonia.Media.RadialGradientBrush"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler to be called when the property changes.</param>
    /// <returns>The target object.</returns>
    public static Avalonia.Media.RadialGradientBrush OnGradientOrigin(this Avalonia.Media.RadialGradientBrush obj, Action<Avalonia.Media.RadialGradientBrush, IObservable<Avalonia.RelativePoint>> handler)
    {
        var observable = obj.GetObservable(Avalonia.Media.RadialGradientBrush.GradientOriginProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Media.RadialGradientBrush.RadiusProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Media.RadialGradientBrush.RadiusProperty"/> value on an object of type <see cref="Avalonia.Media.RadialGradientBrush"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value to set for the property.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Media.RadialGradientBrush Radius(this Avalonia.Media.RadialGradientBrush obj, System.Double value)
    {
        obj[Avalonia.Media.RadialGradientBrush.RadiusProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Media.RadialGradientBrush.RadiusProperty"/> on an object of type <see cref="Avalonia.Media.RadialGradientBrush"/> with a source binding specified as a parameter.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Media.RadialGradientBrush Radius(
        this Avalonia.Media.RadialGradientBrush obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.RadialGradientBrush.RadiusProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Media.RadialGradientBrush.RadiusProperty"/> on an object of type <see cref="Avalonia.Media.RadialGradientBrush"/> with a source binding specified as an observable.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Media.RadialGradientBrush Radius(
        this Avalonia.Media.RadialGradientBrush obj,
        IObservable<System.Double> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.RadialGradientBrush.RadiusProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Media.RadialGradientBrush.RadiusProperty"/> binding on an object of type <see cref="Avalonia.Media.RadialGradientBrush"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Media.RadialGradientBrush.RadiusProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindRadius(
        this Avalonia.Media.RadialGradientBrush obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.RadialGradientBrush.RadiusProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Media.RadialGradientBrush.RadiusProperty"/> on an object of type <see cref="Avalonia.Media.RadialGradientBrush"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the object, and thereafter whenever the property changes.
    /// </returns>
    public static IObservable<System.Double> ObserveRadius(this Avalonia.Media.RadialGradientBrush obj)
    {
        return obj.GetObservable(Avalonia.Media.RadialGradientBrush.RadiusProperty);
    }

    /// <summary>
    /// Registers a handler for the <see cref="Avalonia.Media.RadialGradientBrush.RadiusProperty"/> property on an object of type <see cref="Avalonia.Media.RadialGradientBrush"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler to be called when the property changes.</param>
    /// <returns>The target object.</returns>
    public static Avalonia.Media.RadialGradientBrush OnRadius(this Avalonia.Media.RadialGradientBrush obj, Action<Avalonia.Media.RadialGradientBrush, IObservable<System.Double>> handler)
    {
        var observable = obj.GetObservable(Avalonia.Media.RadialGradientBrush.RadiusProperty);
        handler(obj, observable);
        return obj;
    }
}