namespace StringBuilder
{
    public class program
    {
        static void Main(string[] args)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder("Hello");
            sb.Append("World"); //HelloWorld
            sb.Remove(0, 5); //World
            sb.Insert(0, "Bye"); //ByeWorld

            string s = sb.ToString();
        }
    }
}