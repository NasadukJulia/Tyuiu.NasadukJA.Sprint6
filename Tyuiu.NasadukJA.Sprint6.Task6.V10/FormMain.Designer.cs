namespace Tyuiu.NasadukJA.Sprint6.Task6.V10;

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

    /// <summary>
    /// Required method for Designer support.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        labelCondition_NJA = new Label();
        textBoxIn_NJA = new TextBox();
        textBoxOut_NJA = new TextBox();
        buttonOpenFile_NJA = new Button();
        buttonDone_NJA = new Button();
        buttonHelp_NJA = new Button();
        openFileDialogTask_NJA = new OpenFileDialog();
        labelIn_NJA = new Label();
        labelOut_NJA = new Label();
        toolTip1_NJA = new ToolTip(components);
        SuspendLayout();
        // 
        // labelCondition_NJA
        // 
        labelCondition_NJA.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        labelCondition_NJA.Font = new Font("Segoe UI", 10F);
        labelCondition_NJA.Location = new Point(12, 60);
        labelCondition_NJA.Name = "labelCondition_NJA";
        labelCondition_NJA.Size = new Size(939, 40);
        labelCondition_NJA.TabIndex = 0;
        labelCondition_NJA.Text = "Дан файл InPutFileTask6V10.txt. Загрузить файл и вывести слова, содержащие букву 'w', в textBoxOut.";
        // 
        // textBoxIn_NJA
        // 
        textBoxIn_NJA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        textBoxIn_NJA.Location = new Point(12, 140);
        textBoxIn_NJA.Multiline = true;
        textBoxIn_NJA.Name = "textBoxIn_NJA";
        textBoxIn_NJA.ScrollBars = ScrollBars.Both;
        textBoxIn_NJA.Size = new Size(450, 392);
        textBoxIn_NJA.TabIndex = 1;
        // 
        // textBoxOut_NJA
        // 
        textBoxOut_NJA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
        textBoxOut_NJA.Location = new Point(489, 140);
        textBoxOut_NJA.Multiline = true;
        textBoxOut_NJA.Name = "textBoxOut_NJA";
        textBoxOut_NJA.ScrollBars = ScrollBars.Both;
        textBoxOut_NJA.Size = new Size(462, 392);
        textBoxOut_NJA.TabIndex = 2;
        // 
        // buttonOpenFile_NJA
        // 
        buttonOpenFile_NJA.Location = new Point(12, 10);
        buttonOpenFile_NJA.Name = "buttonOpenFile_NJA";
        buttonOpenFile_NJA.Size = new Size(50, 45);
        buttonOpenFile_NJA.TabIndex = 3;
        buttonOpenFile_NJA.Text = "📂";
        toolTip1_NJA.SetToolTip(buttonOpenFile_NJA, "Открыть файл  \r\nВыберите нужный файл для обработки");
        buttonOpenFile_NJA.UseVisualStyleBackColor = true;
        buttonOpenFile_NJA.Click += buttonOpenFile_NJA_Click;
        // 
        // buttonDone_NJA
        // 
        buttonDone_NJA.Enabled = false;
        buttonDone_NJA.Location = new Point(70, 10);
        buttonDone_NJA.Name = "buttonDone_NJA";
        buttonDone_NJA.Size = new Size(50, 45);
        buttonDone_NJA.TabIndex = 4;
        buttonDone_NJA.Text = "✔";
        toolTip1_NJA.SetToolTip(buttonDone_NJA, "Выполнить задание");
        buttonDone_NJA.UseVisualStyleBackColor = true;
        buttonDone_NJA.Click += buttonDone_NJA_Click;
        // 
        // buttonHelp_NJA
        // 
        buttonHelp_NJA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        buttonHelp_NJA.Location = new Point(901, 10);
        buttonHelp_NJA.Name = "buttonHelp_NJA";
        buttonHelp_NJA.Size = new Size(50, 45);
        buttonHelp_NJA.TabIndex = 5;
        buttonHelp_NJA.Text = "?";
        toolTip1_NJA.SetToolTip(buttonHelp_NJA, "О программе");
        buttonHelp_NJA.UseVisualStyleBackColor = true;
        buttonHelp_NJA.Click += buttonHelp_NJA_Click;
        // 
        // labelIn_NJA
        // 
        labelIn_NJA.AutoSize = true;
        labelIn_NJA.Location = new Point(12, 120);
        labelIn_NJA.Name = "labelIn_NJA";
        labelIn_NJA.Size = new Size(46, 20);
        labelIn_NJA.TabIndex = 6;
        labelIn_NJA.Text = "Ввод:";
        // 
        // labelOut_NJA
        // 
        labelOut_NJA.AutoSize = true;
        labelOut_NJA.Location = new Point(510, 120);
        labelOut_NJA.Name = "labelOut_NJA";
        labelOut_NJA.Size = new Size(57, 20);
        labelOut_NJA.TabIndex = 7;
        labelOut_NJA.Text = "Вывод:";
        // 
        // FormMain
        // 
        ClientSize = new Size(963, 553);
        Controls.Add(labelOut_NJA);
        Controls.Add(labelIn_NJA);
        Controls.Add(buttonHelp_NJA);
        Controls.Add(buttonDone_NJA);
        Controls.Add(buttonOpenFile_NJA);
        Controls.Add(textBoxOut_NJA);
        Controls.Add(textBoxIn_NJA);
        Controls.Add(labelCondition_NJA);
        MinimumSize = new Size(850, 500);
        Name = "FormMain";
        Text = "Спринт 6 | Task 6 | Вариант 10 | Насадюк Ю.А.";
        ResumeLayout(false);
        PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label labelCondition_NJA;
    private System.Windows.Forms.TextBox textBoxIn_NJA;
    private System.Windows.Forms.TextBox textBoxOut_NJA;
    private System.Windows.Forms.Button buttonOpenFile_NJA;
    private System.Windows.Forms.Button buttonDone_NJA;
    private System.Windows.Forms.Button buttonHelp_NJA;
    private System.Windows.Forms.OpenFileDialog openFileDialogTask_NJA;
    private System.Windows.Forms.Label labelIn_NJA;
    private System.Windows.Forms.Label labelOut_NJA;
    private ToolTip toolTip1_NJA;
}
