// <auto-generated />
namespace NXUI.Extensions;

/// <summary>
/// The avalonia <see cref="Avalonia.Controls.Primitives.PopupRoot"/> class style setters extension methods.
/// </summary>
public static partial class PopupRootSetters
{
    // Avalonia.Controls.Primitives.PopupRoot.TransformProperty

    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Controls.Primitives.PopupRoot.TransformProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="value">The property value.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetPopupRootTransform(this Style style, Avalonia.Media.Transform value)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.Primitives.PopupRoot.TransformProperty, value));
        return style;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Controls.Primitives.PopupRoot.TransformProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="value">The property value.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetPopupRootTransform(this KeyFrame keyFrame, Avalonia.Media.Transform value)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.Primitives.PopupRoot.TransformProperty, value));
        return keyFrame;
    }
    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Controls.Primitives.PopupRoot.TransformProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="observable">The property observable.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetPopupRootTransform(this Style style, IObservable<Avalonia.Media.Transform> observable)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.Primitives.PopupRoot.TransformProperty, observable.ToBinding()));
        return style;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Controls.Primitives.PopupRoot.TransformProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="observable">The property binding.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetPopupRootTransform(this KeyFrame keyFrame, IObservable<Avalonia.Media.Transform> observable)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.Primitives.PopupRoot.TransformProperty, observable.ToBinding()));
        return keyFrame;
    }
    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Controls.Primitives.PopupRoot.TransformProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="binding">The property binding.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetPopupRootTransform(this Style style, Avalonia.Data.IBinding binding)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.Primitives.PopupRoot.TransformProperty, binding));
        return style;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Controls.Primitives.PopupRoot.TransformProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="binding">The property binding.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetPopupRootTransform(this KeyFrame keyFrame, Avalonia.Data.IBinding binding)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.Primitives.PopupRoot.TransformProperty, binding));
        return keyFrame;
    }
}