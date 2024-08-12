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
            licencaDemoLabel = new Label();
            sobreButton = new Button();
            opcoesButton = new Button();
            buscarButton = new Button();
            pesagemButton = new Button();
            telaInicialButton = new Button();
            companyLogoPanel = new Panel();
            pictureBox1 = new PictureBox();
            topBarPanel = new Panel();
            sistemaGestPesagemLabel = new Label();
            MinimizeLabel = new Label();
            closeLabel = new Label();
            diasRestantesLabel = new Label();
            sideBarPanel.SuspendLayout();
            companyLogoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            topBarPanel.SuspendLayout();
            SuspendLayout();
            // 
            // sideBarPanel
            // 
            sideBarPanel.BackColor = Color.FromArgb(246, 246, 246);
            sideBarPanel.Controls.Add(diasRestantesLabel);
            sideBarPanel.Controls.Add(licencaDemoLabel);
            sideBarPanel.Controls.Add(sobreButton);
            sideBarPanel.Controls.Add(opcoesButton);
            sideBarPanel.Controls.Add(buscarButton);
            sideBarPanel.Controls.Add(pesagemButton);
            sideBarPanel.Controls.Add(telaInicialButton);
            sideBarPanel.Controls.Add(companyLogoPanel);
            sideBarPanel.Dock = DockStyle.Left;
            sideBarPanel.Font = new Font("Nirmala UI Semilight", 24F, FontStyle.Regular, GraphicsUnit.Point);
            sideBarPanel.Location = new Point(0, 0);
            sideBarPanel.Name = "sideBarPanel";
            sideBarPanel.Size = new Size(208, 1032);
            sideBarPanel.TabIndex = 0;
            // 
            // licencaDemoLabel
            // 
            licencaDemoLabel.AutoSize = true;
            licencaDemoLabel.FlatStyle = FlatStyle.Flat;
            licencaDemoLabel.Font = new Font("Nirmala UI Semilight", 20F, FontStyle.Regular, GraphicsUnit.Point);
            licencaDemoLabel.ForeColor = Color.Black;
            licencaDemoLabel.Location = new Point(53, 903);
            licencaDemoLabel.Name = "licencaDemoLabel";
            licencaDemoLabel.Size = new Size(103, 74);
            licencaDemoLabel.TabIndex = 3;
            licencaDemoLabel.Text = "Licença\r\nDemo";
            licencaDemoLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // sobreButton
            // 
            sobreButton.BackColor = Color.FromArgb(217, 217, 217);
            sobreButton.BackgroundImage = (Image)resources.GetObject("sobreButton.BackgroundImage");
            sobreButton.BackgroundImageLayout = ImageLayout.Zoom;
            sobreButton.Dock = DockStyle.Top;
            sobreButton.FlatAppearance.BorderSize = 0;
            sobreButton.FlatStyle = FlatStyle.Flat;
            sobreButton.Font = new Font("Nirmala UI Semilight", 24F, FontStyle.Regular, GraphicsUnit.Point);
            sobreButton.Location = new Point(0, 742);
            sobreButton.Name = "sobreButton";
            sobreButton.Size = new Size(208, 148);
            sobreButton.TabIndex = 6;
            sobreButton.Text = "Sobre";
            sobreButton.TextAlign = ContentAlignment.BottomCenter;
            sobreButton.UseVisualStyleBackColor = false;
            sobreButton.Click += SobreButton_Click;
            // 
            // opcoesButton
            // 
            opcoesButton.BackColor = Color.FromArgb(217, 217, 217);
            opcoesButton.BackgroundImage = (Image)resources.GetObject("opcoesButton.BackgroundImage");
            opcoesButton.BackgroundImageLayout = ImageLayout.Zoom;
            opcoesButton.Dock = DockStyle.Top;
            opcoesButton.FlatAppearance.BorderSize = 0;
            opcoesButton.FlatStyle = FlatStyle.Flat;
            opcoesButton.Font = new Font("Nirmala UI Semilight", 24F, FontStyle.Regular, GraphicsUnit.Point);
            opcoesButton.Location = new Point(0, 594);
            opcoesButton.Name = "opcoesButton";
            opcoesButton.Size = new Size(208, 148);
            opcoesButton.TabIndex = 5;
            opcoesButton.Text = "Opções";
            opcoesButton.TextAlign = ContentAlignment.BottomCenter;
            opcoesButton.UseVisualStyleBackColor = false;
            opcoesButton.Click += OpcoesButton_Click;
            // 
            // buscarButton
            // 
            buscarButton.BackColor = Color.FromArgb(217, 217, 217);
            buscarButton.BackgroundImage = (Image)resources.GetObject("buscarButton.BackgroundImage");
            buscarButton.BackgroundImageLayout = ImageLayout.Zoom;
            buscarButton.Dock = DockStyle.Top;
            buscarButton.FlatAppearance.BorderSize = 0;
            buscarButton.FlatStyle = FlatStyle.Flat;
            buscarButton.Font = new Font("Nirmala UI Semilight", 24F, FontStyle.Regular, GraphicsUnit.Point);
            buscarButton.Location = new Point(0, 446);
            buscarButton.Name = "buscarButton";
            buscarButton.Size = new Size(208, 148);
            buscarButton.TabIndex = 4;
            buscarButton.Text = "Buscar";
            buscarButton.TextAlign = ContentAlignment.BottomCenter;
            buscarButton.UseVisualStyleBackColor = false;
            buscarButton.Click += BuscarButton_Click;
            // 
            // pesagemButton
            // 
            pesagemButton.BackColor = Color.FromArgb(217, 217, 217);
            pesagemButton.BackgroundImage = (Image)resources.GetObject("pesagemButton.BackgroundImage");
            pesagemButton.BackgroundImageLayout = ImageLayout.Zoom;
            pesagemButton.Dock = DockStyle.Top;
            pesagemButton.FlatAppearance.BorderSize = 0;
            pesagemButton.FlatStyle = FlatStyle.Flat;
            pesagemButton.Font = new Font("Nirmala UI Semilight", 24F, FontStyle.Regular, GraphicsUnit.Point);
            pesagemButton.Location = new Point(0, 298);
            pesagemButton.Name = "pesagemButton";
            pesagemButton.Size = new Size(208, 148);
            pesagemButton.TabIndex = 3;
            pesagemButton.Text = "Pesagem";
            pesagemButton.TextAlign = ContentAlignment.BottomCenter;
            pesagemButton.UseVisualStyleBackColor = false;
            pesagemButton.Click += PesagemButton_Click;
            // 
            // telaInicialButton
            // 
            telaInicialButton.BackColor = Color.FromArgb(217, 217, 217);
            telaInicialButton.BackgroundImage = (Image)resources.GetObject("telaInicialButton.BackgroundImage");
            telaInicialButton.BackgroundImageLayout = ImageLayout.Zoom;
            telaInicialButton.Dock = DockStyle.Top;
            telaInicialButton.FlatAppearance.BorderSize = 0;
            telaInicialButton.FlatStyle = FlatStyle.Flat;
            telaInicialButton.Font = new Font("Nirmala UI Semilight", 24F, FontStyle.Regular, GraphicsUnit.Point);
            telaInicialButton.Location = new Point(0, 150);
            telaInicialButton.Name = "telaInicialButton";
            telaInicialButton.Size = new Size(208, 148);
            telaInicialButton.TabIndex = 2;
            telaInicialButton.Text = "Tela inicial";
            telaInicialButton.TextAlign = ContentAlignment.BottomCenter;
            telaInicialButton.UseVisualStyleBackColor = false;
            telaInicialButton.Click += TelaInicialButton_Click;
            // 
            // companyLogoPanel
            // 
            companyLogoPanel.BackColor = Color.White;
            companyLogoPanel.Controls.Add(pictureBox1);
            companyLogoPanel.Dock = DockStyle.Top;
            companyLogoPanel.ImeMode = ImeMode.NoControl;
            companyLogoPanel.Location = new Point(0, 0);
            companyLogoPanel.Name = "companyLogoPanel";
            companyLogoPanel.Size = new Size(208, 150);
            companyLogoPanel.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(4, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(199, 135);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // topBarPanel
            // 
            topBarPanel.BackColor = Color.FromArgb(52, 63, 72);
            topBarPanel.Controls.Add(sistemaGestPesagemLabel);
            topBarPanel.Controls.Add(MinimizeLabel);
            topBarPanel.Controls.Add(closeLabel);
            topBarPanel.Dock = DockStyle.Top;
            topBarPanel.Location = new Point(208, 0);
            topBarPanel.Name = "topBarPanel";
            topBarPanel.Size = new Size(1712, 150);
            topBarPanel.TabIndex = 1;
            // 
            // sistemaGestPesagemLabel
            // 
            sistemaGestPesagemLabel.AutoSize = true;
            sistemaGestPesagemLabel.Font = new Font("Bahnschrift Light", 48F, FontStyle.Regular, GraphicsUnit.Point);
            sistemaGestPesagemLabel.ForeColor = Color.FromArgb(230, 230, 230);
            sistemaGestPesagemLabel.Location = new Point(385, 29);
            sistemaGestPesagemLabel.Name = "sistemaGestPesagemLabel";
            sistemaGestPesagemLabel.Size = new Size(948, 77);
            sistemaGestPesagemLabel.TabIndex = 1;
            sistemaGestPesagemLabel.Text = "Sistema de Gestão de Pesagem ";
            sistemaGestPesagemLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MinimizeLabel
            // 
            MinimizeLabel.AutoSize = true;
            MinimizeLabel.Font = new Font("Showcard Gothic", 31F, FontStyle.Bold, GraphicsUnit.Point);
            MinimizeLabel.ForeColor = SystemColors.ButtonFace;
            MinimizeLabel.Location = new Point(1612, 0);
            MinimizeLabel.Name = "MinimizeLabel";
            MinimizeLabel.Size = new Size(44, 52);
            MinimizeLabel.TabIndex = 2;
            MinimizeLabel.Text = "_";
            MinimizeLabel.TextAlign = ContentAlignment.MiddleCenter;
            MinimizeLabel.Click += MinimizeLabel_Click;
            // 
            // closeLabel
            // 
            closeLabel.AutoSize = true;
            closeLabel.Font = new Font("Segoe UI", 28F, FontStyle.Bold, GraphicsUnit.Point);
            closeLabel.ForeColor = SystemColors.ButtonFace;
            closeLabel.Location = new Point(1653, 9);
            closeLabel.Name = "closeLabel";
            closeLabel.Size = new Size(47, 51);
            closeLabel.TabIndex = 1;
            closeLabel.Text = "X";
            closeLabel.TextAlign = ContentAlignment.MiddleCenter;
            closeLabel.Click += CloseLabel_Click;
            // 
            // diasRestantesLabel
            // 
            diasRestantesLabel.AutoSize = true;
            diasRestantesLabel.FlatStyle = FlatStyle.Flat;
            diasRestantesLabel.Font = new Font("Nirmala UI Semilight", 14F, FontStyle.Regular, GraphicsUnit.Point);
            diasRestantesLabel.ForeColor = Color.Black;
            diasRestantesLabel.Location = new Point(26, 986);
            diasRestantesLabel.Name = "diasRestantesLabel";
            diasRestantesLabel.Size = new Size(161, 25);
            diasRestantesLabel.TabIndex = 7;
            diasRestantesLabel.Text = "(29 dias restantes)";
            diasRestantesLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1920, 1032);
            Controls.Add(topBarPanel);
            Controls.Add(sideBarPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SGPG-MainForm";
            sideBarPanel.ResumeLayout(false);
            sideBarPanel.PerformLayout();
            companyLogoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            topBarPanel.ResumeLayout(false);
            topBarPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel sideBarPanel;
        private Panel companyLogoPanel;
        private Panel topBarPanel;
        private Label closeLabel;
        private Label MinimizeLabel;
        private Label sistemaGestPesagemLabel;
        private Button telaInicialButton;
        private PictureBox pictureBox1;
        private Button pesagemButton;
        private Button sobreButton;
        private Button opcoesButton;
        private Button buscarButton;
        private Label licencaDemoLabel;
        private Label diasRestantesLabel;
    }
}
