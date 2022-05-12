// <auto-generated />
namespace MinimalAvalonia.Extensions;

public static partial class DatePickerExtensions
{
    // DayFormatProperty

    public static T DayFormat<T>(this T obj, System.String value) where T : Avalonia.Controls.DatePicker
    {
        obj[Avalonia.Controls.DatePicker.DayFormatProperty] = value;
        return obj;
    }

    public static T DayFormat<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.DatePicker
    {
        obj[Avalonia.Controls.DatePicker.DayFormatProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T DayFormat<T>(this T obj, IObservable<System.String> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.DatePicker
    {
        obj[Avalonia.Controls.DatePicker.DayFormatProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindDayFormat(this Avalonia.Controls.DatePicker obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.DatePicker.DayFormatProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.String> ObserveDayFormat(this Avalonia.Controls.DatePicker obj)
    {
        return obj.GetObservable(Avalonia.Controls.DatePicker.DayFormatProperty);
    }

    // DayVisibleProperty

    public static T DayVisible<T>(this T obj, System.Boolean value) where T : Avalonia.Controls.DatePicker
    {
        obj[Avalonia.Controls.DatePicker.DayVisibleProperty] = value;
        return obj;
    }

    public static T DayVisible<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.DatePicker
    {
        obj[Avalonia.Controls.DatePicker.DayVisibleProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T DayVisible<T>(this T obj, IObservable<System.Boolean> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.DatePicker
    {
        obj[Avalonia.Controls.DatePicker.DayVisibleProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindDayVisible(this Avalonia.Controls.DatePicker obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.DatePicker.DayVisibleProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Boolean> ObserveDayVisible(this Avalonia.Controls.DatePicker obj)
    {
        return obj.GetObservable(Avalonia.Controls.DatePicker.DayVisibleProperty);
    }

    // HeaderProperty

    public static T Header<T>(this T obj, System.Object value) where T : Avalonia.Controls.DatePicker
    {
        obj[Avalonia.Controls.DatePicker.HeaderProperty] = value;
        return obj;
    }

    public static T Header<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.DatePicker
    {
        obj[Avalonia.Controls.DatePicker.HeaderProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T Header<T>(this T obj, IObservable<System.Object> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.DatePicker
    {
        obj[Avalonia.Controls.DatePicker.HeaderProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindHeader(this Avalonia.Controls.DatePicker obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.DatePicker.HeaderProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Object> ObserveHeader(this Avalonia.Controls.DatePicker obj)
    {
        return obj.GetObservable(Avalonia.Controls.DatePicker.HeaderProperty);
    }

    // HeaderTemplateProperty

    public static T HeaderTemplate<T>(this T obj, Avalonia.Controls.Templates.IDataTemplate value) where T : Avalonia.Controls.DatePicker
    {
        obj[Avalonia.Controls.DatePicker.HeaderTemplateProperty] = value;
        return obj;
    }

    public static T HeaderTemplate<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.DatePicker
    {
        obj[Avalonia.Controls.DatePicker.HeaderTemplateProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T HeaderTemplate<T>(this T obj, IObservable<Avalonia.Controls.Templates.IDataTemplate> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.DatePicker
    {
        obj[Avalonia.Controls.DatePicker.HeaderTemplateProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindHeaderTemplate(this Avalonia.Controls.DatePicker obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.DatePicker.HeaderTemplateProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Controls.Templates.IDataTemplate> ObserveHeaderTemplate(this Avalonia.Controls.DatePicker obj)
    {
        return obj.GetObservable(Avalonia.Controls.DatePicker.HeaderTemplateProperty);
    }

    // MaxYearProperty

    public static T MaxYear<T>(this T obj, System.DateTimeOffset value) where T : Avalonia.Controls.DatePicker
    {
        obj[Avalonia.Controls.DatePicker.MaxYearProperty] = value;
        return obj;
    }

    public static T MaxYear<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.DatePicker
    {
        obj[Avalonia.Controls.DatePicker.MaxYearProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T MaxYear<T>(this T obj, IObservable<System.DateTimeOffset> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.DatePicker
    {
        obj[Avalonia.Controls.DatePicker.MaxYearProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindMaxYear(this Avalonia.Controls.DatePicker obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.DatePicker.MaxYearProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.DateTimeOffset> ObserveMaxYear(this Avalonia.Controls.DatePicker obj)
    {
        return obj.GetObservable(Avalonia.Controls.DatePicker.MaxYearProperty);
    }

    // MinYearProperty

    public static T MinYear<T>(this T obj, System.DateTimeOffset value) where T : Avalonia.Controls.DatePicker
    {
        obj[Avalonia.Controls.DatePicker.MinYearProperty] = value;
        return obj;
    }

    public static T MinYear<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.DatePicker
    {
        obj[Avalonia.Controls.DatePicker.MinYearProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T MinYear<T>(this T obj, IObservable<System.DateTimeOffset> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.DatePicker
    {
        obj[Avalonia.Controls.DatePicker.MinYearProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindMinYear(this Avalonia.Controls.DatePicker obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.DatePicker.MinYearProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.DateTimeOffset> ObserveMinYear(this Avalonia.Controls.DatePicker obj)
    {
        return obj.GetObservable(Avalonia.Controls.DatePicker.MinYearProperty);
    }

    // MonthFormatProperty

    public static T MonthFormat<T>(this T obj, System.String value) where T : Avalonia.Controls.DatePicker
    {
        obj[Avalonia.Controls.DatePicker.MonthFormatProperty] = value;
        return obj;
    }

    public static T MonthFormat<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.DatePicker
    {
        obj[Avalonia.Controls.DatePicker.MonthFormatProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T MonthFormat<T>(this T obj, IObservable<System.String> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.DatePicker
    {
        obj[Avalonia.Controls.DatePicker.MonthFormatProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindMonthFormat(this Avalonia.Controls.DatePicker obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.DatePicker.MonthFormatProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.String> ObserveMonthFormat(this Avalonia.Controls.DatePicker obj)
    {
        return obj.GetObservable(Avalonia.Controls.DatePicker.MonthFormatProperty);
    }

    // MonthVisibleProperty

    public static T MonthVisible<T>(this T obj, System.Boolean value) where T : Avalonia.Controls.DatePicker
    {
        obj[Avalonia.Controls.DatePicker.MonthVisibleProperty] = value;
        return obj;
    }

    public static T MonthVisible<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.DatePicker
    {
        obj[Avalonia.Controls.DatePicker.MonthVisibleProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T MonthVisible<T>(this T obj, IObservable<System.Boolean> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.DatePicker
    {
        obj[Avalonia.Controls.DatePicker.MonthVisibleProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindMonthVisible(this Avalonia.Controls.DatePicker obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.DatePicker.MonthVisibleProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Boolean> ObserveMonthVisible(this Avalonia.Controls.DatePicker obj)
    {
        return obj.GetObservable(Avalonia.Controls.DatePicker.MonthVisibleProperty);
    }

    // YearFormatProperty

    public static T YearFormat<T>(this T obj, System.String value) where T : Avalonia.Controls.DatePicker
    {
        obj[Avalonia.Controls.DatePicker.YearFormatProperty] = value;
        return obj;
    }

    public static T YearFormat<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.DatePicker
    {
        obj[Avalonia.Controls.DatePicker.YearFormatProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T YearFormat<T>(this T obj, IObservable<System.String> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.DatePicker
    {
        obj[Avalonia.Controls.DatePicker.YearFormatProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindYearFormat(this Avalonia.Controls.DatePicker obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.DatePicker.YearFormatProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.String> ObserveYearFormat(this Avalonia.Controls.DatePicker obj)
    {
        return obj.GetObservable(Avalonia.Controls.DatePicker.YearFormatProperty);
    }

    // YearVisibleProperty

    public static T YearVisible<T>(this T obj, System.Boolean value) where T : Avalonia.Controls.DatePicker
    {
        obj[Avalonia.Controls.DatePicker.YearVisibleProperty] = value;
        return obj;
    }

    public static T YearVisible<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.DatePicker
    {
        obj[Avalonia.Controls.DatePicker.YearVisibleProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T YearVisible<T>(this T obj, IObservable<System.Boolean> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.DatePicker
    {
        obj[Avalonia.Controls.DatePicker.YearVisibleProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindYearVisible(this Avalonia.Controls.DatePicker obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.DatePicker.YearVisibleProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Boolean> ObserveYearVisible(this Avalonia.Controls.DatePicker obj)
    {
        return obj.GetObservable(Avalonia.Controls.DatePicker.YearVisibleProperty);
    }

    // SelectedDateProperty

    public static T SelectedDate<T>(this T obj, System.Nullable<System.DateTimeOffset> value) where T : Avalonia.Controls.DatePicker
    {
        obj[Avalonia.Controls.DatePicker.SelectedDateProperty] = value;
        return obj;
    }

    public static T SelectedDate<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.DatePicker
    {
        obj[Avalonia.Controls.DatePicker.SelectedDateProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T SelectedDate<T>(this T obj, IObservable<System.Nullable<System.DateTimeOffset>> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.DatePicker
    {
        obj[Avalonia.Controls.DatePicker.SelectedDateProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindSelectedDate(this Avalonia.Controls.DatePicker obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.DatePicker.SelectedDateProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Nullable<System.DateTimeOffset>> ObserveSelectedDate(this Avalonia.Controls.DatePicker obj)
    {
        return obj.GetObservable(Avalonia.Controls.DatePicker.SelectedDateProperty);
    }
}