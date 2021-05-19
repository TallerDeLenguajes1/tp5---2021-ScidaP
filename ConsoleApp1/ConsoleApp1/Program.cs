using System;

namespace ConsoleApp1 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Ingrese un número para ser invertido (Mayor a 0)");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Numero insertado: " + num);
            int numInvertido = 0;
            int aux;
            while (num < 0) {
                Console.WriteLine("El número tiene que ser mayor a 0. Intente nuevamente.");
                num = int.Parse(Console.ReadLine());
            }
            while (num != 0) {
                aux = num % 10;
                numInvertido = numInvertido * 10 + aux;
                num = num / 10;
            }
            Console.WriteLine("Numero Invertido: " + numInvertido);
            Console.WriteLine("-----------");
            Console.WriteLine("CALCULADORA");
            Console.WriteLine("Ingrese la operación que quiere hacer ('S', 'R', 'M', 'D')");
            char op = char.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese dos numeros para hacer el calculo.");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int aux1;
            switch (op) {
                case 'S':
                case 's':
                    aux1 = num1 + num2;
                    Console.WriteLine($"Suma de {num1} + {num2} = {aux1}");
                    break;
                case 'R':
                case 'r':
                    aux1 = num1 - num2;
                    Console.WriteLine($"Resta de {num1} - {num2} = {aux1}");
                    break;
                case 'M':
                case 'm':
                    aux1 = num1 * num2;
                    Console.WriteLine($"Multiplicacion de {num1} * {num2} = {aux1}");
                    break;
                case 'D':
                case 'd':
                    aux1 = num1 / num2;
                    Console.WriteLine($"Division de {num1} / {num2} = {aux1}");
                    break;
            }
        }
    }
}