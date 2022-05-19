// <auto-generated />
namespace MinimalAvalonia.Extensions;

public static partial class SpinnerSetters
{
    // ValidSpinDirectionProperty

    public static Style SetSpinnerValidSpinDirection(this Style style, Avalonia.Controls.ValidSpinDirections value)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.Spinner.ValidSpinDirectionProperty, value));
        return style;
    }

    public static Style SetSpinnerValidSpinDirection(this Style style, Avalonia.Data.IBinding binding)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.Spinner.ValidSpinDirectionProperty, binding));
        return style;
    }

    public static Style SetSpinnerValidSpinDirection(this Style style, IObservable<Avalonia.Controls.ValidSpinDirections> observable)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.Spinner.ValidSpinDirectionProperty, observable.ToBinding()));
        return style;
    }

    public static KeyFrame SetSpinnerValidSpinDirection(this KeyFrame keyFrame, Avalonia.Controls.ValidSpinDirections value)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.Spinner.ValidSpinDirectionProperty, value));
        return keyFrame;
    }

    public static KeyFrame SetSpinnerValidSpinDirection(this KeyFrame keyFrame, Avalonia.Data.IBinding binding)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.Spinner.ValidSpinDirectionProperty, binding));
        return keyFrame;
    }

    public static KeyFrame SetSpinnerValidSpinDirection(this KeyFrame keyFrame, IObservable<Avalonia.Controls.ValidSpinDirections> observable)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.Spinner.ValidSpinDirectionProperty, observable.ToBinding()));
        return keyFrame;
    }

}
