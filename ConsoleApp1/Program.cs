using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double otvet;
            char oper;
            char next;

            Console.WriteLine("Math calc by uzumaki team!");

        Start:
            Console.WriteLine("Введите первое число:");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите оператор:");
            oper = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            b = Convert.ToDouble(Console.ReadLine());

            if (oper == '+') //Sabuhi
            {
                otvet = a + b;
                Console.WriteLine("Ваш ответ = " + otvet);
                Console.WriteLine("Продолжить? Д/Н");
                next = Convert.ToChar(Console.ReadLine());
                if (next == 'Д')
                {
                    goto Start;
                }
            }

            if (oper == '-') //Anton
            {
                Console.Write("Otvet: ");
                Console.WriteLine("Ваш ответ = " +  (a - b));
                Console.WriteLine("Продолжить? Д/Н");
                next = Convert.ToChar(Console.ReadLine());
                if (next == 'Д')
                {
                    goto Start;
                }
            }

            if (oper == '*') //Sanya
            {
                otvet = a * b;
                Console.WriteLine("Ваш ответ = " + otvet);
                Console.WriteLine("Продолжить? Д/Н");
                next = Convert.ToChar(Console.ReadLine());
                if (next == 'Д')
                {
                    goto Start;
                }
            }

            if (oper == '/') //Lev or Leha
            {
                if (b != 0)
                {
                    otvet = a / b;
                    Console.WriteLine("Ваш ответ = " + otvet);
                    Console.WriteLine("Продолжить? Д/Н");
                    next = Convert.ToChar(Console.ReadLine());
                    if (next == 'Д')
                    {
                        goto Start;
                    } 
                    
                }
            }

      
            Console.ReadKey();
        }
    }
}
