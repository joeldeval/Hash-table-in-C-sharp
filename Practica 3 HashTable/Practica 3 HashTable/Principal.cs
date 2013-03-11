using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practica_3_HashTable
{
    class Principal
    {
        static void Main(string[] args)
        {
            Programa programa = new Programa();
            programa.Captura();
            Console.Clear();
            programa.editar();
            Console.Clear();
            programa.eliminar();
            Console.Clear();
            programa.imprimirTodos();
            Console.WriteLine("PRESIONA ENTER Y PODRAS SALIR");
            Console.ReadLine();
        }
    }
}
