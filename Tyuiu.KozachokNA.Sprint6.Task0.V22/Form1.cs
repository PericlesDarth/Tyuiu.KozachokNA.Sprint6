namespace Tyuiu.KozachokNA.Sprint6.Task0.V22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MyTextbox.Text = Convert.ToString(DataService.func(2));
        }
    }
}
