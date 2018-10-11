namespace Préstamos {
  partial class FrmCalculaPagos {
    /// <summary>
    /// Variable del diseñador necesaria.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Limpiar los recursos que se estén usando.
    /// </summary>
    /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Código generado por el Diseñador de Windows Forms

    /// <summary>
    /// Método necesario para admitir el Diseñador. No se puede modificar
    /// el contenido de este método con el editor de código.
    /// </summary>
    private void InitializeComponent() {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCalculaPagos));
      this.label1 = new System.Windows.Forms.Label();
      this.txtMonto = new System.Windows.Forms.TextBox();
      this.btnMensual = new System.Windows.Forms.Button();
      this.btnTotal = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.cboTasa = new System.Windows.Forms.ComboBox();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.radioButton1 = new System.Windows.Forms.RadioButton();
      this.radioButton2 = new System.Windows.Forms.RadioButton();
      this.radioButton3 = new System.Windows.Forms.RadioButton();
      this.radioButton4 = new System.Windows.Forms.RadioButton();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(106, 62);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(141, 17);
      this.label1.TabIndex = 0;
      this.label1.Text = "M;onto del préstamo:";
      // 
      // txtMonto
      // 
      this.txtMonto.Location = new System.Drawing.Point(293, 63);
      this.txtMonto.Name = "txtMonto";
      this.txtMonto.Size = new System.Drawing.Size(138, 22);
      this.txtMonto.TabIndex = 1;
      // 
      // btnMensual
      // 
      this.btnMensual.Location = new System.Drawing.Point(560, 53);
      this.btnMensual.Name = "btnMensual";
      this.btnMensual.Size = new System.Drawing.Size(164, 46);
      this.btnMensual.TabIndex = 2;
      this.btnMensual.Text = "Mensualidad";
      this.btnMensual.UseVisualStyleBackColor = true;
      this.btnMensual.Click += new System.EventHandler(this.btnMensual_Click);
      // 
      // btnTotal
      // 
      this.btnTotal.Enabled = false;
      this.btnTotal.Location = new System.Drawing.Point(560, 140);
      this.btnTotal.Name = "btnTotal";
      this.btnTotal.Size = new System.Drawing.Size(164, 46);
      this.btnTotal.TabIndex = 3;
      this.btnTotal.Text = "Total a pagar";
      this.btnTotal.UseVisualStyleBackColor = true;
      this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(116, 154);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(111, 17);
      this.label2.TabIndex = 4;
      this.label2.Text = "Tasa de interés:";
      // 
      // cboTasa
      // 
      this.cboTasa.FormattingEnabled = true;
      this.cboTasa.Items.AddRange(new object[] {
            "10.0",
            "12.0",
            "15.0",
            "20.0"});
      this.cboTasa.Location = new System.Drawing.Point(295, 148);
      this.cboTasa.Name = "cboTasa";
      this.cboTasa.Size = new System.Drawing.Size(136, 24);
      this.cboTasa.TabIndex = 5;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.radioButton4);
      this.groupBox1.Controls.Add(this.radioButton3);
      this.groupBox1.Controls.Add(this.radioButton2);
      this.groupBox1.Controls.Add(this.radioButton1);
      this.groupBox1.Location = new System.Drawing.Point(118, 246);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(189, 197);
      this.groupBox1.TabIndex = 6;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Plazo del préstamo:";
      // 
      // radioButton1
      // 
      this.radioButton1.AutoSize = true;
      this.radioButton1.Location = new System.Drawing.Point(21, 38);
      this.radioButton1.Name = "radioButton1";
      this.radioButton1.Size = new System.Drawing.Size(65, 21);
      this.radioButton1.TabIndex = 0;
      this.radioButton1.TabStop = true;
      this.radioButton1.Text = "1 año";
      this.radioButton1.UseVisualStyleBackColor = true;
      this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
      // 
      // radioButton2
      // 
      this.radioButton2.AutoSize = true;
      this.radioButton2.Location = new System.Drawing.Point(19, 75);
      this.radioButton2.Name = "radioButton2";
      this.radioButton2.Size = new System.Drawing.Size(72, 21);
      this.radioButton2.TabIndex = 1;
      this.radioButton2.TabStop = true;
      this.radioButton2.Text = "3 años";
      this.radioButton2.UseVisualStyleBackColor = true;
      this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
      // 
      // radioButton3
      // 
      this.radioButton3.AutoSize = true;
      this.radioButton3.Location = new System.Drawing.Point(19, 116);
      this.radioButton3.Name = "radioButton3";
      this.radioButton3.Size = new System.Drawing.Size(72, 21);
      this.radioButton3.TabIndex = 2;
      this.radioButton3.TabStop = true;
      this.radioButton3.Text = "5 años";
      this.radioButton3.UseVisualStyleBackColor = true;
      this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
      // 
      // radioButton4
      // 
      this.radioButton4.AutoSize = true;
      this.radioButton4.Location = new System.Drawing.Point(19, 157);
      this.radioButton4.Name = "radioButton4";
      this.radioButton4.Size = new System.Drawing.Size(80, 21);
      this.radioButton4.TabIndex = 3;
      this.radioButton4.TabStop = true;
      this.radioButton4.Text = "10 años";
      this.radioButton4.UseVisualStyleBackColor = true;
      this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
      this.pictureBox1.Location = new System.Drawing.Point(453, 247);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(282, 176);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pictureBox1.TabIndex = 7;
      this.pictureBox1.TabStop = false;
      // 
      // FrmCalculaPagos
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(813, 480);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.cboTasa);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.btnTotal);
      this.Controls.Add(this.btnMensual);
      this.Controls.Add(this.txtMonto);
      this.Controls.Add(this.label1);
      this.Name = "FrmCalculaPagos";
      this.Text = "Estimación de pagos de un préstamo";
      this.Load += new System.EventHandler(this.FrmCalculaPagos_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtMonto;
    private System.Windows.Forms.Button btnMensual;
    private System.Windows.Forms.Button btnTotal;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.ComboBox cboTasa;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.RadioButton radioButton4;
    private System.Windows.Forms.RadioButton radioButton3;
    private System.Windows.Forms.RadioButton radioButton2;
    private System.Windows.Forms.RadioButton radioButton1;
    private System.Windows.Forms.PictureBox pictureBox1;
  }
}

