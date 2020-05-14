using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class LiquidacionUrbana : liquidacionPredio
    {
        public double CalcularTarifa(int estrato) 
        {
            if (estrato == 1)
            {
                Tarifa = 0.002;
                return Tarifa;
            }
            else if (estrato>=2 || estrato<=3 )
            {
                Tarifa = 0.003;
            }
            Tarifa = 0.003;
            return Tarifa;
        }
        public override void CalcularValorImpuesto(long avaluo)
        {
            ValorImpuesto = avaluo * CalcularTarifa(Estrato);
        }
    }
}
