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
        public FrmConsultaPréstamos(GestorBD.GestorBD GestorBD) {
            InitializeComponent();

            this.gestorLocal = GestorBD; 
        }

        private void label1_Click(object sender, EventArgs e) {

        }
    }
}
