using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoConsumoEnergia
{
    internal class ConsumoEnergia
    {
        public double FaseUno { get; set; }
        public double FaseDos { get; set; }
        public double FaseDCinco { get; set; }
        public double PrecioKw { get; set; }

        public double ConsumoTotalEnergia { get; set; }



       public void CalculoConsumoEnergia(double faseUno, double FaseDos, double FaseD5)
        {
            double ConsTotal = faseUno + FaseDos + FaseD5;
            ConsumoTotalEnergia = ConsTotal;
          
        }

    }

   

}
