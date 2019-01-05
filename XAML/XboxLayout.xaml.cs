using Windows.UI;

// 200% scale factor by default
Windows.UI.ViewManagement.ApplicationViewScaling.TryDisableLayoutScaling(true);

// Automatic adjustment for title safe area
AppView.SetDesiredBoundsMode(ApplicationViewBoundsMode.UseCoreWindow);

// Mouse cursor emulation
Application.RequiresPointerMode = ApplicationRequiresPointerMode.WhenRequested;