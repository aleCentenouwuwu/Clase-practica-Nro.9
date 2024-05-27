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
                        ReservacionHotel Hacer = new ReservacionHotel();
                        Hacer.HacerReservacion();
                        Hacer.nombre = "Norvin";
                        Hacer.numerohabitacion =1;
                        break;
                    case 2:
                        Console.Clear();
                        ReservacionHotel Consultar = new ReservacionHotel();
                        //Consultar.ConsultarReservacion();
                        break;
                    case 3:
                        Console.Clear();
                        ReservacionHotel Cancelar = new ReservacionHotel();
                        Cancelar.CancelarReservacion();
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
