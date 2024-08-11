namespace SGPG
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            sideBarPanel = new Panel();
            companyLogoPanel = new Panel();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            sideBarPanel.SuspendLayout();
            companyLogoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // sideBarPanel
            // 
            sideBarPanel.BackColor = Color.FromArgb(246, 246, 246);
            sideBarPanel.Controls.Add(companyLogoPanel);
            sideBarPanel.Dock = DockStyle.Left;
            sideBarPanel.Location = new Point(0, 0);
            sideBarPanel.Name = "sideBarPanel";
            sideBarPanel.Size = new Size(208, 1032);
            sideBarPanel.TabIndex = 0;
            // 
            // companyLogoPanel
            // 
            companyLogoPanel.BackColor = Color.White;
            companyLogoPanel.Controls.Add(pictureBox1);
            companyLogoPanel.ImeMode = ImeMode.NoControl;
            companyLogoPanel.Location = new Point(0, 0);
            companyLogoPanel.Name = "companyLogoPanel";
            companyLogoPanel.Size = new Size(208, 150);
            companyLogoPanel.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(199, 135);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(52, 63, 72);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(208, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1712, 150);
            panel1.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift Light", 48F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(230, 230, 230);
            label3.Location = new Point(385, 29);
            label3.Name = "label3";
            label3.Size = new Size(948, 77);
            label3.TabIndex = 1;
            label3.Text = "Sistema de Gestão de Pesagem ";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 31F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(230, 230, 230);
            label2.Location = new Point(1612, 0);
            label2.Name = "label2";
            label2.Size = new Size(44, 52);
            label2.TabIndex = 2;
            label2.Text = "_";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(230, 230, 230);
            label1.Location = new Point(1653, 9);
            label1.Name = "label1";
            label1.Size = new Size(47, 51);
            label1.TabIndex = 1;
            label1.Text = "X";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1920, 1032);
            Controls.Add(panel1);
            Controls.Add(sideBarPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SGPG-MainForm";
            sideBarPanel.ResumeLayout(false);
            companyLogoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel sideBarPanel;
        private Panel companyLogoPanel;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
    }
}
