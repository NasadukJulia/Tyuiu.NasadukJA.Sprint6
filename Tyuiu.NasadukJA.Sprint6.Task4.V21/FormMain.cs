using System.Windows.Forms;
using Tyuiu.NasadukJA.Sprint6.Task4.V21.Lib;

using System.Windows.Forms.VisualStyles;

namespace Tyuiu.NasadukJA.Sprint6.Task4.V21;

public partial class FormMain : Form
{
    DataService ds = new DataService();

    public FormMain()
    {
        InitializeComponent();
    }

    private void buttonDone_NJA_Click(object sender, EventArgs e)
    {
        textBoxResult_NJA.Clear();
        chartFunction_NJA.Series[0].Points.Clear();

        int start = -5;
        int stop = 5;

        double[] values = ds.GetMassFunction(start, stop);

        int x = start;

        for (int i = 0; i < values.Length; i++)
        {
            textBoxResult_NJA.AppendText(values[i].ToString() + Environment.NewLine);

            chartFunction_NJA.Series[0].Points.AddXY(x, values[i]);

            x++;
        }
    }

    private void buttonSave_NJA_Click(object sender, EventArgs e)
    {
        try
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask4V21.txt");

            File.WriteAllText(path, textBoxResult_NJA.Text);

            DialogResult result = MessageBox.Show(
                $"Файл сохранён:\n{path}\nОткрыть файл?",
                "Сохранение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                var psi = new System.Diagnostics.ProcessStartInfo()
                {
                    FileName = path,
                    UseShellExecute = true 
                };

                System.Diagnostics.Process.Start(psi);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Ошибка при сохранении файла: " + ex.Message);
        }
    }

    private void buttonHelp_NJA_Click(object sender, EventArgs e)
    {
        MessageBox.Show(
            "Выполнила студентка группы СМАРТБ-25-1 Насадюк Ю.А.",
            "Справка",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        );
    }
}
