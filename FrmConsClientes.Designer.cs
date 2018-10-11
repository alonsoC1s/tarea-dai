namespace Préstamos {
  partial class FrmConsClientes {
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
      this.label1 = new System.Windows.Forms.Label();
      this.cboCliente = new System.Windows.Forms.ComboBox();
      this.btnMostrar = new System.Windows.Forms.Button();
      this.grdCliente = new System.Windows.Forms.DataGridView();
      ((System.ComponentModel.ISupportInitialize)(this.grdCliente)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(102, 59);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(55, 17);
      this.label1.TabIndex = 0;
      this.label1.Text = "Cliente:";
      this.label1.Visible = false;
      // 
      // cboCliente
      // 
      this.cboCliente.FormattingEnabled = true;
      this.cboCliente.Location = new System.Drawing.Point(174, 56);
      this.cboCliente.Name = "cboCliente";
      this.cboCliente.Size = new System.Drawing.Size(121, 24);
      this.cboCliente.TabIndex = 1;
      this.cboCliente.Visible = false;
      this.cboCliente.SelectedIndexChanged += new System.EventHandler(this.cboCliente_SelectedIndexChanged);
      // 
      // btnMostrar
      // 
      this.btnMostrar.Location = new System.Drawing.Point(416, 49);
      this.btnMostrar.Name = "btnMostrar";
      this.btnMostrar.Size = new System.Drawing.Size(118, 42);
      this.btnMostrar.TabIndex = 2;
      this.btnMostrar.Text = "Mostrar datos";
      this.btnMostrar.UseVisualStyleBackColor = true;
      this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
      // 
      // grdCliente
      // 
      this.grdCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.grdCliente.Location = new System.Drawing.Point(87, 155);
      this.grdCliente.Name = "grdCliente";
      this.grdCliente.RowTemplate.Height = 24;
      this.grdCliente.Size = new System.Drawing.Size(520, 108);
      this.grdCliente.TabIndex = 3;
      // 
      // FrmConsClientes
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(695, 340);
      this.Controls.Add(this.grdCliente);
      this.Controls.Add(this.btnMostrar);
      this.Controls.Add(this.cboCliente);
      this.Controls.Add(this.label1);
      this.Name = "FrmConsClientes";
      this.Text = "Datos de los clientes";
      ((System.ComponentModel.ISupportInitialize)(this.grdCliente)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ComboBox cboCliente;
    private System.Windows.Forms.Button btnMostrar;
    private System.Windows.Forms.DataGridView grdCliente;
  }
}