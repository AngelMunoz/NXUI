// <auto-generated />
namespace NXUI;

/// <summary>
/// The minimal avalonia builders.
/// </summary>
public static partial class Builders
{
    /// <summary>
    /// Creates a new instance of the <see cref="Avalonia.Animation.AnimatorKeyFrame"/> class.
    /// </summary>
    /// <returns>The new instance of the <see cref="Avalonia.Animation.AnimatorKeyFrame"/> class.</returns>
    public static Avalonia.Animation.AnimatorKeyFrame AnimatorKeyFrame()
        => new();

    /// <summary>
    /// Creates a new instance of the <see cref="Avalonia.Animation.AnimatorKeyFrame"/> class.
    /// </summary>
    /// <param name="ref">The reference of the <see cref="Avalonia.Animation.AnimatorKeyFrame"/> instantiated class.</param>
    /// <returns>The new instance of the <see cref="Avalonia.Animation.AnimatorKeyFrame"/> class.</returns>
    public static Avalonia.Animation.AnimatorKeyFrame AnimatorKeyFrame(out Avalonia.Animation.AnimatorKeyFrame @ref)
        => @ref = new();

    /// <summary>
    /// Creates a new instance of the <see cref="Avalonia.Animation.AnimatorKeyFrame"/> class.
    /// </summary>
    /// <param name="animatorType">The animatorType value.</param>
    /// <param name="animatorFactory">The animatorFactory value.</param>
    /// <param name="cue">The cue value.</param>
    /// <returns>The new instance of the <see cref="Avalonia.Animation.AnimatorKeyFrame"/> class.</returns>
    public static Avalonia.Animation.AnimatorKeyFrame AnimatorKeyFrame(System.Type animatorType, System.Func<Avalonia.Animation.IAnimator> animatorFactory, Avalonia.Animation.Cue cue)
        => new(animatorType, animatorFactory, cue);

    /// <summary>
    /// Creates a new instance of the <see cref="Avalonia.Animation.AnimatorKeyFrame"/> class.
    /// </summary>
    /// <param name="ref">The reference of the <see cref="Avalonia.Animation.AnimatorKeyFrame"/> instantiated class.</param>
    /// <param name="animatorType">The animatorType value.</param>
    /// <param name="animatorFactory">The animatorFactory value.</param>
    /// <param name="cue">The cue value.</param>
    /// <returns>The new instance of the <see cref="Avalonia.Animation.AnimatorKeyFrame"/> class.</returns>
    public static Avalonia.Animation.AnimatorKeyFrame AnimatorKeyFrame(out Avalonia.Animation.AnimatorKeyFrame @ref, System.Type animatorType, System.Func<Avalonia.Animation.IAnimator> animatorFactory, Avalonia.Animation.Cue cue)
        => @ref = new(animatorType, animatorFactory, cue);

    /// <summary>
    /// Creates a new instance of the <see cref="Avalonia.Animation.AnimatorKeyFrame"/> class.
    /// </summary>
    /// <param name="animatorType">The animatorType value.</param>
    /// <param name="animatorFactory">The animatorFactory value.</param>
    /// <param name="cue">The cue value.</param>
    /// <param name="keySpline">The keySpline value.</param>
    /// <returns>The new instance of the <see cref="Avalonia.Animation.AnimatorKeyFrame"/> class.</returns>
    public static Avalonia.Animation.AnimatorKeyFrame AnimatorKeyFrame(System.Type animatorType, System.Func<Avalonia.Animation.IAnimator> animatorFactory, Avalonia.Animation.Cue cue, Avalonia.Animation.KeySpline keySpline)
        => new(animatorType, animatorFactory, cue, keySpline);

    /// <summary>
    /// Creates a new instance of the <see cref="Avalonia.Animation.AnimatorKeyFrame"/> class.
    /// </summary>
    /// <param name="ref">The reference of the <see cref="Avalonia.Animation.AnimatorKeyFrame"/> instantiated class.</param>
    /// <param name="animatorType">The animatorType value.</param>
    /// <param name="animatorFactory">The animatorFactory value.</param>
    /// <param name="cue">The cue value.</param>
    /// <param name="keySpline">The keySpline value.</param>
    /// <returns>The new instance of the <see cref="Avalonia.Animation.AnimatorKeyFrame"/> class.</returns>
    public static Avalonia.Animation.AnimatorKeyFrame AnimatorKeyFrame(out Avalonia.Animation.AnimatorKeyFrame @ref, System.Type animatorType, System.Func<Avalonia.Animation.IAnimator> animatorFactory, Avalonia.Animation.Cue cue, Avalonia.Animation.KeySpline keySpline)
        => @ref = new(animatorType, animatorFactory, cue, keySpline);
}
