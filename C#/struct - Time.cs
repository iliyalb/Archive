namespace Struct
{
    struct Time 
    {
        private int hour, minute, second;
        public Time(int hh, int mm, int ss)
        {
            hour = hh;
            minute = mm;
            second = ss;
        }
        public void WriteTime() 
        {
            System.Console.WriteLine("{0}:{1}:{2}", hour, minute, second);
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