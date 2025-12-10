namespace Tyuiu.NasadukJA.Sprint6.Task4.V21;

partial class FormMain
{
    private System.ComponentModel.IContainer components = null;

    private System.Windows.Forms.Label labelCond_NJA;
    private System.Windows.Forms.TextBox textBoxResult_NJA;
    private System.Windows.Forms.Button buttonDone_NJA;
    private System.Windows.Forms.Button buttonSave_NJA;
    private System.Windows.Forms.Button buttonHelp_NJA;
    private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_NJA;

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
        System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
        System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
        System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
        labelCond_NJA = new Label();
        textBoxResult_NJA = new TextBox();
        buttonDone_NJA = new Button();
        buttonSave_NJA = new Button();
        buttonHelp_NJA = new Button();
        chartFunction_NJA = new System.Windows.Forms.DataVisualization.Charting.Chart();
        ((System.ComponentModel.ISupportInitialize)chartFunction_NJA).BeginInit();
        SuspendLayout();
        // 
        // labelCond_NJA
        // 
        labelCond_NJA.AutoSize = true;
        labelCond_NJA.Location = new Point(12, 9);
        labelCond_NJA.Name = "labelCond_NJA";
        labelCond_NJA.Size = new Size(353, 60);
        labelCond_NJA.TabIndex = 5;
        labelCond_NJA.Text = "Табулирование функции F(x) на диапазоне [-5; 5]\r\nF(x) = (2cos(x)+2)/(2x–1) + cos(x) – 5x + 3\r\nРезультат вывести в TextBox и построить график.";
        // 
        // textBoxResult_NJA
        // 
        textBoxResult_NJA.Location = new Point(15, 80);
        textBoxResult_NJA.Multiline = true;
        textBoxResult_NJA.Name = "textBoxResult_NJA";
        textBoxResult_NJA.ScrollBars = ScrollBars.Vertical;
        textBoxResult_NJA.Size = new Size(170, 350);
        textBoxResult_NJA.TabIndex = 4;
        // 
        // buttonDone_NJA
        // 
        buttonDone_NJA.Location = new Point(870, 12);
        buttonDone_NJA.Name = "buttonDone_NJA";
        buttonDone_NJA.Size = new Size(110, 40);
        buttonDone_NJA.TabIndex = 3;
        buttonDone_NJA.Text = "Выполнить";
        buttonDone_NJA.Click += buttonDone_NJA_Click;
        // 
        // buttonSave_NJA
        // 
        buttonSave_NJA.Location = new Point(754, 12);
        buttonSave_NJA.Name = "buttonSave_NJA";
        buttonSave_NJA.Size = new Size(110, 40);
        buttonSave_NJA.TabIndex = 2;
        buttonSave_NJA.Text = "Сохранить";
        buttonSave_NJA.Click += buttonSave_NJA_Click;
        // 
        // buttonHelp_NJA
        // 
        buttonHelp_NJA.Location = new Point(403, 12);
        buttonHelp_NJA.Name = "buttonHelp_NJA";
        buttonHelp_NJA.Size = new Size(110, 40);
        buttonHelp_NJA.TabIndex = 1;
        buttonHelp_NJA.Text = "Справка";
        buttonHelp_NJA.Click += buttonHelp_NJA_Click;
        // 
        // chartFunction_NJA
        // 
        chartArea1.Name = "ChartArea1";
        chartFunction_NJA.ChartAreas.Add(chartArea1);
        chartFunction_NJA.Location = new Point(330, 80);
        chartFunction_NJA.Name = "chartFunction_NJA";
        series1.ChartArea = "ChartArea1";
        series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
        series1.Name = "Series1";
        chartFunction_NJA.Series.Add(series1);
        chartFunction_NJA.Size = new Size(650, 350);
        chartFunction_NJA.TabIndex = 0;
        title1.Name = "Title1";
        title1.Text = "График функции F(x)";
        chartFunction_NJA.Titles.Add(title1);
        // 
        // FormMain
        // 
        ClientSize = new Size(1000, 460);
        Controls.Add(chartFunction_NJA);
        Controls.Add(buttonHelp_NJA);
        Controls.Add(buttonSave_NJA);
        Controls.Add(buttonDone_NJA);
        Controls.Add(textBoxResult_NJA);
        Controls.Add(labelCond_NJA);
        Name = "FormMain";
        Text = "Спринт 6 | Таск 4 | Вариант 21 | Насадюк Ю.А.";
        ((System.ComponentModel.ISupportInitialize)chartFunction_NJA).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }
}
