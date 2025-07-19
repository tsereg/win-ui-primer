using System;
using Microsoft.UI.Xaml;

public static class Program
{
    static void Main(string[] args)
    {
        Application.Start(p => _ = new App());
    }

    private class App : Application
    {
        protected override void OnLaunched(LaunchActivatedEventArgs args)
        {
            var window = new FooBarWindow();
            window.Activate();
        }
    }
}
