using System;

namespace tp_6_eje_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            string entrada, opcion;
            int num, num1, resul;
            num = 0;
            num1 = 0;
            resul = 0;

            Console.WriteLine("Escriba un numero entero");
            entrada = Console.ReadLine();
            num = Convert.ToInt32(entrada);

            Console.WriteLine("Escriba un numero entero");
            entrada = Console.ReadLine();
            num1 = Convert.ToInt32(entrada);

            Console.WriteLine("Que operacion desea realizar?");
            Console.WriteLine("1-si desea sumar ");
            Console.WriteLine("2-si desea restar");
            Console.WriteLine("3-si desea multiplicar");
            Console.WriteLine("4-si desea dividir");

            opcion = Console.ReadLine();
            switch (opcion)
            {
                case "1":
                    resul = num + num1;
                    Console.WriteLine("el resultado es " + resul);
                    break;
                case "2":
                    resul = num - num1;
                    Console.WriteLine("El resultado es " + resul);
                    break;
                case "3":
                    resul = num * num1;
                    Console.WriteLine("El resultado es " + resul);
                    break;
                case "4":
                    resul = num / num1;
                    Console.WriteLine("El resultado es " + resul);
                    break;
                default:
                    Console.WriteLine("ERROR");
                    break;
            }

        }
    }
}
