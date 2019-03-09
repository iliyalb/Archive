namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            CLASSNAME c = new CLASSNAME(10, 10);

        }
    }

    class CLASSNAME
    {
        private int x, y;
        public CLASSNAME(int width, int height)
        {
            x = width; y = height;
        }

    }
}