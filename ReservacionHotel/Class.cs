using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservacionHotel
{
    public class ReservacionHotel
    {
        public string nombre;
        public int numerohabitacion;
        public void HacerReservacion()
        {
            Console.WriteLine("Ingrese su nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Que habitacion desea reservar?");
            numerohabitacion =Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Su reservacion se ha realizado con exito");
            Console.ReadKey();
        }
        public void CancelarReservacion()
        {
           
            Console.WriteLine(">> Cancelar reservacion");
            Console.WriteLine("¿Su reservación es la siguiente?");
            Console.WriteLine($"Nombre del huesped: {this.nombre}.");
            Console.WriteLine($"Numero habitacion: {this.numerohabitacion}");
            Console.WriteLine("");
            Console.WriteLine("1. Si");
            Console.WriteLine("2. No");
            int opc =Convert.ToInt32(Console.ReadLine());
            if (opc ==1)
            {
                Console.Clear();
                Console.WriteLine("Desea cancelar su reservacion? ");
                Console.WriteLine("");
                Console.WriteLine("1. Si");
                Console.WriteLine("2. No");
                byte opcion =Convert.ToByte(Console.ReadLine());
                if (opcion ==1)
                {
                    Console.Clear();
                    Console.WriteLine("Su reservacion se ha cancelado con exito");
                    Console.ReadKey();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Su reservacion sigue activa, gracias por darnos plata.");
                    Console.ReadKey();
                }

            }
            else
            {
                Console.Clear();
                Console.WriteLine("oki, bye :33");
                Console.ReadKey();
            }
        }
        public void ConsultarReservacion(bool Verificacion)
        {
            if(Verificacion == true)
            {
                Console.WriteLine($"La habitacion {numerohabitacion} esta reservada por {nombre}");

            }
            else
            {
                Console.WriteLine("No hay reservacion a su nombre");
            }
          
        }
    }
}
