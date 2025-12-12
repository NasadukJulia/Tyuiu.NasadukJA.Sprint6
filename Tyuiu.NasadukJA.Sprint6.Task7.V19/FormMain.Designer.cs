namespace Tyuiu.NasadukJA.Sprint6.Task7.V19
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            toolTip_NJA = new ToolTip(components);
            buttonOpenFile_NJA = new Button();
            buttonDone_NJA = new Button();
            buttonSaveFile_NJA = new Button();
            buttonHelp_NJA = new Button();
            openFileDialogTask_NJA = new OpenFileDialog();
            saveFileDialogTask_NJA = new SaveFileDialog();
            labelTask_NJA = new Label();
            textBoxPath_NJA = new TextBox();
            dataGridViewIn_NJA = new DataGridView();
            dataGridViewOut_NJA = new DataGridView();
            groupBox1_NJA = new GroupBox();
            panelButtons_NJA = new TableLayoutPanel();
            groupBox2_NJA = new GroupBox();
            groupBoxIn_NJA = new GroupBox();
            groupBoxOut_NJA = new GroupBox();
            tableLayoutPanel_NJA = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_NJA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_NJA).BeginInit();
            groupBox1_NJA.SuspendLayout();
            panelButtons_NJA.SuspendLayout();
            groupBox2_NJA.SuspendLayout();
            groupBoxIn_NJA.SuspendLayout();
            groupBoxOut_NJA.SuspendLayout();
            tableLayoutPanel_NJA.SuspendLayout();
            SuspendLayout();
            // 
            // buttonOpenFile_NJA
            // 
            buttonOpenFile_NJA.BackgroundImage = Properties.Resources.folder;
            buttonOpenFile_NJA.BackgroundImageLayout = ImageLayout.Stretch;
            buttonOpenFile_NJA.Location = new Point(3, 3);
            buttonOpenFile_NJA.Name = "buttonOpenFile_NJA";
            buttonOpenFile_NJA.Size = new Size(60, 60);
            buttonOpenFile_NJA.TabIndex = 0;
            toolTip_NJA.SetToolTip(buttonOpenFile_NJA, "Открыть CSV файл");
            buttonOpenFile_NJA.Click += buttonOpenFile_NJA_Click;
            // 
            // buttonDone_NJA
            // 
            buttonDone_NJA.BackgroundImage = Properties.Resources.run;
            buttonDone_NJA.BackgroundImageLayout = ImageLayout.Stretch;
            buttonDone_NJA.Enabled = false;
            buttonDone_NJA.Location = new Point(83, 3);
            buttonDone_NJA.Name = "buttonDone_NJA";
            buttonDone_NJA.Size = new Size(60, 60);
            buttonDone_NJA.TabIndex = 1;
            toolTip_NJA.SetToolTip(buttonDone_NJA, "Выполнить обработку");
            buttonDone_NJA.Click += buttonDone_NJA_Click;
            // 
            // buttonSaveFile_NJA
            // 
            buttonSaveFile_NJA.BackgroundImage = Properties.Resources.save;
            buttonSaveFile_NJA.BackgroundImageLayout = ImageLayout.Stretch;
            buttonSaveFile_NJA.Enabled = false;
            buttonSaveFile_NJA.Location = new Point(163, 3);
            buttonSaveFile_NJA.Name = "buttonSaveFile_NJA";
            buttonSaveFile_NJA.Size = new Size(60, 60);
            buttonSaveFile_NJA.TabIndex = 2;
            toolTip_NJA.SetToolTip(buttonSaveFile_NJA, "Сохранить результат");
            buttonSaveFile_NJA.Click += buttonSaveFile_NJA_Click;
            // 
            // buttonHelp_NJA
            // 
            buttonHelp_NJA.BackgroundImage = Properties.Resources.help;
            buttonHelp_NJA.BackgroundImageLayout = ImageLayout.Stretch;
            buttonHelp_NJA.Location = new Point(902, 3);
            buttonHelp_NJA.Name = "buttonHelp_NJA";
            buttonHelp_NJA.Size = new Size(60, 60);
            buttonHelp_NJA.TabIndex = 3;
            toolTip_NJA.SetToolTip(buttonHelp_NJA, "О программе");
            buttonHelp_NJA.Click += buttonHelp_NJA_Click;
            // 
            // labelTask_NJA
            // 
            labelTask_NJA.Dock = DockStyle.Fill;
            labelTask_NJA.Location = new Point(3, 23);
            labelTask_NJA.Name = "labelTask_NJA";
            labelTask_NJA.Size = new Size(979, 64);
            labelTask_NJA.TabIndex = 0;
            labelTask_NJA.Text = "Дан файл InPutFileTask7V19.csv. Загрузить через openFileDialog. Во 2-й строке заменить числа, кратные 2, на 2. Вывести результат.";
            // 
            // textBoxPath_NJA
            // 
            textBoxPath_NJA.Dock = DockStyle.Top;
            textBoxPath_NJA.Location = new Point(3, 23);
            textBoxPath_NJA.Name = "textBoxPath_NJA";
            textBoxPath_NJA.Size = new Size(480, 27);
            textBoxPath_NJA.TabIndex = 1;
            // 
            // dataGridViewIn_NJA
            // 
            dataGridViewIn_NJA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewIn_NJA.ColumnHeadersHeight = 29;
            dataGridViewIn_NJA.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridViewIn_NJA.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewIn_NJA.Dock = DockStyle.Fill;
            dataGridViewIn_NJA.Location = new Point(3, 50);
            dataGridViewIn_NJA.Name = "dataGridViewIn_NJA";
            dataGridViewIn_NJA.ReadOnly = true;
            dataGridViewIn_NJA.RowHeadersVisible = false;
            dataGridViewIn_NJA.RowHeadersWidth = 51;
            dataGridViewIn_NJA.Size = new Size(480, 304);
            dataGridViewIn_NJA.TabIndex = 0;
            // 
            // dataGridViewOut_NJA
            // 
            dataGridViewOut_NJA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewOut_NJA.ColumnHeadersHeight = 29;
            dataGridViewOut_NJA.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewOut_NJA.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewOut_NJA.Dock = DockStyle.Fill;
            dataGridViewOut_NJA.Location = new Point(3, 23);
            dataGridViewOut_NJA.Name = "dataGridViewOut_NJA";
            dataGridViewOut_NJA.ReadOnly = true;
            dataGridViewOut_NJA.RowHeadersVisible = false;
            dataGridViewOut_NJA.RowHeadersWidth = 51;
            dataGridViewOut_NJA.Size = new Size(481, 331);
            dataGridViewOut_NJA.TabIndex = 0;
            // 
            // groupBox1_NJA
            // 
            groupBox1_NJA.Controls.Add(panelButtons_NJA);
            groupBox1_NJA.Dock = DockStyle.Top;
            groupBox1_NJA.Location = new Point(0, 0);
            groupBox1_NJA.Name = "groupBox1_NJA";
            groupBox1_NJA.Size = new Size(985, 95);
            groupBox1_NJA.TabIndex = 2;
            groupBox1_NJA.TabStop = false;
            // 
            // panelButtons_NJA
            // 
            panelButtons_NJA.ColumnCount = 5;
            panelButtons_NJA.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            panelButtons_NJA.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            panelButtons_NJA.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            panelButtons_NJA.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            panelButtons_NJA.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            panelButtons_NJA.Controls.Add(buttonOpenFile_NJA, 0, 0);
            panelButtons_NJA.Controls.Add(buttonDone_NJA, 1, 0);
            panelButtons_NJA.Controls.Add(buttonSaveFile_NJA, 2, 0);
            panelButtons_NJA.Controls.Add(buttonHelp_NJA, 4, 0);
            panelButtons_NJA.Dock = DockStyle.Fill;
            panelButtons_NJA.Location = new Point(3, 23);
            panelButtons_NJA.Name = "panelButtons_NJA";
            panelButtons_NJA.RowCount = 1;
            panelButtons_NJA.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            panelButtons_NJA.Size = new Size(979, 69);
            panelButtons_NJA.TabIndex = 0;
            // 
            // groupBox2_NJA
            // 
            groupBox2_NJA.Controls.Add(labelTask_NJA);
            groupBox2_NJA.Dock = DockStyle.Top;
            groupBox2_NJA.Location = new Point(0, 95);
            groupBox2_NJA.Name = "groupBox2_NJA";
            groupBox2_NJA.Size = new Size(985, 90);
            groupBox2_NJA.TabIndex = 1;
            groupBox2_NJA.TabStop = false;
            groupBox2_NJA.Text = "Условие";
            // 
            // groupBoxIn_NJA
            // 
            groupBoxIn_NJA.Controls.Add(dataGridViewIn_NJA);
            groupBoxIn_NJA.Controls.Add(textBoxPath_NJA);
            groupBoxIn_NJA.Dock = DockStyle.Fill;
            groupBoxIn_NJA.Location = new Point(3, 3);
            groupBoxIn_NJA.Name = "groupBoxIn_NJA";
            groupBoxIn_NJA.Size = new Size(486, 357);
            groupBoxIn_NJA.TabIndex = 0;
            groupBoxIn_NJA.TabStop = false;
            groupBoxIn_NJA.Text = "Ввод";
            // 
            // groupBoxOut_NJA
            // 
            groupBoxOut_NJA.Controls.Add(dataGridViewOut_NJA);
            groupBoxOut_NJA.Dock = DockStyle.Fill;
            groupBoxOut_NJA.Location = new Point(495, 3);
            groupBoxOut_NJA.Name = "groupBoxOut_NJA";
            groupBoxOut_NJA.Size = new Size(487, 357);
            groupBoxOut_NJA.TabIndex = 1;
            groupBoxOut_NJA.TabStop = false;
            groupBoxOut_NJA.Text = "Вывод";
            // 
            // tableLayoutPanel_NJA
            // 
            tableLayoutPanel_NJA.ColumnCount = 2;
            tableLayoutPanel_NJA.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel_NJA.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel_NJA.Controls.Add(groupBoxIn_NJA, 0, 0);
            tableLayoutPanel_NJA.Controls.Add(groupBoxOut_NJA, 1, 0);
            tableLayoutPanel_NJA.Dock = DockStyle.Fill;
            tableLayoutPanel_NJA.Location = new Point(0, 185);
            tableLayoutPanel_NJA.Name = "tableLayoutPanel_NJA";
            tableLayoutPanel_NJA.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel_NJA.Size = new Size(985, 363);
            tableLayoutPanel_NJA.TabIndex = 0;
            // 
            // FormMain
            // 
            ClientSize = new Size(985, 548);
            Controls.Add(tableLayoutPanel_NJA);
            Controls.Add(groupBox2_NJA);
            Controls.Add(groupBox1_NJA);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 7 | Вариант 19 | Насадюк Ю.А.";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_NJA).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_NJA).EndInit();
            groupBox1_NJA.ResumeLayout(false);
            panelButtons_NJA.ResumeLayout(false);
            groupBox2_NJA.ResumeLayout(false);
            groupBoxIn_NJA.ResumeLayout(false);
            groupBoxIn_NJA.PerformLayout();
            groupBoxOut_NJA.ResumeLayout(false);
            tableLayoutPanel_NJA.ResumeLayout(false);
            ResumeLayout(false);
        }

        private ToolTip toolTip_NJA;
        private OpenFileDialog openFileDialogTask_NJA;
        private SaveFileDialog saveFileDialogTask_NJA;

        private Button buttonOpenFile_NJA;
        private Button buttonDone_NJA;
        private Button buttonSaveFile_NJA;
        private Button buttonHelp_NJA;

        private Label labelTask_NJA;
        private TextBox textBoxPath_NJA;
        private DataGridView dataGridViewIn_NJA;
        private DataGridView dataGridViewOut_NJA;

        private GroupBox groupBox1_NJA;
        private GroupBox groupBox2_NJA;
        private GroupBox groupBoxIn_NJA;
        private GroupBox groupBoxOut_NJA;

        private TableLayoutPanel panelButtons_NJA;
        private TableLayoutPanel tableLayoutPanel_NJA;
    }
}