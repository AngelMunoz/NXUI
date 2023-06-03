// <auto-generated />
namespace NXUI.FSharp.Extensions;

/// <summary>
/// The avalonia <see cref="Avalonia.Media.CombinedGeometry"/> class property extension methods.
/// </summary>
public static partial class CombinedGeometryExtensions
{
    // Avalonia.Media.CombinedGeometry.Geometry1Property

    /// <summary>
    /// Sets a <see cref="Avalonia.Media.CombinedGeometry.Geometry1Property"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T geometry1<T>(this T obj, Avalonia.Media.Geometry value) where T : Avalonia.Media.CombinedGeometry
    {
        obj[Avalonia.Media.CombinedGeometry.Geometry1Property] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Media.CombinedGeometry.Geometry1Property"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T geometry1<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Media.CombinedGeometry
    {
        var descriptor = Avalonia.Media.CombinedGeometry.Geometry1Property.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Media.CombinedGeometry.Geometry1Property"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T geometry1<T>(
        this T obj,
        IObservable<Avalonia.Media.Geometry> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Media.CombinedGeometry
    {
        var descriptor = Avalonia.Media.CombinedGeometry.Geometry1Property.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Media.CombinedGeometry.Geometry1Property"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Media.CombinedGeometry.Geometry1Property"/> binding.</returns>
    public static Avalonia.Data.IBinding BindGeometry1(
        this Avalonia.Media.CombinedGeometry obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.CombinedGeometry.Geometry1Property.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Media.CombinedGeometry.Geometry1Property"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<Avalonia.Media.Geometry> ObserveGeometry1(this Avalonia.Media.CombinedGeometry obj)
    {
        return obj.GetObservable(Avalonia.Media.CombinedGeometry.Geometry1Property);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Media.CombinedGeometry.Geometry1Property"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnGeometry1<T>(this T obj, Action<Avalonia.Media.CombinedGeometry, IObservable<Avalonia.Media.Geometry>> handler) where T : Avalonia.Media.CombinedGeometry
    {
        var observable = obj.GetObservable(Avalonia.Media.CombinedGeometry.Geometry1Property);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Media.CombinedGeometry.Geometry2Property

    /// <summary>
    /// Sets a <see cref="Avalonia.Media.CombinedGeometry.Geometry2Property"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T geometry2<T>(this T obj, Avalonia.Media.Geometry value) where T : Avalonia.Media.CombinedGeometry
    {
        obj[Avalonia.Media.CombinedGeometry.Geometry2Property] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Media.CombinedGeometry.Geometry2Property"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T geometry2<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Media.CombinedGeometry
    {
        var descriptor = Avalonia.Media.CombinedGeometry.Geometry2Property.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Media.CombinedGeometry.Geometry2Property"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T geometry2<T>(
        this T obj,
        IObservable<Avalonia.Media.Geometry> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Media.CombinedGeometry
    {
        var descriptor = Avalonia.Media.CombinedGeometry.Geometry2Property.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Media.CombinedGeometry.Geometry2Property"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Media.CombinedGeometry.Geometry2Property"/> binding.</returns>
    public static Avalonia.Data.IBinding BindGeometry2(
        this Avalonia.Media.CombinedGeometry obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.CombinedGeometry.Geometry2Property.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Media.CombinedGeometry.Geometry2Property"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<Avalonia.Media.Geometry> ObserveGeometry2(this Avalonia.Media.CombinedGeometry obj)
    {
        return obj.GetObservable(Avalonia.Media.CombinedGeometry.Geometry2Property);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Media.CombinedGeometry.Geometry2Property"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnGeometry2<T>(this T obj, Action<Avalonia.Media.CombinedGeometry, IObservable<Avalonia.Media.Geometry>> handler) where T : Avalonia.Media.CombinedGeometry
    {
        var observable = obj.GetObservable(Avalonia.Media.CombinedGeometry.Geometry2Property);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Media.CombinedGeometry.GeometryCombineModeProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Media.CombinedGeometry.GeometryCombineModeProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T geometryCombineMode<T>(this T obj, Avalonia.Media.GeometryCombineMode value) where T : Avalonia.Media.CombinedGeometry
    {
        obj[Avalonia.Media.CombinedGeometry.GeometryCombineModeProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Media.CombinedGeometry.GeometryCombineModeProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T geometryCombineMode<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Media.CombinedGeometry
    {
        var descriptor = Avalonia.Media.CombinedGeometry.GeometryCombineModeProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Media.CombinedGeometry.GeometryCombineModeProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T geometryCombineMode<T>(
        this T obj,
        IObservable<Avalonia.Media.GeometryCombineMode> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Media.CombinedGeometry
    {
        var descriptor = Avalonia.Media.CombinedGeometry.GeometryCombineModeProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Media.CombinedGeometry.GeometryCombineModeProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Media.CombinedGeometry.GeometryCombineModeProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindGeometryCombineMode(
        this Avalonia.Media.CombinedGeometry obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.CombinedGeometry.GeometryCombineModeProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Media.CombinedGeometry.GeometryCombineModeProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<Avalonia.Media.GeometryCombineMode> ObserveGeometryCombineMode(this Avalonia.Media.CombinedGeometry obj)
    {
        return obj.GetObservable(Avalonia.Media.CombinedGeometry.GeometryCombineModeProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Media.CombinedGeometry.GeometryCombineModeProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnGeometryCombineMode<T>(this T obj, Action<Avalonia.Media.CombinedGeometry, IObservable<Avalonia.Media.GeometryCombineMode>> handler) where T : Avalonia.Media.CombinedGeometry
    {
        var observable = obj.GetObservable(Avalonia.Media.CombinedGeometry.GeometryCombineModeProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Media.CombinedGeometry.GeometryCombineModeProperty"/> property value to <see cref="Avalonia.Media.GeometryCombineMode.Union"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T GeometryCombineModeUnion<T>(this T obj) where T : Avalonia.Media.CombinedGeometry
    {
        obj[Avalonia.Media.CombinedGeometry.GeometryCombineModeProperty] = Avalonia.Media.GeometryCombineMode.Union;
        return obj;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Media.CombinedGeometry.GeometryCombineModeProperty"/> property value to <see cref="Avalonia.Media.GeometryCombineMode.Intersect"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T GeometryCombineModeIntersect<T>(this T obj) where T : Avalonia.Media.CombinedGeometry
    {
        obj[Avalonia.Media.CombinedGeometry.GeometryCombineModeProperty] = Avalonia.Media.GeometryCombineMode.Intersect;
        return obj;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Media.CombinedGeometry.GeometryCombineModeProperty"/> property value to <see cref="Avalonia.Media.GeometryCombineMode.Xor"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T GeometryCombineModeXor<T>(this T obj) where T : Avalonia.Media.CombinedGeometry
    {
        obj[Avalonia.Media.CombinedGeometry.GeometryCombineModeProperty] = Avalonia.Media.GeometryCombineMode.Xor;
        return obj;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Media.CombinedGeometry.GeometryCombineModeProperty"/> property value to <see cref="Avalonia.Media.GeometryCombineMode.Exclude"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T GeometryCombineModeExclude<T>(this T obj) where T : Avalonia.Media.CombinedGeometry
    {
        obj[Avalonia.Media.CombinedGeometry.GeometryCombineModeProperty] = Avalonia.Media.GeometryCombineMode.Exclude;
        return obj;
    }
}
