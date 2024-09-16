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
            MnuAutor = new ToolStripSeparator();
            MenuAutor = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            MnuSair = new ToolStripMenuItem();
            MenuSuspenso = new ContextMenuStrip(components);
            MnSGenero = new ToolStripMenuItem();
            MnSAutor = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            LblDisplay = new ToolStripStatusLabel();
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
            MnuStrip.Size = new Size(800, 28);
            MnuStrip.TabIndex = 1;
            MnuStrip.Text = "MnuStrip";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { MnuGenero, MnuAutor, MenuAutor, toolStripMenuItem2, MnuSair });
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(88, 24);
            cadastrosToolStripMenuItem.Text = "&Cadastros";
            // 
            // MnuGenero
            // 
            MnuGenero.Name = "MnuGenero";
            MnuGenero.Size = new Size(224, 26);
            MnuGenero.Text = "&Gêneros";
            MnuGenero.Click += MnuGenero_Click;
            // 
            // MnuAutor
            // 
            MnuAutor.Name = "MnuAutor";
            MnuAutor.Size = new Size(221, 6);
            // 
            // MenuAutor
            // 
            MenuAutor.Name = "MenuAutor";
            MenuAutor.Size = new Size(224, 26);
            MenuAutor.Text = "&Autor";
            MenuAutor.Click += MenuAutor_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(221, 6);
            // 
            // MnuSair
            // 
            MnuSair.Name = "MnuSair";
            MnuSair.Size = new Size(224, 26);
            MnuSair.Text = "Sai&r";
            MnuSair.Click += MnuSair_Click;
            // 
            // MenuSuspenso
            // 
            MenuSuspenso.ImageScalingSize = new Size(20, 20);
            MenuSuspenso.Items.AddRange(new ToolStripItem[] { MnSGenero, MnSAutor });
            MenuSuspenso.Name = "MenuSuspenso";
            MenuSuspenso.Size = new Size(127, 52);
            // 
            // MnSGenero
            // 
            MnSGenero.Name = "MnSGenero";
            MnSGenero.Size = new Size(126, 24);
            MnSGenero.Text = "&Gênero";
            MnSGenero.Click += MnSGenero_Click;
            // 
            // MnSAutor
            // 
            MnSAutor.Name = "MnSAutor";
            MnSAutor.Size = new Size(126, 24);
            MnSAutor.Text = "&Autor";
            MnSAutor.Click += MnSAutor_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { LblDisplay });
            statusStrip1.Location = new Point(0, 426);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 24);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // LblDisplay
            // 
            LblDisplay.AutoSize = false;
            LblDisplay.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
            LblDisplay.DisplayStyle = ToolStripItemDisplayStyle.Text;
            LblDisplay.Name = "LblDisplay";
            LblDisplay.Size = new Size(300, 18);
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ContextMenuStrip = MenuSuspenso;
            Controls.Add(statusStrip1);
            Controls.Add(MnuStrip);
            IsMdiContainer = true;
            MainMenuStrip = MnuStrip;
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
        private ToolStripSeparator MnuAutor;
        private ToolStripMenuItem MnuSair;
        public MenuStrip MnuStrip;
        public ToolStripMenuItem MnuGenero;
        public ContextMenuStrip MenuSuspenso;
        public ToolStripMenuItem MnSGenero;
        private StatusStrip statusStrip1;
        public ToolStripStatusLabel LblDisplay;
        private ToolStripSeparator toolStripMenuItem2;
        public ToolStripMenuItem MnSAutor;
        public ToolStripMenuItem MenuAutor;
    }
}
