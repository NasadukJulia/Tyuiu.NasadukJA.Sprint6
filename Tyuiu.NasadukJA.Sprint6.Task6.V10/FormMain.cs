using Tyuiu.NasadukJA.Sprint6.Task6.V10.Lib;

namespace Tyuiu.NasadukJA.Sprint6.Task6.V10;

public partial class FormMain : Form
{
    private string openFilePath_NJA = "";
    DataService ds = new DataService();

    public FormMain()
    {
        InitializeComponent();
    }

    private void buttonOpenFile_NJA_Click(object sender, EventArgs e)
    {
        if (openFileDialogTask_NJA.ShowDialog() == DialogResult.OK)
        {
            openFilePath_NJA = openFileDialogTask_NJA.FileName;
            textBoxIn_NJA.Text = File.ReadAllText(openFilePath_NJA);
            buttonDone_NJA.Enabled = true;
        }
    }

    private void buttonDone_NJA_Click(object sender, EventArgs e)
    {
        if (openFilePath_NJA == "")
        {
            MessageBox.Show("Файл не выбран!", "Ошибка");
            return;
        }

        string result = ds.CollectTextFromFile(openFilePath_NJA);
        textBoxOut_NJA.Text = result;
    }

    private void buttonHelp_NJA_Click(object sender, EventArgs e)
    {
        FormAbout_NJA about = new FormAbout_NJA();
        about.ShowDialog();
    }
}
