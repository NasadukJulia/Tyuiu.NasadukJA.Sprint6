using Tyuiu.NasadukJA.Sprint6.Task5.V29.Lib;

namespace Tyuiu.NasadukJA.Sprint6.Task5.V29;

public partial class FormMain : Form
{
    private string filePath_NJA = @"C:\Users\Julia\Desktop\DataSprint6\InPutFileTask5V29.txt";
    private DataService ds_NJA = new DataService();

    public FormMain()
    {
        InitializeComponent();
    }

    private void buttonOpenFile_NJA_Click(object sender, EventArgs e)
    {
        string path = @"C:\Users\Julia\Desktop\DataSprint6\InPutFileTask5V29.txt";

        if (File.Exists(path))
        {
            MessageBox.Show("Файл найден! Открываю...", "Информация", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            // Открытие файла
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
            {
                FileName = path,
                UseShellExecute = true
            });
        }
        else
        {
            MessageBox.Show("Файл не найден!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void buttonDo_NJA_Click(object sender, EventArgs e)
    {
        try
        {
            double[] values_NJA = ds_NJA.LoadFromDataFile(filePath_NJA);

            dataGridViewResult_NJA.Rows.Clear();
            dataGridViewResult_NJA.Columns.Clear();
            dataGridViewResult_NJA.Columns.Add("col", "Значения");

            foreach (double val_NJA in values_NJA)
                dataGridViewResult_NJA.Rows.Add(val_NJA);

            chartValues_NJA.Series[0].Points.Clear();
            for (int i = 0; i < values_NJA.Length; i++)
            {
                chartValues_NJA.Series[0].Points.AddXY(i + 1, values_NJA[i]);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Ошибка: " + ex.Message);
        }
    }

    private void buttonHelp_NJA_Click(object sender, EventArgs e)
    {
        MessageBox.Show(
            "Задание выполнила студентка группы СМАРТб-25-1 Насадюк Ю.А."
        );
    }
}
