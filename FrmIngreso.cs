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
  public partial class FrmIngreso : Form {

    //Variables de clase.
    GestorBD.GestorBD GestorBD;   //Para manejarbla BD.
    DataSet DsGeneral = new DataSet();
    string cadSql, rfc;

    public FrmIngreso() {
      InitializeComponent();
    }

    private void txtUsuario_TextChanged(object sender, EventArgs e) {

    }

    //Acciones iniciales.
    private void FrmIngreso_Load(object sender, EventArgs e) {

      GestorBD = new GestorBD.GestorBD("SQLNCLI11", "localhost",
        "sa", "sqladmin", "Préstamos");
    }

    //Valida que el usuario y contraseña coincidan.
    private void btnIngresar_Click(object sender, EventArgs e) {

      cadSql = "select * from Clientes where Rfc='"+txtUsuario.Text+"' "+
        "and Contraseña='"+txtContra.Text+"'";
      GestorBD.consBD(cadSql, DsGeneral, "Temp");

      //Verifica si el usuario existe.
      if (DsGeneral.Tables["Temp"].Rows.Count != 0) {
        rfc = txtUsuario.Text;
        FrmMenúGeneral fm = new FrmMenúGeneral(GestorBD,rfc);     //Sí existe.
        fm.ShowDialog();
      }
      else {
        MessageBox.Show("El usuario no existe");
        txtUsuario.Focus();
      }
    }

  }
}









