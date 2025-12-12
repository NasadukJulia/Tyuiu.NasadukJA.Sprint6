using Tyuiu.NasadukJA.Sprint6.Task7.V19.Lib;

namespace Tyuiu.NasadukJA.Sprint6.Task7.V19
{
    public partial class FormMain : Form
    {
        private int[,]? inputMatrix = null;
        private int[,]? outputMatrix = null;

        DataService ds = new DataService();
        private string openFilePath = string.Empty;

        public FormMain()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            buttonDone_NJA.Enabled = false;
            buttonSaveFile_NJA.Enabled = false;
        }

        private int[,] LoadRawMatrix(string path)
        {
            string[] lines = File.ReadAllLines(path);

            int rows = lines.Length;
            int cols = lines[0].Split(';').Length;

            int[,] matrix = new int[rows, cols];

            for (int r = 0; r < rows; r++)
            {
                string[] values = lines[r].Split(';');
                for (int c = 0; c < cols; c++)
                {
                    matrix[r, c] = Convert.ToInt32(values[c]);
                }
            }

            return matrix;
        }

        private void buttonOpenFile_NJA_Click(object sender, EventArgs e)
        {
            if (openFileDialogTask_NJA.ShowDialog() == DialogResult.OK)
            {
                openFilePath = openFileDialogTask_NJA.FileName;
                textBoxPath_NJA.Text = openFilePath;

                inputMatrix = LoadRawMatrix(openFilePath);
                FillDataGrid(dataGridViewIn_NJA, inputMatrix);

                outputMatrix = ds.GetMatrix(openFilePath);

                buttonDone_NJA.Enabled = true;
                buttonSaveFile_NJA.Enabled = false;
            }
        }

        private void buttonDone_NJA_Click(object sender, EventArgs e)
        {
            FillDataGrid(dataGridViewOut_NJA, outputMatrix);
            buttonSaveFile_NJA.Enabled = true;
        }

        private void buttonSaveFile_NJA_Click(object sender, EventArgs e)
        {
            saveFileDialogTask_NJA.FileName = "OutPutFileTask7V19.csv";
            saveFileDialogTask_NJA.InitialDirectory = Directory.GetCurrentDirectory();

            if (saveFileDialogTask_NJA.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialogTask_NJA.FileName;

                FileInfo fi = new FileInfo(path);
                if (fi.Exists) fi.Delete();

                int rows = outputMatrix.GetLength(0);
                int cols = outputMatrix.GetLength(1);

                string line = "";

                for (int r = 0; r < rows; r++)
                {
                    line = "";
                    for (int c = 0; c < cols; c++)
                    {
                        if (c != cols - 1)
                            line += outputMatrix[r, c] + ";";
                        else
                            line += outputMatrix[r, c];
                    }
                    File.AppendAllText(path, line + Environment.NewLine);
                }

                MessageBox.Show("Файл успешно сохранён!");
            }
        }

        private void buttonHelp_NJA_Click(object sender, EventArgs e)
        {
            FormAbout_NJA about = new FormAbout_NJA();
            about.ShowDialog();
        }

        private void FillDataGrid(DataGridView grid, int[,] matrix)
        {
            grid.Rows.Clear();
            grid.Columns.Clear();

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            grid.ColumnCount = cols;
            grid.RowCount = rows;

            for (int i = 0; i < cols; i++)
            {
                grid.Columns[i].Width = 40;
            }

            for (int r = 0; r < rows; r++)
                for (int c = 0; c < cols; c++)
                    grid.Rows[r].Cells[c].Value = matrix[r, c];
        }

        private void labelTask_NJA_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxPath_NJA_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPath_NJA_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void openFileDialogTask_NJA_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}