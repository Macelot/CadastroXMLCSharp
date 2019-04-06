namespace frmXML
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consutarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criarArquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criarArquivoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.criarBancoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criaMDFELDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.produtoToolStripMenuItem,
            this.criarBancoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(705, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.consutarToolStripMenuItem,
            this.criarArquivoToolStripMenuItem});
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.clienteToolStripMenuItem.Text = "Cliente";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.novoToolStripMenuItem.Text = "Novo";
            this.novoToolStripMenuItem.Click += new System.EventHandler(this.novoToolStripMenuItem_Click);
            // 
            // consutarToolStripMenuItem
            // 
            this.consutarToolStripMenuItem.Name = "consutarToolStripMenuItem";
            this.consutarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.consutarToolStripMenuItem.Text = "Consutar";
            this.consutarToolStripMenuItem.Click += new System.EventHandler(this.consutarToolStripMenuItem_Click);
            // 
            // criarArquivoToolStripMenuItem
            // 
            this.criarArquivoToolStripMenuItem.Name = "criarArquivoToolStripMenuItem";
            this.criarArquivoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.criarArquivoToolStripMenuItem.Text = "Criar arquivo";
            this.criarArquivoToolStripMenuItem.Click += new System.EventHandler(this.criarArquivoToolStripMenuItem_Click);
            // 
            // produtoToolStripMenuItem
            // 
            this.produtoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem1,
            this.consultarToolStripMenuItem,
            this.criarArquivoToolStripMenuItem1,
            this.listaToolStripMenuItem});
            this.produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            this.produtoToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.produtoToolStripMenuItem.Text = "Produto";
            // 
            // novoToolStripMenuItem1
            // 
            this.novoToolStripMenuItem1.Name = "novoToolStripMenuItem1";
            this.novoToolStripMenuItem1.Size = new System.Drawing.Size(147, 22);
            this.novoToolStripMenuItem1.Text = "Novo";
            this.novoToolStripMenuItem1.Click += new System.EventHandler(this.novoToolStripMenuItem1_Click);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.consultarToolStripMenuItem.Text = "Consultar";
            this.consultarToolStripMenuItem.Click += new System.EventHandler(this.consultarToolStripMenuItem_Click);
            // 
            // criarArquivoToolStripMenuItem1
            // 
            this.criarArquivoToolStripMenuItem1.Name = "criarArquivoToolStripMenuItem1";
            this.criarArquivoToolStripMenuItem1.Size = new System.Drawing.Size(147, 22);
            this.criarArquivoToolStripMenuItem1.Text = "Criar arquivo";
            this.criarArquivoToolStripMenuItem1.Click += new System.EventHandler(this.criarArquivoToolStripMenuItem1_Click);
            // 
            // listaToolStripMenuItem
            // 
            this.listaToolStripMenuItem.Name = "listaToolStripMenuItem";
            this.listaToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.listaToolStripMenuItem.Text = "Lista";
            this.listaToolStripMenuItem.Click += new System.EventHandler(this.listaToolStripMenuItem_Click);
            // 
            // criarBancoToolStripMenuItem
            // 
            this.criarBancoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.criaMDFELDFToolStripMenuItem});
            this.criarBancoToolStripMenuItem.Name = "criarBancoToolStripMenuItem";
            this.criarBancoToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.criarBancoToolStripMenuItem.Text = "Criar Banco";
            // 
            // criaMDFELDFToolStripMenuItem
            // 
            this.criaMDFELDFToolStripMenuItem.Name = "criaMDFELDFToolStripMenuItem";
            this.criaMDFELDFToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.criaMDFELDFToolStripMenuItem.Text = "Cria MDF e LDF";
            this.criaMDFELDFToolStripMenuItem.Click += new System.EventHandler(this.criaMDFELDFToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 369);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consutarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem criarArquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem criarArquivoToolStripMenuItem1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripMenuItem listaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem criarBancoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem criaMDFELDFToolStripMenuItem;
    }
}

