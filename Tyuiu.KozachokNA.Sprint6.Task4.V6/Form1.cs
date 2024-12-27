using Sprint5.Lib;

namespace Tyuiu.KozachokNA.Sprint6.Task4.V6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string foo = DataService.TabulatedOutput(-5, 5);
            myTextbox.Text = foo;
            MyIO.myOutput("OutputFileSprint6Task4V6.txt", foo);
        }
    }
}
