using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    class Program
    {
        static double distance(double x1, double x2, double y1, double y2)
        {
            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return r;
        }
        
        static void info()
        {
            Console.Clear();
            Console.SetWindowSize(50, 20);
            Console.SetBufferSize(50, 20);
            
            Console.SetCursorPosition(25, 10);
            Console.WriteLine("My name is Artyom. My surname is Khairulin. Im from Aktobe, KZ");
        }
        static void Main(string[] args)
        {
            Console.Title = "Artyom Khairulin, GameLand, 18, Aktobe";
            Console.WriteLine("All was done by Artyom Khairulin");
            #region First exercise
            //написать программу «анкета». 
            //последовательно задаются вопросы(имя, фамилия, возраст, рост, вес).
            //в результате вся информация выводится в одну строчку.
            Console.Write("Enter your name:");
            string name = Console.ReadLine();
            Console.Write("Enter your surname:");
            string surname = Console.ReadLine();
            Console.Write("Enter your age:");
            string age = Console.ReadLine();
            Console.Write("Enter your height:");
            string height = Console.ReadLine();
            Console.Write("Enter your weight:");
            string weight = Console.ReadLine();
            // a
            Console.WriteLine("Your name is " + name + ". Your surname is " + surname + ". You are " + age + ". Your height: " + height + ". Your weight is " + weight + ".");
            // b
            Console.WriteLine("Your name is {0}. Your surname is {1}. You are {2}. Your height: {3}. Your weight is {4}.", name, surname, age, height, weight);
            // c
            Console.WriteLine($"Your name is {name}. Your surname is {surname}. You are {age}. Your height: {height}. Your weight is {weight}.");

            #endregion
            #region Second exercise
            //Ввести вес и рост человека.
            //Рассчитать и вывести индекс массы тела(ИМТ) по формуле I = m / (h * h);
            //где m — масса тела в килограммах, h — рост в метрах
            Console.Write("Enter the weight: ");
            double m = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the height: ");
            double h = Convert.ToDouble(Console.ReadLine());
            double i = m / (Math.Pow(h, 2));
            Console.WriteLine($"Your BMI is {i:N5}");
            #endregion
            #region Third exercise 
            Console.Write("Enter x1 - ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter x2 - ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter y1 - ");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter y2 - ");
            double y2 = Convert.ToDouble(Console.ReadLine());
            double r = distance(x1, x2, y1, y2);
            Console.WriteLine($"Your distance is {r:N2}");
            #endregion
            #region Fourth exercise
            Console.Write("Enter the first value: ");
            int firstValue = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second value: ");
            int secondValue = Convert.ToInt32(Console.ReadLine());
            firstValue += secondValue;
            secondValue = firstValue - secondValue;
            firstValue -= secondValue;
            Console.WriteLine($"Your first value now is {firstValue}, and second value is {secondValue}");

            #endregion
            #region Fifth exercise

            info();
            #endregion
            Console.ReadKey();
        }
    }
}


