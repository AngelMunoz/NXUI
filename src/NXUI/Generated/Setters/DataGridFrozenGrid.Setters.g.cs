// <auto-generated />
namespace NXUI.Extensions;

/// <summary>
/// The avalonia <see cref="Avalonia.Controls.Primitives.DataGridFrozenGrid"/> class style setters extension methods.
/// </summary>
public static partial class DataGridFrozenGridSetters
{
    // Avalonia.Controls.Primitives.DataGridFrozenGrid.IsFrozenProperty

    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Controls.Primitives.DataGridFrozenGrid.IsFrozenProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="value">The property value.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetDataGridFrozenGridIsFrozen(this Style style, System.Boolean value)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.Primitives.DataGridFrozenGrid.IsFrozenProperty, value));
        return style;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Controls.Primitives.DataGridFrozenGrid.IsFrozenProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="value">The property value.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetDataGridFrozenGridIsFrozen(this KeyFrame keyFrame, System.Boolean value)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.Primitives.DataGridFrozenGrid.IsFrozenProperty, value));
        return keyFrame;
    }
    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Controls.Primitives.DataGridFrozenGrid.IsFrozenProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="observable">The property observable.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetDataGridFrozenGridIsFrozen(this Style style, IObservable<System.Boolean> observable)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.Primitives.DataGridFrozenGrid.IsFrozenProperty, observable.ToBinding()));
        return style;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Controls.Primitives.DataGridFrozenGrid.IsFrozenProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="observable">The property binding.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetDataGridFrozenGridIsFrozen(this KeyFrame keyFrame, IObservable<System.Boolean> observable)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.Primitives.DataGridFrozenGrid.IsFrozenProperty, observable.ToBinding()));
        return keyFrame;
    }
    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Controls.Primitives.DataGridFrozenGrid.IsFrozenProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="binding">The property binding.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetDataGridFrozenGridIsFrozen(this Style style, Avalonia.Data.IBinding binding)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.Primitives.DataGridFrozenGrid.IsFrozenProperty, binding));
        return style;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Controls.Primitives.DataGridFrozenGrid.IsFrozenProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="binding">The property binding.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetDataGridFrozenGridIsFrozen(this KeyFrame keyFrame, Avalonia.Data.IBinding binding)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.Primitives.DataGridFrozenGrid.IsFrozenProperty, binding));
        return keyFrame;
    }
}