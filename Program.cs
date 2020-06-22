using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double otvet;
            char oper;

            Console.WriteLine("Math calc by uzumaki team!");

            Console.WriteLine("Введите первое число:");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите оператор:");
            oper = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            b = Convert.ToDouble(Console.ReadLine());

            if(oper == '+') //Sabuhi
            {
                   otvet = a + b; 
                 Console.WriteLine(otvet);
            }

            if (oper == '-') //Anton
            {
                Console.Write("Otvet: ");
                Console.WriteLine(a-b);
            }

            if (oper == '*') //Sanya
            {
                otvet = a * b;
                Console.WriteLine(otvet);
            }

            if (oper == '/') //Lev or Leha
            {
                if (b != 0) 
                {
                    otvet = a / b;
                    Console.WriteLine(otvet);
                }
            }
            
           
            Console.ReadKey();
        }
    }
}
