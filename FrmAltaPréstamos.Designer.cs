namespace Préstamos {
  partial class FrmAltaPréstamos {
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
      this.dtpFecha = new System.Windows.Forms.DateTimePicker();
      this.btnAlta = new System.Windows.Forms.Button();
      this.comboBox1 = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.btnCalculaPago = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // dtpFecha
      // 
      this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.dtpFecha.Location = new System.Drawing.Point(55, 88);
      this.dtpFecha.Name = "dtpFecha";
      this.dtpFecha.Size = new System.Drawing.Size(200, 20);
      this.dtpFecha.TabIndex = 0;
      // 
      // btnAlta
      // 
      this.btnAlta.Enabled = false;
      this.btnAlta.Location = new System.Drawing.Point(347, 33);
      this.btnAlta.Name = "btnAlta";
      this.btnAlta.Size = new System.Drawing.Size(91, 22);
      this.btnAlta.TabIndex = 1;
      this.btnAlta.Text = "Alta";
      this.btnAlta.UseVisualStyleBackColor = true;
      this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
      // 
      // comboBox1
      // 
      this.comboBox1.FormattingEnabled = true;
      this.comboBox1.Location = new System.Drawing.Point(134, 33);
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new System.Drawing.Size(121, 21);
      this.comboBox1.TabIndex = 2;
      this.comboBox1.Visible = false;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(52, 36);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(42, 13);
      this.label1.TabIndex = 3;
      this.label1.Text = "Cliente:";
      this.label1.Visible = false;
      // 
      // btnCalculaPago
      // 
      this.btnCalculaPago.Location = new System.Drawing.Point(83, 143);
      this.btnCalculaPago.Name = "btnCalculaPago";
      this.btnCalculaPago.Size = new System.Drawing.Size(124, 27);
      this.btnCalculaPago.TabIndex = 4;
      this.btnCalculaPago.Text = "Calcula pago mensual";
      this.btnCalculaPago.UseVisualStyleBackColor = true;
      this.btnCalculaPago.Click += new System.EventHandler(this.btnCalculaPago_Click);
      // 
      // FrmAltaPréstamos
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(534, 295);
      this.Controls.Add(this.btnCalculaPago);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.comboBox1);
      this.Controls.Add(this.btnAlta);
      this.Controls.Add(this.dtpFecha);
      this.Name = "FrmAltaPréstamos";
      this.Text = "Alta de préstamos";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DateTimePicker dtpFecha;
    private System.Windows.Forms.Button btnAlta;
    private System.Windows.Forms.ComboBox comboBox1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnCalculaPago;
  }
}