using System;

namespace KV.DelegateEvent
{
    class Program
    {
        static void Main(string[] args)
        {
            Figura Minhafigura = new Figura(10, 20, 30);

            Figura.Invertido += OnFiguraInvertida;

            Minhafigura.InverterX();

            Console.WriteLine("\r\n");

            Minhafigura.InverterZ();
        }

        private static void OnFiguraInvertida(string msg)
        {
            Console.WriteLine("A figura foi {0}", msg);
        }
    }
}