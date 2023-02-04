// <auto-generated />
namespace NXUI;

/// <summary>
/// The avalonia builders.
/// </summary>
public static partial class Builders
{
    /// <summary>
    /// Creates a new instance of the <see cref="Avalonia.Controls.ColumnDefinition"/> class.
    /// </summary>
    /// <returns>The new instance of the <see cref="Avalonia.Controls.ColumnDefinition"/> class.</returns>
    public static Avalonia.Controls.ColumnDefinition ColumnDefinition()
        => new();

    /// <summary>
    /// Creates a new instance of the <see cref="Avalonia.Controls.ColumnDefinition"/> class.
    /// </summary>
    /// <param name="ref">The reference of the <see cref="Avalonia.Controls.ColumnDefinition"/> instantiated class.</param>
    /// <returns>The new instance of the <see cref="Avalonia.Controls.ColumnDefinition"/> class.</returns>
    public static Avalonia.Controls.ColumnDefinition ColumnDefinition(out Avalonia.Controls.ColumnDefinition @ref)
        => @ref = new();

    /// <summary>
    /// Creates a new instance of the <see cref="Avalonia.Controls.ColumnDefinition"/> class.
    /// </summary>
    /// <param name="value">The value value.</param>
    /// <param name="type">The type value.</param>
    /// <returns>The new instance of the <see cref="Avalonia.Controls.ColumnDefinition"/> class.</returns>
    public static Avalonia.Controls.ColumnDefinition ColumnDefinition(System.Double value, Avalonia.Controls.GridUnitType type)
        => new(value, type);

    /// <summary>
    /// Creates a new instance of the <see cref="Avalonia.Controls.ColumnDefinition"/> class.
    /// </summary>
    /// <param name="ref">The reference of the <see cref="Avalonia.Controls.ColumnDefinition"/> instantiated class.</param>
    /// <param name="value">The value value.</param>
    /// <param name="type">The type value.</param>
    /// <returns>The new instance of the <see cref="Avalonia.Controls.ColumnDefinition"/> class.</returns>
    public static Avalonia.Controls.ColumnDefinition ColumnDefinition(out Avalonia.Controls.ColumnDefinition @ref, System.Double value, Avalonia.Controls.GridUnitType type)
        => @ref = new(value, type);

    /// <summary>
    /// Creates a new instance of the <see cref="Avalonia.Controls.ColumnDefinition"/> class.
    /// </summary>
    /// <param name="width">The width value.</param>
    /// <returns>The new instance of the <see cref="Avalonia.Controls.ColumnDefinition"/> class.</returns>
    public static Avalonia.Controls.ColumnDefinition ColumnDefinition(Avalonia.Controls.GridLength width)
        => new(width);

    /// <summary>
    /// Creates a new instance of the <see cref="Avalonia.Controls.ColumnDefinition"/> class.
    /// </summary>
    /// <param name="ref">The reference of the <see cref="Avalonia.Controls.ColumnDefinition"/> instantiated class.</param>
    /// <param name="width">The width value.</param>
    /// <returns>The new instance of the <see cref="Avalonia.Controls.ColumnDefinition"/> class.</returns>
    public static Avalonia.Controls.ColumnDefinition ColumnDefinition(out Avalonia.Controls.ColumnDefinition @ref, Avalonia.Controls.GridLength width)
        => @ref = new(width);
}