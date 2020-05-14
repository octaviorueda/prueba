using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ENTITY;

namespace DAL
{
    public class LiquidacionPredioRepository
    {
         private List<liquidacionPredio> liquidacionPredios;
        private string ruta = @"Parcial.txt";

        public LiquidacionPredioRepository()
        {
            liquidacionPredios = new List<liquidacionPredio>();
        }

        public void Guardar(liquidacionPredio liquidacionPredio) 
        {
            FileStream file = new FileStream(ruta,FileMode.Append);
            StreamWriter writer = new StreamWriter(file);
            writer.WriteLine($"{liquidacionPredio.Identificacion};{liquidacionPredio.NombrePropietario};{liquidacionPredio.CategoriaPredio};{liquidacionPredio.Estrato};{liquidacionPredio.Avaluo};{liquidacionPredio.Tarifa};{liquidacionPredio.NumeroLiquidacion};{liquidacionPredio.ValorImpuesto}");
            writer.Close();
            file.Close();
        }

        public List<liquidacionPredio> Consultar() 
        {
            string linea = string.Empty;
            FileStream file = new FileStream(ruta, FileMode.OpenOrCreate);
            StreamReader reader = new StreamReader(file);
            liquidacionPredio liquidacionPredio;
            while ((linea = reader.ReadLine()) != null)
            {
                char delimiter = ';';
                string[] Datos = linea.Split(delimiter);
                if (Datos[2].Equals("rural"))
                {
                    liquidacionPredio = new LiquidacionRural();
                }
                else
                {
                    liquidacionPredio = new LiquidacionUrbana();  
                }
                liquidacionPredio.Identificacion = Datos[0];
                liquidacionPredio.NombrePropietario = Datos[1];
                liquidacionPredio.CategoriaPredio = Datos[2];
                liquidacionPredio.Estrato = Convert.ToInt32(Datos[3]);
                liquidacionPredio.Avaluo = Convert.ToInt64(Datos[4]);
                liquidacionPredio.Tarifa = Convert.ToInt64(Datos[5]);
                liquidacionPredio.NumeroLiquidacion = Datos[6];
                liquidacionPredio.ValorImpuesto = Convert.ToInt64(Datos[7]);

                liquidacionPredios.Add(liquidacionPredio);
            }
            reader.Close();
            file.Close();

            return liquidacionPredios;
        }


        public void Eliminar(string numeroliquidacion) 
        {
            liquidacionPredios = Consultar();
            FileStream fileStream = new FileStream(ruta, FileMode.Create);
            fileStream.Close();
            foreach (var lista in liquidacionPredios)
            {
                if (lista.NumeroLiquidacion != lista.NumeroLiquidacion )
                {
                    Guardar(lista);

                }

            }
        
        }

        public void Modificar(liquidacionPredio liquidacion)
        {
            liquidacionPredios = Consultar();

            FileStream fileStream = new FileStream(ruta, FileMode.Create);
            fileStream.Close();

            foreach (var item in liquidacionPredios)
            {
                if (item.NumeroLiquidacion.Equals(liquidacion.NumeroLiquidacion))
                {
                    Guardar(liquidacion);
                }
                else
                {
                    Guardar(item);
                }
            }
        }
        public liquidacionPredio Buscar(string numeroLiquidacion)
        {
            liquidacionPredios = Consultar();

            foreach (var item in liquidacionPredios)
            {
                if (item.NumeroLiquidacion.Equals(numeroLiquidacion))
                {
                    return item;
                }
            }

            return null;
        }






    }
}
