using System;

namespace CoreEscuela
{
    class Escuela
    {
        public string nombre;
        public string direccion;
        public int añoFundacion;
        public string ceo="Freddy Vega";

        public void Timbrar()
        {
            Console.Beep(2000,3000);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var miEscuela = new Escuela();
            miEscuela.nombre="UBAM";
            miEscuela.direccion="Teoloyucan Edo. México";
            miEscuela.añoFundacion=1978;
            Console.WriteLine("Timbrando");
            miEscuela.Timbrar();
            //Console.WriteLine("Hello World!");
        }
    }
}
