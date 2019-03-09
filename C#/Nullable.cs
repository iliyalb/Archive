namespace Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            //All reference types take null
            System.String s = null;

            //By value types don't take null normally unless... ?
            bool? b = null;

            //Conditional null
            int? i = null;
            int j = i ?? 0; /* If it's not null then it returns left value
                                ,If it's null then it returns right value*/
        }
    }
}