namespace OverloadingSimple
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    class CLASSNAME
    {
        private int x, y;

        public CLASSNAME()
        {
            //Default constructor
            x = 10;
            y = 5;
        }

        public CLASSNAME(int a)
        {
            x = a;
            y = a;
        }

        public CLASSNAME(int a, float b)
        {
            x = a;
            y = (int)b;
        }

        public CLASSNAME(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}