namespace Tyuiu.NasadukJA.Sprint6.Task5.V29;

partial class FormMain
{
    private System.ComponentModel.IContainer components = null;

    private System.Windows.Forms.Label labelCond_NJA;
    private System.Windows.Forms.Button buttonDo_NJA;
    private System.Windows.Forms.Button buttonOpenFile_NJA;
    private System.Windows.Forms.Button buttonHelp_NJA;
    private System.Windows.Forms.DataGridView dataGridViewResult_NJA;
    private System.Windows.Forms.DataVisualization.Charting.Chart chartValues_NJA;

    protected override void Dispose(bool disposing)
    {
        if (disposing && components != null)
            components.Dispose();
        base.Dispose(disposing);
    }


    private void InitializeComponent()
    {
        System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
        System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
        labelCond_NJA = new Label();
        buttonDo_NJA = new Button();
        buttonOpenFile_NJA = new Button();
        buttonHelp_NJA = new Button();
        dataGridViewResult_NJA = new DataGridView();
        chartValues_NJA = new System.Windows.Forms.DataVisualization.Charting.Chart();
        ((System.ComponentModel.ISupportInitialize)dataGridViewResult_NJA).BeginInit();
        ((System.ComponentModel.ISupportInitialize)chartValues_NJA).BeginInit();
        SuspendLayout();
        // 
        // labelCond_NJA
        // 
        labelCond_NJA.AutoSize = true;
        labelCond_NJA.Font = new Font("Microsoft Sans Serif", 10F);
        labelCond_NJA.Location = new Point(12, 9);
        labelCond_NJA.Name = "labelCond_NJA";
        labelCond_NJA.Size = new Size(628, 40);
        labelCond_NJA.TabIndex = 0;
        labelCond_NJA.Text = "Прочитать данные из файла InPutFileTask5V29.txt. Вывести в dataGridView.\r\nВывести все числа больше или равные 10 и построить диаграмму.";
        // 
        // buttonDo_NJA
        // 
        buttonDo_NJA.BackColor = Color.LimeGreen;
        buttonDo_NJA.Location = new Point(610, 398);
        buttonDo_NJA.Name = "buttonDo_NJA";
        buttonDo_NJA.Size = new Size(120, 40);
        buttonDo_NJA.TabIndex = 3;
        buttonDo_NJA.Text = "Выполнить";
        buttonDo_NJA.UseVisualStyleBackColor = false;
        buttonDo_NJA.Click += buttonDo_NJA_Click;
        // 
        // buttonOpenFile_NJA
        // 
        buttonOpenFile_NJA.BackColor = Color.DeepSkyBlue;
        buttonOpenFile_NJA.Location = new Point(471, 398);
        buttonOpenFile_NJA.Name = "buttonOpenFile_NJA";
        buttonOpenFile_NJA.Size = new Size(120, 40);
        buttonOpenFile_NJA.TabIndex = 4;
        buttonOpenFile_NJA.Text = "Открыть файл";
        buttonOpenFile_NJA.UseVisualStyleBackColor = false;
        buttonOpenFile_NJA.Click += buttonOpenFile_NJA_Click;
        // 
        // buttonHelp_NJA
        // 
        buttonHelp_NJA.BackColor = Color.RoyalBlue;
        buttonHelp_NJA.Location = new Point(230, 398);
        buttonHelp_NJA.Name = "buttonHelp_NJA";
        buttonHelp_NJA.Size = new Size(120, 40);
        buttonHelp_NJA.TabIndex = 5;
        buttonHelp_NJA.Text = "Справка";
        buttonHelp_NJA.UseVisualStyleBackColor = false;
        buttonHelp_NJA.Click += buttonHelp_NJA_Click;
        // 
        // dataGridViewResult_NJA
        // 
        dataGridViewResult_NJA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewResult_NJA.Location = new Point(15, 70);
        dataGridViewResult_NJA.Name = "dataGridViewResult_NJA";
        dataGridViewResult_NJA.RowHeadersWidth = 51;
        dataGridViewResult_NJA.Size = new Size(200, 300);
        dataGridViewResult_NJA.TabIndex = 1;
        // 
        // chartValues_NJA
        // 
        chartArea1.AxisX.Title = "№";
        chartArea1.AxisY.Title = "Значение";
        chartArea1.Name = "ChartArea1";
        chartValues_NJA.ChartAreas.Add(chartArea1);
        chartValues_NJA.Location = new Point(230, 70);
        chartValues_NJA.Name = "chartValues_NJA";
        series1.ChartArea = "ChartArea1";
        series1.Color = Color.Green;
        series1.Name = "Series1";
        chartValues_NJA.Series.Add(series1);
        chartValues_NJA.Size = new Size(500, 300);
        chartValues_NJA.TabIndex = 2;
        // 
        // FormMain
        // 
        ClientSize = new Size(760, 450);
        Controls.Add(labelCond_NJA);
        Controls.Add(dataGridViewResult_NJA);
        Controls.Add(chartValues_NJA);
        Controls.Add(buttonDo_NJA);
        Controls.Add(buttonOpenFile_NJA);
        Controls.Add(buttonHelp_NJA);
        Name = "FormMain";
        Text = "Спринт 6 | Task 5 | Вариант 29 | Насадюк Ю.А.";
        ((System.ComponentModel.ISupportInitialize)dataGridViewResult_NJA).EndInit();
        ((System.ComponentModel.ISupportInitialize)chartValues_NJA).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }
}
