namespace Préstamos {
  partial class FrmMenúGeneral {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenúGeneral));
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.MnuCerrar = new System.Windows.Forms.ToolStripMenuItem();
      this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.MnuAltaClientes = new System.Windows.Forms.ToolStripMenuItem();
      this.MnuConsultaClientes = new System.Windows.Forms.ToolStripMenuItem();
      this.préstamosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.MnuAltaPréstamos = new System.Windows.Forms.ToolStripMenuItem();
      this.consultaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.pagosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.altaToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
      this.consultaToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.préstamosToolStripMenuItem,
            this.pagosToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(758, 28);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // archivoToolStripMenuItem
      // 
      this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuCerrar});
      this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
      this.archivoToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
      this.archivoToolStripMenuItem.Text = "Archivo";
      // 
      // MnuCerrar
      // 
      this.MnuCerrar.Name = "MnuCerrar";
      this.MnuCerrar.Size = new System.Drawing.Size(124, 26);
      this.MnuCerrar.Text = "Cerrar";
      this.MnuCerrar.Click += new System.EventHandler(this.MnuCerrar_Click);
      // 
      // clientesToolStripMenuItem
      // 
      this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuAltaClientes,
            this.MnuConsultaClientes});
      this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
      this.clientesToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
      this.clientesToolStripMenuItem.Text = "Clientes";
      // 
      // MnuAltaClientes
      // 
      this.MnuAltaClientes.Enabled = false;
      this.MnuAltaClientes.Name = "MnuAltaClientes";
      this.MnuAltaClientes.Size = new System.Drawing.Size(141, 26);
      this.MnuAltaClientes.Text = "Alta";
      this.MnuAltaClientes.Click += new System.EventHandler(this.MnuAltaClientes_Click);
      // 
      // MnuConsultaClientes
      // 
      this.MnuConsultaClientes.Name = "MnuConsultaClientes";
      this.MnuConsultaClientes.Size = new System.Drawing.Size(141, 26);
      this.MnuConsultaClientes.Text = "Consulta";
      this.MnuConsultaClientes.Click += new System.EventHandler(this.MnuConsultaClientes_Click);
      // 
      // préstamosToolStripMenuItem
      // 
      this.préstamosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuAltaPréstamos,
            this.consultaToolStripMenuItem1});
      this.préstamosToolStripMenuItem.Name = "préstamosToolStripMenuItem";
      this.préstamosToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
      this.préstamosToolStripMenuItem.Text = "Préstamos";
      // 
      // MnuAltaPréstamos
      // 
      this.MnuAltaPréstamos.Enabled = false;
      this.MnuAltaPréstamos.Name = "MnuAltaPréstamos";
      this.MnuAltaPréstamos.Size = new System.Drawing.Size(181, 26);
      this.MnuAltaPréstamos.Text = "Alta";
      this.MnuAltaPréstamos.Click += new System.EventHandler(this.MnuAltaPréstamos_Click);
      // 
      // consultaToolStripMenuItem1
      // 
      this.consultaToolStripMenuItem1.Name = "consultaToolStripMenuItem1";
      this.consultaToolStripMenuItem1.Size = new System.Drawing.Size(181, 26);
      this.consultaToolStripMenuItem1.Text = "Consulta";
      // 
      // pagosToolStripMenuItem
      // 
      this.pagosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaToolStripMenuItem2,
            this.consultaToolStripMenuItem2});
      this.pagosToolStripMenuItem.Name = "pagosToolStripMenuItem";
      this.pagosToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
      this.pagosToolStripMenuItem.Text = "Pagos";
      // 
      // altaToolStripMenuItem2
      // 
      this.altaToolStripMenuItem2.Enabled = false;
      this.altaToolStripMenuItem2.Name = "altaToolStripMenuItem2";
      this.altaToolStripMenuItem2.Size = new System.Drawing.Size(141, 26);
      this.altaToolStripMenuItem2.Text = "Alta";
      // 
      // consultaToolStripMenuItem2
      // 
      this.consultaToolStripMenuItem2.Name = "consultaToolStripMenuItem2";
      this.consultaToolStripMenuItem2.Size = new System.Drawing.Size(141, 26);
      this.consultaToolStripMenuItem2.Text = "Consulta";
      // 
      // FrmMenúGeneral
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
      this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ClientSize = new System.Drawing.Size(758, 469);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "FrmMenúGeneral";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Menú general";
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem MnuCerrar;
    private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem MnuAltaClientes;
    private System.Windows.Forms.ToolStripMenuItem MnuConsultaClientes;
    private System.Windows.Forms.ToolStripMenuItem préstamosToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem MnuAltaPréstamos;
    private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem pagosToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem altaToolStripMenuItem2;
    private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem2;
  }
}