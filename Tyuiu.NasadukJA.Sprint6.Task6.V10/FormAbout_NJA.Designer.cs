namespace Tyuiu.NasadukJA.Sprint6.Task6.V10
{
    partial class FormAbout_NJA
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout_NJA));
            pictureBox1_NJA = new PictureBox();
            label1_NJA = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1_NJA).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1_NJA
            // 
            pictureBox1_NJA.Image = (Image)resources.GetObject("pictureBox1_NJA.Image");
            pictureBox1_NJA.Location = new Point(12, 9);
            pictureBox1_NJA.Name = "pictureBox1_NJA";
            pictureBox1_NJA.Size = new Size(219, 223);
            pictureBox1_NJA.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1_NJA.TabIndex = 0;
            pictureBox1_NJA.TabStop = false;
            pictureBox1_NJA.Click += pictureBox1_Click;
            // 
            // label1_NJA
            // 
            label1_NJA.AutoSize = true;
            label1_NJA.Location = new Point(237, 21);
            label1_NJA.Name = "label1_NJA";
            label1_NJA.Size = new Size(304, 200);
            label1_NJA.TabIndex = 1;
            label1_NJA.Text = "Разработчик: Насадюк Ю. А.\r\n\r\nГруппа: СМАРТб-25-15\r\n\r\nПрограмма разработана в \r\nрамках изучения языка C#\r\n\r\nТюменский индустриальный университет \r\n\r\nВнутреннее имя: Tyuiu.NasadukJA.Sprint";
            label1_NJA.Click += label1_Click;
            // 
            // FormAbout_NJA
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(540, 242);
            Controls.Add(label1_NJA);
            Controls.Add(pictureBox1_NJA);
            Name = "FormAbout_NJA";
            Text = "FormAbout_NJA";
            ((System.ComponentModel.ISupportInitialize)pictureBox1_NJA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1_NJA;
        private Label label1_NJA;
    }
}