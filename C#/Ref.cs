namespace Ref
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            Set(ref x);
            System.Console.WriteLine(x);
        }

        static void Set(ref int i)
        {
            i = 10;
        }
    }
}
