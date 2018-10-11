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

  public partial class FrmMenúGeneral : Form {
    //Variables de clase.
    GestorBD.GestorBD GestorBD;
    string rfc;
    
    public FrmMenúGeneral(GestorBD.GestorBD GestorBD, string rfc) {
      InitializeComponent();

      this.GestorBD = GestorBD;
      this.rfc = rfc;
      if (rfc == "ger") {
        MnuAltaClientes.Enabled = true;
        MnuAltaPréstamos.Enabled = true;
      }
      else {
        MnuAltaClientes.Enabled = false;
        MnuAltaPréstamos.Enabled = false;
      }
    }

    //Termina la aplicación.
    private void MnuCerrar_Click(object sender, EventArgs e) {
      Application.Exit();
    }

    //Abre la forma de alta de clientes.
    private void MnuAltaClientes_Click(object sender, EventArgs e) {

      FrmAltaClientes fac = new FrmAltaClientes(GestorBD);
      fac.ShowDialog();
    }

    //Abre la forma de consulta de clientes.
    private void MnuConsultaClientes_Click(object sender, EventArgs e) {

      FrmConsClientes fcc = new FrmConsClientes(GestorBD,rfc);
      fcc.ShowDialog();
    }

    //Abre la forma de alta de préstamos.
    private void MnuAltaPréstamos_Click(object sender, EventArgs e) {
      FrmAltaPréstamos fap = new FrmAltaPréstamos(GestorBD);
      fap.ShowDialog();
    }

    private void btnConPrestam_Click(object sender, EventArgs e) {
            FrmConsultaPréstamos fcp = new FrmConsultaPréstamos(GestorBD, rfc);
            fcp.ShowDialog(); 
    }
    }
}
