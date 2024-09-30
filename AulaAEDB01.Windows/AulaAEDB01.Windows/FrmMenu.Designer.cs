namespace AulaAEDB01.Windows
{
    partial class FrmMenu
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
            components = new System.ComponentModel.Container();
            MnuStrip = new MenuStrip();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            MnuGenero = new ToolStripMenuItem();
            MnuAutor = new ToolStripMenuItem();
            MnuEditora = new ToolStripMenuItem();
            MnuLivros = new ToolStripMenuItem();
            MnuIdioma = new ToolStripMenuItem();
            MnuUsuario = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            MnuSair = new ToolStripMenuItem();
            MenuSuspenso = new ContextMenuStrip(components);
            MnSGenero = new ToolStripMenuItem();
            MnSAutor = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            LblDisplay = new ToolStripStatusLabel();
            MnSIdioma = new ToolStripMenuItem();
            MnSUsuario = new ToolStripMenuItem();
            MnSLivros = new ToolStripMenuItem();
            MnSEditora = new ToolStripMenuItem();
            MnuStrip.SuspendLayout();
            MenuSuspenso.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // MnuStrip
            // 
            MnuStrip.ImageScalingSize = new Size(20, 20);
            MnuStrip.Items.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem });
            MnuStrip.Location = new Point(0, 0);
            MnuStrip.Name = "MnuStrip";
            MnuStrip.Padding = new Padding(5, 2, 0, 2);
            MnuStrip.Size = new Size(700, 24);
            MnuStrip.TabIndex = 1;
            MnuStrip.Text = "MnuStrip";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { MnuGenero, MnuAutor, MnuEditora, MnuLivros, MnuIdioma, MnuUsuario, toolStripMenuItem2, MnuSair });
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(71, 20);
            cadastrosToolStripMenuItem.Text = "&Cadastros";
            // 
            // MnuGenero
            // 
            MnuGenero.Name = "MnuGenero";
            MnuGenero.Size = new Size(180, 22);
            MnuGenero.Text = "&Gêneros";
            MnuGenero.Click += MnuGenero_Click;
            // 
            // MnuAutor
            // 
            MnuAutor.Name = "MnuAutor";
            MnuAutor.Size = new Size(180, 22);
            MnuAutor.Text = "&Autor";
            MnuAutor.Click += MenuAutor_Click;
            // 
            // MnuEditora
            // 
            MnuEditora.Name = "MnuEditora";
            MnuEditora.Size = new Size(180, 22);
            MnuEditora.Text = "&Editora";
            MnuEditora.Click += MenuEditora_Click;
            // 
            // MnuLivros
            // 
            MnuLivros.Name = "MnuLivros";
            MnuLivros.Size = new Size(180, 22);
            MnuLivros.Text = "&Livros";
            // 
            // MnuIdioma
            // 
            MnuIdioma.Name = "MnuIdioma";
            MnuIdioma.Size = new Size(180, 22);
            MnuIdioma.Text = "&Idioma";
            // 
            // MnuUsuario
            // 
            MnuUsuario.Name = "MnuUsuario";
            MnuUsuario.Size = new Size(180, 22);
            MnuUsuario.Text = "&Usuário";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(177, 6);
            // 
            // MnuSair
            // 
            MnuSair.Name = "MnuSair";
            MnuSair.Size = new Size(180, 22);
            MnuSair.Text = "Sai&r";
            MnuSair.Click += MnuSair_Click;
            // 
            // MenuSuspenso
            // 
            MenuSuspenso.ImageScalingSize = new Size(20, 20);
            MenuSuspenso.Items.AddRange(new ToolStripItem[] { MnSGenero, MnSAutor, MnSEditora, MnSLivros, MnSIdioma, MnSUsuario });
            MenuSuspenso.Name = "MenuSuspenso";
            MenuSuspenso.Size = new Size(115, 136);
            // 
            // MnSGenero
            // 
            MnSGenero.Name = "MnSGenero";
            MnSGenero.Size = new Size(114, 22);
            MnSGenero.Text = "&Gênero";
            MnSGenero.Click += MnSGenero_Click;
            // 
            // MnSAutor
            // 
            MnSAutor.Name = "MnSAutor";
            MnSAutor.Size = new Size(114, 22);
            MnSAutor.Text = "&Autor";
            MnSAutor.Click += MnSAutor_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { LblDisplay });
            statusStrip1.Location = new Point(0, 314);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 12, 0);
            statusStrip1.Size = new Size(700, 24);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // LblDisplay
            // 
            LblDisplay.AutoSize = false;
            LblDisplay.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
            LblDisplay.DisplayStyle = ToolStripItemDisplayStyle.Text;
            LblDisplay.Name = "LblDisplay";
            LblDisplay.Size = new Size(300, 19);
            // 
            // MnSIdioma
            // 
            MnSIdioma.Name = "MnSIdioma";
            MnSIdioma.Size = new Size(114, 22);
            MnSIdioma.Text = "&Idioma";
            // 
            // MnSUsuario
            // 
            MnSUsuario.Name = "MnSUsuario";
            MnSUsuario.Size = new Size(114, 22);
            MnSUsuario.Text = "&Usuário";
            // 
            // MnSLivros
            // 
            MnSLivros.Name = "MnSLivros";
            MnSLivros.Size = new Size(114, 22);
            MnSLivros.Text = "&Livros";
            // 
            // MnSEditora
            // 
            MnSEditora.Name = "MnSEditora";
            MnSEditora.Size = new Size(114, 22);
            MnSEditora.Text = "&Editora";
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            ContextMenuStrip = MenuSuspenso;
            Controls.Add(statusStrip1);
            Controls.Add(MnuStrip);
            IsMdiContainer = true;
            MainMenuStrip = MnuStrip;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmMenu";
            Text = "SistemaBiblioteca";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            MnuStrip.ResumeLayout(false);
            MnuStrip.PerformLayout();
            MenuSuspenso.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem MnuSair;
        public MenuStrip MnuStrip;
        public ToolStripMenuItem MnuGenero;
        public ContextMenuStrip MenuSuspenso;
        public ToolStripMenuItem MnSGenero;
        private StatusStrip statusStrip1;
        public ToolStripStatusLabel LblDisplay;
        private ToolStripSeparator toolStripMenuItem2;
        public ToolStripMenuItem MnSAutor;
        public ToolStripMenuItem MnuAutor;
        public ToolStripMenuItem MnuEditora;
        public ToolStripMenuItem MnSEditora;
        public ToolStripMenuItem MnSLivros;
        public ToolStripMenuItem MnSIdioma;
        public ToolStripMenuItem MnSUsuario;
        public ToolStripMenuItem MnuLivros;
        public ToolStripMenuItem MnuIdioma;
        public ToolStripMenuItem MnuUsuario;
    }
}
