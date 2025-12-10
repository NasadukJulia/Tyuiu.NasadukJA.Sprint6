namespace Tyuiu.NasadukJA.Sprint6.Task3.V9;
partial class FormMain
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        labelCond_NJA = new Label();
        dataGridViewMatrix_NJA = new DataGridView();
        buttonHelp_NJA = new Button();
        buttonDone_NJA = new Button();
        ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_NJA).BeginInit();
        SuspendLayout();
        // 
        // labelCond_NJA
        // 
        labelCond_NJA.AutoSize = true;
        labelCond_NJA.Font = new Font("Microsoft Sans Serif", 10F);
        labelCond_NJA.Location = new Point(12, 9);
        labelCond_NJA.Name = "labelCond_NJA";
        labelCond_NJA.Size = new Size(461, 180);
        labelCond_NJA.TabIndex = 4;
        labelCond_NJA.Text = "Условие\nДана матрица 5 на 5:\n-14   25   26   18   17\n 28   10    6   -2    4\n 30   25   -3   11  -10\n 11   32   -5  -20   25\n  2  -18   11    8  -20\n\nВыполнить сортировку по возрастанию 5-го столбца.";
        // 
        // dataGridViewMatrix_NJA
        // 
        dataGridViewMatrix_NJA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewMatrix_NJA.Location = new Point(492, 12);
        dataGridViewMatrix_NJA.Name = "dataGridViewMatrix_NJA";
        dataGridViewMatrix_NJA.RowHeadersVisible = false;
        dataGridViewMatrix_NJA.RowHeadersWidth = 51;
        dataGridViewMatrix_NJA.Size = new Size(300, 250);
        dataGridViewMatrix_NJA.TabIndex = 1;
        // 
        // buttonHelp_NJA
        // 
        buttonHelp_NJA.BackColor = Color.SkyBlue;
        buttonHelp_NJA.Font = new Font("Microsoft Sans Serif", 10F);
        buttonHelp_NJA.Location = new Point(157, 220);
        buttonHelp_NJA.Name = "buttonHelp_NJA";
        buttonHelp_NJA.Size = new Size(133, 42);
        buttonHelp_NJA.TabIndex = 1;
        buttonHelp_NJA.Text = "Справка";
        buttonHelp_NJA.UseVisualStyleBackColor = false;
        buttonHelp_NJA.Click += buttonHelp_NJA_Click;
        // 
        // buttonDone_NJA
        // 
        buttonDone_NJA.BackColor = Color.LightGreen;
        buttonDone_NJA.Font = new Font("Microsoft Sans Serif", 10F);
        buttonDone_NJA.Location = new Point(296, 208);
        buttonDone_NJA.Name = "buttonDone_NJA";
        buttonDone_NJA.Size = new Size(177, 54);
        buttonDone_NJA.TabIndex = 0;
        buttonDone_NJA.Text = "Выполнить";
        buttonDone_NJA.UseVisualStyleBackColor = false;
        buttonDone_NJA.Click += buttonDone_NJA_Click;
        // 
        // FormMain
        // 
        ClientSize = new Size(810, 283);
        Controls.Add(buttonDone_NJA);
        Controls.Add(buttonHelp_NJA);
        Controls.Add(dataGridViewMatrix_NJA);
        Controls.Add(labelCond_NJA);
        Name = "FormMain";
        Text = "Спринт 6 | Таск 3 | Вариант 9 | Насадюк Ю.А.";
        ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_NJA).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private System.Windows.Forms.Label labelCond_NJA;
    private System.Windows.Forms.DataGridView dataGridViewMatrix_NJA;
    private System.Windows.Forms.Button buttonHelp_NJA;
    private System.Windows.Forms.Button buttonDone_NJA;
}

