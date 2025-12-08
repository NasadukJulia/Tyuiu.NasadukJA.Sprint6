namespace Tyuiu.NasadukJA.Sprint6.Task0.V3
{
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
            textBoxVarX_NJA = new TextBox();
            labelX_NJA = new Label();
            textBoxResult_NJA = new TextBox();
            labelResult_NJA = new Label();
            buttonCalc_NJA = new Button();
            buttonHelp_NJA = new Button();
            pictureBoxFormula_NJA = new PictureBox();
            groupBoxCondition_NJA = new GroupBox();
            groupBoxInput_NJA = new GroupBox();
            groupBoxOutput_NJA = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_NJA).BeginInit();
            groupBoxCondition_NJA.SuspendLayout();
            groupBoxInput_NJA.SuspendLayout();
            groupBoxOutput_NJA.SuspendLayout();
            SuspendLayout();
            // 
            // labelCond_NJA
            // 
            labelCond_NJA.AutoSize = true;
            labelCond_NJA.Font = new Font("Microsoft Sans Serif", 12F);
            labelCond_NJA.Location = new Point(11, 37);
            labelCond_NJA.Name = "labelCond_NJA";
            labelCond_NJA.Size = new Size(354, 25);
            labelCond_NJA.TabIndex = 7;
            labelCond_NJA.Text = "Вычислить выражение по формуле:";
            // 
            // textBoxVarX_NJA
            // 
            textBoxVarX_NJA.Location = new Point(48, 69);
            textBoxVarX_NJA.Name = "textBoxVarX_NJA";
            textBoxVarX_NJA.Size = new Size(114, 27);
            textBoxVarX_NJA.TabIndex = 4;
            textBoxVarX_NJA.KeyPress += textBoxVarX_NJA_KeyPress;
            // 
            // labelX_NJA
            // 
            labelX_NJA.AutoSize = true;
            labelX_NJA.Location = new Point(48, 33);
            labelX_NJA.Name = "labelX_NJA";
            labelX_NJA.Size = new Size(114, 20);
            labelX_NJA.TabIndex = 5;
            labelX_NJA.Text = "Переменная X:";
            // 
            // textBoxResult_NJA
            // 
            textBoxResult_NJA.Location = new Point(128, 37);
            textBoxResult_NJA.Name = "textBoxResult_NJA";
            textBoxResult_NJA.ReadOnly = true;
            textBoxResult_NJA.Size = new Size(100, 27);
            textBoxResult_NJA.TabIndex = 2;
            // 
            // labelResult_NJA
            // 
            labelResult_NJA.AutoSize = true;
            labelResult_NJA.Location = new Point(21, 44);
            labelResult_NJA.Name = "labelResult_NJA";
            labelResult_NJA.Size = new Size(78, 20);
            labelResult_NJA.TabIndex = 3;
            labelResult_NJA.Text = "Результат:";
            // 
            // buttonCalc_NJA
            // 
            buttonCalc_NJA.Location = new Point(427, 257);
            buttonCalc_NJA.Name = "buttonCalc_NJA";
            buttonCalc_NJA.Size = new Size(100, 30);
            buttonCalc_NJA.TabIndex = 1;
            buttonCalc_NJA.Text = "Вычислить";
            buttonCalc_NJA.Click += buttonCalc_NJA_Click;
            // 
            // buttonHelp_NJA
            // 
            buttonHelp_NJA.Location = new Point(320, 257);
            buttonHelp_NJA.Name = "buttonHelp_NJA";
            buttonHelp_NJA.Size = new Size(80, 30);
            buttonHelp_NJA.TabIndex = 0;
            buttonHelp_NJA.Text = "?";
            buttonHelp_NJA.Click += buttonHelp_NJA_Click;
            // 
            // pictureBoxFormula_NJA
            // 
            pictureBoxFormula_NJA.Image = Properties.Resources.formula;
            pictureBoxFormula_NJA.Location = new Point(382, 26);
            pictureBoxFormula_NJA.Name = "pictureBoxFormula_NJA";
            pictureBoxFormula_NJA.Size = new Size(169, 98);
            pictureBoxFormula_NJA.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxFormula_NJA.TabIndex = 6;
            pictureBoxFormula_NJA.TabStop = false;
            // 
            // groupBoxCondition_NJA
            // 
            groupBoxCondition_NJA.Controls.Add(labelCond_NJA);
            groupBoxCondition_NJA.Controls.Add(pictureBoxFormula_NJA);
            groupBoxCondition_NJA.Location = new Point(1, 8);
            groupBoxCondition_NJA.Name = "groupBoxCondition_NJA";
            groupBoxCondition_NJA.Size = new Size(566, 138);
            groupBoxCondition_NJA.TabIndex = 8;
            groupBoxCondition_NJA.TabStop = false;
            groupBoxCondition_NJA.Text = "Условие";
            groupBoxCondition_NJA.Enter += groupBox1_Enter;
            // 
            // groupBoxInput_NJA
            // 
            groupBoxInput_NJA.Controls.Add(labelX_NJA);
            groupBoxInput_NJA.Controls.Add(textBoxVarX_NJA);
            groupBoxInput_NJA.Location = new Point(12, 162);
            groupBoxInput_NJA.Name = "groupBoxInput_NJA";
            groupBoxInput_NJA.Size = new Size(250, 125);
            groupBoxInput_NJA.TabIndex = 9;
            groupBoxInput_NJA.TabStop = false;
            groupBoxInput_NJA.Text = "Ввод данных";
            // 
            // groupBoxOutput_NJA
            // 
            groupBoxOutput_NJA.Controls.Add(labelResult_NJA);
            groupBoxOutput_NJA.Controls.Add(textBoxResult_NJA);
            groupBoxOutput_NJA.Location = new Point(299, 162);
            groupBoxOutput_NJA.Name = "groupBoxOutput_NJA";
            groupBoxOutput_NJA.Size = new Size(250, 89);
            groupBoxOutput_NJA.TabIndex = 6;
            groupBoxOutput_NJA.TabStop = false;
            groupBoxOutput_NJA.Text = "Вывод данных";
            // 
            // FormMain
            // 
            ClientSize = new Size(579, 299);
            Controls.Add(groupBoxOutput_NJA);
            Controls.Add(groupBoxInput_NJA);
            Controls.Add(groupBoxCondition_NJA);
            Controls.Add(buttonHelp_NJA);
            Controls.Add(buttonCalc_NJA);
            Name = "FormMain";
            Text = "Спирт 6 | Таск 0 | Насадюк Ю. А.";
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_NJA).EndInit();
            groupBoxCondition_NJA.ResumeLayout(false);
            groupBoxCondition_NJA.PerformLayout();
            groupBoxInput_NJA.ResumeLayout(false);
            groupBoxInput_NJA.PerformLayout();
            groupBoxOutput_NJA.ResumeLayout(false);
            groupBoxOutput_NJA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label labelCond_NJA;
        private System.Windows.Forms.Label labelX_NJA;
        private System.Windows.Forms.Label labelResult_NJA;
        private System.Windows.Forms.TextBox textBoxVarX_NJA;
        private System.Windows.Forms.TextBox textBoxResult_NJA;
        private System.Windows.Forms.Button buttonCalc_NJA;
        private System.Windows.Forms.Button buttonHelp_NJA;
        private System.Windows.Forms.PictureBox pictureBoxFormula_NJA;
        private GroupBox groupBoxCondition_NJA;
        private GroupBox groupBoxInput_NJA;
        private GroupBox groupBoxOutput_NJA;
    }
}