using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public  abstract class liquidacionPredio
    {
        public string Identificacion{ get; set; }
        public string NombrePropietario { get; set; }
        public string CategoriaPredio { get; set; }
        public int Estrato { get; set; }
        public long  Avaluo { get; set; }
        public double Tarifa { get; set; }
        public string NumeroLiquidacion { get; set; }
        public  double ValorImpuesto { get; set; }

        
        public abstract void CalcularValorImpuesto(long avaluo);


    }
}
