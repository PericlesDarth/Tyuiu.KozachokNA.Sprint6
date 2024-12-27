namespace Tyuiu.KozachokNA.Sprint6.Task3.V15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            int[,] data = DataService.initArray();
            data = DataService.sortColumn(data, 2);
            int n, m;
            n = data.GetLength(0);
            m = data.GetLength(1);
            dataGridView1.RowCount = n;
            dataGridView1.ColumnCount = m;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = data[i, j];
                }
            }
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dataGridView1.Update();
        }
    }
}
