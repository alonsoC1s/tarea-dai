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
    public partial class FrmConsultaPréstamos : Form {

        // Atributos de clase 
        GestorBD.GestorBD gestorLocal;
        private DataSet DsGeneral = new DataSet();
        private const int OK = 1;
        private string rfc;           //El rfc del usuario.
        private string cadSql;


        public FrmConsultaPréstamos(GestorBD.GestorBD GestorBD, string rfc) {
            InitializeComponent();

            this.gestorLocal = GestorBD;
            this.rfc = rfc;

            //Checamos si es ger. 
            //Si no es ger, solo puede ver sus propios prestamos 
            if (rfc == "ger") {
                this.cadSql = "select * from Préstamos" ;
                gestorLocal.consBD(this.cadSql, DsGeneral, "Préstamos"); 
            }else {
                this.cadSql = "select * from Préstamos where rfc = ' " + this.rfc + " ' ";
                gestorLocal.consBD(this.cadSql, DsGeneral, "Préstamos");

            }

            //Muestra los datos en el grid.
            dataGVDatos.DataSource = DsGeneral.Tables["Préstamos"];
        }

        private void label1_Click(object sender, EventArgs e) {

        }
    }
}
