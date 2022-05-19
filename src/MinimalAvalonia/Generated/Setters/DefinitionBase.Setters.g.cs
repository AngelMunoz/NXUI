// <auto-generated />
namespace MinimalAvalonia.Extensions;

public static partial class DefinitionBaseSetters
{
    // SharedSizeGroupProperty

    public static Style SetDefinitionBaseSharedSizeGroup(this Style style, System.String value)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.DefinitionBase.SharedSizeGroupProperty, value));
        return style;
    }

    public static Style SetDefinitionBaseSharedSizeGroup(this Style style, Avalonia.Data.IBinding binding)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.DefinitionBase.SharedSizeGroupProperty, binding));
        return style;
    }

    public static Style SetDefinitionBaseSharedSizeGroup(this Style style, IObservable<System.String> observable)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.DefinitionBase.SharedSizeGroupProperty, observable.ToBinding()));
        return style;
    }

    public static KeyFrame SetDefinitionBaseSharedSizeGroup(this KeyFrame keyFrame, System.String value)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.DefinitionBase.SharedSizeGroupProperty, value));
        return keyFrame;
    }

    public static KeyFrame SetDefinitionBaseSharedSizeGroup(this KeyFrame keyFrame, Avalonia.Data.IBinding binding)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.DefinitionBase.SharedSizeGroupProperty, binding));
        return keyFrame;
    }

    public static KeyFrame SetDefinitionBaseSharedSizeGroup(this KeyFrame keyFrame, IObservable<System.String> observable)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.DefinitionBase.SharedSizeGroupProperty, observable.ToBinding()));
        return keyFrame;
    }
}
