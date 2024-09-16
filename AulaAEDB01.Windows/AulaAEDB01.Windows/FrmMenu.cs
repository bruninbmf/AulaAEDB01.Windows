namespace AulaAEDB01.Windows
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void MnuSair_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();

        }

        private void MnuGenero_Click(object sender, EventArgs e)
        {
            FrmGenero oFrm = new FrmGenero();
            oFrm.MdiParent = this;
            MnuGenero.Enabled = false;
            MnSGenero.Enabled = false;
            oFrm.Show();
        }

        private void MnSGenero_Click(object sender, EventArgs e)
        {
            MnuGenero_Click(sender, e);
        }
        private void MenuAutor_Click(object sender, EventArgs e)
        {
            FrmAutor oFrm = new FrmAutor();
            oFrm.MdiParent = this;
            MenuAutor.Enabled = false;
            MnSAutor.Enabled = false;
            oFrm.Show();
        }
        private void MnSAutor_Click(object sender, EventArgs e)
        {
            MenuAutor_Click(sender, e );
        }
    }
}
