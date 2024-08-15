namespace SGPG
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void CloseLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MinimizeLabel_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void TelaInicialButton_Click(object sender, EventArgs e)
        {

        }

        private void PesagemButton_Click(object sender, EventArgs e)
        {

        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {

        }

        private void OpcoesButton_Click(object sender, EventArgs e)
        {

        }

        private void SobreButton_Click(object sender, EventArgs e)
        {

        }

        private void customerLogoPictureBox_Click(object sender, EventArgs e)
        {
            customerLogoPictureBox.Visible = false;
            suaLogoAquiLabel.Visible = true;
        }

        private void suaLogoAquiLabel_Click(object sender, EventArgs e)
        {
            customerLogoPictureBox.Visible = true;
            suaLogoAquiLabel.Visible = false;
        }
    }
}
