using System;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main()
        {
            Biblioteca Alexandría = new Biblioteca();

            Console.WriteLine("Buenos dias, en que le puedo ayudar");
            Console.WriteLine("1. Buscar un libro");
            Console.WriteLine("2. Devolver un libro");

            byte opc = Convert.ToByte(Console.ReadLine());

            switch (opc)
            {
                case 1:
                    Console.WriteLine("Que libro quiere prestar");
                    Alexandría.libro = Console.ReadLine();

                    bool Disponible = Convert.ToBoolean(Alexandría.Consultar());
                    if (Disponible==true)
                    {
                        Console.WriteLine("Quiere prestar el libro");
                        Console.WriteLine("1. Si");
                        Console.WriteLine("2. No");
                        byte opc2= Convert.ToByte(Console.ReadLine());
                        switch (opc2)
                        {
                            case 1:
                                Console.WriteLine("Digite su nombre");
                                Alexandría.usuario = Console.ReadLine();
                                Alexandría.Prestar();
                                break;
                            case 2:
                                Console.WriteLine("A, ok. Chao pescao");
                                break;
                            default:
                                Console.WriteLine("Opción Invalida");
                                break;
                        }
                    }
                    break;
                case 2:
                    Console.WriteLine("Cual es su nombre");
                    string usuario = Console.ReadLine();

                    Console.WriteLine("Cual libro devolverá");
                    string libro = Console.ReadLine();

                    if (usuario == Alexandría.usuario&& libro == Alexandría.libro)
                    {
                        Alexandría.Devolver();
                    }
                    break;
                default:
                    Console.WriteLine("Opción Invalida");
                    break;
            }
            Console.ReadKey();
        }
    }
}