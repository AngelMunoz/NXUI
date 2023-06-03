// <auto-generated />
namespace NXUI.FSharp.Extensions;

/// <summary>
/// The avalonia <see cref="Avalonia.Media.TransformGroup"/> class property extension methods.
/// </summary>
public static partial class TransformGroupExtensions
{
    // Avalonia.Media.TransformGroup.ChildrenProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Media.TransformGroup.ChildrenProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T children<T>(this T obj, Avalonia.Media.Transforms value) where T : Avalonia.Media.TransformGroup
    {
        obj[Avalonia.Media.TransformGroup.ChildrenProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Media.TransformGroup.ChildrenProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T children<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Media.TransformGroup
    {
        var descriptor = Avalonia.Media.TransformGroup.ChildrenProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Media.TransformGroup.ChildrenProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T children<T>(
        this T obj,
        IObservable<Avalonia.Media.Transforms> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Media.TransformGroup
    {
        var descriptor = Avalonia.Media.TransformGroup.ChildrenProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Media.TransformGroup.ChildrenProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Media.TransformGroup.ChildrenProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindChildren(
        this Avalonia.Media.TransformGroup obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.TransformGroup.ChildrenProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Media.TransformGroup.ChildrenProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<Avalonia.Media.Transforms> ObserveChildren(this Avalonia.Media.TransformGroup obj)
    {
        return obj.GetObservable(Avalonia.Media.TransformGroup.ChildrenProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Media.TransformGroup.ChildrenProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnChildren<T>(this T obj, Action<Avalonia.Media.TransformGroup, IObservable<Avalonia.Media.Transforms>> handler) where T : Avalonia.Media.TransformGroup
    {
        var observable = obj.GetObservable(Avalonia.Media.TransformGroup.ChildrenProperty);
        handler(obj, observable);
        return obj;
    }
}
