using Tyuiu.NasadukJA.Sprint6.Task2.V29.Lib;

namespace Tyuiu.NasadukJA.Sprint6.Task2.V29;

public partial class FormMain : Form
{
    public FormMain()
    {
        InitializeComponent();
    }

    DataService ds = new DataService();
    private void buttonDone_NJA_Click(object sender, EventArgs e)
    {
        try
        {
            int start = Convert.ToInt32(textBoxStartStep_NJA.Text);
            int stop = Convert.ToInt32(textBoxStopStep_NJA.Text);
            
            double[] arr = ds.GetMassFunction(start, stop);

            dataGridViewResult_NJA.Rows.Clear();

            int x = start;

            for (int i = 0; i < arr.Length; i++)
            {
                dataGridViewResult_NJA.Rows.Add(x, arr[i]);
                x++;
            }

        }
        catch
        {
            MessageBox.Show("Ошибка: неверно введены данные!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void buttonHelp_NJA_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Таск 2 выполнила студентка группы СМАРТб-25-1 Насадюк Юлия Андреевна",
            "Справка",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
    }
}
