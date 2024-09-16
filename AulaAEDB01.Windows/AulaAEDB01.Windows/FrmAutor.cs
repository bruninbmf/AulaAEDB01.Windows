using AulaAEDB01.Windows.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AulaAEDB01.Windows
{
    public partial class FrmAutor : Form
    {
        private bool Incluir = true;
        public FrmAutor()
        {
            InitializeComponent();
        }

        private void FrmAutor_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((FrmMenu)this.MdiParent).MenuAutor.Enabled = true;
            ((FrmMenu)this.MdiParent).MnSAutor.Enabled = true;
            ((FrmMenu)this.MdiParent).LblDisplay.Text = "";
        }
        private void CarregaGrid()
        {
            GrdItens.AutoGenerateColumns = false;
            GrdItens.DataSource = Autor.ListarTodos();
        }

        private void FrmAutor_Activated(object sender, EventArgs e)
        {
            ((FrmMenu)this.MdiParent).LblDisplay.Text = "Cadastro de Autor";
        }

        private void TxtCodigo_Click(object sender, EventArgs e)
        {

        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool ValidaControles()
        {
            int Codigo;
            if (TxtNome.Text.Trim() == "")
            {
                MessageBox.Show("O campo Nome é de preenchimento obrigatório.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtNome.Focus();
                return false;
            }
            if (TxtCodigo.Text.Trim() == "")
            {
                MessageBox.Show("O campo Código é de preenchimento obrigatório.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtCodigo.Focus();
                return false;
            }

            if (int.TryParse(TxtCodigo.Text, out Codigo) == false)
            {
                MessageBox.Show("O campo Código não é numérico.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtCodigo.Focus();
                return false;
            }

            return true;
        }
        private void LimpaControles()
        {
            TxtCodigo.Text = "";
            TxtNome.Text = "";
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnSalvar_Click_1(object sender, EventArgs e)
        {
            if (ValidaControles())
                if (Incluir)
                {
                    Autor oAutor = new Autor()
                    {
                        Codigo = int.Parse(TxtCodigo.Text),
                        Nome = TxtNome.Text
                    };

                    try
                    {
                        oAutor.Incluir();
                        CarregaGrid();
                        LimpaControles();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Um erro ocorreu ao incluir o autor: {ex.Message}.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TxtCodigo.Focus();
                    }

                }
                else
                {
                    Autor oAutor = new Autor()
                    {
                        Codigo = int.Parse(TxtCodigo.Text),
                        Nome = TxtNome.Text
                    };
                    try
                    {
                        Autor.Alterar(oAutor);
                        CarregaGrid();
                        LimpaControles();
                        Incluir = true;
                        TxtCodigo.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Um erro ocorreu ao alterar o autor: {ex.Message}.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TxtCodigo.Focus();
                    }
                }
        }

        private void GrdItens_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

            if (GrdItens.Rows[e.RowIndex].DataBoundItem != null)
            {
                Autor objSelecionado = (Autor)GrdItens.Rows[e.RowIndex].DataBoundItem;
                if (GrdItens.Columns[e.ColumnIndex].Name == "BtnAlterar")
                {
                    //Clicou no botão alterar
                    TxtCodigo.Text = objSelecionado.Codigo.ToString();
                    TxtNome.Text = objSelecionado.Nome;
                    TxtCodigo.Enabled = false;
                    TxtNome.Focus();
                    Incluir = false;
                }
                else if (GrdItens.Columns[e.ColumnIndex].Name == "BtnExcluir")
                {
                    //Clicou no botão excluir
                    if (MessageBox.Show("Confirme a exclusão.", "Deseja mesmo Excluir?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        objSelecionado.Excluir();
                        CarregaGrid();
                    }
                }


            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmAutor_Load_1(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void GrdItens_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}
