namespace Tyuiu.KozachokNA.Sprint6.Task2.V24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            int a, b;
            a = -5;
            b = 5;
            dataGridView1.RowCount = b - a + 1;
            for (int i = a; i <= b; i++)
            {
                dataGridView1.Rows[i - a].Cells[0].Value = i;
                if (2 - i == 0)
                {
                    dataGridView1.Rows[i - a].Cells[1].Value = 0;
                }
                else
                {
                    dataGridView1.Rows[i - a].Cells[1].Value = DataService.func(i);
                }
            }
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dataGridView1.Update();
        }
    }
}
