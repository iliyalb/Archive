namespace Indexer
{
    class Index
    {
        private int[] ages = new int[3];
        public int this[int index]
        {
            get
            {
                return ages[index];
            }
            set
            {
                ages[index] = value;
            }
        }
    }

    class IntBits
    {
        private bool[] blnArray = new bool[32];
        public bool this[int index]
        {
            get
            {
                return blnArray[index];
            }
            set
            {
                blnArray[index] = value;
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Index oIndex = new Index();
            //set
            oIndex[0] = 55;
            oIndex[0] = 65;
            oIndex[0] = 23;
            //get
            for (int i = 0; i < 3; i++)
            {
                System.Console.WriteLine(oIndex[i]);
            }

            //boolean integer array flag
            IntBits oIntBits = new IntBits();
            oIntBits[0] = false;
            pIntBits[1] = true;
        }
    }
}