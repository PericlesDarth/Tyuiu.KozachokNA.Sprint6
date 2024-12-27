using System.IO;

namespace Tyuiu.KozachokNA.Sprint6.Task7.V12
{
    public partial class Form1 : Form
    {
        string path;
        string[,] input;
        string[,] output;
        public Form1()
        {
            InitializeComponent();
            dataGridViewIn.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dataGridViewOut.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void OpenFile_Click(object sender, System.EventArgs e)
        {
            openFileDialog1.ShowDialog();
            path = openFileDialog1.FileName;
            input = ParseCSV(File.ReadAllLines(path));
            FillDataGrid(dataGridViewIn, input); 
            output = DataService.ProcessData(input, 8);
            FillDataGrid(dataGridViewOut, output);

            dataGridViewIn.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dataGridViewOut.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dataGridViewIn.Update();
            dataGridViewOut.Update();

            OpenFile.Enabled = true;
        }

        private void SaveFile_Click(object sender, System.EventArgs e)
        {
            string[] csv = UnparseCSV(output);
            saveFileDialog1.ShowDialog();
            path = saveFileDialog1.FileName;
            File.WriteAllLines(path, csv);
            SaveFile.Enabled = true;
        }

        private void FillDataGrid(DataGridView grid, string[,] data)
        {
            int n, m;
            n = data.GetLength(0);
            m = data.GetLength(1);
            grid.Rows.Clear();
            grid.Columns.Clear();
            grid.RowCount = n;
            grid.ColumnCount = m;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    grid.Rows[i].Cells[j].Value = data[i, j];
                }
            }
        }

        private string[,] ParseCSV(string[] csv)
        {
            int n, m;
            n = csv.Length;
            m = 1;
            string foo = "";
            int[] count = new int[n];
            for (int i = 0; i < n; i++)
            {
                count[i] = 0;
                foreach (char c in csv[i])
                {
                    if (c == ';')
                    {
                        count[i]++;
                    }
                }
            }
            m = count.Max() + 1;

            string[,] res = new string[n, m];
            for (int i = 0; i < n; i++)
            {
                foo = csv[i];
                string[] bar = foo.Split(';');
                for (int j = 0; j < m; j++)
                {
                    if (j <= count[i])
                    {
                        res[i, j] = bar[j];
                    }
                    else
                    {
                        res[i, j] = "";
                    }
                }
            }
            return res;
        }

        private string[] UnparseCSV(string[,] data)
        {
            int n, m;
            n = data.GetLength(0);
            m = data.GetLength(1);
            string[] csv = new string[n];
            string foo = "";
            for (int i = 0; i < n; i++)
            {
                foo = "";
                for (int j = 0; j < m; j++)
                {
                    if (j < m - 1)
                    {
                        foo += data[i, j] + ";";
                    }
                    else
                    {
                        foo += data[i, j];
                    }
                }
                csv[i] = foo;
            }
            return csv;
        }
    }
}
