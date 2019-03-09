namespace Enum
{
    [System.Flags]
    public enum Days
    {
        None = 0x0, //0
        Saturday = 0x1, //1
        Sunday = 0x2, //2
        Monday = 0x4, //4
        Tuesday = 0x8, //8
        Wednesday = 0x10, //16
        Thirsday = 0x20, //32
        Friday = 0x40 //64
    }
    class Program
    {
        static void Main(string[] args)
        {
            Days MeetingDay = Days.Saturday | Days.Tuesday;
            System.Console.WriteLine("Meeting Days: {0}", MeetingDay);

            //To add a day
            MeetingDay = MeetingDay | Days.Friday;

            //To remove a day
            MeetingDay = MeetingDay ^ Days.Tuesday;

            //To check a day
            bool chk = (MeetingDay & Days.Friday) == Days.Friday;

            //To get a day by value
            string s = System.Enum.GetName(typeof(Days),0x1);

            //To get day values
            foreach (int i in System.Enum.GetValues(typeof(Days))) 
            {
                System.Console.WriteLine(i);
            }
        }
    }
}