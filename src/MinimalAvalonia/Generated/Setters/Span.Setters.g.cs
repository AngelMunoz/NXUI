// <auto-generated />
namespace MinimalAvalonia.Extensions;

public static partial class SpanSetters
{
    // InlinesProperty

    public static Style SetSpanInlines(this Style style, Avalonia.Controls.Documents.InlineCollection value)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.Documents.Span.InlinesProperty, value));
        return style;
    }

    public static Style SetSpanInlines(this Style style, Avalonia.Data.IBinding binding)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.Documents.Span.InlinesProperty, binding));
        return style;
    }

    public static Style SetSpanInlines(this Style style, IObservable<Avalonia.Controls.Documents.InlineCollection> observable)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.Documents.Span.InlinesProperty, observable.ToBinding()));
        return style;
    }

    public static KeyFrame SetSpanInlines(this KeyFrame keyFrame, Avalonia.Controls.Documents.InlineCollection value)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.Documents.Span.InlinesProperty, value));
        return keyFrame;
    }

    public static KeyFrame SetSpanInlines(this KeyFrame keyFrame, Avalonia.Data.IBinding binding)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.Documents.Span.InlinesProperty, binding));
        return keyFrame;
    }

    public static KeyFrame SetSpanInlines(this KeyFrame keyFrame, IObservable<Avalonia.Controls.Documents.InlineCollection> observable)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.Documents.Span.InlinesProperty, observable.ToBinding()));
        return keyFrame;
    }
}