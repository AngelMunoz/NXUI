// <auto-generated />
namespace NXUI.FSharp.Extensions;

/// <summary>
/// The avalonia <see cref="Avalonia.Controls.Primitives.RangeBase"/> class property extension methods.
/// </summary>
public static partial class RangeBaseExtensions
{
    // Avalonia.Controls.Primitives.RangeBase.MinimumProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Primitives.RangeBase.MinimumProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T minimum<T>(this T obj, System.Double value) where T : Avalonia.Controls.Primitives.RangeBase
    {
        obj[Avalonia.Controls.Primitives.RangeBase.MinimumProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Primitives.RangeBase.MinimumProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T minimum<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Primitives.RangeBase
    {
        var descriptor = Avalonia.Controls.Primitives.RangeBase.MinimumProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Primitives.RangeBase.MinimumProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T minimum<T>(
        this T obj,
        IObservable<System.Double> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Primitives.RangeBase
    {
        var descriptor = Avalonia.Controls.Primitives.RangeBase.MinimumProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.Primitives.RangeBase.MinimumProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.Primitives.RangeBase.MinimumProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindMinimum(
        this Avalonia.Controls.Primitives.RangeBase obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.Primitives.RangeBase.MinimumProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.Primitives.RangeBase.MinimumProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.Double> ObserveMinimum(this Avalonia.Controls.Primitives.RangeBase obj)
    {
        return obj.GetObservable(Avalonia.Controls.Primitives.RangeBase.MinimumProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.Primitives.RangeBase.MinimumProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnMinimum<T>(this T obj, Action<Avalonia.Controls.Primitives.RangeBase, IObservable<System.Double>> handler) where T : Avalonia.Controls.Primitives.RangeBase
    {
        var observable = obj.GetObservable(Avalonia.Controls.Primitives.RangeBase.MinimumProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.Primitives.RangeBase.MaximumProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Primitives.RangeBase.MaximumProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T maximum<T>(this T obj, System.Double value) where T : Avalonia.Controls.Primitives.RangeBase
    {
        obj[Avalonia.Controls.Primitives.RangeBase.MaximumProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Primitives.RangeBase.MaximumProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T maximum<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Primitives.RangeBase
    {
        var descriptor = Avalonia.Controls.Primitives.RangeBase.MaximumProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Primitives.RangeBase.MaximumProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T maximum<T>(
        this T obj,
        IObservable<System.Double> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Primitives.RangeBase
    {
        var descriptor = Avalonia.Controls.Primitives.RangeBase.MaximumProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.Primitives.RangeBase.MaximumProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.Primitives.RangeBase.MaximumProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindMaximum(
        this Avalonia.Controls.Primitives.RangeBase obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.Primitives.RangeBase.MaximumProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.Primitives.RangeBase.MaximumProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.Double> ObserveMaximum(this Avalonia.Controls.Primitives.RangeBase obj)
    {
        return obj.GetObservable(Avalonia.Controls.Primitives.RangeBase.MaximumProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.Primitives.RangeBase.MaximumProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnMaximum<T>(this T obj, Action<Avalonia.Controls.Primitives.RangeBase, IObservable<System.Double>> handler) where T : Avalonia.Controls.Primitives.RangeBase
    {
        var observable = obj.GetObservable(Avalonia.Controls.Primitives.RangeBase.MaximumProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.Primitives.RangeBase.ValueProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Primitives.RangeBase.ValueProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T value<T>(this T obj, System.Double value) where T : Avalonia.Controls.Primitives.RangeBase
    {
        obj[Avalonia.Controls.Primitives.RangeBase.ValueProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Primitives.RangeBase.ValueProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T value<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Primitives.RangeBase
    {
        var descriptor = Avalonia.Controls.Primitives.RangeBase.ValueProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Primitives.RangeBase.ValueProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T value<T>(
        this T obj,
        IObservable<System.Double> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Primitives.RangeBase
    {
        var descriptor = Avalonia.Controls.Primitives.RangeBase.ValueProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.Primitives.RangeBase.ValueProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.Primitives.RangeBase.ValueProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindValue(
        this Avalonia.Controls.Primitives.RangeBase obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.Primitives.RangeBase.ValueProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.Primitives.RangeBase.ValueProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.Double> ObserveValue(this Avalonia.Controls.Primitives.RangeBase obj)
    {
        return obj.GetObservable(Avalonia.Controls.Primitives.RangeBase.ValueProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.Primitives.RangeBase.ValueProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnValue<T>(this T obj, Action<Avalonia.Controls.Primitives.RangeBase, IObservable<System.Double>> handler) where T : Avalonia.Controls.Primitives.RangeBase
    {
        var observable = obj.GetObservable(Avalonia.Controls.Primitives.RangeBase.ValueProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.Primitives.RangeBase.SmallChangeProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Primitives.RangeBase.SmallChangeProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T smallChange<T>(this T obj, System.Double value) where T : Avalonia.Controls.Primitives.RangeBase
    {
        obj[Avalonia.Controls.Primitives.RangeBase.SmallChangeProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Primitives.RangeBase.SmallChangeProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T smallChange<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Primitives.RangeBase
    {
        var descriptor = Avalonia.Controls.Primitives.RangeBase.SmallChangeProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Primitives.RangeBase.SmallChangeProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T smallChange<T>(
        this T obj,
        IObservable<System.Double> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Primitives.RangeBase
    {
        var descriptor = Avalonia.Controls.Primitives.RangeBase.SmallChangeProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.Primitives.RangeBase.SmallChangeProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.Primitives.RangeBase.SmallChangeProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindSmallChange(
        this Avalonia.Controls.Primitives.RangeBase obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.Primitives.RangeBase.SmallChangeProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.Primitives.RangeBase.SmallChangeProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.Double> ObserveSmallChange(this Avalonia.Controls.Primitives.RangeBase obj)
    {
        return obj.GetObservable(Avalonia.Controls.Primitives.RangeBase.SmallChangeProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.Primitives.RangeBase.SmallChangeProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnSmallChange<T>(this T obj, Action<Avalonia.Controls.Primitives.RangeBase, IObservable<System.Double>> handler) where T : Avalonia.Controls.Primitives.RangeBase
    {
        var observable = obj.GetObservable(Avalonia.Controls.Primitives.RangeBase.SmallChangeProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.Primitives.RangeBase.LargeChangeProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Primitives.RangeBase.LargeChangeProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T largeChange<T>(this T obj, System.Double value) where T : Avalonia.Controls.Primitives.RangeBase
    {
        obj[Avalonia.Controls.Primitives.RangeBase.LargeChangeProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Primitives.RangeBase.LargeChangeProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T largeChange<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Primitives.RangeBase
    {
        var descriptor = Avalonia.Controls.Primitives.RangeBase.LargeChangeProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Primitives.RangeBase.LargeChangeProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T largeChange<T>(
        this T obj,
        IObservable<System.Double> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Primitives.RangeBase
    {
        var descriptor = Avalonia.Controls.Primitives.RangeBase.LargeChangeProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.Primitives.RangeBase.LargeChangeProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.Primitives.RangeBase.LargeChangeProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindLargeChange(
        this Avalonia.Controls.Primitives.RangeBase obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.Primitives.RangeBase.LargeChangeProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.Primitives.RangeBase.LargeChangeProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.Double> ObserveLargeChange(this Avalonia.Controls.Primitives.RangeBase obj)
    {
        return obj.GetObservable(Avalonia.Controls.Primitives.RangeBase.LargeChangeProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.Primitives.RangeBase.LargeChangeProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnLargeChange<T>(this T obj, Action<Avalonia.Controls.Primitives.RangeBase, IObservable<System.Double>> handler) where T : Avalonia.Controls.Primitives.RangeBase
    {
        var observable = obj.GetObservable(Avalonia.Controls.Primitives.RangeBase.LargeChangeProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.Primitives.RangeBase.ValueChangedEvent

    /// <summary>
    /// Registers a handler for the <see cref="Avalonia.Controls.Primitives.RangeBase.ValueChangedEvent"/> event on an object of type <see cref="Avalonia.Controls.Primitives.RangeBase"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="action">The action to be performed when the event is raised.</param>
    /// <param name="routes">The routing strategies for the event.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object.</returns>
    public static T OnValueChangedHandler<T>(
        this T obj,
        Action<T, Avalonia.Controls.Primitives.RangeBaseValueChangedEventArgs> action,
        Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Bubble) where T : Avalonia.Controls.Primitives.RangeBase
    {
        obj.AddHandler(Avalonia.Controls.Primitives.RangeBase.ValueChangedEvent, (_, args) => action(obj, args), routes);
        return obj;
    }

    /// <summary>
    /// Registers a handler for the <see cref="Avalonia.Controls.Primitives.RangeBase.ValueChangedEvent"/> event on an object of type <see cref="Avalonia.Controls.Primitives.RangeBase"/> and returns an observable for the event.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler to be called when the event is raised.</param>
    /// <param name="routes">The routing strategies for the event.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object.</returns>
    public static T OnValueChanged<T>(
        this T obj, Action<T, IObservable<Avalonia.Controls.Primitives.RangeBaseValueChangedEventArgs>> handler,
        Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Bubble) where T : Avalonia.Controls.Primitives.RangeBase
    {
        var observable = obj.GetObservable(Avalonia.Controls.Primitives.RangeBase.ValueChangedEvent, routes);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets an observable for the <see cref="Avalonia.Controls.Primitives.RangeBase.ValueChangedEvent"/> event on an object of type <see cref="Avalonia.Controls.Primitives.RangeBase"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="routes">The routing strategies for the event.</param>
    /// <returns>An observable for the event.</returns>
    public static IObservable<Avalonia.Controls.Primitives.RangeBaseValueChangedEventArgs> ObserveOnValueChanged(
        this Avalonia.Controls.Primitives.RangeBase obj,
        Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Bubble)
    {
        return obj.GetObservable(Avalonia.Controls.Primitives.RangeBase.ValueChangedEvent, routes);
    }

    // Avalonia.Controls.Primitives.RangeBase.ValueChanged

    /// <summary>
    /// Adds a handler to the `ValueChanged` event on the specified object.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler to be called when the event is raised.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnValueChangedEvent<T>(this T obj, Action<T, IObservable<Avalonia.Controls.Primitives.RangeBaseValueChangedEventArgs>> handler) where T : Avalonia.Controls.Primitives.RangeBase
    {
        var observable = Observable
            .FromEventPattern<EventHandler<Avalonia.Controls.Primitives.RangeBaseValueChangedEventArgs>, Avalonia.Controls.Primitives.RangeBaseValueChangedEventArgs>(
                h => obj.ValueChanged += h, 
                h => obj.ValueChanged -= h)
            .Select(x => x.EventArgs);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Returns an observable for the `ValueChanged` event on the specified object.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable for the `ValueChanged` event on the specified object.</returns>
    public static IObservable<Avalonia.Controls.Primitives.RangeBaseValueChangedEventArgs> ObserveOnValueChangedEvent(this Avalonia.Controls.Primitives.RangeBase obj)
    {
        return Observable
            .FromEventPattern<EventHandler<Avalonia.Controls.Primitives.RangeBaseValueChangedEventArgs>, Avalonia.Controls.Primitives.RangeBaseValueChangedEventArgs>(
                h => obj.ValueChanged += h, 
                h => obj.ValueChanged -= h)
            .Select(x => x.EventArgs);
    }
}
