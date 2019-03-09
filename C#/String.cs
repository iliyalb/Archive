namespace StringTricks
{
    public class Program
    {
        static void Main(string[] args)
        {
            string a = "String";
            string b;

            b = a.Replace("i","o"); //Strong
            b = a.Insert(0, "My"); //MyString
            b = a.Remove(0, 3); //ing
            b = a.Substring(0, 3); //Str
            b = a.ToUpper(); //STRING
            int i = a.Length; //6
        }
    }
}