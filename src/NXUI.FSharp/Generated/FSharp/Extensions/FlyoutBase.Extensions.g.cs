// <auto-generated />
namespace NXUI.FSharp.Extensions;

/// <summary>
/// The avalonia <see cref="Avalonia.Controls.Primitives.FlyoutBase"/> class property extension methods.
/// </summary>
public static partial class FlyoutBaseExtensions
{
    // Avalonia.Controls.Primitives.FlyoutBase.IsOpenProperty

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.Primitives.FlyoutBase.IsOpenProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.Primitives.FlyoutBase.IsOpenProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindIsOpen(
        this Avalonia.Controls.Primitives.FlyoutBase obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.OneWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.Primitives.FlyoutBase.IsOpenProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.Primitives.FlyoutBase.IsOpenProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.Boolean> ObserveIsOpen(this Avalonia.Controls.Primitives.FlyoutBase obj)
    {
        return obj.GetObservable(Avalonia.Controls.Primitives.FlyoutBase.IsOpenProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.Primitives.FlyoutBase.IsOpenProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Controls.Primitives.FlyoutBase OnIsOpen(this Avalonia.Controls.Primitives.FlyoutBase obj, Action<Avalonia.Controls.Primitives.FlyoutBase, IObservable<System.Boolean>> handler)
    {
        var observable = obj.GetObservable(Avalonia.Controls.Primitives.FlyoutBase.IsOpenProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.Primitives.FlyoutBase.TargetProperty

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.Primitives.FlyoutBase.TargetProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.Primitives.FlyoutBase.TargetProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindTarget(
        this Avalonia.Controls.Primitives.FlyoutBase obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.OneWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.Primitives.FlyoutBase.TargetProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.Primitives.FlyoutBase.TargetProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<Avalonia.Controls.Control> ObserveTarget(this Avalonia.Controls.Primitives.FlyoutBase obj)
    {
        return obj.GetObservable(Avalonia.Controls.Primitives.FlyoutBase.TargetProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.Primitives.FlyoutBase.TargetProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Controls.Primitives.FlyoutBase OnTarget(this Avalonia.Controls.Primitives.FlyoutBase obj, Action<Avalonia.Controls.Primitives.FlyoutBase, IObservable<Avalonia.Controls.Control>> handler)
    {
        var observable = obj.GetObservable(Avalonia.Controls.Primitives.FlyoutBase.TargetProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.Primitives.FlyoutBase.AttachedFlyoutProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Primitives.FlyoutBase.AttachedFlyoutProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T attachedFlyout<T>(this T obj, Avalonia.Controls.Primitives.FlyoutBase value) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.Primitives.FlyoutBase.AttachedFlyoutProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Primitives.FlyoutBase.AttachedFlyoutProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T attachedFlyout<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Control
    {
        var descriptor = Avalonia.Controls.Primitives.FlyoutBase.AttachedFlyoutProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Primitives.FlyoutBase.AttachedFlyoutProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T attachedFlyout<T>(
        this T obj,
        IObservable<Avalonia.Controls.Primitives.FlyoutBase> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Control
    {
        var descriptor = Avalonia.Controls.Primitives.FlyoutBase.AttachedFlyoutProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.Primitives.FlyoutBase.AttachedFlyoutProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.Primitives.FlyoutBase.AttachedFlyoutProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindAttachedFlyout(
        this Avalonia.Controls.Control obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.Primitives.FlyoutBase.AttachedFlyoutProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.Primitives.FlyoutBase.AttachedFlyoutProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<Avalonia.Controls.Primitives.FlyoutBase> ObserveAttachedFlyout(this Avalonia.Controls.Control obj)
    {
        return obj.GetObservable(Avalonia.Controls.Primitives.FlyoutBase.AttachedFlyoutProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.Primitives.FlyoutBase.AttachedFlyoutProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnAttachedFlyout<T>(this T obj, Action<Avalonia.Controls.Control, IObservable<Avalonia.Controls.Primitives.FlyoutBase>> handler) where T : Avalonia.Controls.Control
    {
        var observable = obj.GetObservable(Avalonia.Controls.Primitives.FlyoutBase.AttachedFlyoutProperty);
        handler(obj, observable);
        return obj;
    }
}
