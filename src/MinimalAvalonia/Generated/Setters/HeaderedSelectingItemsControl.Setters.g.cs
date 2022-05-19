// <auto-generated />
namespace MinimalAvalonia.Extensions;

public static partial class HeaderedSelectingItemsControlSetters
{
    // HeaderProperty

    public static Style SetHeaderedSelectingItemsControlHeader(this Style style, System.Object value)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.Primitives.HeaderedSelectingItemsControl.HeaderProperty, value));
        return style;
    }

    public static Style SetHeaderedSelectingItemsControlHeader(this Style style, Avalonia.Data.IBinding binding)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.Primitives.HeaderedSelectingItemsControl.HeaderProperty, binding));
        return style;
    }

    public static Style SetHeaderedSelectingItemsControlHeader(this Style style, IObservable<System.Object> observable)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.Primitives.HeaderedSelectingItemsControl.HeaderProperty, observable.ToBinding()));
        return style;
    }

    public static KeyFrame SetHeaderedSelectingItemsControlHeader(this KeyFrame keyFrame, System.Object value)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.Primitives.HeaderedSelectingItemsControl.HeaderProperty, value));
        return keyFrame;
    }

    public static KeyFrame SetHeaderedSelectingItemsControlHeader(this KeyFrame keyFrame, Avalonia.Data.IBinding binding)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.Primitives.HeaderedSelectingItemsControl.HeaderProperty, binding));
        return keyFrame;
    }

    public static KeyFrame SetHeaderedSelectingItemsControlHeader(this KeyFrame keyFrame, IObservable<System.Object> observable)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.Primitives.HeaderedSelectingItemsControl.HeaderProperty, observable.ToBinding()));
        return keyFrame;
    }
}
