namespace Destructor
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    class CLASSNAME
    {
        System.ComponentModel.Component comp;

        public CLASSNAME()
        {
            comp = new System.ComponentModel.Component();
        }

        //Destructor
        ~CLASSNAME()
        {
            comp.Dispose();
        }
    }
}