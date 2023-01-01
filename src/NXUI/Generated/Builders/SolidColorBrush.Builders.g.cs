// <auto-generated />
namespace NXUI;

/// <summary>
/// The minimal avalonia builders.
/// </summary>
public static partial class Builders
{
    /// <summary>
    /// Creates a new instance of the <see cref="Avalonia.Media.SolidColorBrush"/> class.
    /// </summary>
    /// <returns>The new instance of the <see cref="Avalonia.Media.SolidColorBrush"/> class.</returns>
    public static Avalonia.Media.SolidColorBrush SolidColorBrush()
        => new();

    /// <summary>
    /// Creates a new instance of the <see cref="Avalonia.Media.SolidColorBrush"/> class.
    /// </summary>
    /// <param name="ref">The reference of the <see cref="Avalonia.Media.SolidColorBrush"/> instantiated class.</param>
    /// <returns>The new instance of the <see cref="Avalonia.Media.SolidColorBrush"/> class.</returns>
    public static Avalonia.Media.SolidColorBrush SolidColorBrush(out Avalonia.Media.SolidColorBrush @ref)
        => @ref = new();

    /// <summary>
    /// Creates a new instance of the <see cref="Avalonia.Media.SolidColorBrush"/> class.
    /// </summary>
    /// <param name="color">The color value.</param>
    /// <param name="opacity">The opacity value.</param>
    /// <returns>The new instance of the <see cref="Avalonia.Media.SolidColorBrush"/> class.</returns>
    public static Avalonia.Media.SolidColorBrush SolidColorBrush(Avalonia.Media.Color color, System.Double opacity = 1)
        => new(color, opacity);

    /// <summary>
    /// Creates a new instance of the <see cref="Avalonia.Media.SolidColorBrush"/> class.
    /// </summary>
    /// <param name="ref">The reference of the <see cref="Avalonia.Media.SolidColorBrush"/> instantiated class.</param>
    /// <param name="color">The color value.</param>
    /// <param name="opacity">The opacity value.</param>
    /// <returns>The new instance of the <see cref="Avalonia.Media.SolidColorBrush"/> class.</returns>
    public static Avalonia.Media.SolidColorBrush SolidColorBrush(out Avalonia.Media.SolidColorBrush @ref, Avalonia.Media.Color color, System.Double opacity = 1)
        => @ref = new(color, opacity);

    /// <summary>
    /// Creates a new instance of the <see cref="Avalonia.Media.SolidColorBrush"/> class.
    /// </summary>
    /// <param name="color">The color value.</param>
    /// <returns>The new instance of the <see cref="Avalonia.Media.SolidColorBrush"/> class.</returns>
    public static Avalonia.Media.SolidColorBrush SolidColorBrush(System.UInt32 color)
        => new(color);

    /// <summary>
    /// Creates a new instance of the <see cref="Avalonia.Media.SolidColorBrush"/> class.
    /// </summary>
    /// <param name="ref">The reference of the <see cref="Avalonia.Media.SolidColorBrush"/> instantiated class.</param>
    /// <param name="color">The color value.</param>
    /// <returns>The new instance of the <see cref="Avalonia.Media.SolidColorBrush"/> class.</returns>
    public static Avalonia.Media.SolidColorBrush SolidColorBrush(out Avalonia.Media.SolidColorBrush @ref, System.UInt32 color)
        => @ref = new(color);
}
