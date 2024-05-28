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

        //Matrices   
        string[] Libros = {"Laurel", "Azul", "Biblia", "Diccionario", "Buscando sentido"};
        bool[] Disponible = { true, true, true, true, true };
        string[] Usuarios = { "", "", "", "", "" };


        //Acciones
        public bool Consultar()
        {
            bool disponible1 = false;
            for (int i = 0; i < Libros.Length; i++)
            {
                if (Libros[i] == libro && Disponible[i] == true)
                {
                    Console.WriteLine("Libro Disponible");
                    return true;
                }
                else
                {
                    disponible1 = false;
                }
            }
            if (disponible1 == false)
            {
                Console.WriteLine("Libro Inexistente");
            }
            return false;
        }
        public void Prestar()
        {
            for (int i = 0; i < 2; i++)
            {
                if (Libros[i] == libro)
                {
                    Disponible[i] = false;
                }
                Usuarios[i] = usuario;
                
            }
            Console.WriteLine("Libro prestado");
            Console.ReadKey();
            Console.Clear();
        }
        public bool Devolver()
        {
            bool coincideUsuario = true;
            bool coincideLibro = true;

            for (int i = 0; i < Libros.Length; i++)
            {
                if (Libros[i] == libro && Usuarios[i] == usuario)
                {
                    Disponible[i] = true;
                    return true;
                }
                if (Usuarios[i] != usuario)
                {
                    coincideUsuario = false;
                }
                if (Libros[i] != libro)
                {
                    coincideLibro = false;
                }
            }
            if (coincideLibro == false)
            {
                Console.WriteLine("Usted no prestó ese libro");
            }
            if (coincideUsuario == false)
            {
                Console.WriteLine("Los usuarios no coiciden");
            }
            return false;
        }
    }
}