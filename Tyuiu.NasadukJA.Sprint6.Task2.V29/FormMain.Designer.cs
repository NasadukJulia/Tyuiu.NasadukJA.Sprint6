namespace Tyuiu.NasadukJA.Sprint6.Task2.V29;

partial class FormMain
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
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
        labelInput_NJA = new Label();
        labelOutput_NJA = new Label();
        labelStartStep_NJA = new Label();
        labelStopStep_NJA = new Label();
        textBoxStartStep_NJA = new TextBox();
        textBoxStopStep_NJA = new TextBox();
        buttonHelp_NJA = new Button();
        buttonDone_NJA = new Button();
        dataGridViewResult_NJA = new DataGridView();
        ColumnX = new DataGridViewTextBoxColumn();
        ColumnFx = new DataGridViewTextBoxColumn();
        ((System.ComponentModel.ISupportInitialize)dataGridViewResult_NJA).BeginInit();
        SuspendLayout();
        // 
        // labelCond_NJA
        // 
        labelCond_NJA.AutoSize = true;
        labelCond_NJA.Font = new Font("Microsoft Sans Serif", 11F);
        labelCond_NJA.Location = new Point(20, 20);
        labelCond_NJA.Name = "labelCond_NJA";
        labelCond_NJA.Size = new Size(472, 72);
        labelCond_NJA.TabIndex = 9;
        labelCond_NJA.Text = "Условие:\nПротабулировать функцию F(x) на диапазоне [-5;5].\nРезультат вывести в виде таблицы.";
        // 
        // labelInput_NJA
        // 
        labelInput_NJA.AutoSize = true;
        labelInput_NJA.Font = new Font("Microsoft Sans Serif", 10F);
        labelInput_NJA.Location = new Point(20, 128);
        labelInput_NJA.Name = "labelInput_NJA";
        labelInput_NJA.Size = new Size(125, 20);
        labelInput_NJA.TabIndex = 8;
        labelInput_NJA.Text = "Ввод данных:";
        // 
        // labelOutput_NJA
        // 
        labelOutput_NJA.AutoSize = true;
        labelOutput_NJA.Font = new Font("Microsoft Sans Serif", 10F);
        labelOutput_NJA.Location = new Point(420, 110);
        labelOutput_NJA.Name = "labelOutput_NJA";
        labelOutput_NJA.Size = new Size(137, 20);
        labelOutput_NJA.TabIndex = 7;
        labelOutput_NJA.Text = "Вывод данных:";
        // 
        // labelStartStep_NJA
        // 
        labelStartStep_NJA.AutoSize = true;
        labelStartStep_NJA.Location = new Point(20, 168);
        labelStartStep_NJA.Name = "labelStartStep_NJA";
        labelStartStep_NJA.Size = new Size(88, 20);
        labelStartStep_NJA.TabIndex = 6;
        labelStartStep_NJA.Text = "Старт шага:";
        // 
        // labelStopStep_NJA
        // 
        labelStopStep_NJA.AutoSize = true;
        labelStopStep_NJA.Location = new Point(20, 217);
        labelStopStep_NJA.Name = "labelStopStep_NJA";
        labelStopStep_NJA.Size = new Size(94, 20);
        labelStopStep_NJA.TabIndex = 5;
        labelStopStep_NJA.Text = "Конец шага:";
        // 
        // textBoxStartStep_NJA
        // 
        textBoxStartStep_NJA.Location = new Point(129, 165);
        textBoxStartStep_NJA.Name = "textBoxStartStep_NJA";
        textBoxStartStep_NJA.Size = new Size(139, 27);
        textBoxStartStep_NJA.TabIndex = 4;
        // 
        // textBoxStopStep_NJA
        // 
        textBoxStopStep_NJA.Location = new Point(129, 210);
        textBoxStopStep_NJA.Name = "textBoxStopStep_NJA";
        textBoxStopStep_NJA.Size = new Size(139, 27);
        textBoxStopStep_NJA.TabIndex = 3;
        // 
        // buttonHelp_NJA
        // 
        buttonHelp_NJA.BackColor = Color.SkyBlue;
        buttonHelp_NJA.Location = new Point(36, 316);
        buttonHelp_NJA.Name = "buttonHelp_NJA";
        buttonHelp_NJA.Size = new Size(156, 43);
        buttonHelp_NJA.TabIndex = 2;
        buttonHelp_NJA.Text = "Справка";
        buttonHelp_NJA.UseVisualStyleBackColor = false;
        buttonHelp_NJA.Click += buttonHelp_NJA_Click;
        // 
        // buttonDone_NJA
        // 
        buttonDone_NJA.BackColor = Color.LightGreen;
        buttonDone_NJA.Location = new Point(218, 291);
        buttonDone_NJA.Name = "buttonDone_NJA";
        buttonDone_NJA.Size = new Size(160, 79);
        buttonDone_NJA.TabIndex = 1;
        buttonDone_NJA.Text = "Выполнить";
        buttonDone_NJA.UseVisualStyleBackColor = false;
        buttonDone_NJA.Click += buttonDone_NJA_Click;
        // 
        // dataGridViewResult_NJA
        // 
        dataGridViewResult_NJA.AllowUserToAddRows = false;
        dataGridViewResult_NJA.AllowUserToDeleteRows = false;
        dataGridViewResult_NJA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewResult_NJA.Columns.AddRange(new DataGridViewColumn[] { ColumnX, ColumnFx });
        dataGridViewResult_NJA.Location = new Point(420, 140);
        dataGridViewResult_NJA.Name = "dataGridViewResult_NJA";
        dataGridViewResult_NJA.ReadOnly = true;
        dataGridViewResult_NJA.RowHeadersWidth = 51;
        dataGridViewResult_NJA.Size = new Size(260, 230);
        dataGridViewResult_NJA.TabIndex = 0;
        // 
        // ColumnX
        // 
        ColumnX.HeaderText = "X";
        ColumnX.MinimumWidth = 6;
        ColumnX.Name = "ColumnX";
        ColumnX.ReadOnly = true;
        ColumnX.Width = 80;
        // 
        // ColumnFx
        // 
        ColumnFx.HeaderText = "F(x)";
        ColumnFx.MinimumWidth = 6;
        ColumnFx.Name = "ColumnFx";
        ColumnFx.ReadOnly = true;
        ColumnFx.Width = 120;
        // 
        // FormMain
        // 
        ClientSize = new Size(720, 400);
        Controls.Add(dataGridViewResult_NJA);
        Controls.Add(buttonDone_NJA);
        Controls.Add(buttonHelp_NJA);
        Controls.Add(textBoxStopStep_NJA);
        Controls.Add(textBoxStartStep_NJA);
        Controls.Add(labelStopStep_NJA);
        Controls.Add(labelStartStep_NJA);
        Controls.Add(labelOutput_NJA);
        Controls.Add(labelInput_NJA);
        Controls.Add(labelCond_NJA);
        Name = "FormMain";
        Text = "Спринт 6 | Таск 2 | Вариант 29 | Насадюк Ю. А.";
        ((System.ComponentModel.ISupportInitialize)dataGridViewResult_NJA).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private System.Windows.Forms.Label labelCond_NJA;
    private System.Windows.Forms.Label labelInput_NJA;
    private System.Windows.Forms.Label labelOutput_NJA;
    private System.Windows.Forms.Label labelStartStep_NJA;
    private System.Windows.Forms.Label labelStopStep_NJA;
    private System.Windows.Forms.TextBox textBoxStartStep_NJA;
    private System.Windows.Forms.TextBox textBoxStopStep_NJA;
    private System.Windows.Forms.Button buttonHelp_NJA;
    private System.Windows.Forms.Button buttonDone_NJA;
    private System.Windows.Forms.DataGridView dataGridViewResult_NJA;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColumnX;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFx;
}