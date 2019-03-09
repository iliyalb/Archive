namespace SwapClass
{
    class Test
    {
        public static void Swap1(int i, int j)
        {
            int temp = i;
            i = j;
            j = temp;
            System.Console.WriteLine("arg1 = {0}, arg2 = {1}", i, j);
        }
        public static void Swap2(string str1, string str2)
        {
            string temp = str1;
            str1 = str2;
            str2 = temp;
            System.Console.WriteLine("arg1 = {0}, arg2 = {1}", str1, str2);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Test.Swap1(1, 2);
            Test.Swap2("Mehrdad", "Naderi");
        }
    }
}