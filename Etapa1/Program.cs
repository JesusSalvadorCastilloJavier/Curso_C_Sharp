using System;
using CoreEscuela.Entidades;
namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var Escuela = new Escuela("UBAM",1976);
            Escuela.Pais="México";
            Escuela.Ciudad="México";
            Escuela.TipoEscuela=TiposEscuela.Secundaria;
            Console.WriteLine(Escuela);
        }
    }
}
