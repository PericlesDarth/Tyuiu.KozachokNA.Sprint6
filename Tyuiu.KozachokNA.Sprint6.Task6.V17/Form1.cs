using System.ComponentModel;

namespace Tyuiu.KozachokNA.Sprint6.Task6.V17
{
    public partial class Form1 : Form
    {
        string path;
        string input;
        string output;
        public Form1()
        {
            InitializeComponent();

            
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            path = openFileDialog1.FileName;
            input = File.ReadAllText(path);
            InputBox.Text = input;
            OpenFile.Enabled = true;
            output = DataService.ProcessData(input);
            OutputBox.Text = output;
        }
    }
}
