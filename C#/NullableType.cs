namespace Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            //All reference types take null
            System.String s = null;

            //By value types don't take null normally unless... ?
            bool? b = false;

            int? i = 1;
            int j = i ?? 0;
            System.Console.WriteLine(j);
            bool cb = b ?? true;
            System.Console.WriteLine(cb);
            System.Console.ReadKey();
        }
    }
}