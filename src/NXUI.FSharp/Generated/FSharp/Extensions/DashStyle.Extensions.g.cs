// <auto-generated />
namespace NXUI.FSharp.Extensions;

/// <summary>
/// The avalonia <see cref="Avalonia.Media.DashStyle"/> class property extension methods.
/// </summary>
public static partial class DashStyleExtensions
{
    // Avalonia.Media.DashStyle.DashesProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Media.DashStyle.DashesProperty"/> value on an object of type <see cref="Avalonia.Media.DashStyle"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value to set for the property.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Media.DashStyle dashes(this Avalonia.Media.DashStyle obj, Avalonia.Collections.AvaloniaList<System.Double> value)
    {
        obj[Avalonia.Media.DashStyle.DashesProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Media.DashStyle.DashesProperty"/> on an object of type <see cref="Avalonia.Media.DashStyle"/> with a source binding specified as a parameter.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Media.DashStyle dashes(
        this Avalonia.Media.DashStyle obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.DashStyle.DashesProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Media.DashStyle.DashesProperty"/> on an object of type <see cref="Avalonia.Media.DashStyle"/> with a source binding specified as an observable.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Media.DashStyle dashes(
        this Avalonia.Media.DashStyle obj,
        IObservable<Avalonia.Collections.AvaloniaList<System.Double>> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.DashStyle.DashesProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Media.DashStyle.DashesProperty"/> binding on an object of type <see cref="Avalonia.Media.DashStyle"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Media.DashStyle.DashesProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindDashes(
        this Avalonia.Media.DashStyle obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.DashStyle.DashesProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Media.DashStyle.DashesProperty"/> on an object of type <see cref="Avalonia.Media.DashStyle"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the object, and thereafter whenever the property changes.
    /// </returns>
    public static IObservable<Avalonia.Collections.AvaloniaList<System.Double>> ObserveDashes(this Avalonia.Media.DashStyle obj)
    {
        return obj.GetObservable(Avalonia.Media.DashStyle.DashesProperty);
    }

    /// <summary>
    /// Registers a handler for the <see cref="Avalonia.Media.DashStyle.DashesProperty"/> property on an object of type <see cref="Avalonia.Media.DashStyle"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler to be called when the property changes.</param>
    /// <returns>The target object.</returns>
    public static Avalonia.Media.DashStyle OnDashes(this Avalonia.Media.DashStyle obj, Action<Avalonia.Media.DashStyle, IObservable<Avalonia.Collections.AvaloniaList<System.Double>>> handler)
    {
        var observable = obj.GetObservable(Avalonia.Media.DashStyle.DashesProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Media.DashStyle.OffsetProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Media.DashStyle.OffsetProperty"/> value on an object of type <see cref="Avalonia.Media.DashStyle"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value to set for the property.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Media.DashStyle offset(this Avalonia.Media.DashStyle obj, System.Double value)
    {
        obj[Avalonia.Media.DashStyle.OffsetProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Media.DashStyle.OffsetProperty"/> on an object of type <see cref="Avalonia.Media.DashStyle"/> with a source binding specified as a parameter.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Media.DashStyle offset(
        this Avalonia.Media.DashStyle obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.DashStyle.OffsetProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Media.DashStyle.OffsetProperty"/> on an object of type <see cref="Avalonia.Media.DashStyle"/> with a source binding specified as an observable.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Media.DashStyle offset(
        this Avalonia.Media.DashStyle obj,
        IObservable<System.Double> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.DashStyle.OffsetProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Media.DashStyle.OffsetProperty"/> binding on an object of type <see cref="Avalonia.Media.DashStyle"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Media.DashStyle.OffsetProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindOffset(
        this Avalonia.Media.DashStyle obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.DashStyle.OffsetProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Media.DashStyle.OffsetProperty"/> on an object of type <see cref="Avalonia.Media.DashStyle"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the object, and thereafter whenever the property changes.
    /// </returns>
    public static IObservable<System.Double> ObserveOffset(this Avalonia.Media.DashStyle obj)
    {
        return obj.GetObservable(Avalonia.Media.DashStyle.OffsetProperty);
    }

    /// <summary>
    /// Registers a handler for the <see cref="Avalonia.Media.DashStyle.OffsetProperty"/> property on an object of type <see cref="Avalonia.Media.DashStyle"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler to be called when the property changes.</param>
    /// <returns>The target object.</returns>
    public static Avalonia.Media.DashStyle OnOffset(this Avalonia.Media.DashStyle obj, Action<Avalonia.Media.DashStyle, IObservable<System.Double>> handler)
    {
        var observable = obj.GetObservable(Avalonia.Media.DashStyle.OffsetProperty);
        handler(obj, observable);
        return obj;
    }
}
