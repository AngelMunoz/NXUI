// <auto-generated />
namespace MinimalAvalonia.Extensions;

public static partial class ImageDrawingSetters
{
    // ImageSourceProperty

    public static Style SetImageDrawingImageSource(this Style style, Avalonia.Media.IImage value)
    {
        style.Setters.Add(new Setter(Avalonia.Media.ImageDrawing.ImageSourceProperty, value));
        return style;
    }

    public static Style SetImageDrawingImageSource(this Style style, Avalonia.Data.IBinding binding)
    {
        style.Setters.Add(new Setter(Avalonia.Media.ImageDrawing.ImageSourceProperty, binding));
        return style;
    }

    public static Style SetImageDrawingImageSource(this Style style, IObservable<Avalonia.Media.IImage> observable)
    {
        style.Setters.Add(new Setter(Avalonia.Media.ImageDrawing.ImageSourceProperty, observable.ToBinding()));
        return style;
    }

    public static KeyFrame SetImageDrawingImageSource(this KeyFrame keyFrame, Avalonia.Media.IImage value)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Media.ImageDrawing.ImageSourceProperty, value));
        return keyFrame;
    }

    public static KeyFrame SetImageDrawingImageSource(this KeyFrame keyFrame, Avalonia.Data.IBinding binding)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Media.ImageDrawing.ImageSourceProperty, binding));
        return keyFrame;
    }

    public static KeyFrame SetImageDrawingImageSource(this KeyFrame keyFrame, IObservable<Avalonia.Media.IImage> observable)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Media.ImageDrawing.ImageSourceProperty, observable.ToBinding()));
        return keyFrame;
    }

    // RectProperty

    public static Style SetImageDrawingRect(this Style style, Avalonia.Rect value)
    {
        style.Setters.Add(new Setter(Avalonia.Media.ImageDrawing.RectProperty, value));
        return style;
    }

    public static Style SetImageDrawingRect(this Style style, Avalonia.Data.IBinding binding)
    {
        style.Setters.Add(new Setter(Avalonia.Media.ImageDrawing.RectProperty, binding));
        return style;
    }

    public static Style SetImageDrawingRect(this Style style, IObservable<Avalonia.Rect> observable)
    {
        style.Setters.Add(new Setter(Avalonia.Media.ImageDrawing.RectProperty, observable.ToBinding()));
        return style;
    }

    public static KeyFrame SetImageDrawingRect(this KeyFrame keyFrame, Avalonia.Rect value)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Media.ImageDrawing.RectProperty, value));
        return keyFrame;
    }

    public static KeyFrame SetImageDrawingRect(this KeyFrame keyFrame, Avalonia.Data.IBinding binding)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Media.ImageDrawing.RectProperty, binding));
        return keyFrame;
    }

    public static KeyFrame SetImageDrawingRect(this KeyFrame keyFrame, IObservable<Avalonia.Rect> observable)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Media.ImageDrawing.RectProperty, observable.ToBinding()));
        return keyFrame;
    }
}
