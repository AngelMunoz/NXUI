// <auto-generated />
namespace NXUI.FSharp.Extensions;

/// <summary>
/// The avalonia <see cref="Avalonia.Media.PathGeometry"/> class property extension methods.
/// </summary>
public static partial class PathGeometryExtensions
{
    // Avalonia.Media.PathGeometry.FiguresProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Media.PathGeometry.FiguresProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T figures<T>(this T obj, Avalonia.Media.PathFigures value) where T : Avalonia.Media.PathGeometry
    {
        obj[Avalonia.Media.PathGeometry.FiguresProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Media.PathGeometry.FiguresProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T figures<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Media.PathGeometry
    {
        var descriptor = Avalonia.Media.PathGeometry.FiguresProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Media.PathGeometry.FiguresProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T figures<T>(
        this T obj,
        IObservable<Avalonia.Media.PathFigures> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Media.PathGeometry
    {
        var descriptor = Avalonia.Media.PathGeometry.FiguresProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Media.PathGeometry.FiguresProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Media.PathGeometry.FiguresProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindFigures(
        this Avalonia.Media.PathGeometry obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.PathGeometry.FiguresProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Media.PathGeometry.FiguresProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<Avalonia.Media.PathFigures> ObserveFigures(this Avalonia.Media.PathGeometry obj)
    {
        return obj.GetObservable(Avalonia.Media.PathGeometry.FiguresProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Media.PathGeometry.FiguresProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnFigures<T>(this T obj, Action<Avalonia.Media.PathGeometry, IObservable<Avalonia.Media.PathFigures>> handler) where T : Avalonia.Media.PathGeometry
    {
        var observable = obj.GetObservable(Avalonia.Media.PathGeometry.FiguresProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Media.PathGeometry.FillRuleProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Media.PathGeometry.FillRuleProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T fillRule<T>(this T obj, Avalonia.Media.FillRule value) where T : Avalonia.Media.PathGeometry
    {
        obj[Avalonia.Media.PathGeometry.FillRuleProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Media.PathGeometry.FillRuleProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T fillRule<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Media.PathGeometry
    {
        var descriptor = Avalonia.Media.PathGeometry.FillRuleProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Media.PathGeometry.FillRuleProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T fillRule<T>(
        this T obj,
        IObservable<Avalonia.Media.FillRule> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Media.PathGeometry
    {
        var descriptor = Avalonia.Media.PathGeometry.FillRuleProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Media.PathGeometry.FillRuleProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Media.PathGeometry.FillRuleProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindFillRule(
        this Avalonia.Media.PathGeometry obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.PathGeometry.FillRuleProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Media.PathGeometry.FillRuleProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<Avalonia.Media.FillRule> ObserveFillRule(this Avalonia.Media.PathGeometry obj)
    {
        return obj.GetObservable(Avalonia.Media.PathGeometry.FillRuleProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Media.PathGeometry.FillRuleProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnFillRule<T>(this T obj, Action<Avalonia.Media.PathGeometry, IObservable<Avalonia.Media.FillRule>> handler) where T : Avalonia.Media.PathGeometry
    {
        var observable = obj.GetObservable(Avalonia.Media.PathGeometry.FillRuleProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Media.PathGeometry.FillRuleProperty"/> property value to <see cref="Avalonia.Media.FillRule.EvenOdd"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T FillRuleEvenOdd<T>(this T obj) where T : Avalonia.Media.PathGeometry
    {
        obj[Avalonia.Media.PathGeometry.FillRuleProperty] = Avalonia.Media.FillRule.EvenOdd;
        return obj;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Media.PathGeometry.FillRuleProperty"/> property value to <see cref="Avalonia.Media.FillRule.NonZero"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T FillRuleNonZero<T>(this T obj) where T : Avalonia.Media.PathGeometry
    {
        obj[Avalonia.Media.PathGeometry.FillRuleProperty] = Avalonia.Media.FillRule.NonZero;
        return obj;
    }
}
