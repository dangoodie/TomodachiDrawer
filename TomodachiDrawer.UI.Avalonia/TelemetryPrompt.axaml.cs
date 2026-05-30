using Avalonia.Controls;
using Avalonia.Interactivity;

namespace TomodachiDrawer.UI.Avalonia;

public partial class TelemetryPrompt : Window
{
    private bool _answered = false;

    public TelemetryPrompt()
    {
        InitializeComponent();
    }

    protected override void OnClosing(WindowClosingEventArgs e)
    {
        if (!_answered)
            e.Cancel = true;
        base.OnClosing(e);
    }

    private void OpenSourceButton_Click(object? sender, RoutedEventArgs e)
    {
        Launcher.LaunchUriAsync(
            new Uri(
                "https://github.com/Lucas7yoshi/TomodachiDrawer/blob/master/TomodachiDrawer.UI.Avalonia/TelemetryService.cs"
            )
        );
    }

    private void NoThanksButton_Click(object? sender, RoutedEventArgs e)
    {
        _answered = true;
        this.Close(false);
    }

    private void SureButton_Click(object? sender, RoutedEventArgs e)
    {
        _answered = true;
        this.Close(true);
    }
}
