// <auto-generated />
namespace NXUI.Extensions;

/// <summary>
/// The avalonia <see cref="Avalonia.Controls.Primitives.HeaderedItemsControl"/> class property extension methods.
/// </summary>
public static partial class HeaderedItemsControlExtensions
{
    // Avalonia.Controls.Primitives.HeaderedItemsControl.HeaderProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Primitives.HeaderedItemsControl.HeaderProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Header<T>(this T obj, System.Object value) where T : Avalonia.Controls.Primitives.HeaderedItemsControl
    {
        obj[Avalonia.Controls.Primitives.HeaderedItemsControl.HeaderProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Primitives.HeaderedItemsControl.HeaderProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Header<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Primitives.HeaderedItemsControl
    {
        var descriptor = Avalonia.Controls.Primitives.HeaderedItemsControl.HeaderProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Primitives.HeaderedItemsControl.HeaderProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Header<T>(
        this T obj,
        IObservable<System.Object> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Primitives.HeaderedItemsControl
    {
        var descriptor = Avalonia.Controls.Primitives.HeaderedItemsControl.HeaderProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.Primitives.HeaderedItemsControl.HeaderProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.Primitives.HeaderedItemsControl.HeaderProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindHeader(
        this Avalonia.Controls.Primitives.HeaderedItemsControl obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.Primitives.HeaderedItemsControl.HeaderProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.Primitives.HeaderedItemsControl.HeaderProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.Object> ObserveHeader(this Avalonia.Controls.Primitives.HeaderedItemsControl obj)
    {
        return obj.GetObservable(Avalonia.Controls.Primitives.HeaderedItemsControl.HeaderProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.Primitives.HeaderedItemsControl.HeaderProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnHeader<T>(this T obj, Action<Avalonia.Controls.Primitives.HeaderedItemsControl, IObservable<System.Object>> handler) where T : Avalonia.Controls.Primitives.HeaderedItemsControl
    {
        var observable = obj.GetObservable(Avalonia.Controls.Primitives.HeaderedItemsControl.HeaderProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.Primitives.HeaderedItemsControl.HeaderTemplateProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Primitives.HeaderedItemsControl.HeaderTemplateProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T HeaderTemplate<T>(this T obj, Avalonia.Controls.Templates.IDataTemplate value) where T : Avalonia.Controls.Primitives.HeaderedItemsControl
    {
        obj[Avalonia.Controls.Primitives.HeaderedItemsControl.HeaderTemplateProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Primitives.HeaderedItemsControl.HeaderTemplateProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T HeaderTemplate<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Primitives.HeaderedItemsControl
    {
        var descriptor = Avalonia.Controls.Primitives.HeaderedItemsControl.HeaderTemplateProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Primitives.HeaderedItemsControl.HeaderTemplateProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T HeaderTemplate<T>(
        this T obj,
        IObservable<Avalonia.Controls.Templates.IDataTemplate> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Primitives.HeaderedItemsControl
    {
        var descriptor = Avalonia.Controls.Primitives.HeaderedItemsControl.HeaderTemplateProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.Primitives.HeaderedItemsControl.HeaderTemplateProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.Primitives.HeaderedItemsControl.HeaderTemplateProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindHeaderTemplate(
        this Avalonia.Controls.Primitives.HeaderedItemsControl obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.Primitives.HeaderedItemsControl.HeaderTemplateProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.Primitives.HeaderedItemsControl.HeaderTemplateProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<Avalonia.Controls.Templates.IDataTemplate> ObserveHeaderTemplate(this Avalonia.Controls.Primitives.HeaderedItemsControl obj)
    {
        return obj.GetObservable(Avalonia.Controls.Primitives.HeaderedItemsControl.HeaderTemplateProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.Primitives.HeaderedItemsControl.HeaderTemplateProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnHeaderTemplate<T>(this T obj, Action<Avalonia.Controls.Primitives.HeaderedItemsControl, IObservable<Avalonia.Controls.Templates.IDataTemplate>> handler) where T : Avalonia.Controls.Primitives.HeaderedItemsControl
    {
        var observable = obj.GetObservable(Avalonia.Controls.Primitives.HeaderedItemsControl.HeaderTemplateProperty);
        handler(obj, observable);
        return obj;
    }
}
