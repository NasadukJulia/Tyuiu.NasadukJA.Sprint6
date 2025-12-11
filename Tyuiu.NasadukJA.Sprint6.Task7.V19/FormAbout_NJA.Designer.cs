namespace Tyuiu.NasadukJA.Sprint6.Task7.V19
{
    partial class FormAbout_NJA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout_NJA));
            pictureBoxPhoto_NJA = new PictureBox();
            labelInfo_NJA = new Label();
            buttonOK_NJA = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPhoto_NJA).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxPhoto_NJA
            // 
            pictureBoxPhoto_NJA.Image = Properties.Resources.Снимок_экрана_2025_12_11_164149;
            pictureBoxPhoto_NJA.Location = new Point(20, 20);
            pictureBoxPhoto_NJA.Name = "pictureBoxPhoto_NJA";
            pictureBoxPhoto_NJA.Size = new Size(214, 268);
            pictureBoxPhoto_NJA.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPhoto_NJA.TabIndex = 2;
            pictureBoxPhoto_NJA.TabStop = false;
            // 
            // labelInfo_NJA
            // 
            labelInfo_NJA.Location = new Point(249, 20);
            labelInfo_NJA.Name = "labelInfo_NJA";
            labelInfo_NJA.Size = new Size(300, 235);
            labelInfo_NJA.TabIndex = 1;
            labelInfo_NJA.Text = resources.GetString("labelInfo_NJA.Text");
            labelInfo_NJA.Click += labelInfo_NJA_Click;
            // 
            // buttonOK_NJA
            // 
            buttonOK_NJA.Location = new Point(449, 258);
            buttonOK_NJA.Name = "buttonOK_NJA";
            buttonOK_NJA.Size = new Size(100, 30);
            buttonOK_NJA.TabIndex = 0;
            buttonOK_NJA.Text = "OK";
            buttonOK_NJA.Click += buttonOK_NJA_Click;
            // 
            // FormAbout_NJA
            // 
            ClientSize = new Size(561, 300);
            Controls.Add(buttonOK_NJA);
            Controls.Add(labelInfo_NJA);
            Controls.Add(pictureBoxPhoto_NJA);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FormAbout_NJA";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxPhoto_NJA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPhoto_NJA;
        private System.Windows.Forms.Label labelInfo_NJA;
        private System.Windows.Forms.Button buttonOK_NJA;
    }
}