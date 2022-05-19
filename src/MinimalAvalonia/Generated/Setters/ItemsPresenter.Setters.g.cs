// <auto-generated />
namespace MinimalAvalonia.Extensions;

public static partial class ItemsPresenterSetters
{
    // VirtualizationModeProperty

    public static Style SetItemsPresenterVirtualizationMode(this Style style, Avalonia.Controls.ItemVirtualizationMode value)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.Presenters.ItemsPresenter.VirtualizationModeProperty, value));
        return style;
    }

    public static Style SetItemsPresenterVirtualizationMode(this Style style, Avalonia.Data.IBinding binding)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.Presenters.ItemsPresenter.VirtualizationModeProperty, binding));
        return style;
    }

    public static Style SetItemsPresenterVirtualizationMode(this Style style, IObservable<Avalonia.Controls.ItemVirtualizationMode> observable)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.Presenters.ItemsPresenter.VirtualizationModeProperty, observable.ToBinding()));
        return style;
    }

    public static KeyFrame SetItemsPresenterVirtualizationMode(this KeyFrame keyFrame, Avalonia.Controls.ItemVirtualizationMode value)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.Presenters.ItemsPresenter.VirtualizationModeProperty, value));
        return keyFrame;
    }

    public static KeyFrame SetItemsPresenterVirtualizationMode(this KeyFrame keyFrame, Avalonia.Data.IBinding binding)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.Presenters.ItemsPresenter.VirtualizationModeProperty, binding));
        return keyFrame;
    }

    public static KeyFrame SetItemsPresenterVirtualizationMode(this KeyFrame keyFrame, IObservable<Avalonia.Controls.ItemVirtualizationMode> observable)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.Presenters.ItemsPresenter.VirtualizationModeProperty, observable.ToBinding()));
        return keyFrame;
    }
}
