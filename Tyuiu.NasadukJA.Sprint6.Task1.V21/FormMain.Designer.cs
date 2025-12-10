namespace Tyuiu.NasadukJA.Sprint6.Task1.V21;

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
        labelInput_NJA = new Label();
        labelOutput_NJA = new Label();
        labelStartStep_NJA = new Label();
        labelStopStep_NJA = new Label();
        textBoxStartStep_NJA = new TextBox();
        textBoxStopStep_NJA = new TextBox();
        textBoxResult_NJA = new TextBox();
        buttonHelp_NJA = new Button();
        buttonDone_NJA = new Button();
        groupBoxCond_NJA = new GroupBox();
        groupBoxCond_NJA.SuspendLayout();
        SuspendLayout();
        // 
        // labelCond_NJA
        // 
        labelCond_NJA.AutoSize = true;
        labelCond_NJA.Font = new Font("Microsoft Sans Serif", 12F);
        labelCond_NJA.Location = new Point(4, 41);
        labelCond_NJA.Name = "labelCond_NJA";
        labelCond_NJA.Size = new Size(542, 50);
        labelCond_NJA.TabIndex = 0;
        labelCond_NJA.Text = "Протабулировать функцию F(x) на заданном диапазоне.\nРезультат вывести в виде таблицы.";
        labelCond_NJA.Click += labelCond_NJA_Click;
        // 
        // labelInput_NJA
        // 
        labelInput_NJA.AutoSize = true;
        labelInput_NJA.Font = new Font("Microsoft Sans Serif", 10F);
        labelInput_NJA.Location = new Point(24, 224);
        labelInput_NJA.Name = "labelInput_NJA";
        labelInput_NJA.Size = new Size(125, 20);
        labelInput_NJA.TabIndex = 1;
        labelInput_NJA.Text = "Ввод данных:";
        // 
        // labelOutput_NJA
        // 
        labelOutput_NJA.AutoSize = true;
        labelOutput_NJA.Font = new Font("Microsoft Sans Serif", 10F);
        labelOutput_NJA.Location = new Point(642, 12);
        labelOutput_NJA.Name = "labelOutput_NJA";
        labelOutput_NJA.Size = new Size(137, 20);
        labelOutput_NJA.TabIndex = 2;
        labelOutput_NJA.Text = "Вывод данных:";
        // 
        // labelStartStep_NJA
        // 
        labelStartStep_NJA.AutoSize = true;
        labelStartStep_NJA.Location = new Point(20, 269);
        labelStartStep_NJA.Name = "labelStartStep_NJA";
        labelStartStep_NJA.Size = new Size(88, 20);
        labelStartStep_NJA.TabIndex = 3;
        labelStartStep_NJA.Text = "Старт шага:";
        // 
        // labelStopStep_NJA
        // 
        labelStopStep_NJA.AutoSize = true;
        labelStopStep_NJA.Location = new Point(20, 304);
        labelStopStep_NJA.Name = "labelStopStep_NJA";
        labelStopStep_NJA.Size = new Size(94, 20);
        labelStopStep_NJA.TabIndex = 4;
        labelStopStep_NJA.Text = "Конец шага:";
        // 
        // textBoxStartStep_NJA
        // 
        textBoxStartStep_NJA.Location = new Point(120, 262);
        textBoxStartStep_NJA.Name = "textBoxStartStep_NJA";
        textBoxStartStep_NJA.Size = new Size(99, 27);
        textBoxStartStep_NJA.TabIndex = 5;
        // 
        // textBoxStopStep_NJA
        // 
        textBoxStopStep_NJA.Location = new Point(120, 304);
        textBoxStopStep_NJA.Name = "textBoxStopStep_NJA";
        textBoxStopStep_NJA.Size = new Size(99, 27);
        textBoxStopStep_NJA.TabIndex = 6;
        // 
        // textBoxResult_NJA
        // 
        textBoxResult_NJA.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
        textBoxResult_NJA.Location = new Point(593, 54);
        textBoxResult_NJA.Multiline = true;
        textBoxResult_NJA.Name = "textBoxResult_NJA";
        textBoxResult_NJA.ScrollBars = ScrollBars.Vertical;
        textBoxResult_NJA.Size = new Size(250, 277);
        textBoxResult_NJA.TabIndex = 7;
        // 
        // buttonHelp_NJA
        // 
        buttonHelp_NJA.BackColor = Color.SkyBlue;
        buttonHelp_NJA.Location = new Point(284, 240);
        buttonHelp_NJA.Name = "buttonHelp_NJA";
        buttonHelp_NJA.Size = new Size(123, 70);
        buttonHelp_NJA.TabIndex = 8;
        buttonHelp_NJA.Text = "Справка";
        buttonHelp_NJA.UseVisualStyleBackColor = false;
        buttonHelp_NJA.Click += buttonHelp_NJA_Click;
        // 
        // buttonDone_NJA
        // 
        buttonDone_NJA.BackColor = Color.LightGreen;
        buttonDone_NJA.Location = new Point(413, 232);
        buttonDone_NJA.Name = "buttonDone_NJA";
        buttonDone_NJA.Size = new Size(159, 81);
        buttonDone_NJA.TabIndex = 9;
        buttonDone_NJA.Text = "Выполнить";
        buttonDone_NJA.UseVisualStyleBackColor = false;
        buttonDone_NJA.Click += buttonDone_NJA_Click;
        // 
        // groupBoxCond_NJA
        // 
        groupBoxCond_NJA.Controls.Add(labelCond_NJA);
        groupBoxCond_NJA.Location = new Point(20, 12);
        groupBoxCond_NJA.Name = "groupBoxCond_NJA";
        groupBoxCond_NJA.Size = new Size(552, 195);
        groupBoxCond_NJA.TabIndex = 10;
        groupBoxCond_NJA.TabStop = false;
        groupBoxCond_NJA.Text = "Условие";
        // 
        // FormMain
        // 
        ClientSize = new Size(856, 344);
        Controls.Add(groupBoxCond_NJA);
        Controls.Add(labelOutput_NJA);
        Controls.Add(labelInput_NJA);
        Controls.Add(labelStartStep_NJA);
        Controls.Add(labelStopStep_NJA);
        Controls.Add(textBoxStartStep_NJA);
        Controls.Add(textBoxStopStep_NJA);
        Controls.Add(textBoxResult_NJA);
        Controls.Add(buttonHelp_NJA);
        Controls.Add(buttonDone_NJA);
        Name = "FormMain";
        Text = "Спринт 6 | Task 1 | Вариант 21 | Насадюк Ю.А.";
        groupBoxCond_NJA.ResumeLayout(false);
        groupBoxCond_NJA.PerformLayout();
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
        private System.Windows.Forms.TextBox textBoxResult_NJA;
        private System.Windows.Forms.Button buttonHelp_NJA;
        private System.Windows.Forms.Button buttonDone_NJA;
    private GroupBox groupBoxCond_NJA;
}
