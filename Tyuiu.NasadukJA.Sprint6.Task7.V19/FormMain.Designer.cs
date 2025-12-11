namespace Tyuiu.NasadukJA.Sprint6.Task7.V19;

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

    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
        buttonOpenFile_NJA = new Button();
        buttonDone_NJA = new Button();
        buttonSaveFile_NJA = new Button();
        buttonHelp_NJA = new Button();
        textBoxPath_NJA = new TextBox();
        labelTask_NJA = new Label();
        labelIn_NJA = new Label();
        labelOut_NJA = new Label();
        dataGridViewIn_NJA = new DataGridView();
        dataGridViewOut_NJA = new DataGridView();
        toolTip_NJA = new ToolTip(components);
        openFileDialogTask_NJA = new OpenFileDialog();
        saveFileDialogTask_NJA = new SaveFileDialog();
        groupBox1_NJA = new GroupBox();
        groupBox2_NJA = new GroupBox();
        ((System.ComponentModel.ISupportInitialize)dataGridViewIn_NJA).BeginInit();
        ((System.ComponentModel.ISupportInitialize)dataGridViewOut_NJA).BeginInit();
        groupBox1_NJA.SuspendLayout();
        groupBox2_NJA.SuspendLayout();
        SuspendLayout();
        // 
        // buttonOpenFile_NJA
        // 
        buttonOpenFile_NJA.BackgroundImage = Properties.Resources.folder;
        buttonOpenFile_NJA.BackgroundImageLayout = ImageLayout.Stretch;
        buttonOpenFile_NJA.Location = new Point(13, 22);
        buttonOpenFile_NJA.Name = "buttonOpenFile_NJA";
        buttonOpenFile_NJA.Size = new Size(60, 61);
        buttonOpenFile_NJA.TabIndex = 0;
        toolTip_NJA.SetToolTip(buttonOpenFile_NJA, "Открыть CSV файл");
        buttonOpenFile_NJA.Click += buttonOpenFile_NJA_Click;
        // 
        // buttonDone_NJA
        // 
        buttonDone_NJA.BackgroundImage = Properties.Resources.run;
        buttonDone_NJA.BackgroundImageLayout = ImageLayout.Stretch;
        buttonDone_NJA.Enabled = false;
        buttonDone_NJA.Location = new Point(90, 22);
        buttonDone_NJA.Name = "buttonDone_NJA";
        buttonDone_NJA.Size = new Size(59, 61);
        buttonDone_NJA.TabIndex = 1;
        toolTip_NJA.SetToolTip(buttonDone_NJA, "Выполнить обработку");
        buttonDone_NJA.Click += buttonDone_NJA_Click;
        // 
        // buttonSaveFile_NJA
        // 
        buttonSaveFile_NJA.BackgroundImage = Properties.Resources.save;
        buttonSaveFile_NJA.BackgroundImageLayout = ImageLayout.Stretch;
        buttonSaveFile_NJA.Enabled = false;
        buttonSaveFile_NJA.Location = new Point(170, 22);
        buttonSaveFile_NJA.Name = "buttonSaveFile_NJA";
        buttonSaveFile_NJA.Size = new Size(59, 61);
        buttonSaveFile_NJA.TabIndex = 2;
        toolTip_NJA.SetToolTip(buttonSaveFile_NJA, "Сохранить результат");
        buttonSaveFile_NJA.Click += buttonSaveFile_NJA_Click;
        // 
        // buttonHelp_NJA
        // 
        buttonHelp_NJA.BackgroundImage = Properties.Resources.help;
        buttonHelp_NJA.BackgroundImageLayout = ImageLayout.Stretch;
        buttonHelp_NJA.Location = new Point(905, 22);
        buttonHelp_NJA.Name = "buttonHelp_NJA";
        buttonHelp_NJA.Size = new Size(70, 61);
        buttonHelp_NJA.TabIndex = 3;
        toolTip_NJA.SetToolTip(buttonHelp_NJA, "О программе");
        buttonHelp_NJA.Click += buttonHelp_NJA_Click;
        // 
        // textBoxPath_NJA
        // 
        textBoxPath_NJA.Font = new Font("Segoe UI", 9F);
        textBoxPath_NJA.Location = new Point(57, 216);
        textBoxPath_NJA.Name = "textBoxPath_NJA";
        textBoxPath_NJA.Size = new Size(454, 27);
        textBoxPath_NJA.TabIndex = 4;
        // 
        // labelTask_NJA
        // 
        labelTask_NJA.Font = new Font("Segoe UI", 9F);
        labelTask_NJA.Location = new Point(13, 37);
        labelTask_NJA.Name = "labelTask_NJA";
        labelTask_NJA.Size = new Size(962, 39);
        labelTask_NJA.TabIndex = 5;
        labelTask_NJA.Text = "Дан файл InPutFileTask7V19.csv. Загрузить через openFileDialog. Во 2-й строке заменить числа кратные 2 на 2. Вывести результат.";
        labelTask_NJA.Click += labelTask_NJA_Click;
        // 
        // labelIn_NJA
        // 
        labelIn_NJA.Font = new Font("Segoe UI", 9F);
        labelIn_NJA.Location = new Point(12, 216);
        labelIn_NJA.Name = "labelIn_NJA";
        labelIn_NJA.Size = new Size(48, 26);
        labelIn_NJA.TabIndex = 6;
        labelIn_NJA.Text = "Ввод:";
        // 
        // labelOut_NJA
        // 
        labelOut_NJA.Font = new Font("Segoe UI", 9F);
        labelOut_NJA.Location = new Point(517, 220);
        labelOut_NJA.Name = "labelOut_NJA";
        labelOut_NJA.Size = new Size(104, 23);
        labelOut_NJA.TabIndex = 7;
        labelOut_NJA.Text = "Вывод:";
        // 
        // dataGridViewIn_NJA
        // 
        dataGridViewIn_NJA.AllowUserToAddRows = false;
        dataGridViewIn_NJA.AllowUserToResizeColumns = false;
        dataGridViewIn_NJA.AllowUserToResizeRows = false;
        dataGridViewIn_NJA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
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
        dataGridViewIn_NJA.Location = new Point(12, 249);
        dataGridViewIn_NJA.Name = "dataGridViewIn_NJA";
        dataGridViewIn_NJA.ReadOnly = true;
        dataGridViewIn_NJA.RowHeadersVisible = false;
        dataGridViewIn_NJA.RowHeadersWidth = 51;
        dataGridViewIn_NJA.Size = new Size(499, 357);
        dataGridViewIn_NJA.TabIndex = 8;
        // 
        // dataGridViewOut_NJA
        // 
        dataGridViewOut_NJA.AllowUserToAddRows = false;
        dataGridViewOut_NJA.AllowUserToResizeColumns = false;
        dataGridViewOut_NJA.AllowUserToResizeRows = false;
        dataGridViewOut_NJA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
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
        dataGridViewOut_NJA.Location = new Point(517, 246);
        dataGridViewOut_NJA.Name = "dataGridViewOut_NJA";
        dataGridViewOut_NJA.ReadOnly = true;
        dataGridViewOut_NJA.RowHeadersVisible = false;
        dataGridViewOut_NJA.RowHeadersWidth = 51;
        dataGridViewOut_NJA.Size = new Size(470, 357);
        dataGridViewOut_NJA.TabIndex = 9;
        // 
        // groupBox1_NJA
        // 
        groupBox1_NJA.Controls.Add(buttonOpenFile_NJA);
        groupBox1_NJA.Controls.Add(buttonHelp_NJA);
        groupBox1_NJA.Controls.Add(buttonSaveFile_NJA);
        groupBox1_NJA.Controls.Add(buttonDone_NJA);
        groupBox1_NJA.Location = new Point(12, 12);
        groupBox1_NJA.Name = "groupBox1_NJA";
        groupBox1_NJA.Size = new Size(987, 95);
        groupBox1_NJA.TabIndex = 10;
        groupBox1_NJA.TabStop = false;
        // 
        // groupBox2_NJA
        // 
        groupBox2_NJA.Controls.Add(labelTask_NJA);
        groupBox2_NJA.Font = new Font("Segoe UI", 9F);
        groupBox2_NJA.Location = new Point(12, 113);
        groupBox2_NJA.Name = "groupBox2_NJA";
        groupBox2_NJA.Size = new Size(987, 93);
        groupBox2_NJA.TabIndex = 11;
        groupBox2_NJA.TabStop = false;
        groupBox2_NJA.Text = "Условие";
        groupBox2_NJA.Enter += groupBox1_Enter;
        // 
        // FormMain
        // 
        ClientSize = new Size(1010, 630);
        Controls.Add(groupBox2_NJA);
        Controls.Add(dataGridViewIn_NJA);
        Controls.Add(groupBox1_NJA);
        Controls.Add(textBoxPath_NJA);
        Controls.Add(labelIn_NJA);
        Controls.Add(labelOut_NJA);
        Controls.Add(dataGridViewOut_NJA);
        Name = "FormMain";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Спринт 6 | Таск 7 | Вариант 19 | Насадюк Ю.А.";
        ((System.ComponentModel.ISupportInitialize)dataGridViewIn_NJA).EndInit();
        ((System.ComponentModel.ISupportInitialize)dataGridViewOut_NJA).EndInit();
        groupBox1_NJA.ResumeLayout(false);
        groupBox2_NJA.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    private Button buttonOpenFile_NJA;
    private Button buttonDone_NJA;
    private Button buttonSaveFile_NJA;
    private Button buttonHelp_NJA;
    private TextBox textBoxPath_NJA;
    private Label labelTask_NJA;
    private Label labelIn_NJA;
    private Label labelOut_NJA;
    private DataGridView dataGridViewIn_NJA;
    private DataGridView dataGridViewOut_NJA;
    private ToolTip toolTip_NJA;
    private OpenFileDialog openFileDialogTask_NJA;
    private SaveFileDialog saveFileDialogTask_NJA;
    private GroupBox groupBox1_NJA;
    private GroupBox groupBox2_NJA;
}
