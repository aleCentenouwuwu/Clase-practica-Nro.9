
using System;
using System.Linq.Expressions;

namespace ReservacionHotel
{
    class Program
    {
        static void Main (string[] args)
        {
            ReservacionHotel reservacion = new ReservacionHotel();
            bool Salir = false;
            do
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("----------Elija una opcion----------");
                    Console.WriteLine("");
                    Console.WriteLine("1.     Hacer reservacion");
                    Console.WriteLine("2.     Cancelar reservacion");
                    Console.WriteLine("3.     Mostrar reservacion");
                    Console.WriteLine("4.     Salir");
                    Console.WriteLine("------------------------------------");
                    byte opc = Convert.ToByte(Console.ReadLine());

                    switch (opc)
                    {
                        case 1:
                            Console.Clear();
                            if (reservacion.nombre != default && reservacion.numeroHabitacion != default)
                            {
                                Console.WriteLine("Usted ya realizo una reservacion");
                            }
                            else
                            {  
                                reservacion.HacerReservacion();
                            }
                              
                            Console.ReadKey();
                            break;
                        case 2:
                            Console.Clear();
                            if (reservacion.nombre != default && reservacion.numeroHabitacion != default)
                            { 
                                reservacion.CancelarReservacion();
                            }
                            else
                            {
                                Console.WriteLine("Lo sentimos! no encontramos ninguna reservacion a su nombre");
                            }
                           
                            Console.ReadKey();
                            break;
                        case 3:
                            Console.Clear();
                            if (reservacion.nombre != default && reservacion.numeroHabitacion != default)
                            {
                                reservacion.MostrarReservacion();
                            }
                            else
                            {
                                Console.WriteLine("Lo sentimos! no encontramos ninguna reservacion a su nombre");
                            }
                            Console.ReadKey();
                            break;
                        case 4:
                            Console.Clear();
                            Salir = true;
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Error! Valor invalido");
                            Console.ReadKey();
                            break;
                    }
                }
                catch (OverflowException)
                {
                    Console.Clear();
                    reservacion.nombre = default;
                    reservacion.numeroHabitacion = default;
                    Console.WriteLine("Error! Valor invalido");
                    Console.ReadKey();
                }
                catch (FormatException)
                {
                    reservacion.nombre = default;
                    reservacion.numeroHabitacion = default;
                    Console.Clear();
                    Console.WriteLine("Error! Valor invalido");
                    Console.ReadKey();
                }
            } while (!Salir);
            
        }
    }
}