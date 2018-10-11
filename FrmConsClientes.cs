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
  public partial class FrmConsClientes : Form {
    //Variables de clase.
    GestorBD.GestorBD GestorBD;
    DataSet DsGeneral = new DataSet();  //Guarda resultado de cons.
    string rfc, cadSql;
    Comunes cm = new Comunes();

    public FrmConsClientes(GestorBD.GestorBD GestorBD, string rfc) {
      InitializeComponent();

      this.GestorBD = GestorBD;
      this.rfc = rfc;

      //Si es el gerente, puede ver a todos los clientes.
      if (rfc=="ger") {
        label1.Visible = true; cboCliente.Visible = true;

        //Lee a todos los clientes.
        cadSql = "select * from Clientes where rfc!='ger'";
        GestorBD.consBD(cadSql, DsGeneral, "Clientes");
        cm.cargaCombo(cboCliente, DsGeneral, "Clientes", "Rfc");
      }
      else {
        label1.Visible = false; cboCliente.Visible = false;
      }
    }

    //Se toma el rfc del cliente elegido en el combo por el gerente.
    private void cboCliente_SelectedIndexChanged(object sender, EventArgs e) {
      rfc = cboCliente.Text;
    }

    //Se muestran los datos del cliente
    private void btnMostrar_Click(object sender, EventArgs e) {

      cadSql = "select * from Clientes where rfc='" + rfc + "'";
      GestorBD.consBD(cadSql, DsGeneral, "Cliente");

      //Muestra los datos en el grid.
      grdCliente.DataSource = DsGeneral.Tables["Cliente"];
    }


  }
}










