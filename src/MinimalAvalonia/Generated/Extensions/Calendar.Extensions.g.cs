// <auto-generated />
namespace MinimalAvalonia.Extensions;

public static partial class CalendarExtensions
{
    // FirstDayOfWeekProperty

    public static T FirstDayOfWeek<T>(this T obj, System.DayOfWeek value) where T : Avalonia.Controls.Calendar
    {
        obj[Avalonia.Controls.Calendar.FirstDayOfWeekProperty] = value;
        return obj;
    }

    public static T FirstDayOfWeek<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Calendar
    {
        obj[Avalonia.Controls.Calendar.FirstDayOfWeekProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T FirstDayOfWeek<T>(this T obj, IObservable<System.DayOfWeek> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Calendar
    {
        obj[Avalonia.Controls.Calendar.FirstDayOfWeekProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindFirstDayOfWeek(this Avalonia.Controls.Calendar obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Calendar.FirstDayOfWeekProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.DayOfWeek> ObserveFirstDayOfWeek(this Avalonia.Controls.Calendar obj)
    {
        return obj.GetObservable(Avalonia.Controls.Calendar.FirstDayOfWeekProperty);
    }

    public static T OnFirstDayOfWeek<T>(this T obj, Action<IObservable<System.DayOfWeek>> handler) where T : Avalonia.Controls.Calendar
    {
        var observable = obj.GetObservable(Avalonia.Controls.Calendar.FirstDayOfWeekProperty);
        handler(observable);
        return obj;
    }

    public static T FirstDayOfWeekSunday<T>(this T obj) where T : Avalonia.Controls.Calendar
    {
        obj[Avalonia.Controls.Calendar.FirstDayOfWeekProperty] = System.DayOfWeek.Sunday;
        return obj;
    }

    public static T FirstDayOfWeekMonday<T>(this T obj) where T : Avalonia.Controls.Calendar
    {
        obj[Avalonia.Controls.Calendar.FirstDayOfWeekProperty] = System.DayOfWeek.Monday;
        return obj;
    }

    public static T FirstDayOfWeekTuesday<T>(this T obj) where T : Avalonia.Controls.Calendar
    {
        obj[Avalonia.Controls.Calendar.FirstDayOfWeekProperty] = System.DayOfWeek.Tuesday;
        return obj;
    }

    public static T FirstDayOfWeekWednesday<T>(this T obj) where T : Avalonia.Controls.Calendar
    {
        obj[Avalonia.Controls.Calendar.FirstDayOfWeekProperty] = System.DayOfWeek.Wednesday;
        return obj;
    }

    public static T FirstDayOfWeekThursday<T>(this T obj) where T : Avalonia.Controls.Calendar
    {
        obj[Avalonia.Controls.Calendar.FirstDayOfWeekProperty] = System.DayOfWeek.Thursday;
        return obj;
    }

    public static T FirstDayOfWeekFriday<T>(this T obj) where T : Avalonia.Controls.Calendar
    {
        obj[Avalonia.Controls.Calendar.FirstDayOfWeekProperty] = System.DayOfWeek.Friday;
        return obj;
    }

    public static T FirstDayOfWeekSaturday<T>(this T obj) where T : Avalonia.Controls.Calendar
    {
        obj[Avalonia.Controls.Calendar.FirstDayOfWeekProperty] = System.DayOfWeek.Saturday;
        return obj;
    }

    // IsTodayHighlightedProperty

    public static T IsTodayHighlighted<T>(this T obj, System.Boolean value) where T : Avalonia.Controls.Calendar
    {
        obj[Avalonia.Controls.Calendar.IsTodayHighlightedProperty] = value;
        return obj;
    }

    public static T IsTodayHighlighted<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Calendar
    {
        obj[Avalonia.Controls.Calendar.IsTodayHighlightedProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T IsTodayHighlighted<T>(this T obj, IObservable<System.Boolean> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Calendar
    {
        obj[Avalonia.Controls.Calendar.IsTodayHighlightedProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindIsTodayHighlighted(this Avalonia.Controls.Calendar obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Calendar.IsTodayHighlightedProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Boolean> ObserveIsTodayHighlighted(this Avalonia.Controls.Calendar obj)
    {
        return obj.GetObservable(Avalonia.Controls.Calendar.IsTodayHighlightedProperty);
    }

    public static T OnIsTodayHighlighted<T>(this T obj, Action<IObservable<System.Boolean>> handler) where T : Avalonia.Controls.Calendar
    {
        var observable = obj.GetObservable(Avalonia.Controls.Calendar.IsTodayHighlightedProperty);
        handler(observable);
        return obj;
    }

    // HeaderBackgroundProperty

    public static T HeaderBackground<T>(this T obj, Avalonia.Media.IBrush value) where T : Avalonia.Controls.Calendar
    {
        obj[Avalonia.Controls.Calendar.HeaderBackgroundProperty] = value;
        return obj;
    }

    public static T HeaderBackground<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Calendar
    {
        obj[Avalonia.Controls.Calendar.HeaderBackgroundProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T HeaderBackground<T>(this T obj, IObservable<Avalonia.Media.IBrush> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Calendar
    {
        obj[Avalonia.Controls.Calendar.HeaderBackgroundProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindHeaderBackground(this Avalonia.Controls.Calendar obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Calendar.HeaderBackgroundProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Media.IBrush> ObserveHeaderBackground(this Avalonia.Controls.Calendar obj)
    {
        return obj.GetObservable(Avalonia.Controls.Calendar.HeaderBackgroundProperty);
    }

    public static T OnHeaderBackground<T>(this T obj, Action<IObservable<Avalonia.Media.IBrush>> handler) where T : Avalonia.Controls.Calendar
    {
        var observable = obj.GetObservable(Avalonia.Controls.Calendar.HeaderBackgroundProperty);
        handler(observable);
        return obj;
    }

    // DisplayModeProperty

    public static T DisplayMode<T>(this T obj, Avalonia.Controls.CalendarMode value) where T : Avalonia.Controls.Calendar
    {
        obj[Avalonia.Controls.Calendar.DisplayModeProperty] = value;
        return obj;
    }

    public static T DisplayMode<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Calendar
    {
        obj[Avalonia.Controls.Calendar.DisplayModeProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T DisplayMode<T>(this T obj, IObservable<Avalonia.Controls.CalendarMode> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Calendar
    {
        obj[Avalonia.Controls.Calendar.DisplayModeProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindDisplayMode(this Avalonia.Controls.Calendar obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Calendar.DisplayModeProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Controls.CalendarMode> ObserveDisplayMode(this Avalonia.Controls.Calendar obj)
    {
        return obj.GetObservable(Avalonia.Controls.Calendar.DisplayModeProperty);
    }

    public static T OnDisplayMode<T>(this T obj, Action<IObservable<Avalonia.Controls.CalendarMode>> handler) where T : Avalonia.Controls.Calendar
    {
        var observable = obj.GetObservable(Avalonia.Controls.Calendar.DisplayModeProperty);
        handler(observable);
        return obj;
    }

    public static T DisplayModeMonth<T>(this T obj) where T : Avalonia.Controls.Calendar
    {
        obj[Avalonia.Controls.Calendar.DisplayModeProperty] = Avalonia.Controls.CalendarMode.Month;
        return obj;
    }

    public static T DisplayModeYear<T>(this T obj) where T : Avalonia.Controls.Calendar
    {
        obj[Avalonia.Controls.Calendar.DisplayModeProperty] = Avalonia.Controls.CalendarMode.Year;
        return obj;
    }

    public static T DisplayModeDecade<T>(this T obj) where T : Avalonia.Controls.Calendar
    {
        obj[Avalonia.Controls.Calendar.DisplayModeProperty] = Avalonia.Controls.CalendarMode.Decade;
        return obj;
    }

    // SelectionModeProperty

    public static T SelectionMode<T>(this T obj, Avalonia.Controls.CalendarSelectionMode value) where T : Avalonia.Controls.Calendar
    {
        obj[Avalonia.Controls.Calendar.SelectionModeProperty] = value;
        return obj;
    }

    public static T SelectionMode<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Calendar
    {
        obj[Avalonia.Controls.Calendar.SelectionModeProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T SelectionMode<T>(this T obj, IObservable<Avalonia.Controls.CalendarSelectionMode> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Calendar
    {
        obj[Avalonia.Controls.Calendar.SelectionModeProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindSelectionMode(this Avalonia.Controls.Calendar obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Calendar.SelectionModeProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Controls.CalendarSelectionMode> ObserveSelectionMode(this Avalonia.Controls.Calendar obj)
    {
        return obj.GetObservable(Avalonia.Controls.Calendar.SelectionModeProperty);
    }

    public static T OnSelectionMode<T>(this T obj, Action<IObservable<Avalonia.Controls.CalendarSelectionMode>> handler) where T : Avalonia.Controls.Calendar
    {
        var observable = obj.GetObservable(Avalonia.Controls.Calendar.SelectionModeProperty);
        handler(observable);
        return obj;
    }

    public static T SelectionModeSingleDate<T>(this T obj) where T : Avalonia.Controls.Calendar
    {
        obj[Avalonia.Controls.Calendar.SelectionModeProperty] = Avalonia.Controls.CalendarSelectionMode.SingleDate;
        return obj;
    }

    public static T SelectionModeSingleRange<T>(this T obj) where T : Avalonia.Controls.Calendar
    {
        obj[Avalonia.Controls.Calendar.SelectionModeProperty] = Avalonia.Controls.CalendarSelectionMode.SingleRange;
        return obj;
    }

    public static T SelectionModeMultipleRange<T>(this T obj) where T : Avalonia.Controls.Calendar
    {
        obj[Avalonia.Controls.Calendar.SelectionModeProperty] = Avalonia.Controls.CalendarSelectionMode.MultipleRange;
        return obj;
    }

    public static T SelectionModeNone<T>(this T obj) where T : Avalonia.Controls.Calendar
    {
        obj[Avalonia.Controls.Calendar.SelectionModeProperty] = Avalonia.Controls.CalendarSelectionMode.None;
        return obj;
    }

    // SelectedDateProperty

    public static T SelectedDate<T>(this T obj, System.Nullable<System.DateTime> value) where T : Avalonia.Controls.Calendar
    {
        obj[Avalonia.Controls.Calendar.SelectedDateProperty] = value;
        return obj;
    }

    public static T SelectedDate<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Calendar
    {
        obj[Avalonia.Controls.Calendar.SelectedDateProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T SelectedDate<T>(this T obj, IObservable<System.Nullable<System.DateTime>> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Calendar
    {
        obj[Avalonia.Controls.Calendar.SelectedDateProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindSelectedDate(this Avalonia.Controls.Calendar obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Calendar.SelectedDateProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Nullable<System.DateTime>> ObserveSelectedDate(this Avalonia.Controls.Calendar obj)
    {
        return obj.GetObservable(Avalonia.Controls.Calendar.SelectedDateProperty);
    }

    public static T OnSelectedDate<T>(this T obj, Action<IObservable<System.Nullable<System.DateTime>>> handler) where T : Avalonia.Controls.Calendar
    {
        var observable = obj.GetObservable(Avalonia.Controls.Calendar.SelectedDateProperty);
        handler(observable);
        return obj;
    }

    // DisplayDateProperty

    public static T DisplayDate<T>(this T obj, System.DateTime value) where T : Avalonia.Controls.Calendar
    {
        obj[Avalonia.Controls.Calendar.DisplayDateProperty] = value;
        return obj;
    }

    public static T DisplayDate<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Calendar
    {
        obj[Avalonia.Controls.Calendar.DisplayDateProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T DisplayDate<T>(this T obj, IObservable<System.DateTime> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Calendar
    {
        obj[Avalonia.Controls.Calendar.DisplayDateProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindDisplayDate(this Avalonia.Controls.Calendar obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Calendar.DisplayDateProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.DateTime> ObserveDisplayDate(this Avalonia.Controls.Calendar obj)
    {
        return obj.GetObservable(Avalonia.Controls.Calendar.DisplayDateProperty);
    }

    public static T OnDisplayDate<T>(this T obj, Action<IObservable<System.DateTime>> handler) where T : Avalonia.Controls.Calendar
    {
        var observable = obj.GetObservable(Avalonia.Controls.Calendar.DisplayDateProperty);
        handler(observable);
        return obj;
    }

    // DisplayDateStartProperty

    public static T DisplayDateStart<T>(this T obj, System.Nullable<System.DateTime> value) where T : Avalonia.Controls.Calendar
    {
        obj[Avalonia.Controls.Calendar.DisplayDateStartProperty] = value;
        return obj;
    }

    public static T DisplayDateStart<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Calendar
    {
        obj[Avalonia.Controls.Calendar.DisplayDateStartProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T DisplayDateStart<T>(this T obj, IObservable<System.Nullable<System.DateTime>> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Calendar
    {
        obj[Avalonia.Controls.Calendar.DisplayDateStartProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindDisplayDateStart(this Avalonia.Controls.Calendar obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Calendar.DisplayDateStartProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Nullable<System.DateTime>> ObserveDisplayDateStart(this Avalonia.Controls.Calendar obj)
    {
        return obj.GetObservable(Avalonia.Controls.Calendar.DisplayDateStartProperty);
    }

    public static T OnDisplayDateStart<T>(this T obj, Action<IObservable<System.Nullable<System.DateTime>>> handler) where T : Avalonia.Controls.Calendar
    {
        var observable = obj.GetObservable(Avalonia.Controls.Calendar.DisplayDateStartProperty);
        handler(observable);
        return obj;
    }

    // DisplayDateEndProperty

    public static T DisplayDateEnd<T>(this T obj, System.Nullable<System.DateTime> value) where T : Avalonia.Controls.Calendar
    {
        obj[Avalonia.Controls.Calendar.DisplayDateEndProperty] = value;
        return obj;
    }

    public static T DisplayDateEnd<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Calendar
    {
        obj[Avalonia.Controls.Calendar.DisplayDateEndProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T DisplayDateEnd<T>(this T obj, IObservable<System.Nullable<System.DateTime>> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Calendar
    {
        obj[Avalonia.Controls.Calendar.DisplayDateEndProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindDisplayDateEnd(this Avalonia.Controls.Calendar obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Calendar.DisplayDateEndProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Nullable<System.DateTime>> ObserveDisplayDateEnd(this Avalonia.Controls.Calendar obj)
    {
        return obj.GetObservable(Avalonia.Controls.Calendar.DisplayDateEndProperty);
    }

    public static T OnDisplayDateEnd<T>(this T obj, Action<IObservable<System.Nullable<System.DateTime>>> handler) where T : Avalonia.Controls.Calendar
    {
        var observable = obj.GetObservable(Avalonia.Controls.Calendar.DisplayDateEndProperty);
        handler(observable);
        return obj;
    }
}