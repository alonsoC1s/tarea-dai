using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualBasic;
using System.Text;
using System.Threading.Tasks;

namespace Préstamos {
  class Fórmulas {
    //La función devuelve el pago mensual de un préstamo a un
    //peíodo establecido.
    public double mensualidad(double tasa, int plazo, double monto) {
      double tasaMensual, pagoMes;
      int plazoMeses;

      tasaMensual = (tasa / 100) / 12;  //Tasa mensual en decimales.
      plazoMeses = plazo * 12;        //Plazo total en meses.
      pagoMes = Financial.Pmt(tasaMensual, plazoMeses, -monto);
      return pagoMes;       //Regresa el pago mensual del préstamo.
    }
  }
}
