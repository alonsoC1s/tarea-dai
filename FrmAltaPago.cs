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
    public partial class FrmAltaPago : Form{
        // Atributos de clase +
        // Se asume que solo está disponible la opción disponible para administradores.

        string rfc;
        GestorBD.GestorBD gestorLocal;
        string queryStr;
        private const int OK = 1;

        public FrmAltaPago(GestorBD.GestorBD gestor, string rfc){
            InitializeComponent();

            this.gestorLocal = gestor;
            this.rfc = rfc;
            
        }

        private void btnIngresar_Click(object sender, EventArgs e){
            // Recuperamos datos 

 
           string monto = txtMonto.Text;
           string fecha = txtFecha.Text;

            Random rnd = new Random();
            int randint = rnd.Next(100);
            int nextranding = randint + 1;
            string randstring = randint.ToString() + "," + nextranding.ToString(); 

            this.queryStr = "insert into Pagos values (" +randstring +  ",'" + fecha + "' ," + monto + ");";
            Console.WriteLine(this.queryStr);

            if (gestorLocal.altaBD(queryStr) == OK){
                MessageBox.Show("Alta exitosa");
            }else{
                MessageBox.Show("Alta Fallida!!!!!!!!!!");
            }



        }
    }
}
