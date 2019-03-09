namespace Time
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare ints
            int totalSecondsPlayed = 100;
            const int SECONDS_PER_MINUTE = 60;

            //calculate
            int minutes = totalSecondsPlayed / SECONDS_PER_MINUTE;
            int seconds = totalSecondsPlayed % SECONDS_PER_MINUTE;
        }
    }
}