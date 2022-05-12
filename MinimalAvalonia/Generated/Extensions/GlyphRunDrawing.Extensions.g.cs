// <auto-generated />
namespace MinimalAvalonia.Extensions;

public static partial class GlyphRunDrawingExtensions
{
    // ForegroundProperty

    public static T Foreground<T>(this T obj, Avalonia.Media.IBrush value) where T : Avalonia.Media.GlyphRunDrawing
    {
        obj[Avalonia.Media.GlyphRunDrawing.ForegroundProperty] = value;
        return obj;
    }

    public static T Foreground<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Media.GlyphRunDrawing
    {
        obj[Avalonia.Media.GlyphRunDrawing.ForegroundProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T Foreground<T>(this T obj, IObservable<Avalonia.Media.IBrush> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Media.GlyphRunDrawing
    {
        obj[Avalonia.Media.GlyphRunDrawing.ForegroundProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindForeground(this Avalonia.Media.GlyphRunDrawing obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Media.GlyphRunDrawing.ForegroundProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Media.IBrush> ObserveForeground(this Avalonia.Media.GlyphRunDrawing obj)
    {
        return obj.GetObservable(Avalonia.Media.GlyphRunDrawing.ForegroundProperty);
    }

    // GlyphRunProperty

    public static T GlyphRun<T>(this T obj, Avalonia.Media.GlyphRun value) where T : Avalonia.Media.GlyphRunDrawing
    {
        obj[Avalonia.Media.GlyphRunDrawing.GlyphRunProperty] = value;
        return obj;
    }

    public static T GlyphRun<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Media.GlyphRunDrawing
    {
        obj[Avalonia.Media.GlyphRunDrawing.GlyphRunProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T GlyphRun<T>(this T obj, IObservable<Avalonia.Media.GlyphRun> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Media.GlyphRunDrawing
    {
        obj[Avalonia.Media.GlyphRunDrawing.GlyphRunProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindGlyphRun(this Avalonia.Media.GlyphRunDrawing obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Media.GlyphRunDrawing.GlyphRunProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Media.GlyphRun> ObserveGlyphRun(this Avalonia.Media.GlyphRunDrawing obj)
    {
        return obj.GetObservable(Avalonia.Media.GlyphRunDrawing.GlyphRunProperty);
    }
}