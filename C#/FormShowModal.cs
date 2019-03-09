namespace modalform
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        //Form2 oForm2 = new Form2();

        Form2 oForm2 = null;

        private void Button1_Click(object Sender, EventArgs e)
        {
            //Normal Form
            oForm2.Show();

            //Modal Form
            oForm2.ShowDialog();

            //Null Method
            if (oForm2 == null || oForm2.IsDisposed)
            {
                oForm2 = new Form2();
                oForm2.Owner = this;
                oForm2.Show();
            }

            //Send a message to another form
            oForm2.Message = "Hello there";
        }
    }

    class Program2
    {
        //In the other form
        public string Message
        {
            get
            {
                return label1.Text;
            }
            set
            {
                label1.Text = value;
            }
        }

        //Send back a message to Owner
        private void button1_click(object sender, EventArgs e)
        {
            Form1 oForm1 = (Form1)Owner; //Object already exists and must be downcasted
            oForm1.Message = "Greetings";
        }
    }
}