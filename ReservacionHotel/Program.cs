using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservacionHotel
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // El error es que creaban un objeto por cada accion, entonces recuerden que solo es un objeto 
            // es el que tiene su informacion, si crean otro este estara en blanco
            ReservacionHotel reservacion = new ReservacionHotel();  
            bool Salir = false;
            do
            {
                Console.WriteLine("-------Opciones de reservacion-------");
                Console.WriteLine("");
                Console.WriteLine("1. Hacer reservacion");
                Console.WriteLine("2. Consultar reservacion");
                Console.WriteLine("3. Cancelar reservacion");
                Console.WriteLine("4. Salir del menu");
                Console.WriteLine("-------------------------------------");
                byte opc = Convert.ToByte(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        Console.Clear();
                       
                        reservacion.HacerReservacion();
                       
                        break;
                    case 2:
                        Console.Clear();
                      
                        //Consultar.ConsultarReservacion();
                        break;
                    case 3:
                        Console.Clear();
                      
                        reservacion.CancelarReservacion();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("ly ");
                        Salir = true;
                        Console.ReadKey();
                        break;
                    default:
                        break;


                }
            } while (!Salir);
        }
    }
}
