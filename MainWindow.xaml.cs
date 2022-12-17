using System;
using System.Windows;
using System.Windows.Threading;

namespace TimeWidgetWPF;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        this.ResizeMode = ResizeMode.CanMinimize;
        StartUp();
        this.Topmost = true;
    }

    public void SetTime(object sender, EventArgs e)
    {
        this.TimeLocal.Content = DateTime.Now.ToString("HH:mm:ss");
        this.TimeUTC.Content = DateTime.UtcNow.ToString("HH:mm:ss");
    }

    public void StartUp()
    {
        DispatcherTimer dispatcherTimer = new DispatcherTimer();
        dispatcherTimer.Tick += new EventHandler(SetTime);
        dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
        dispatcherTimer.Start();
    }
}