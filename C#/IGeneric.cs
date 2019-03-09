namespace SwapGenericInterface
{
    interface ITest<T>
    {
        void Swap(T arg1, T arg2);
    }
    class Test<T> : ITest<T>
    {
        public void Swap(T arg1, T arg2)
        {
            T temp = arg1;
            arg1 = arg2;
            arg2 = temp;
            System.Console.WriteLine("arg1 = {0}, arg2 = {1}", arg1, arg2);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ITest<int> obj = new Test<int>();
            obj.Swap(10,20);
        }
    }
}