using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class LiquidacionRural : liquidacionPredio
    {
        public LiquidacionRural()
        {
            Estrato = 0;
            Tarifa = 0.002;
        }
        public override void CalcularValorImpuesto(long avaluo)
        {
            Avaluo = avaluo;
            ValorImpuesto = avaluo * Tarifa ;

        }

       
    }
}
