using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            //int numero1;
            //int numero2;
            //int numero3 = 3;
            //int numero4 = numero1 + numero2 + numero3;
            //Console.WriteLine(numero4);

            //2
            Console.WriteLine("Introduzca un numero");
            var numero1 = Console.ReadLine();
            Console.WriteLine("Introduzca otro numero");
            var numero2 = Console.ReadLine();
            if (int.Parse(numero1) < int.Parse(numero2))
            {
                Console.WriteLine("El numero mayor es el numero 2, que vale: " + numero2);
            }
            else
            {
                Console.WriteLine("El numero mayor es el numero 1, que vale: " + numero1);
            }

            //
            //string dia = Console.ReadLine();
            //string dia2 = Console.ReadLine();
            //if (dia == "lunes" || dia == "martes" || dia == "miercoles" || dia == "jueves" || dia == "viernes")
            //{
            //    Console.Write("No es fin de semana");
            //}
            //else
            //{
            //    if (dia == "sabado" || dia == "domingo")
            //    {
            //        Console.Write("Es fin de semana");
            //    }
            //    else
            //    {
            //        Console.Write("Ingrese un dia correcto");
            //    }
            //}
            //for (int i = 0; i < 100; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
        }
    }
}
