// <auto-generated />
namespace NXUI.FSharp.Extensions;

/// <summary>
/// The avalonia <see cref="Avalonia.Controls.Border"/> class property extension methods.
/// </summary>
public static partial class BorderExtensions
{
    // Avalonia.Controls.Border.BackgroundProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Border.BackgroundProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T background<T>(this T obj, Avalonia.Media.IBrush value) where T : Avalonia.Controls.Border
    {
        obj[Avalonia.Controls.Border.BackgroundProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Border.BackgroundProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T background<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Border
    {
        var descriptor = Avalonia.Controls.Border.BackgroundProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Border.BackgroundProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T background<T>(
        this T obj,
        IObservable<Avalonia.Media.IBrush> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Border
    {
        var descriptor = Avalonia.Controls.Border.BackgroundProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.Border.BackgroundProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.Border.BackgroundProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindBackground(
        this Avalonia.Controls.Border obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.Border.BackgroundProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.Border.BackgroundProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<Avalonia.Media.IBrush> ObserveBackground(this Avalonia.Controls.Border obj)
    {
        return obj.GetObservable(Avalonia.Controls.Border.BackgroundProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.Border.BackgroundProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnBackground<T>(this T obj, Action<Avalonia.Controls.Border, IObservable<Avalonia.Media.IBrush>> handler) where T : Avalonia.Controls.Border
    {
        var observable = obj.GetObservable(Avalonia.Controls.Border.BackgroundProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.Border.BackgroundSizingProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Border.BackgroundSizingProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T backgroundSizing<T>(this T obj, Avalonia.Media.BackgroundSizing value) where T : Avalonia.Controls.Border
    {
        obj[Avalonia.Controls.Border.BackgroundSizingProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Border.BackgroundSizingProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T backgroundSizing<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Border
    {
        var descriptor = Avalonia.Controls.Border.BackgroundSizingProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Border.BackgroundSizingProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T backgroundSizing<T>(
        this T obj,
        IObservable<Avalonia.Media.BackgroundSizing> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Border
    {
        var descriptor = Avalonia.Controls.Border.BackgroundSizingProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.Border.BackgroundSizingProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.Border.BackgroundSizingProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindBackgroundSizing(
        this Avalonia.Controls.Border obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.Border.BackgroundSizingProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.Border.BackgroundSizingProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<Avalonia.Media.BackgroundSizing> ObserveBackgroundSizing(this Avalonia.Controls.Border obj)
    {
        return obj.GetObservable(Avalonia.Controls.Border.BackgroundSizingProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.Border.BackgroundSizingProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnBackgroundSizing<T>(this T obj, Action<Avalonia.Controls.Border, IObservable<Avalonia.Media.BackgroundSizing>> handler) where T : Avalonia.Controls.Border
    {
        var observable = obj.GetObservable(Avalonia.Controls.Border.BackgroundSizingProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Border.BackgroundSizingProperty"/> property value to <see cref="Avalonia.Media.BackgroundSizing.InnerBorderEdge"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T BackgroundSizingInnerBorderEdge<T>(this T obj) where T : Avalonia.Controls.Border
    {
        obj[Avalonia.Controls.Border.BackgroundSizingProperty] = Avalonia.Media.BackgroundSizing.InnerBorderEdge;
        return obj;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Border.BackgroundSizingProperty"/> property value to <see cref="Avalonia.Media.BackgroundSizing.OuterBorderEdge"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T BackgroundSizingOuterBorderEdge<T>(this T obj) where T : Avalonia.Controls.Border
    {
        obj[Avalonia.Controls.Border.BackgroundSizingProperty] = Avalonia.Media.BackgroundSizing.OuterBorderEdge;
        return obj;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Border.BackgroundSizingProperty"/> property value to <see cref="Avalonia.Media.BackgroundSizing.CenterBorder"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T BackgroundSizingCenterBorder<T>(this T obj) where T : Avalonia.Controls.Border
    {
        obj[Avalonia.Controls.Border.BackgroundSizingProperty] = Avalonia.Media.BackgroundSizing.CenterBorder;
        return obj;
    }

    // Avalonia.Controls.Border.BorderBrushProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Border.BorderBrushProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T borderBrush<T>(this T obj, Avalonia.Media.IBrush value) where T : Avalonia.Controls.Border
    {
        obj[Avalonia.Controls.Border.BorderBrushProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Border.BorderBrushProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T borderBrush<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Border
    {
        var descriptor = Avalonia.Controls.Border.BorderBrushProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Border.BorderBrushProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T borderBrush<T>(
        this T obj,
        IObservable<Avalonia.Media.IBrush> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Border
    {
        var descriptor = Avalonia.Controls.Border.BorderBrushProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.Border.BorderBrushProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.Border.BorderBrushProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindBorderBrush(
        this Avalonia.Controls.Border obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.Border.BorderBrushProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.Border.BorderBrushProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<Avalonia.Media.IBrush> ObserveBorderBrush(this Avalonia.Controls.Border obj)
    {
        return obj.GetObservable(Avalonia.Controls.Border.BorderBrushProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.Border.BorderBrushProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnBorderBrush<T>(this T obj, Action<Avalonia.Controls.Border, IObservable<Avalonia.Media.IBrush>> handler) where T : Avalonia.Controls.Border
    {
        var observable = obj.GetObservable(Avalonia.Controls.Border.BorderBrushProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.Border.BorderThicknessProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Border.BorderThicknessProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T borderThickness<T>(this T obj, Avalonia.Thickness value) where T : Avalonia.Controls.Border
    {
        obj[Avalonia.Controls.Border.BorderThicknessProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Border.BorderThicknessProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T borderThickness<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Border
    {
        var descriptor = Avalonia.Controls.Border.BorderThicknessProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Border.BorderThicknessProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T borderThickness<T>(
        this T obj,
        IObservable<Avalonia.Thickness> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Border
    {
        var descriptor = Avalonia.Controls.Border.BorderThicknessProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.Border.BorderThicknessProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.Border.BorderThicknessProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindBorderThickness(
        this Avalonia.Controls.Border obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.Border.BorderThicknessProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.Border.BorderThicknessProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<Avalonia.Thickness> ObserveBorderThickness(this Avalonia.Controls.Border obj)
    {
        return obj.GetObservable(Avalonia.Controls.Border.BorderThicknessProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.Border.BorderThicknessProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnBorderThickness<T>(this T obj, Action<Avalonia.Controls.Border, IObservable<Avalonia.Thickness>> handler) where T : Avalonia.Controls.Border
    {
        var observable = obj.GetObservable(Avalonia.Controls.Border.BorderThicknessProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.Border.CornerRadiusProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Border.CornerRadiusProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T cornerRadius<T>(this T obj, Avalonia.CornerRadius value) where T : Avalonia.Controls.Border
    {
        obj[Avalonia.Controls.Border.CornerRadiusProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Border.CornerRadiusProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T cornerRadius<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Border
    {
        var descriptor = Avalonia.Controls.Border.CornerRadiusProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Border.CornerRadiusProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T cornerRadius<T>(
        this T obj,
        IObservable<Avalonia.CornerRadius> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Border
    {
        var descriptor = Avalonia.Controls.Border.CornerRadiusProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.Border.CornerRadiusProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.Border.CornerRadiusProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindCornerRadius(
        this Avalonia.Controls.Border obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.Border.CornerRadiusProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.Border.CornerRadiusProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<Avalonia.CornerRadius> ObserveCornerRadius(this Avalonia.Controls.Border obj)
    {
        return obj.GetObservable(Avalonia.Controls.Border.CornerRadiusProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.Border.CornerRadiusProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnCornerRadius<T>(this T obj, Action<Avalonia.Controls.Border, IObservable<Avalonia.CornerRadius>> handler) where T : Avalonia.Controls.Border
    {
        var observable = obj.GetObservable(Avalonia.Controls.Border.CornerRadiusProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.Border.BoxShadowProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Border.BoxShadowProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T boxShadow<T>(this T obj, Avalonia.Media.BoxShadows value) where T : Avalonia.Controls.Border
    {
        obj[Avalonia.Controls.Border.BoxShadowProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Border.BoxShadowProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T boxShadow<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Border
    {
        var descriptor = Avalonia.Controls.Border.BoxShadowProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Border.BoxShadowProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T boxShadow<T>(
        this T obj,
        IObservable<Avalonia.Media.BoxShadows> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Border
    {
        var descriptor = Avalonia.Controls.Border.BoxShadowProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.Border.BoxShadowProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.Border.BoxShadowProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindBoxShadow(
        this Avalonia.Controls.Border obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.Border.BoxShadowProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.Border.BoxShadowProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<Avalonia.Media.BoxShadows> ObserveBoxShadow(this Avalonia.Controls.Border obj)
    {
        return obj.GetObservable(Avalonia.Controls.Border.BoxShadowProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.Border.BoxShadowProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnBoxShadow<T>(this T obj, Action<Avalonia.Controls.Border, IObservable<Avalonia.Media.BoxShadows>> handler) where T : Avalonia.Controls.Border
    {
        var observable = obj.GetObservable(Avalonia.Controls.Border.BoxShadowProperty);
        handler(obj, observable);
        return obj;
    }
}
