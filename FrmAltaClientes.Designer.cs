namespace Préstamos {
  partial class FrmAltaClientes {
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
      this.txtRFC = new System.Windows.Forms.TextBox();
      this.txtContra = new System.Windows.Forms.TextBox();
      this.txtNom = new System.Windows.Forms.TextBox();
      this.txtDom = new System.Windows.Forms.TextBox();
      this.txtTel = new System.Windows.Forms.TextBox();
      this.btnAlta = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // txtRFC
      // 
      this.txtRFC.Location = new System.Drawing.Point(124, 42);
      this.txtRFC.Name = "txtRFC";
      this.txtRFC.Size = new System.Drawing.Size(100, 20);
      this.txtRFC.TabIndex = 0;
      this.txtRFC.Text = "RFC";
      // 
      // txtContra
      // 
      this.txtContra.Location = new System.Drawing.Point(124, 87);
      this.txtContra.Name = "txtContra";
      this.txtContra.Size = new System.Drawing.Size(100, 20);
      this.txtContra.TabIndex = 1;
      this.txtContra.Text = "Contraseña";
      // 
      // txtNom
      // 
      this.txtNom.Location = new System.Drawing.Point(124, 136);
      this.txtNom.Name = "txtNom";
      this.txtNom.Size = new System.Drawing.Size(100, 20);
      this.txtNom.TabIndex = 2;
      this.txtNom.Text = "Nombre";
      // 
      // txtDom
      // 
      this.txtDom.Location = new System.Drawing.Point(124, 191);
      this.txtDom.Name = "txtDom";
      this.txtDom.Size = new System.Drawing.Size(100, 20);
      this.txtDom.TabIndex = 3;
      this.txtDom.Text = "Domicilio";
      // 
      // txtTel
      // 
      this.txtTel.Location = new System.Drawing.Point(124, 245);
      this.txtTel.Name = "txtTel";
      this.txtTel.Size = new System.Drawing.Size(100, 20);
      this.txtTel.TabIndex = 4;
      this.txtTel.Text = "Teléfono";
      // 
      // btnAlta
      // 
      this.btnAlta.Location = new System.Drawing.Point(302, 239);
      this.btnAlta.Name = "btnAlta";
      this.btnAlta.Size = new System.Drawing.Size(136, 25);
      this.btnAlta.TabIndex = 5;
      this.btnAlta.Text = "Alta del cliente";
      this.btnAlta.UseVisualStyleBackColor = true;
      this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
      // 
      // FrmAltaClientes
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(524, 375);
      this.Controls.Add(this.btnAlta);
      this.Controls.Add(this.txtTel);
      this.Controls.Add(this.txtDom);
      this.Controls.Add(this.txtNom);
      this.Controls.Add(this.txtContra);
      this.Controls.Add(this.txtRFC);
      this.Name = "FrmAltaClientes";
      this.Text = "Alta de un cliente";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtRFC;
    private System.Windows.Forms.TextBox txtContra;
    private System.Windows.Forms.TextBox txtNom;
    private System.Windows.Forms.TextBox txtDom;
    private System.Windows.Forms.TextBox txtTel;
    private System.Windows.Forms.Button btnAlta;
  }
}