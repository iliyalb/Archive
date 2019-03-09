namespace Indexer
{
    class String
    {
        public static bool InNullOrEmpty(string value)
        {
            if (value != null)
            {
                return (value.Length == 0);
            }
            else
                return true;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}