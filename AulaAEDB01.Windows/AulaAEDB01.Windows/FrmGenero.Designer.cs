namespace AulaAEDB01.Windows
{
    partial class FrmGenero
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
            TxtCodigo = new TextBox();
            TxtNome = new TextBox();
            LblCodigo = new Label();
            LblNome = new Label();
            BtnSalvar = new Button();
            BtnFechar = new Button();
            GrdItens = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            BtnAlterar = new DataGridViewButtonColumn();
            BtnExcluir = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)GrdItens).BeginInit();
            SuspendLayout();
            // 
            // TxtCodigo
            // 
            TxtCodigo.Enabled = false;
            TxtCodigo.Location = new Point(35, 46);
            TxtCodigo.MaxLength = 4;
            TxtCodigo.Name = "TxtCodigo";
            TxtCodigo.Size = new Size(58, 27);
            TxtCodigo.TabIndex = 1;
            TxtCodigo.TextChanged += TxtCodigo_TextChanged;
            // 
            // TxtNome
            // 
            TxtNome.Location = new Point(133, 46);
            TxtNome.MaxLength = 50;
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(465, 27);
            TxtNome.TabIndex = 4;
            TxtNome.TextChanged += TxtNome_TextChanged;
            // 
            // LblCodigo
            // 
            LblCodigo.AutoSize = true;
            LblCodigo.Location = new Point(35, 14);
            LblCodigo.Name = "LblCodigo";
            LblCodigo.Size = new Size(58, 20);
            LblCodigo.TabIndex = 0;
            LblCodigo.Text = "Código";
            // 
            // LblNome
            // 
            LblNome.AutoSize = true;
            LblNome.Location = new Point(133, 14);
            LblNome.Name = "LblNome";
            LblNome.Size = new Size(50, 20);
            LblNome.TabIndex = 2;
            LblNome.Text = "Nome";
            // 
            // BtnSalvar
            // 
            BtnSalvar.CausesValidation = false;
            BtnSalvar.Location = new Point(35, 99);
            BtnSalvar.Name = "BtnSalvar";
            BtnSalvar.Size = new Size(122, 44);
            BtnSalvar.TabIndex = 5;
            BtnSalvar.Text = "&Salvar";
            BtnSalvar.UseVisualStyleBackColor = true;
            BtnSalvar.Click += BtnSalvar_Click;
            // 
            // BtnFechar
            // 
            BtnFechar.Location = new Point(183, 99);
            BtnFechar.Name = "BtnFechar";
            BtnFechar.Size = new Size(122, 44);
            BtnFechar.TabIndex = 6;
            BtnFechar.Text = "&Fechar";
            BtnFechar.UseVisualStyleBackColor = true;
            BtnFechar.Click += BtnFechar_Click;
            // 
            // GrdItens
            // 
            GrdItens.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GrdItens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GrdItens.Columns.AddRange(new DataGridViewColumn[] { Id, Nome, BtnAlterar, BtnExcluir });
            GrdItens.Location = new Point(1, 149);
            GrdItens.Name = "GrdItens";
            GrdItens.RowHeadersWidth = 51;
            GrdItens.Size = new Size(1147, 341);
            GrdItens.TabIndex = 6;
            GrdItens.CellClick += GrdItens_CellClick;
            GrdItens.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Código";
            Id.MaxInputLength = 4;
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.Width = 125;
            // 
            // Nome
            // 
            Nome.DataPropertyName = "Nome";
            Nome.HeaderText = "Nome";
            Nome.MaxInputLength = 50;
            Nome.MinimumWidth = 6;
            Nome.Name = "Nome";
            Nome.Width = 200;
            // 
            // BtnAlterar
            // 
            BtnAlterar.HeaderText = "Alterar";
            BtnAlterar.MinimumWidth = 6;
            BtnAlterar.Name = "BtnAlterar";
            BtnAlterar.Width = 125;
            // 
            // BtnExcluir
            // 
            BtnExcluir.HeaderText = "Excluir";
            BtnExcluir.MinimumWidth = 6;
            BtnExcluir.Name = "BtnExcluir";
            BtnExcluir.Width = 125;
            // 
            // FrmGenero
            // 
            AcceptButton = BtnSalvar;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = BtnFechar;
            ClientSize = new Size(1148, 491);
            Controls.Add(GrdItens);
            Controls.Add(BtnFechar);
            Controls.Add(BtnSalvar);
            Controls.Add(LblNome);
            Controls.Add(LblCodigo);
            Controls.Add(TxtNome);
            Controls.Add(TxtCodigo);
            Name = "FrmGenero";
            Text = "Cadastro de Gêneros";
            Activated += FrmGenero_Activated;
            FormClosed += FrmGenero_FormClosed;
            Load += FrmGenero_Load;
            ((System.ComponentModel.ISupportInitialize)GrdItens).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtCodigo;
        private TextBox TxtNome;
        private Label LblCodigo;
        private Label LblNome;
        private Button BtnSalvar;
        private Button BtnFechar;
        private DataGridView GrdItens;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewButtonColumn BtnAlterar;
        private DataGridViewButtonColumn BtnExcluir;

        //public FrmGenero(TextBox txtCodigo)
        //{
        //    TxtCodigo = txtCodigo;
        //}
    }
}