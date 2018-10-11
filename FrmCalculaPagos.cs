using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Préstamos {
  public partial class FrmCalculaPagos : Form {
    public FrmCalculaPagos() {
      InitializeComponent();
    }
    //Variables de clase.
    int plazo;      //Plazo del préstamo en años.
    double pagoMensual;   //Pago mensual del préstamo.
    double pagoTotal;     //Pago total del prétamo.
    Fórmulas f = new Fórmulas();

    //Propiedades de la clase.
    //Ejemplo: se define una propiedad para el monto.
    private double propMonto;
    public double Monto {
      get { return Convert.ToDouble(txtMonto.Text); }
      set { propMonto = Convert.ToDouble(txtMonto.Text); }
    }

    //Acciones iniciales.
    private void FrmCalculaPagos_Load(object sender, EventArgs e) {

      //Valores default.
      txtMonto.Text = "5,000.00";
      cboTasa.Text = "10.0";
      radioButton1.Checked = true;
      plazo = 1;
    }

    //Establece el plazo según el botón elegido.
    private void radioButton1_CheckedChanged(object sender, EventArgs e) {
      plazo = 1;
    }
    private void radioButton2_CheckedChanged(object sender, EventArgs e) {
      plazo = 3;
    }
    private void radioButton3_CheckedChanged(object sender, EventArgs e) {
      plazo = 5;
    }
    private void radioButton4_CheckedChanged(object sender, EventArgs e) {
      plazo = 10;
    }

    //Calcula el pago mensual del préstamo.
    private void btnMensual_Click(object sender, EventArgs e) {

      pagoMensual = f.mensualidad(Convert.ToDouble(cboTasa.Text),
        plazo, Convert.ToDouble(txtMonto.Text));
      MessageBox.Show("Pago mensual: " + pagoMensual.ToString("c"));
      btnTotal.Enabled = true;
    }

    //Calcula el total a pagar del préstamo.
    private void btnTotal_Click(object sender, EventArgs e) {

      pagoTotal = pagoMensual * 12 * plazo;
      MessageBox.Show("Pago total: " + pagoTotal.ToString("c"));
    }
  }
}













