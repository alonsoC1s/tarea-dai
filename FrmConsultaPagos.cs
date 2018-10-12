using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Préstamos
{
    public partial class FrmConsultaPagos: Form
    {
        //Atributos 
        string rfc;
        GestorBD.GestorBD gestorLocal;
        string queryStr;
        DataSet generalDataV = new DataSet(); 
    
        public FrmConsultaPagos(GestorBD.GestorBD gestor, string rfc){
            InitializeComponent();

            this.gestorLocal = gestor;
            this.rfc = rfc; 

            //Privilegios 
            if (this.rfc == "ger")
            {
                this.queryStr = "select * from Pagos";
            }
            else
            {
                this.queryStr = "select * from Pagos where rfc= '" + this.rfc + "'";
            }

            gestorLocal.consBD(this.queryStr, generalDataV, "Pagos");

            dGVPagos.DataSource = generalDataV.Tables["Pagos"]; 
        }
    }
}
