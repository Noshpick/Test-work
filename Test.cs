using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваше имя: ");
            string uname = Console.ReadLine();
            Console.WriteLine("Привет " + uname);
    
            Console.WriteLine("Введи свой возраст: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Возраст: " + age);

            Console.ReadKey();

            Console.Clear();

            Console.WriteLine("Ваши данные: Имя - " + uname);
            Console.WriteLine("Возраст: " + age);

            Console.ReadKey();
        }
            }
        }
