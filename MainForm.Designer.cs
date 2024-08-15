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
            pictureBox2 = new PictureBox();
            sobreButton = new Button();
            opcoesButton = new Button();
            buscarButton = new Button();
            pesagemButton = new Button();
            telaInicialButton = new Button();
            companyLogoPanel = new Panel();
            suaLogoAquiLabel = new Label();
            customerLogoPictureBox = new PictureBox();
            diasRestantesLabel = new Label();
            topBarPanel = new Panel();
            sistemaGestPesagemLabel = new Label();
            MinimizeLabel = new Label();
            closeLabel = new Label();
            formLoaderPanel = new Panel();
            sideBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            companyLogoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)customerLogoPictureBox).BeginInit();
            topBarPanel.SuspendLayout();
            SuspendLayout();
            // 
            // sideBarPanel
            // 
            sideBarPanel.BackColor = Color.White;
            sideBarPanel.Controls.Add(pictureBox2);
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
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(34, 909);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(138, 111);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // sobreButton
            // 
            sobreButton.BackColor = Color.FromArgb(217, 217, 217);
            sobreButton.BackgroundImage = (Image)resources.GetObject("sobreButton.BackgroundImage");
            sobreButton.BackgroundImageLayout = ImageLayout.Zoom;
            sobreButton.Dock = DockStyle.Top;
            sobreButton.FlatAppearance.BorderSize = 0;
            sobreButton.FlatStyle = FlatStyle.Flat;
            sobreButton.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
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
            opcoesButton.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
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
            buscarButton.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
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
            pesagemButton.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
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
            telaInicialButton.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
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
            companyLogoPanel.Controls.Add(suaLogoAquiLabel);
            companyLogoPanel.Controls.Add(customerLogoPictureBox);
            companyLogoPanel.Dock = DockStyle.Top;
            companyLogoPanel.ImeMode = ImeMode.NoControl;
            companyLogoPanel.Location = new Point(0, 0);
            companyLogoPanel.Name = "companyLogoPanel";
            companyLogoPanel.Size = new Size(208, 150);
            companyLogoPanel.TabIndex = 1;
            // 
            // suaLogoAquiLabel
            // 
            suaLogoAquiLabel.AutoSize = true;
            suaLogoAquiLabel.BackColor = Color.Orange;
            suaLogoAquiLabel.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            suaLogoAquiLabel.Location = new Point(12, 29);
            suaLogoAquiLabel.Name = "suaLogoAquiLabel";
            suaLogoAquiLabel.Size = new Size(178, 90);
            suaLogoAquiLabel.TabIndex = 0;
            suaLogoAquiLabel.Text = "SUA LOGO\r\nAQUI";
            suaLogoAquiLabel.TextAlign = ContentAlignment.MiddleCenter;
            suaLogoAquiLabel.Visible = false;
            suaLogoAquiLabel.Click += suaLogoAquiLabel_Click;
            // 
            // customerLogoPictureBox
            // 
            customerLogoPictureBox.Image = (Image)resources.GetObject("customerLogoPictureBox.Image");
            customerLogoPictureBox.Location = new Point(4, 7);
            customerLogoPictureBox.Name = "customerLogoPictureBox";
            customerLogoPictureBox.Size = new Size(199, 135);
            customerLogoPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            customerLogoPictureBox.TabIndex = 0;
            customerLogoPictureBox.TabStop = false;
            customerLogoPictureBox.Click += customerLogoPictureBox_Click;
            // 
            // diasRestantesLabel
            // 
            diasRestantesLabel.AutoSize = true;
            diasRestantesLabel.FlatStyle = FlatStyle.Flat;
            diasRestantesLabel.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            diasRestantesLabel.ForeColor = Color.Black;
            diasRestantesLabel.Location = new Point(208, 1009);
            diasRestantesLabel.Name = "diasRestantesLabel";
            diasRestantesLabel.Size = new Size(263, 21);
            diasRestantesLabel.TabIndex = 7;
            diasRestantesLabel.Text = "Licenca demo - 29 dias restantes";
            diasRestantesLabel.TextAlign = ContentAlignment.MiddleCenter;
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
            sistemaGestPesagemLabel.Font = new Font("Century Gothic", 48F, FontStyle.Regular, GraphicsUnit.Point);
            sistemaGestPesagemLabel.ForeColor = Color.FromArgb(230, 230, 230);
            sistemaGestPesagemLabel.Location = new Point(385, 29);
            sistemaGestPesagemLabel.Name = "sistemaGestPesagemLabel";
            sistemaGestPesagemLabel.Size = new Size(1057, 78);
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
            closeLabel.Location = new Point(1660, 9);
            closeLabel.Name = "closeLabel";
            closeLabel.Size = new Size(47, 51);
            closeLabel.TabIndex = 1;
            closeLabel.Text = "X";
            closeLabel.TextAlign = ContentAlignment.MiddleCenter;
            closeLabel.Click += CloseLabel_Click;
            // 
            // formLoaderPanel
            // 
            formLoaderPanel.BackColor = Color.FromArgb(232, 232, 232);
            formLoaderPanel.Location = new Point(208, 150);
            formLoaderPanel.Name = "formLoaderPanel";
            formLoaderPanel.Size = new Size(1712, 858);
            formLoaderPanel.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1920, 1032);
            Controls.Add(diasRestantesLabel);
            Controls.Add(formLoaderPanel);
            Controls.Add(topBarPanel);
            Controls.Add(sideBarPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SGPG";
            sideBarPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            companyLogoPanel.ResumeLayout(false);
            companyLogoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)customerLogoPictureBox).EndInit();
            topBarPanel.ResumeLayout(false);
            topBarPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel sideBarPanel;
        private Panel companyLogoPanel;
        private Panel topBarPanel;
        private Label closeLabel;
        private Label MinimizeLabel;
        private Label sistemaGestPesagemLabel;
        private Button telaInicialButton;
        private PictureBox customerLogoPictureBox;
        private Button pesagemButton;
        private Button sobreButton;
        private Button opcoesButton;
        private Button buscarButton;
        private Label diasRestantesLabel;
        private Panel formLoaderPanel;
        private PictureBox pictureBox2;
        private Label suaLogoAquiLabel;
    }
}
