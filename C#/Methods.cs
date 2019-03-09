namespace Method
{
    public class Program
    {
        static void Main(string[] args)
        {
            MyText m = new MyText();
            m.Print();
        }
    }

    class MyText
    {
        public void Print()
        {
            System.Console.WriteLine("Hello There");
        }

        public void Print(string s1, string s2)
        {
            System.Console.WriteLine(s1 + s2);
        }

        public void Print(params string[] s)
        {
            foreach (string x in s)
                System.Console.Write(x);
        }
    }
}