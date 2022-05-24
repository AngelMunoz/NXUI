﻿const string format = "dd.MM.yyyy";
var start = new BehaviorSubject<string>(DateTime.Now.ToString(format));
var end = new BehaviorSubject<string>(DateTime.Now.ToString(format));
var selected = new BehaviorSubject<int>(0);

Window Build() 
    => Window()
        .Title("Book Flight").Padding(12).Width(450).Height(200)
        .Content(
            StackPanel()
                .OrientationVertical().Spacing(12).HorizontalAlignmentCenter().VerticalAlignmentCenter()
                .Children(
                    ComboBox()
                        .Items(new [] { "one-way flight", "return flight" })
                        .SelectedIndex(selected.Value)
                        .OnSelectedIndex((_, o) => o.Subscribe(x => selected.OnNext(x))),
                    TextBox()
                        .Text(start)
                        .OnText((t1, o) => o.Subscribe(x => {
                            // TODO:
                        })),
                    TextBox()
                        .Text(end)
                        .IsEnabled(selected.Select(x => x == 1))
                        .OnText((t2, o) => o.Subscribe(x => {
                            // TODO:
                        })),
                    Button()
                        .Content("Book")
                        .HorizontalAlignmentStretch()
                        .OnClick((_, o) => o.Subscribe(_ => {
                            // TODO:
                        }))));

AppBuilder.Configure<Application>()
    .UsePlatformDetect()
    .UseFluentTheme()
    .WithApplicationName("FlightBooker")
    .StartWithClassicDesktopLifetime(Build, args);