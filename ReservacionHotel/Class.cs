
using System;

namespace ReservacionHotel
{
    public class ReservacionHotel
    {
        public string nombre;
        public int numeroHabitacion;

        public void HacerReservacion()
        {
            Console.WriteLine("----------Hacer una reservacion----------");
            Console.WriteLine("");
            Console.WriteLine("-Ingrese su nombre-");
            nombre = Console.ReadLine();

            Console.WriteLine("");
            Console.WriteLine("-Ingrese el numero de habitacion-");
            numeroHabitacion = Convert.ToInt32(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("Su reservacion se ha realizado con exito");
        }
        public void CancelarReservacion()
        {
            Console.WriteLine("------Su reservacion es la siguiente?------");
            Console.WriteLine("");
            Console.WriteLine($"Nombre de huesped: {nombre}");
            Console.WriteLine($"Numero de habitacion {numeroHabitacion}");
            Console.WriteLine("");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("1. Si");
            Console.WriteLine("2. No");
            byte opc = Convert.ToByte(Console.ReadLine());

            if( opc == 1 ) 
            {
                Console.Clear();
                Console.WriteLine("Desea cancelar la reservacion?");
                Console.WriteLine("");
                Console.WriteLine("1. Si");
                Console.WriteLine("2. No");
                byte opc2 = Convert.ToByte(Console.ReadLine());

                if(opc2 == 1)
                {
                    //Un "default" como valor de una variable refleja su estado original
                    //En caso de que se le asigne a una variable int, esta obtendra el valor de 0
                    nombre = default;
                    numeroHabitacion = default;

                    Console.Clear();
                    Console.WriteLine("Su cancelacion se ha realizado con exito");
                }
                else if (opc2 == 2)
                {
                    Console.Clear();
                    Console.WriteLine("...");
                }
                else
                {
                    Console.WriteLine("Opcion invalida");
                }
            }
            else if ( opc == 2 )
            {
                Console.Clear();
                Console.WriteLine("...");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Opcion invalida");
            }

        }
        public void MostrarReservacion()
        {
            Console.WriteLine("---------------Reservacion-----------------");
            Console.WriteLine("");
            Console.WriteLine($"Nombre de huesped: {nombre}");
            Console.WriteLine($"Numero de habitacion: {numeroHabitacion}");
            Console.WriteLine("");
            Console.WriteLine("-------------------------------------------");
        }
    }
}