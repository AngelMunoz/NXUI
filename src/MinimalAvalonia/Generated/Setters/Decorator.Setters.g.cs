// <auto-generated />
namespace MinimalAvalonia.Extensions;

public static partial class DecoratorSetters
{
    // ChildProperty

    public static Style SetDecoratorChild(this Style style, Avalonia.Controls.IControl value)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.Decorator.ChildProperty, value));
        return style;
    }

    public static Style SetDecoratorChild(this Style style, Avalonia.Data.IBinding binding)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.Decorator.ChildProperty, binding));
        return style;
    }

    public static Style SetDecoratorChild(this Style style, IObservable<Avalonia.Controls.IControl> observable)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.Decorator.ChildProperty, observable.ToBinding()));
        return style;
    }

    public static KeyFrame SetDecoratorChild(this KeyFrame keyFrame, Avalonia.Controls.IControl value)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.Decorator.ChildProperty, value));
        return keyFrame;
    }

    public static KeyFrame SetDecoratorChild(this KeyFrame keyFrame, Avalonia.Data.IBinding binding)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.Decorator.ChildProperty, binding));
        return keyFrame;
    }

    public static KeyFrame SetDecoratorChild(this KeyFrame keyFrame, IObservable<Avalonia.Controls.IControl> observable)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.Decorator.ChildProperty, observable.ToBinding()));
        return keyFrame;
    }

    // PaddingProperty

    public static Style SetDecoratorPadding(this Style style, Avalonia.Thickness value)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.Decorator.PaddingProperty, value));
        return style;
    }

    public static Style SetDecoratorPadding(this Style style, Avalonia.Data.IBinding binding)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.Decorator.PaddingProperty, binding));
        return style;
    }

    public static Style SetDecoratorPadding(this Style style, IObservable<Avalonia.Thickness> observable)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.Decorator.PaddingProperty, observable.ToBinding()));
        return style;
    }

    public static KeyFrame SetDecoratorPadding(this KeyFrame keyFrame, Avalonia.Thickness value)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.Decorator.PaddingProperty, value));
        return keyFrame;
    }

    public static KeyFrame SetDecoratorPadding(this KeyFrame keyFrame, Avalonia.Data.IBinding binding)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.Decorator.PaddingProperty, binding));
        return keyFrame;
    }

    public static KeyFrame SetDecoratorPadding(this KeyFrame keyFrame, IObservable<Avalonia.Thickness> observable)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.Decorator.PaddingProperty, observable.ToBinding()));
        return keyFrame;
    }
}
