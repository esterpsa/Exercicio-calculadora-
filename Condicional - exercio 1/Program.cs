using System;

namespace Condicional___exercio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = int.Parse(Console.ReadLine());
            int meses = (idade *12);
            int dias = idade * 365;
            int horas = dias * 24;
            int minuto = horas * 60;

            Console.WriteLine("digite a sua idade: ");
            idade= int.Parse(Console.ReadLine());

            System.Console.WriteLine("idade em meses:"+meses);
            System.Console.WriteLine("idade em dias:"+dias);
            System.Console.WriteLine("idade em horas:"+horas);
            System.Console.WriteLine("idade em minutos:"+minuto); 


        }
    }
}
