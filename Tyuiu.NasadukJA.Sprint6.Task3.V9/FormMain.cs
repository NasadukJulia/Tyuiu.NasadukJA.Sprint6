using Tyuiu.NasadukJA.Sprint6.Task3.V9.Lib;

namespace Tyuiu.NasadukJA.Sprint6.Task3.V9;

public partial class FormMain : Form
{
    public FormMain()
    {
        InitializeComponent();
    }
    DataService ds = new DataService();
    private void buttonDone_NJA_Click(object sender, EventArgs e)
    {
        int[,] matrix =
        {
                { -14, 25, 26, 18, 17 },
                {  28, 10,  6, -2,  4 },
                {  30, 25, -3, 11, -10 },
                {  11, 32, -5, -20, 25 },
                {   2, -18, 11, 8, -20 }
            };

        int[,] result = ds.Calculate(matrix);

        dataGridViewMatrix_NJA.Rows.Clear();
        dataGridViewMatrix_NJA.Columns.Clear();

        // создаём 5 столбцов
        for (int c = 0; c < 5; c++)
        {
            dataGridViewMatrix_NJA.Columns.Add($"col{c}", $"Ст {c + 1}");
        }

        // вывод результата
        for (int i = 0; i < 5; i++)
        {
            dataGridViewMatrix_NJA.Rows.Add(
                result[i, 0],
                result[i, 1],
                result[i, 2],
                result[i, 3],
                result[i, 4]
            );
        }
    }

    private void buttonHelp_NJA_Click(object sender, EventArgs e)
    {
        MessageBox.Show(
            "Таск 3 выполнила студентка группы СМАРТб-25-1 Насадюк Юлия Андреевна",
            "Справка",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
    }
}


