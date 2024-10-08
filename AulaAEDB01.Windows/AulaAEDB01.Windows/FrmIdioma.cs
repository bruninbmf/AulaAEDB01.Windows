﻿using AulaAEDB01.Windows.Model;
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
    public partial class FrmIdioma : Form
    {
        private tipoValidacao Incluir = tipoValidacao.salvar;
        public FrmIdioma()
        {
            InitializeComponent();
        }
        private void FrmIdioma_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((FrmMenu)this.MdiParent).MnuIdioma.Enabled = true;
            ((FrmMenu)this.MdiParent).MnSIdioma.Enabled = true;
            ((FrmMenu)this.MdiParent).LblDisplay.Text = "";

        }
        private void CarregaGrid()
        {
            GrdItens.AutoGenerateColumns = false;
            GrdItens.DataSource = Idioma.ListarTodos();
        }
        private void FrmIdioma_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void FrmIdioma_Activated(object sender, EventArgs e)
        {
            ((FrmMenu)this.MdiParent).LblDisplay.Text = "Cadastro de Idiomas";
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool ValidaControles(tipoValidacao tipoValidacao)
        {
            int id;
            if (TxtNome.Text.Trim() == "")
            {
                MessageBox.Show("O campo Nome é de preenchimento obrigatório.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtNome.Focus();
                return false;
            }
            if (tipoValidacao != tipoValidacao.salvar)
            {
                if (TxtCodigo.Text.Trim() == "")
                {
                    MessageBox.Show("O campo Código é de preenchimento obrigatório.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtCodigo.Focus();
                    return false;
                }
            }

            return true;
        }
        private void LimpaControles()
        {
            TxtCodigo.Text = "";
            TxtNome.Text = "";
        }

        private void BtnSalvar_Click_1(object sender, EventArgs e)
        {
            if (ValidaControles(Incluir))
                if (Incluir == tipoValidacao.salvar)
                {
                    Idioma oIdioma = new Idioma()
                    {
                        //id = int.Parse(TxtCodigo.Text),
                        Nome = TxtNome.Text
                    };

                    try
                    {
                        oIdioma.Incluir();
                        CarregaGrid();
                        LimpaControles();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Um erro ocorreu ao incluir o Idioma: {ex.Message}.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TxtCodigo.Focus();
                    }


                }
                else
                {
                    Idioma oIdioma = new Idioma()
                    {
                        id = int.Parse(TxtCodigo.Text),
                        Nome = TxtNome.Text
                    };
                    try
                    {
                        Idioma.Alterar(oIdioma);
                        CarregaGrid();
                        LimpaControles();
                        Incluir = tipoValidacao.salvar;
                        TxtCodigo.Enabled = false;
                        TxtCodigo.Text = "";
                        MessageBox.Show($"Idioma com codigo:({oIdioma.id}) editado com sucesso.", "Editar", MessageBoxButtons.OK);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Um erro ocorreu ao alterar o Idioma: {ex.Message}.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TxtCodigo.Focus();
                    }
                }
        }

        private void GrdItens_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (GrdItens.Rows[e.RowIndex].DataBoundItem != null)
            {
                Idioma objSelecionado = (Idioma)GrdItens.Rows[e.RowIndex].DataBoundItem;
                if (GrdItens.Columns[e.ColumnIndex].Name == "BtnAlterar")
                {
                    //Clicou no botão alterar
                    TxtCodigo.Text = objSelecionado.id.ToString();
                    TxtNome.Text = objSelecionado.Nome;
                    TxtCodigo.Enabled = false;
                    TxtNome.Focus();
                    Incluir = tipoValidacao.editar;
                }
                else if (GrdItens.Columns[e.ColumnIndex].Name == "BtnExcluir")
                {
                    Incluir = tipoValidacao.excluir;
                    //Clicou no botão excluir
                    if (MessageBox.Show("Confirme a exclusão.", "Deseja mesmo Excluir?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        objSelecionado.Excluir();
                        CarregaGrid();
                    }
                }


            }
        }

        private void TxtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtNome_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
