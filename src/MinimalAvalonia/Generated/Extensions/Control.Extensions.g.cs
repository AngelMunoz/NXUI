// <auto-generated />
namespace MinimalAvalonia.Extensions;

public static partial class ControlExtensions
{
    // FocusAdornerProperty

    public static T FocusAdorner<T>(this T obj, Avalonia.Controls.ITemplate<Avalonia.Controls.IControl> value) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.Control.FocusAdornerProperty] = value;
        return obj;
    }

    public static T FocusAdorner<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.Control.FocusAdornerProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T FocusAdorner<T>(this T obj, IObservable<Avalonia.Controls.ITemplate<Avalonia.Controls.IControl>> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.Control.FocusAdornerProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindFocusAdorner(this Avalonia.Controls.Control obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Control.FocusAdornerProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Controls.ITemplate<Avalonia.Controls.IControl>> ObserveFocusAdorner(this Avalonia.Controls.Control obj)
    {
        return obj.GetObservable(Avalonia.Controls.Control.FocusAdornerProperty);
    }

    public static T OnFocusAdorner<T>(this T obj, Action<Avalonia.Controls.Control, IObservable<Avalonia.Controls.ITemplate<Avalonia.Controls.IControl>>> handler) where T : Avalonia.Controls.Control
    {
        var observable = obj.GetObservable(Avalonia.Controls.Control.FocusAdornerProperty);
        handler(obj, observable);
        return obj;
    }

    // TagProperty

    public static T Tag<T>(this T obj, System.Object value) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.Control.TagProperty] = value;
        return obj;
    }

    public static T Tag<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.Control.TagProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T Tag<T>(this T obj, IObservable<System.Object> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.Control.TagProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindTag(this Avalonia.Controls.Control obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Control.TagProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Object> ObserveTag(this Avalonia.Controls.Control obj)
    {
        return obj.GetObservable(Avalonia.Controls.Control.TagProperty);
    }

    public static T OnTag<T>(this T obj, Action<Avalonia.Controls.Control, IObservable<System.Object>> handler) where T : Avalonia.Controls.Control
    {
        var observable = obj.GetObservable(Avalonia.Controls.Control.TagProperty);
        handler(obj, observable);
        return obj;
    }

    // ContextMenuProperty

    public static T ContextMenu<T>(this T obj, Avalonia.Controls.ContextMenu value) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.Control.ContextMenuProperty] = value;
        return obj;
    }

    public static T ContextMenu<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.Control.ContextMenuProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T ContextMenu<T>(this T obj, IObservable<Avalonia.Controls.ContextMenu> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.Control.ContextMenuProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindContextMenu(this Avalonia.Controls.Control obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Control.ContextMenuProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Controls.ContextMenu> ObserveContextMenu(this Avalonia.Controls.Control obj)
    {
        return obj.GetObservable(Avalonia.Controls.Control.ContextMenuProperty);
    }

    public static T OnContextMenu<T>(this T obj, Action<Avalonia.Controls.Control, IObservable<Avalonia.Controls.ContextMenu>> handler) where T : Avalonia.Controls.Control
    {
        var observable = obj.GetObservable(Avalonia.Controls.Control.ContextMenuProperty);
        handler(obj, observable);
        return obj;
    }

    // ContextFlyoutProperty

    public static T ContextFlyout<T>(this T obj, Avalonia.Controls.Primitives.FlyoutBase value) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.Control.ContextFlyoutProperty] = value;
        return obj;
    }

    public static T ContextFlyout<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.Control.ContextFlyoutProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T ContextFlyout<T>(this T obj, IObservable<Avalonia.Controls.Primitives.FlyoutBase> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.Control.ContextFlyoutProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindContextFlyout(this Avalonia.Controls.Control obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Control.ContextFlyoutProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Controls.Primitives.FlyoutBase> ObserveContextFlyout(this Avalonia.Controls.Control obj)
    {
        return obj.GetObservable(Avalonia.Controls.Control.ContextFlyoutProperty);
    }

    public static T OnContextFlyout<T>(this T obj, Action<Avalonia.Controls.Control, IObservable<Avalonia.Controls.Primitives.FlyoutBase>> handler) where T : Avalonia.Controls.Control
    {
        var observable = obj.GetObservable(Avalonia.Controls.Control.ContextFlyoutProperty);
        handler(obj, observable);
        return obj;
    }

    // FlowDirectionProperty

    public static T FlowDirection<T>(this T obj, Avalonia.Media.FlowDirection value) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.Control.FlowDirectionProperty] = value;
        return obj;
    }

    public static T FlowDirection<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.Control.FlowDirectionProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T FlowDirection<T>(this T obj, IObservable<Avalonia.Media.FlowDirection> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.Control.FlowDirectionProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindFlowDirection(this Avalonia.Controls.Control obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Control.FlowDirectionProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Media.FlowDirection> ObserveFlowDirection(this Avalonia.Controls.Control obj)
    {
        return obj.GetObservable(Avalonia.Controls.Control.FlowDirectionProperty);
    }

    public static T OnFlowDirection<T>(this T obj, Action<Avalonia.Controls.Control, IObservable<Avalonia.Media.FlowDirection>> handler) where T : Avalonia.Controls.Control
    {
        var observable = obj.GetObservable(Avalonia.Controls.Control.FlowDirectionProperty);
        handler(obj, observable);
        return obj;
    }

    public static T FlowDirectionLeftToRight<T>(this T obj) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.Control.FlowDirectionProperty] = Avalonia.Media.FlowDirection.LeftToRight;
        return obj;
    }

    public static T FlowDirectionRightToLeft<T>(this T obj) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.Control.FlowDirectionProperty] = Avalonia.Media.FlowDirection.RightToLeft;
        return obj;
    }

    // RequestBringIntoViewEvent

    public static Avalonia.Controls.Control OnRequestBringIntoViewHandler(this Avalonia.Controls.Control obj, Action<Avalonia.Controls.Control, Avalonia.Controls.RequestBringIntoViewEventArgs> action, Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Bubble)
    {
        obj.AddHandler(Avalonia.Controls.Control.RequestBringIntoViewEvent, (_, args) => action(obj, args), routes);
        return obj;
    }

    public static Avalonia.Controls.Control OnRequestBringIntoView(this Avalonia.Controls.Control obj, Action<Avalonia.Controls.Control, IObservable<Avalonia.Controls.RequestBringIntoViewEventArgs>> handler,  Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Bubble)
    {
        var observable = obj.GetObservable(Avalonia.Controls.Control.RequestBringIntoViewEvent, routes);
        handler(obj, observable);
        return obj;
    }

    // TODO: https://github.com/AvaloniaUI/Avalonia/pull/8147
    /*public static IObservable<Avalonia.Controls.RequestBringIntoViewEventArgs> ObserveOnRequestBringIntoView(this Avalonia.Controls.Control obj)
    {
        return Observable
            .FromEventPattern<EventHandler<Avalonia.Controls.RequestBringIntoViewEventArgs>, Avalonia.Controls.RequestBringIntoViewEventArgs>(
                h => obj.RequestBringIntoView += h, 
                h => obj.RequestBringIntoView -= h)
            .Select(x => x.EventArgs);
    }*/

    // ContextRequestedEvent

    public static Avalonia.Controls.Control OnContextRequestedHandler(this Avalonia.Controls.Control obj, Action<Avalonia.Controls.Control, Avalonia.Controls.ContextRequestedEventArgs> action, Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Tunnel | Avalonia.Interactivity.RoutingStrategies.Bubble)
    {
        obj.AddHandler(Avalonia.Controls.Control.ContextRequestedEvent, (_, args) => action(obj, args), routes);
        return obj;
    }

    public static Avalonia.Controls.Control OnContextRequested(this Avalonia.Controls.Control obj, Action<Avalonia.Controls.Control, IObservable<Avalonia.Controls.ContextRequestedEventArgs>> handler,  Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Tunnel | Avalonia.Interactivity.RoutingStrategies.Bubble)
    {
        var observable = obj.GetObservable(Avalonia.Controls.Control.ContextRequestedEvent, routes);
        handler(obj, observable);
        return obj;
    }

    public static IObservable<Avalonia.Controls.ContextRequestedEventArgs> ObserveOnContextRequested(this Avalonia.Controls.Control obj)
    {
        return Observable
            .FromEventPattern<EventHandler<Avalonia.Controls.ContextRequestedEventArgs>, Avalonia.Controls.ContextRequestedEventArgs>(
                h => obj.ContextRequested += h, 
                h => obj.ContextRequested -= h)
            .Select(x => x.EventArgs);
    }
}
