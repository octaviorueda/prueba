using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;
using DAL;

namespace BLL
{
    public static  class LiquidacionPredioService
    {
        private static LiquidacionPredioRepository liquidacionPredioRepository = new LiquidacionPredioRepository();

        public static string  Guardar(liquidacionPredio liquidacionPredio) 
        {
            liquidacionPredioRepository.Guardar(liquidacionPredio);
            return "registro exitoso";
        }
        public static List<liquidacionPredio> Consultar() 
        {
            return liquidacionPredioRepository.Consultar();
        }

        public static string Eliminar(string numeroliquidacion) 
        {
            liquidacionPredioRepository.Eliminar(numeroliquidacion);

            return $"la liquidacion con el numero de indentificacio{numeroliquidacion} ha sido borrada";
        }

        public static void Modificar(liquidacionPredio liquidacionPredio) 
        {
            liquidacionPredioRepository.Modificar(liquidacionPredio);
        
        }

        public static void Buscar(string numeroliquidacion) 
        {
            liquidacionPredioRepository.Buscar(numeroliquidacion);
                       
        }


    }
}
