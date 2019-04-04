using System;

public sealed class Singleton
{
    private static readonly Lazy<Singleton> uniqueinstance = new Lazy<Singleton>(() => new Singleton(), true);

    Singleton()
    {

    }

    public static Singleton Instance()
    {
        return uniqueinstance.Value;
    }
}