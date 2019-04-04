public sealed class Singleton<T> where T : class, new()
{
    private static readonly T uniqueinstance = new T();

    private Singleton()
    {

    }

    public static T Instance()
    {
        return uniqueinstance;
    }
}