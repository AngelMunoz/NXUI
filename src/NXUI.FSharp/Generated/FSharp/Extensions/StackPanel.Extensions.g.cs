// <auto-generated />
namespace NXUI.FSharp.Extensions;

/// <summary>
/// The avalonia <see cref="Avalonia.Controls.StackPanel"/> class property extension methods.
/// </summary>
public static partial class StackPanelExtensions
{
    // Avalonia.Controls.StackPanel.SpacingProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.StackPanel.SpacingProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T spacing<T>(this T obj, System.Double value) where T : Avalonia.Controls.StackPanel
    {
        obj[Avalonia.Controls.StackPanel.SpacingProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.StackPanel.SpacingProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T spacing<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.StackPanel
    {
        var descriptor = Avalonia.Controls.StackPanel.SpacingProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.StackPanel.SpacingProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T spacing<T>(
        this T obj,
        IObservable<System.Double> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.StackPanel
    {
        var descriptor = Avalonia.Controls.StackPanel.SpacingProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.StackPanel.SpacingProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.StackPanel.SpacingProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindSpacing(
        this Avalonia.Controls.StackPanel obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.StackPanel.SpacingProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.StackPanel.SpacingProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.Double> ObserveSpacing(this Avalonia.Controls.StackPanel obj)
    {
        return obj.GetObservable(Avalonia.Controls.StackPanel.SpacingProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.StackPanel.SpacingProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnSpacing<T>(this T obj, Action<Avalonia.Controls.StackPanel, IObservable<System.Double>> handler) where T : Avalonia.Controls.StackPanel
    {
        var observable = obj.GetObservable(Avalonia.Controls.StackPanel.SpacingProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.StackPanel.OrientationProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.StackPanel.OrientationProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T orientation<T>(this T obj, Avalonia.Layout.Orientation value) where T : Avalonia.Controls.StackPanel
    {
        obj[Avalonia.Controls.StackPanel.OrientationProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.StackPanel.OrientationProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T orientation<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.StackPanel
    {
        var descriptor = Avalonia.Controls.StackPanel.OrientationProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.StackPanel.OrientationProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T orientation<T>(
        this T obj,
        IObservable<Avalonia.Layout.Orientation> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.StackPanel
    {
        var descriptor = Avalonia.Controls.StackPanel.OrientationProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.StackPanel.OrientationProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.StackPanel.OrientationProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindOrientation(
        this Avalonia.Controls.StackPanel obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.StackPanel.OrientationProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.StackPanel.OrientationProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<Avalonia.Layout.Orientation> ObserveOrientation(this Avalonia.Controls.StackPanel obj)
    {
        return obj.GetObservable(Avalonia.Controls.StackPanel.OrientationProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.StackPanel.OrientationProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnOrientation<T>(this T obj, Action<Avalonia.Controls.StackPanel, IObservable<Avalonia.Layout.Orientation>> handler) where T : Avalonia.Controls.StackPanel
    {
        var observable = obj.GetObservable(Avalonia.Controls.StackPanel.OrientationProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.StackPanel.OrientationProperty"/> property value to <see cref="Avalonia.Layout.Orientation.Horizontal"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OrientationHorizontal<T>(this T obj) where T : Avalonia.Controls.StackPanel
    {
        obj[Avalonia.Controls.StackPanel.OrientationProperty] = Avalonia.Layout.Orientation.Horizontal;
        return obj;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.StackPanel.OrientationProperty"/> property value to <see cref="Avalonia.Layout.Orientation.Vertical"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OrientationVertical<T>(this T obj) where T : Avalonia.Controls.StackPanel
    {
        obj[Avalonia.Controls.StackPanel.OrientationProperty] = Avalonia.Layout.Orientation.Vertical;
        return obj;
    }

    // Avalonia.Controls.StackPanel.AreHorizontalSnapPointsRegularProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.StackPanel.AreHorizontalSnapPointsRegularProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T areHorizontalSnapPointsRegular<T>(this T obj, System.Boolean value) where T : Avalonia.Controls.StackPanel
    {
        obj[Avalonia.Controls.StackPanel.AreHorizontalSnapPointsRegularProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.StackPanel.AreHorizontalSnapPointsRegularProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T areHorizontalSnapPointsRegular<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.StackPanel
    {
        var descriptor = Avalonia.Controls.StackPanel.AreHorizontalSnapPointsRegularProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.StackPanel.AreHorizontalSnapPointsRegularProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T areHorizontalSnapPointsRegular<T>(
        this T obj,
        IObservable<System.Boolean> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.StackPanel
    {
        var descriptor = Avalonia.Controls.StackPanel.AreHorizontalSnapPointsRegularProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.StackPanel.AreHorizontalSnapPointsRegularProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.StackPanel.AreHorizontalSnapPointsRegularProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindAreHorizontalSnapPointsRegular(
        this Avalonia.Controls.StackPanel obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.StackPanel.AreHorizontalSnapPointsRegularProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.StackPanel.AreHorizontalSnapPointsRegularProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.Boolean> ObserveAreHorizontalSnapPointsRegular(this Avalonia.Controls.StackPanel obj)
    {
        return obj.GetObservable(Avalonia.Controls.StackPanel.AreHorizontalSnapPointsRegularProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.StackPanel.AreHorizontalSnapPointsRegularProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnAreHorizontalSnapPointsRegular<T>(this T obj, Action<Avalonia.Controls.StackPanel, IObservable<System.Boolean>> handler) where T : Avalonia.Controls.StackPanel
    {
        var observable = obj.GetObservable(Avalonia.Controls.StackPanel.AreHorizontalSnapPointsRegularProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.StackPanel.AreVerticalSnapPointsRegularProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.StackPanel.AreVerticalSnapPointsRegularProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T areVerticalSnapPointsRegular<T>(this T obj, System.Boolean value) where T : Avalonia.Controls.StackPanel
    {
        obj[Avalonia.Controls.StackPanel.AreVerticalSnapPointsRegularProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.StackPanel.AreVerticalSnapPointsRegularProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T areVerticalSnapPointsRegular<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.StackPanel
    {
        var descriptor = Avalonia.Controls.StackPanel.AreVerticalSnapPointsRegularProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.StackPanel.AreVerticalSnapPointsRegularProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T areVerticalSnapPointsRegular<T>(
        this T obj,
        IObservable<System.Boolean> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.StackPanel
    {
        var descriptor = Avalonia.Controls.StackPanel.AreVerticalSnapPointsRegularProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.StackPanel.AreVerticalSnapPointsRegularProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.StackPanel.AreVerticalSnapPointsRegularProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindAreVerticalSnapPointsRegular(
        this Avalonia.Controls.StackPanel obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.StackPanel.AreVerticalSnapPointsRegularProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.StackPanel.AreVerticalSnapPointsRegularProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.Boolean> ObserveAreVerticalSnapPointsRegular(this Avalonia.Controls.StackPanel obj)
    {
        return obj.GetObservable(Avalonia.Controls.StackPanel.AreVerticalSnapPointsRegularProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.StackPanel.AreVerticalSnapPointsRegularProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnAreVerticalSnapPointsRegular<T>(this T obj, Action<Avalonia.Controls.StackPanel, IObservable<System.Boolean>> handler) where T : Avalonia.Controls.StackPanel
    {
        var observable = obj.GetObservable(Avalonia.Controls.StackPanel.AreVerticalSnapPointsRegularProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.StackPanel.HorizontalSnapPointsChangedEvent

    /// <summary>
    /// Registers a handler for the <see cref="Avalonia.Controls.StackPanel.HorizontalSnapPointsChangedEvent"/> event on an object of type <see cref="Avalonia.Controls.StackPanel"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="action">The action to be performed when the event is raised.</param>
    /// <param name="routes">The routing strategies for the event.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object.</returns>
    public static T OnHorizontalSnapPointsChangedHandler<T>(
        this T obj,
        Action<T, Avalonia.Interactivity.RoutedEventArgs> action,
        Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Bubble) where T : Avalonia.Controls.StackPanel
    {
        obj.AddHandler(Avalonia.Controls.StackPanel.HorizontalSnapPointsChangedEvent, (_, args) => action(obj, args), routes);
        return obj;
    }

    /// <summary>
    /// Registers a handler for the <see cref="Avalonia.Controls.StackPanel.HorizontalSnapPointsChangedEvent"/> event on an object of type <see cref="Avalonia.Controls.StackPanel"/> and returns an observable for the event.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler to be called when the event is raised.</param>
    /// <param name="routes">The routing strategies for the event.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object.</returns>
    public static T OnHorizontalSnapPointsChanged<T>(
        this T obj, Action<T, IObservable<Avalonia.Interactivity.RoutedEventArgs>> handler,
        Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Bubble) where T : Avalonia.Controls.StackPanel
    {
        var observable = obj.GetObservable(Avalonia.Controls.StackPanel.HorizontalSnapPointsChangedEvent, routes);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets an observable for the <see cref="Avalonia.Controls.StackPanel.HorizontalSnapPointsChangedEvent"/> event on an object of type <see cref="Avalonia.Controls.StackPanel"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="routes">The routing strategies for the event.</param>
    /// <returns>An observable for the event.</returns>
    public static IObservable<Avalonia.Interactivity.RoutedEventArgs> ObserveOnHorizontalSnapPointsChanged(
        this Avalonia.Controls.StackPanel obj,
        Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Bubble)
    {
        return obj.GetObservable(Avalonia.Controls.StackPanel.HorizontalSnapPointsChangedEvent, routes);
    }

    // Avalonia.Controls.StackPanel.VerticalSnapPointsChangedEvent

    /// <summary>
    /// Registers a handler for the <see cref="Avalonia.Controls.StackPanel.VerticalSnapPointsChangedEvent"/> event on an object of type <see cref="Avalonia.Controls.StackPanel"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="action">The action to be performed when the event is raised.</param>
    /// <param name="routes">The routing strategies for the event.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object.</returns>
    public static T OnVerticalSnapPointsChangedHandler<T>(
        this T obj,
        Action<T, Avalonia.Interactivity.RoutedEventArgs> action,
        Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Bubble) where T : Avalonia.Controls.StackPanel
    {
        obj.AddHandler(Avalonia.Controls.StackPanel.VerticalSnapPointsChangedEvent, (_, args) => action(obj, args), routes);
        return obj;
    }

    /// <summary>
    /// Registers a handler for the <see cref="Avalonia.Controls.StackPanel.VerticalSnapPointsChangedEvent"/> event on an object of type <see cref="Avalonia.Controls.StackPanel"/> and returns an observable for the event.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler to be called when the event is raised.</param>
    /// <param name="routes">The routing strategies for the event.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object.</returns>
    public static T OnVerticalSnapPointsChanged<T>(
        this T obj, Action<T, IObservable<Avalonia.Interactivity.RoutedEventArgs>> handler,
        Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Bubble) where T : Avalonia.Controls.StackPanel
    {
        var observable = obj.GetObservable(Avalonia.Controls.StackPanel.VerticalSnapPointsChangedEvent, routes);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets an observable for the <see cref="Avalonia.Controls.StackPanel.VerticalSnapPointsChangedEvent"/> event on an object of type <see cref="Avalonia.Controls.StackPanel"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="routes">The routing strategies for the event.</param>
    /// <returns>An observable for the event.</returns>
    public static IObservable<Avalonia.Interactivity.RoutedEventArgs> ObserveOnVerticalSnapPointsChanged(
        this Avalonia.Controls.StackPanel obj,
        Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Bubble)
    {
        return obj.GetObservable(Avalonia.Controls.StackPanel.VerticalSnapPointsChangedEvent, routes);
    }

    // Avalonia.Controls.StackPanel.HorizontalSnapPointsChanged

    /// <summary>
    /// Adds a handler to the `HorizontalSnapPointsChanged` event on the specified object.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler to be called when the event is raised.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnHorizontalSnapPointsChangedEvent<T>(this T obj, Action<T, IObservable<Avalonia.Interactivity.RoutedEventArgs>> handler) where T : Avalonia.Controls.StackPanel
    {
        var observable = Observable
            .FromEventPattern<EventHandler<Avalonia.Interactivity.RoutedEventArgs>, Avalonia.Interactivity.RoutedEventArgs>(
                h => obj.HorizontalSnapPointsChanged += h, 
                h => obj.HorizontalSnapPointsChanged -= h)
            .Select(x => x.EventArgs);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Returns an observable for the `HorizontalSnapPointsChanged` event on the specified object.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable for the `HorizontalSnapPointsChanged` event on the specified object.</returns>
    public static IObservable<Avalonia.Interactivity.RoutedEventArgs> ObserveOnHorizontalSnapPointsChangedEvent(this Avalonia.Controls.StackPanel obj)
    {
        return Observable
            .FromEventPattern<EventHandler<Avalonia.Interactivity.RoutedEventArgs>, Avalonia.Interactivity.RoutedEventArgs>(
                h => obj.HorizontalSnapPointsChanged += h, 
                h => obj.HorizontalSnapPointsChanged -= h)
            .Select(x => x.EventArgs);
    }

    // Avalonia.Controls.StackPanel.VerticalSnapPointsChanged

    /// <summary>
    /// Adds a handler to the `VerticalSnapPointsChanged` event on the specified object.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler to be called when the event is raised.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnVerticalSnapPointsChangedEvent<T>(this T obj, Action<T, IObservable<Avalonia.Interactivity.RoutedEventArgs>> handler) where T : Avalonia.Controls.StackPanel
    {
        var observable = Observable
            .FromEventPattern<EventHandler<Avalonia.Interactivity.RoutedEventArgs>, Avalonia.Interactivity.RoutedEventArgs>(
                h => obj.VerticalSnapPointsChanged += h, 
                h => obj.VerticalSnapPointsChanged -= h)
            .Select(x => x.EventArgs);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Returns an observable for the `VerticalSnapPointsChanged` event on the specified object.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable for the `VerticalSnapPointsChanged` event on the specified object.</returns>
    public static IObservable<Avalonia.Interactivity.RoutedEventArgs> ObserveOnVerticalSnapPointsChangedEvent(this Avalonia.Controls.StackPanel obj)
    {
        return Observable
            .FromEventPattern<EventHandler<Avalonia.Interactivity.RoutedEventArgs>, Avalonia.Interactivity.RoutedEventArgs>(
                h => obj.VerticalSnapPointsChanged += h, 
                h => obj.VerticalSnapPointsChanged -= h)
            .Select(x => x.EventArgs);
    }
}
