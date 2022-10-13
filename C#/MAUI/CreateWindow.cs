protected override Window CreateWindow(IActivationState activationState)
{
    Window window = base.CreateWindow(activationState);

    window.Created += (s, e) =>
    {
        // Logic
    };

    window.Activated += (s, e) =>
    {
        // Logic
    };

    return window;
}