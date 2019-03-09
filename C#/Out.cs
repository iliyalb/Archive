namespace Ref
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Set(out x);
            System.Console.WriteLine(x);
        }

        static void Set(out int i)
        {
            i = 10;
        }
    }
}
