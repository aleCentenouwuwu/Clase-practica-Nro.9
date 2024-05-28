using System;

namespace Ejercicio2
{
    internal class Ejercicio2
    {
        static void Main()
        {
            Biblioteca Alexandría = new Biblioteca();
            bool salir = false;

            do
            {
                Console.WriteLine("Buenos dias, en que le puedo ayudar");
                Console.WriteLine("1. Buscar un libro");
                Console.WriteLine("2. Devolver un libro");
                Console.WriteLine("3. Salir");

                byte opc = Convert.ToByte(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Digite el nombre del libro a buscar");

                        Alexandría.libro = Console.ReadLine();

                        bool Disponible = Convert.ToBoolean(Alexandría.Consultar());

                        if (Disponible == true)
                        {
                            Console.WriteLine("Quiere prestar el libro");
                            Console.WriteLine("1. Si");
                            Console.WriteLine("2. No");

                            byte opc2 = Convert.ToByte(Console.ReadLine());

                            switch (opc2)
                            {
                                case 1:
                                    Console.WriteLine("Digite su nombre");

                                    Alexandría.usuario = Console.ReadLine();

                                    Alexandría.Prestar();
                                    break;
                                case 2:
                                    Console.WriteLine("Ok. Chao pescao");
                                    break;
                                default:
                                    Console.WriteLine("Opción Invalida");
                                    break;
                            }
                        }
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Digite su nombre");
                        string usuario = Console.ReadLine();

                        Console.WriteLine("Cual libro devolverá");
                        string libro = Console.ReadLine();

                        if (usuario == Alexandría.usuario && libro == Alexandría.libro)
                        {
                            if (Convert.ToBoolean(Alexandría.Devolver() == true))
                                {
                                Console.WriteLine("Libro devuelto");
                                Console.ReadKey();
                                Console.Clear();
                            }
                        }
                        break;
                    case 3:
                        salir = true;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Opción Invalida");
                        break;
                }
            } while (!salir);
        }
    }
}