namespace Fps
{
    struct Fps
    {
        private int feet, inch;
        public Fps(int f, int i)
        {
            feet = f;
            inch = i;
        }
        public static Fps operator +(Fps obj1, Fps obj2)
        {
            Fps temp = new Fps();
            temp.feet = obj1.feet + obj2.feet;
            temp.inch = obj1.inch + obj2.inch;
            return temp;
        }
        public override string ToString()
        {
            return "Feet = " + feet + ", inch = " + inch;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Time t = new Time(10,55,30);
            t.WriteTime();
        }
    }
}