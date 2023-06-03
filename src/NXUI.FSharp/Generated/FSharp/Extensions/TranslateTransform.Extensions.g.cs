// <auto-generated />
namespace NXUI.FSharp.Extensions;

/// <summary>
/// The avalonia <see cref="Avalonia.Media.TranslateTransform"/> class property extension methods.
/// </summary>
public static partial class TranslateTransformExtensions
{
    // Avalonia.Media.TranslateTransform.XProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Media.TranslateTransform.XProperty"/> value on an object of type <see cref="Avalonia.Media.TranslateTransform"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value to set for the property.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Media.TranslateTransform x(this Avalonia.Media.TranslateTransform obj, System.Double value)
    {
        obj[Avalonia.Media.TranslateTransform.XProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Media.TranslateTransform.XProperty"/> on an object of type <see cref="Avalonia.Media.TranslateTransform"/> with a source binding specified as a parameter.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Media.TranslateTransform x(
        this Avalonia.Media.TranslateTransform obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.TranslateTransform.XProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Media.TranslateTransform.XProperty"/> on an object of type <see cref="Avalonia.Media.TranslateTransform"/> with a source binding specified as an observable.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Media.TranslateTransform x(
        this Avalonia.Media.TranslateTransform obj,
        IObservable<System.Double> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.TranslateTransform.XProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Media.TranslateTransform.XProperty"/> binding on an object of type <see cref="Avalonia.Media.TranslateTransform"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Media.TranslateTransform.XProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindX(
        this Avalonia.Media.TranslateTransform obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.TranslateTransform.XProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Media.TranslateTransform.XProperty"/> on an object of type <see cref="Avalonia.Media.TranslateTransform"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the object, and thereafter whenever the property changes.
    /// </returns>
    public static IObservable<System.Double> ObserveX(this Avalonia.Media.TranslateTransform obj)
    {
        return obj.GetObservable(Avalonia.Media.TranslateTransform.XProperty);
    }

    /// <summary>
    /// Registers a handler for the <see cref="Avalonia.Media.TranslateTransform.XProperty"/> property on an object of type <see cref="Avalonia.Media.TranslateTransform"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler to be called when the property changes.</param>
    /// <returns>The target object.</returns>
    public static Avalonia.Media.TranslateTransform OnX(this Avalonia.Media.TranslateTransform obj, Action<Avalonia.Media.TranslateTransform, IObservable<System.Double>> handler)
    {
        var observable = obj.GetObservable(Avalonia.Media.TranslateTransform.XProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Media.TranslateTransform.YProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Media.TranslateTransform.YProperty"/> value on an object of type <see cref="Avalonia.Media.TranslateTransform"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value to set for the property.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Media.TranslateTransform y(this Avalonia.Media.TranslateTransform obj, System.Double value)
    {
        obj[Avalonia.Media.TranslateTransform.YProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Media.TranslateTransform.YProperty"/> on an object of type <see cref="Avalonia.Media.TranslateTransform"/> with a source binding specified as a parameter.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Media.TranslateTransform y(
        this Avalonia.Media.TranslateTransform obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.TranslateTransform.YProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Media.TranslateTransform.YProperty"/> on an object of type <see cref="Avalonia.Media.TranslateTransform"/> with a source binding specified as an observable.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Media.TranslateTransform y(
        this Avalonia.Media.TranslateTransform obj,
        IObservable<System.Double> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.TranslateTransform.YProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Media.TranslateTransform.YProperty"/> binding on an object of type <see cref="Avalonia.Media.TranslateTransform"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Media.TranslateTransform.YProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindY(
        this Avalonia.Media.TranslateTransform obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.TranslateTransform.YProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Media.TranslateTransform.YProperty"/> on an object of type <see cref="Avalonia.Media.TranslateTransform"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the object, and thereafter whenever the property changes.
    /// </returns>
    public static IObservable<System.Double> ObserveY(this Avalonia.Media.TranslateTransform obj)
    {
        return obj.GetObservable(Avalonia.Media.TranslateTransform.YProperty);
    }

    /// <summary>
    /// Registers a handler for the <see cref="Avalonia.Media.TranslateTransform.YProperty"/> property on an object of type <see cref="Avalonia.Media.TranslateTransform"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler to be called when the property changes.</param>
    /// <returns>The target object.</returns>
    public static Avalonia.Media.TranslateTransform OnY(this Avalonia.Media.TranslateTransform obj, Action<Avalonia.Media.TranslateTransform, IObservable<System.Double>> handler)
    {
        var observable = obj.GetObservable(Avalonia.Media.TranslateTransform.YProperty);
        handler(obj, observable);
        return obj;
    }
}