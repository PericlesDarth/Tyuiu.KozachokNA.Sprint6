namespace Tyuiu.KozachokNA.Sprint6.Task1.V8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MyTextbox.Text = DataService.TabulatedOutput(-5, 5);
        }
    }
}
