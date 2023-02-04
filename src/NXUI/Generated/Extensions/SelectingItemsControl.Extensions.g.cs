// <auto-generated />
namespace NXUI.Extensions;

/// <summary>
/// The avalonia <see cref="Avalonia.Controls.Primitives.SelectingItemsControl"/> class property extension methods.
/// </summary>
public static partial class SelectingItemsControlExtensions
{
    // Avalonia.Controls.Primitives.SelectingItemsControl.AutoScrollToSelectedItemProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Primitives.SelectingItemsControl.AutoScrollToSelectedItemProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T AutoScrollToSelectedItem<T>(this T obj, System.Boolean value) where T : Avalonia.Controls.Primitives.SelectingItemsControl
    {
        obj[Avalonia.Controls.Primitives.SelectingItemsControl.AutoScrollToSelectedItemProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Primitives.SelectingItemsControl.AutoScrollToSelectedItemProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T AutoScrollToSelectedItem<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Primitives.SelectingItemsControl
    {
        var descriptor = Avalonia.Controls.Primitives.SelectingItemsControl.AutoScrollToSelectedItemProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Primitives.SelectingItemsControl.AutoScrollToSelectedItemProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T AutoScrollToSelectedItem<T>(
        this T obj,
        IObservable<System.Boolean> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Primitives.SelectingItemsControl
    {
        var descriptor = Avalonia.Controls.Primitives.SelectingItemsControl.AutoScrollToSelectedItemProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.Primitives.SelectingItemsControl.AutoScrollToSelectedItemProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.Primitives.SelectingItemsControl.AutoScrollToSelectedItemProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindAutoScrollToSelectedItem(
        this Avalonia.Controls.Primitives.SelectingItemsControl obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.Primitives.SelectingItemsControl.AutoScrollToSelectedItemProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.Primitives.SelectingItemsControl.AutoScrollToSelectedItemProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.Boolean> ObserveAutoScrollToSelectedItem(this Avalonia.Controls.Primitives.SelectingItemsControl obj)
    {
        return obj.GetObservable(Avalonia.Controls.Primitives.SelectingItemsControl.AutoScrollToSelectedItemProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.Primitives.SelectingItemsControl.AutoScrollToSelectedItemProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnAutoScrollToSelectedItem<T>(this T obj, Action<Avalonia.Controls.Primitives.SelectingItemsControl, IObservable<System.Boolean>> handler) where T : Avalonia.Controls.Primitives.SelectingItemsControl
    {
        var observable = obj.GetObservable(Avalonia.Controls.Primitives.SelectingItemsControl.AutoScrollToSelectedItemProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.Primitives.SelectingItemsControl.SelectedIndexProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Primitives.SelectingItemsControl.SelectedIndexProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T SelectedIndex<T>(this T obj, System.Int32 value) where T : Avalonia.Controls.Primitives.SelectingItemsControl
    {
        obj[Avalonia.Controls.Primitives.SelectingItemsControl.SelectedIndexProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Primitives.SelectingItemsControl.SelectedIndexProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T SelectedIndex<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Primitives.SelectingItemsControl
    {
        var descriptor = Avalonia.Controls.Primitives.SelectingItemsControl.SelectedIndexProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Primitives.SelectingItemsControl.SelectedIndexProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T SelectedIndex<T>(
        this T obj,
        IObservable<System.Int32> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Primitives.SelectingItemsControl
    {
        var descriptor = Avalonia.Controls.Primitives.SelectingItemsControl.SelectedIndexProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.Primitives.SelectingItemsControl.SelectedIndexProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.Primitives.SelectingItemsControl.SelectedIndexProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindSelectedIndex(
        this Avalonia.Controls.Primitives.SelectingItemsControl obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.Primitives.SelectingItemsControl.SelectedIndexProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.Primitives.SelectingItemsControl.SelectedIndexProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.Int32> ObserveSelectedIndex(this Avalonia.Controls.Primitives.SelectingItemsControl obj)
    {
        return obj.GetObservable(Avalonia.Controls.Primitives.SelectingItemsControl.SelectedIndexProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.Primitives.SelectingItemsControl.SelectedIndexProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnSelectedIndex<T>(this T obj, Action<Avalonia.Controls.Primitives.SelectingItemsControl, IObservable<System.Int32>> handler) where T : Avalonia.Controls.Primitives.SelectingItemsControl
    {
        var observable = obj.GetObservable(Avalonia.Controls.Primitives.SelectingItemsControl.SelectedIndexProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.Primitives.SelectingItemsControl.SelectedItemProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Primitives.SelectingItemsControl.SelectedItemProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T SelectedItem<T>(this T obj, System.Object value) where T : Avalonia.Controls.Primitives.SelectingItemsControl
    {
        obj[Avalonia.Controls.Primitives.SelectingItemsControl.SelectedItemProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Primitives.SelectingItemsControl.SelectedItemProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T SelectedItem<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Primitives.SelectingItemsControl
    {
        var descriptor = Avalonia.Controls.Primitives.SelectingItemsControl.SelectedItemProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Primitives.SelectingItemsControl.SelectedItemProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T SelectedItem<T>(
        this T obj,
        IObservable<System.Object> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Primitives.SelectingItemsControl
    {
        var descriptor = Avalonia.Controls.Primitives.SelectingItemsControl.SelectedItemProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.Primitives.SelectingItemsControl.SelectedItemProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.Primitives.SelectingItemsControl.SelectedItemProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindSelectedItem(
        this Avalonia.Controls.Primitives.SelectingItemsControl obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.Primitives.SelectingItemsControl.SelectedItemProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.Primitives.SelectingItemsControl.SelectedItemProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.Object> ObserveSelectedItem(this Avalonia.Controls.Primitives.SelectingItemsControl obj)
    {
        return obj.GetObservable(Avalonia.Controls.Primitives.SelectingItemsControl.SelectedItemProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.Primitives.SelectingItemsControl.SelectedItemProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnSelectedItem<T>(this T obj, Action<Avalonia.Controls.Primitives.SelectingItemsControl, IObservable<System.Object>> handler) where T : Avalonia.Controls.Primitives.SelectingItemsControl
    {
        var observable = obj.GetObservable(Avalonia.Controls.Primitives.SelectingItemsControl.SelectedItemProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.Primitives.SelectingItemsControl.IsTextSearchEnabledProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Primitives.SelectingItemsControl.IsTextSearchEnabledProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T IsTextSearchEnabled<T>(this T obj, System.Boolean value) where T : Avalonia.Controls.Primitives.SelectingItemsControl
    {
        obj[Avalonia.Controls.Primitives.SelectingItemsControl.IsTextSearchEnabledProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Primitives.SelectingItemsControl.IsTextSearchEnabledProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T IsTextSearchEnabled<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Primitives.SelectingItemsControl
    {
        var descriptor = Avalonia.Controls.Primitives.SelectingItemsControl.IsTextSearchEnabledProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Primitives.SelectingItemsControl.IsTextSearchEnabledProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T IsTextSearchEnabled<T>(
        this T obj,
        IObservable<System.Boolean> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Primitives.SelectingItemsControl
    {
        var descriptor = Avalonia.Controls.Primitives.SelectingItemsControl.IsTextSearchEnabledProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.Primitives.SelectingItemsControl.IsTextSearchEnabledProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.Primitives.SelectingItemsControl.IsTextSearchEnabledProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindIsTextSearchEnabled(
        this Avalonia.Controls.Primitives.SelectingItemsControl obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.Primitives.SelectingItemsControl.IsTextSearchEnabledProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.Primitives.SelectingItemsControl.IsTextSearchEnabledProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.Boolean> ObserveIsTextSearchEnabled(this Avalonia.Controls.Primitives.SelectingItemsControl obj)
    {
        return obj.GetObservable(Avalonia.Controls.Primitives.SelectingItemsControl.IsTextSearchEnabledProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.Primitives.SelectingItemsControl.IsTextSearchEnabledProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnIsTextSearchEnabled<T>(this T obj, Action<Avalonia.Controls.Primitives.SelectingItemsControl, IObservable<System.Boolean>> handler) where T : Avalonia.Controls.Primitives.SelectingItemsControl
    {
        var observable = obj.GetObservable(Avalonia.Controls.Primitives.SelectingItemsControl.IsTextSearchEnabledProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.Primitives.SelectingItemsControl.WrapSelectionProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Primitives.SelectingItemsControl.WrapSelectionProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T WrapSelection<T>(this T obj, System.Boolean value) where T : Avalonia.Controls.Primitives.SelectingItemsControl
    {
        obj[Avalonia.Controls.Primitives.SelectingItemsControl.WrapSelectionProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Primitives.SelectingItemsControl.WrapSelectionProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T WrapSelection<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Primitives.SelectingItemsControl
    {
        var descriptor = Avalonia.Controls.Primitives.SelectingItemsControl.WrapSelectionProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Primitives.SelectingItemsControl.WrapSelectionProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T WrapSelection<T>(
        this T obj,
        IObservable<System.Boolean> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Primitives.SelectingItemsControl
    {
        var descriptor = Avalonia.Controls.Primitives.SelectingItemsControl.WrapSelectionProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.Primitives.SelectingItemsControl.WrapSelectionProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.Primitives.SelectingItemsControl.WrapSelectionProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindWrapSelection(
        this Avalonia.Controls.Primitives.SelectingItemsControl obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.Primitives.SelectingItemsControl.WrapSelectionProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.Primitives.SelectingItemsControl.WrapSelectionProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.Boolean> ObserveWrapSelection(this Avalonia.Controls.Primitives.SelectingItemsControl obj)
    {
        return obj.GetObservable(Avalonia.Controls.Primitives.SelectingItemsControl.WrapSelectionProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.Primitives.SelectingItemsControl.WrapSelectionProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnWrapSelection<T>(this T obj, Action<Avalonia.Controls.Primitives.SelectingItemsControl, IObservable<System.Boolean>> handler) where T : Avalonia.Controls.Primitives.SelectingItemsControl
    {
        var observable = obj.GetObservable(Avalonia.Controls.Primitives.SelectingItemsControl.WrapSelectionProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.Primitives.SelectingItemsControl.IsSelectedChangedEvent

    /// <summary>
    /// Registers a handler for the <see cref="Avalonia.Controls.Primitives.SelectingItemsControl.IsSelectedChangedEvent"/> event on an object of type <see cref="Avalonia.Controls.Primitives.SelectingItemsControl"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="action">The action to be performed when the event is raised.</param>
    /// <param name="routes">The routing strategies for the event.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object.</returns>
    public static T OnIsSelectedChangedHandler<T>(
        this T obj,
        Action<T, Avalonia.Interactivity.RoutedEventArgs> action,
        Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Bubble) where T : Avalonia.Controls.Primitives.SelectingItemsControl
    {
        obj.AddHandler(Avalonia.Controls.Primitives.SelectingItemsControl.IsSelectedChangedEvent, (_, args) => action(obj, args), routes);
        return obj;
    }

    /// <summary>
    /// Registers a handler for the <see cref="Avalonia.Controls.Primitives.SelectingItemsControl.IsSelectedChangedEvent"/> event on an object of type <see cref="Avalonia.Controls.Primitives.SelectingItemsControl"/> and returns an observable for the event.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler to be called when the event is raised.</param>
    /// <param name="routes">The routing strategies for the event.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object.</returns>
    public static T OnIsSelectedChanged<T>(
        this T obj, Action<T, IObservable<Avalonia.Interactivity.RoutedEventArgs>> handler,
        Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Bubble) where T : Avalonia.Controls.Primitives.SelectingItemsControl
    {
        var observable = obj.GetObservable(Avalonia.Controls.Primitives.SelectingItemsControl.IsSelectedChangedEvent, routes);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets an observable for the <see cref="Avalonia.Controls.Primitives.SelectingItemsControl.IsSelectedChangedEvent"/> event on an object of type <see cref="Avalonia.Controls.Primitives.SelectingItemsControl"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="routes">The routing strategies for the event.</param>
    /// <returns>An observable for the event.</returns>
    public static IObservable<Avalonia.Interactivity.RoutedEventArgs> ObserveOnIsSelectedChanged(
        this Avalonia.Controls.Primitives.SelectingItemsControl obj,
        Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Bubble)
    {
        return obj.GetObservable(Avalonia.Controls.Primitives.SelectingItemsControl.IsSelectedChangedEvent, routes);
    }

    // Avalonia.Controls.Primitives.SelectingItemsControl.SelectionChangedEvent

    /// <summary>
    /// Registers a handler for the <see cref="Avalonia.Controls.Primitives.SelectingItemsControl.SelectionChangedEvent"/> event on an object of type <see cref="Avalonia.Controls.Primitives.SelectingItemsControl"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="action">The action to be performed when the event is raised.</param>
    /// <param name="routes">The routing strategies for the event.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object.</returns>
    public static T OnSelectionChangedHandler<T>(
        this T obj,
        Action<T, Avalonia.Controls.SelectionChangedEventArgs> action,
        Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Bubble) where T : Avalonia.Controls.Primitives.SelectingItemsControl
    {
        obj.AddHandler(Avalonia.Controls.Primitives.SelectingItemsControl.SelectionChangedEvent, (_, args) => action(obj, args), routes);
        return obj;
    }

    /// <summary>
    /// Registers a handler for the <see cref="Avalonia.Controls.Primitives.SelectingItemsControl.SelectionChangedEvent"/> event on an object of type <see cref="Avalonia.Controls.Primitives.SelectingItemsControl"/> and returns an observable for the event.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler to be called when the event is raised.</param>
    /// <param name="routes">The routing strategies for the event.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object.</returns>
    public static T OnSelectionChanged<T>(
        this T obj, Action<T, IObservable<Avalonia.Controls.SelectionChangedEventArgs>> handler,
        Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Bubble) where T : Avalonia.Controls.Primitives.SelectingItemsControl
    {
        var observable = obj.GetObservable(Avalonia.Controls.Primitives.SelectingItemsControl.SelectionChangedEvent, routes);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets an observable for the <see cref="Avalonia.Controls.Primitives.SelectingItemsControl.SelectionChangedEvent"/> event on an object of type <see cref="Avalonia.Controls.Primitives.SelectingItemsControl"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="routes">The routing strategies for the event.</param>
    /// <returns>An observable for the event.</returns>
    public static IObservable<Avalonia.Controls.SelectionChangedEventArgs> ObserveOnSelectionChanged(
        this Avalonia.Controls.Primitives.SelectingItemsControl obj,
        Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Bubble)
    {
        return obj.GetObservable(Avalonia.Controls.Primitives.SelectingItemsControl.SelectionChangedEvent, routes);
    }

    // Avalonia.Controls.Primitives.SelectingItemsControl.SelectionChanged

    /// <summary>
    /// Adds a handler to the `SelectionChanged` event on the specified object.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler to be called when the event is raised.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnSelectionChangedEvent<T>(this T obj, Action<T, IObservable<Avalonia.Controls.SelectionChangedEventArgs>> handler) where T : Avalonia.Controls.Primitives.SelectingItemsControl
    {
        var observable = Observable
            .FromEventPattern<EventHandler<Avalonia.Controls.SelectionChangedEventArgs>, Avalonia.Controls.SelectionChangedEventArgs>(
                h => obj.SelectionChanged += h, 
                h => obj.SelectionChanged -= h)
            .Select(x => x.EventArgs);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Returns an observable for the `SelectionChanged` event on the specified object.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable for the `SelectionChanged` event on the specified object.</returns>
    public static IObservable<Avalonia.Controls.SelectionChangedEventArgs> ObserveOnSelectionChangedEvent(this Avalonia.Controls.Primitives.SelectingItemsControl obj)
    {
        return Observable
            .FromEventPattern<EventHandler<Avalonia.Controls.SelectionChangedEventArgs>, Avalonia.Controls.SelectionChangedEventArgs>(
                h => obj.SelectionChanged += h, 
                h => obj.SelectionChanged -= h)
            .Select(x => x.EventArgs);
    }
}