// <auto-generated />
namespace NXUI.FSharp.Extensions;

/// <summary>
/// The avalonia <see cref="Avalonia.Media.PolyLineSegment"/> class property extension methods.
/// </summary>
public static partial class PolyLineSegmentExtensions
{
    // Avalonia.Media.PolyLineSegment.PointsProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Media.PolyLineSegment.PointsProperty"/> value on an object of type <see cref="Avalonia.Media.PolyLineSegment"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value to set for the property.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Media.PolyLineSegment points(this Avalonia.Media.PolyLineSegment obj, System.Collections.Generic.IList<Avalonia.Point> value)
    {
        obj[Avalonia.Media.PolyLineSegment.PointsProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Media.PolyLineSegment.PointsProperty"/> on an object of type <see cref="Avalonia.Media.PolyLineSegment"/> with a source binding specified as a parameter.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Media.PolyLineSegment points(
        this Avalonia.Media.PolyLineSegment obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.PolyLineSegment.PointsProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Media.PolyLineSegment.PointsProperty"/> on an object of type <see cref="Avalonia.Media.PolyLineSegment"/> with a source binding specified as an observable.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Media.PolyLineSegment points(
        this Avalonia.Media.PolyLineSegment obj,
        IObservable<System.Collections.Generic.IList<Avalonia.Point>> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.PolyLineSegment.PointsProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Media.PolyLineSegment.PointsProperty"/> binding on an object of type <see cref="Avalonia.Media.PolyLineSegment"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Media.PolyLineSegment.PointsProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindPoints(
        this Avalonia.Media.PolyLineSegment obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.PolyLineSegment.PointsProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Media.PolyLineSegment.PointsProperty"/> on an object of type <see cref="Avalonia.Media.PolyLineSegment"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the object, and thereafter whenever the property changes.
    /// </returns>
    public static IObservable<System.Collections.Generic.IList<Avalonia.Point>> ObservePoints(this Avalonia.Media.PolyLineSegment obj)
    {
        return obj.GetObservable(Avalonia.Media.PolyLineSegment.PointsProperty);
    }

    /// <summary>
    /// Registers a handler for the <see cref="Avalonia.Media.PolyLineSegment.PointsProperty"/> property on an object of type <see cref="Avalonia.Media.PolyLineSegment"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler to be called when the property changes.</param>
    /// <returns>The target object.</returns>
    public static Avalonia.Media.PolyLineSegment OnPoints(this Avalonia.Media.PolyLineSegment obj, Action<Avalonia.Media.PolyLineSegment, IObservable<System.Collections.Generic.IList<Avalonia.Point>>> handler)
    {
        var observable = obj.GetObservable(Avalonia.Media.PolyLineSegment.PointsProperty);
        handler(obj, observable);
        return obj;
    }
}
