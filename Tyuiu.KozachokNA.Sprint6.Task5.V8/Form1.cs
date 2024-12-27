using Sprint5.Lib;

namespace Tyuiu.KozachokNA.Sprint6.Task5.V8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            myDataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            string foo = MyIO.myInput("InPutDataFileTask5V8.txt");
            string[] bar = foo.Split("\n");
            List<double> baz = new List<double>();
            double f;
            for (int i = 0; i < bar.Length -1; i++)
            {
                f = double.Parse(bar[i]);
                if (f < 0)
                {
                    baz.Add(f);
                }
            }

            myDataGridView.RowCount = baz.Count;
            myDataGridView.ColumnCount = 1;
            for (int i = 0; i < baz.Count; i++)
            {
                myDataGridView.Rows[i].Cells[0].Value = baz[i];
            }

            myDataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            myDataGridView.Update();
        }
    }
}
