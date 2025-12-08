using Tyuiu.NasadukJA.Sprint6.Task0.V3.Lib;

namespace Tyuiu.NasadukJA.Sprint6.Task0.V3
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonCalc_NJA_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();

            try
            {
                int x = Convert.ToInt32(textBoxVarX_NJA.Text);
                textBoxResult_NJA.Text = Convert.ToString(ds.Calculate(x));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxVarX_NJA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void buttonHelp_NJA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполняла студентка группы СМАРТ6-25-1 Насадюк Юлия Андреевна",
                "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}