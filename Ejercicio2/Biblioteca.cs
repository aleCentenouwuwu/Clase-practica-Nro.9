using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    public class Biblioteca
    {
        //Atributos

        public string usuario;
        public string libro;

        //Matrix            Libro                       Estado      
        string[,] Libros = { {"Cien anos de soledad", "Libre" },{"Kimetsu no Yaiba","Libre"}};

        //Acciones
        public bool Consultar()
        {
            for (int i = 0; i < 2; i++)
            {
                if (Libros[i, 0] == libro && Libros[i, 1] == "Libre")
                {
                    Console.WriteLine("Libro Disponible");
                    return true;
                }
                else
                {
                    Console.WriteLine("Libro Indisponible");
                    break;
                }
            }
            return false;
        }
        public void Prestar()
        {
            for (int i = 0; i < 2; i++)
            {
                if (Libros[i, 0] == libro)
                {
                    Libros[i, 1] = "Prestado";
                }
            }
        }
        public void Devolver()
        {
            for (int i = 0; i < 2; i++)
            {
                if (Libros[i, 0] == libro)
                {
                    Libros[i, 1] = "Libre";
                }
            }
        }
    }
}

