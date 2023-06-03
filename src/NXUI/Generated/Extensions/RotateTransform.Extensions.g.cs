// <auto-generated />
namespace NXUI.Extensions;

/// <summary>
/// The avalonia <see cref="Avalonia.Media.RotateTransform"/> class property extension methods.
/// </summary>
public static partial class RotateTransformExtensions
{
    // Avalonia.Media.RotateTransform.AngleProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Media.RotateTransform.AngleProperty"/> value on an object of type <see cref="Avalonia.Media.RotateTransform"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value to set for the property.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Media.RotateTransform Angle(this Avalonia.Media.RotateTransform obj, System.Double value)
    {
        obj[Avalonia.Media.RotateTransform.AngleProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Media.RotateTransform.AngleProperty"/> on an object of type <see cref="Avalonia.Media.RotateTransform"/> with a source binding specified as a parameter.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Media.RotateTransform Angle(
        this Avalonia.Media.RotateTransform obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.RotateTransform.AngleProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Media.RotateTransform.AngleProperty"/> on an object of type <see cref="Avalonia.Media.RotateTransform"/> with a source binding specified as an observable.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Media.RotateTransform Angle(
        this Avalonia.Media.RotateTransform obj,
        IObservable<System.Double> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.RotateTransform.AngleProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Media.RotateTransform.AngleProperty"/> binding on an object of type <see cref="Avalonia.Media.RotateTransform"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Media.RotateTransform.AngleProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindAngle(
        this Avalonia.Media.RotateTransform obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.RotateTransform.AngleProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Media.RotateTransform.AngleProperty"/> on an object of type <see cref="Avalonia.Media.RotateTransform"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the object, and thereafter whenever the property changes.
    /// </returns>
    public static IObservable<System.Double> ObserveAngle(this Avalonia.Media.RotateTransform obj)
    {
        return obj.GetObservable(Avalonia.Media.RotateTransform.AngleProperty);
    }

    /// <summary>
    /// Registers a handler for the <see cref="Avalonia.Media.RotateTransform.AngleProperty"/> property on an object of type <see cref="Avalonia.Media.RotateTransform"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler to be called when the property changes.</param>
    /// <returns>The target object.</returns>
    public static Avalonia.Media.RotateTransform OnAngle(this Avalonia.Media.RotateTransform obj, Action<Avalonia.Media.RotateTransform, IObservable<System.Double>> handler)
    {
        var observable = obj.GetObservable(Avalonia.Media.RotateTransform.AngleProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Media.RotateTransform.CenterXProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Media.RotateTransform.CenterXProperty"/> value on an object of type <see cref="Avalonia.Media.RotateTransform"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value to set for the property.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Media.RotateTransform CenterX(this Avalonia.Media.RotateTransform obj, System.Double value)
    {
        obj[Avalonia.Media.RotateTransform.CenterXProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Media.RotateTransform.CenterXProperty"/> on an object of type <see cref="Avalonia.Media.RotateTransform"/> with a source binding specified as a parameter.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Media.RotateTransform CenterX(
        this Avalonia.Media.RotateTransform obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.RotateTransform.CenterXProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Media.RotateTransform.CenterXProperty"/> on an object of type <see cref="Avalonia.Media.RotateTransform"/> with a source binding specified as an observable.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Media.RotateTransform CenterX(
        this Avalonia.Media.RotateTransform obj,
        IObservable<System.Double> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.RotateTransform.CenterXProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Media.RotateTransform.CenterXProperty"/> binding on an object of type <see cref="Avalonia.Media.RotateTransform"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Media.RotateTransform.CenterXProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindCenterX(
        this Avalonia.Media.RotateTransform obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.RotateTransform.CenterXProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Media.RotateTransform.CenterXProperty"/> on an object of type <see cref="Avalonia.Media.RotateTransform"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the object, and thereafter whenever the property changes.
    /// </returns>
    public static IObservable<System.Double> ObserveCenterX(this Avalonia.Media.RotateTransform obj)
    {
        return obj.GetObservable(Avalonia.Media.RotateTransform.CenterXProperty);
    }

    /// <summary>
    /// Registers a handler for the <see cref="Avalonia.Media.RotateTransform.CenterXProperty"/> property on an object of type <see cref="Avalonia.Media.RotateTransform"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler to be called when the property changes.</param>
    /// <returns>The target object.</returns>
    public static Avalonia.Media.RotateTransform OnCenterX(this Avalonia.Media.RotateTransform obj, Action<Avalonia.Media.RotateTransform, IObservable<System.Double>> handler)
    {
        var observable = obj.GetObservable(Avalonia.Media.RotateTransform.CenterXProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Media.RotateTransform.CenterYProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Media.RotateTransform.CenterYProperty"/> value on an object of type <see cref="Avalonia.Media.RotateTransform"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value to set for the property.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Media.RotateTransform CenterY(this Avalonia.Media.RotateTransform obj, System.Double value)
    {
        obj[Avalonia.Media.RotateTransform.CenterYProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Media.RotateTransform.CenterYProperty"/> on an object of type <see cref="Avalonia.Media.RotateTransform"/> with a source binding specified as a parameter.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Media.RotateTransform CenterY(
        this Avalonia.Media.RotateTransform obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.RotateTransform.CenterYProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Media.RotateTransform.CenterYProperty"/> on an object of type <see cref="Avalonia.Media.RotateTransform"/> with a source binding specified as an observable.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Media.RotateTransform CenterY(
        this Avalonia.Media.RotateTransform obj,
        IObservable<System.Double> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.RotateTransform.CenterYProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Media.RotateTransform.CenterYProperty"/> binding on an object of type <see cref="Avalonia.Media.RotateTransform"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Media.RotateTransform.CenterYProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindCenterY(
        this Avalonia.Media.RotateTransform obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.RotateTransform.CenterYProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Media.RotateTransform.CenterYProperty"/> on an object of type <see cref="Avalonia.Media.RotateTransform"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the object, and thereafter whenever the property changes.
    /// </returns>
    public static IObservable<System.Double> ObserveCenterY(this Avalonia.Media.RotateTransform obj)
    {
        return obj.GetObservable(Avalonia.Media.RotateTransform.CenterYProperty);
    }

    /// <summary>
    /// Registers a handler for the <see cref="Avalonia.Media.RotateTransform.CenterYProperty"/> property on an object of type <see cref="Avalonia.Media.RotateTransform"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler to be called when the property changes.</param>
    /// <returns>The target object.</returns>
    public static Avalonia.Media.RotateTransform OnCenterY(this Avalonia.Media.RotateTransform obj, Action<Avalonia.Media.RotateTransform, IObservable<System.Double>> handler)
    {
        var observable = obj.GetObservable(Avalonia.Media.RotateTransform.CenterYProperty);
        handler(obj, observable);
        return obj;
    }
}
