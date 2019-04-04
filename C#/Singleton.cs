public sealed class Singleton
{
    private static readonly Singleton uniqueinstance = new Singleton();

    Singleton()
    {

    }

    public static Singleton Instance()
    {
        return uniqueinstance;
    }
}