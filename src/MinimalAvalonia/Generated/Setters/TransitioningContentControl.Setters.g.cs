// <auto-generated />
namespace MinimalAvalonia.Extensions;

public static partial class TransitioningContentControlSetters
{
    // PageTransitionProperty

    public static Style SetTransitioningContentControlPageTransition(this Style style, Avalonia.Animation.IPageTransition value)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.TransitioningContentControl.PageTransitionProperty, value));
        return style;
    }

    public static Style SetTransitioningContentControlPageTransition(this Style style, Avalonia.Data.IBinding binding)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.TransitioningContentControl.PageTransitionProperty, binding));
        return style;
    }

    public static Style SetTransitioningContentControlPageTransition(this Style style, IObservable<Avalonia.Animation.IPageTransition> observable)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.TransitioningContentControl.PageTransitionProperty, observable.ToBinding()));
        return style;
    }

    public static KeyFrame SetTransitioningContentControlPageTransition(this KeyFrame keyFrame, Avalonia.Animation.IPageTransition value)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.TransitioningContentControl.PageTransitionProperty, value));
        return keyFrame;
    }

    public static KeyFrame SetTransitioningContentControlPageTransition(this KeyFrame keyFrame, Avalonia.Data.IBinding binding)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.TransitioningContentControl.PageTransitionProperty, binding));
        return keyFrame;
    }

    public static KeyFrame SetTransitioningContentControlPageTransition(this KeyFrame keyFrame, IObservable<Avalonia.Animation.IPageTransition> observable)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.TransitioningContentControl.PageTransitionProperty, observable.ToBinding()));
        return keyFrame;
    }

    // CurrentContentProperty

    public static Style SetTransitioningContentControlCurrentContent(this Style style, System.Object value)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.TransitioningContentControl.CurrentContentProperty, value));
        return style;
    }

    public static Style SetTransitioningContentControlCurrentContent(this Style style, Avalonia.Data.IBinding binding)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.TransitioningContentControl.CurrentContentProperty, binding));
        return style;
    }

    public static Style SetTransitioningContentControlCurrentContent(this Style style, IObservable<System.Object> observable)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.TransitioningContentControl.CurrentContentProperty, observable.ToBinding()));
        return style;
    }

    public static KeyFrame SetTransitioningContentControlCurrentContent(this KeyFrame keyFrame, System.Object value)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.TransitioningContentControl.CurrentContentProperty, value));
        return keyFrame;
    }

    public static KeyFrame SetTransitioningContentControlCurrentContent(this KeyFrame keyFrame, Avalonia.Data.IBinding binding)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.TransitioningContentControl.CurrentContentProperty, binding));
        return keyFrame;
    }

    public static KeyFrame SetTransitioningContentControlCurrentContent(this KeyFrame keyFrame, IObservable<System.Object> observable)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.TransitioningContentControl.CurrentContentProperty, observable.ToBinding()));
        return keyFrame;
    }
}
