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
            MnuAutor.Enabled = false;
            MnSAutor.Enabled = false;
            oFrm.Show();
        }
        private void MnSAutor_Click(object sender, EventArgs e)
        {
            MenuAutor_Click(sender, e);
        }

        private void MnuEditora_Click(object sender, EventArgs e)
        {
            FrmEditora oFrm = new FrmEditora();
            oFrm.MdiParent = this;
            MnuEditora.Enabled = false;
            MnSEditora.Enabled = false;
            oFrm.Show();
        }

        private void MnuLivros_Click(object sender, EventArgs e)
        {
            FrmLivro oFrm = new FrmLivro();
            oFrm.MdiParent = this;
            MnuLivros.Enabled = false;
            MnSLivros.Enabled = false;
            oFrm.Show();
        }

        private void MnuIdioma_Click(object sender, EventArgs e)
        {
            FrmIdioma oFrm = new FrmIdioma();
            oFrm.MdiParent = this;
            MnuIdioma.Enabled = false;
            MnSIdioma.Enabled = false;
            oFrm.Show();
        }

        private void MnuUsuario_Click(object sender, EventArgs e)
        {
            FrmUsuario oFrm = new FrmUsuario();
            oFrm.MdiParent = this;
            MnuUsuario.Enabled = false;
            MnSUsuario.Enabled = false;
            oFrm.Show();
        }
    }
}
