using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;
using BLL;

namespace Parcial
{
    class Program
    {
        static void Main(string[] args)
        {
            liquidacionPredio liquidacionPredio ;
            int opcion;
            do
            {
                Console.Write("digite la opcion deseada");
                Console.Write("1.registar");
                Console.Write("2.consultar");
                Console.Write("3.eliminar");
                Console.Write("4.modificar");
                Console.Write("5.salir");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:

                      
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    default:
                        break;
                }

            } while (opcion !=5);
            Console.ReadKey();
               
            
        }
    }
}
