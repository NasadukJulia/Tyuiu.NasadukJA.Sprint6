using Tyuiu.NasadukJA.Sprint6.Task1.V21.Lib;


namespace Tyuiu.NasadukJA.Sprint6.Task1.V21;

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

            textBoxResult_NJA.Text = "";

            textBoxResult_NJA.AppendText("+-------+----------+" + Environment.NewLine);
            textBoxResult_NJA.AppendText("|   X   |   F(x)   |" + Environment.NewLine);
            textBoxResult_NJA.AppendText("+-------+----------+" + Environment.NewLine);

            int x = start;

            for (int i = 0; i < arr.Length; i++)
            {
                string line = String.Format("|{0,7:D}|{1,10:F2}|", x, arr[i]);
                textBoxResult_NJA.AppendText(line + Environment.NewLine);
                x++;
            }

            textBoxResult_NJA.AppendText("+-------+----------+" + Environment.NewLine);
        }
        catch
        {
            MessageBox.Show("Ошибка: неверно введены данные!",
                            "Ошибка",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }
    }

    // Кнопка "Справка"
    private void buttonHelp_NJA_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Таск 1 выполнила студентка группы СМАРТб-25-1 Насадюк Юлия Андреевна",
                        "Справка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
    }

    private void labelCond_NJA_Click(object sender, EventArgs e)
    {

    }
}
