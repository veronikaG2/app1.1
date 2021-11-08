using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anketa
{
    class Program
    {
        static void Main(string[] args)
        {
            string Fam = null;
            string Name = null;
            string SecondName = null;
            
            string genders = null;
            string login = null;
            string passport = null;
            string Sogl = null;
            Console.WriteLine("Анкета пользователя.");
            Console.Write("Введите вашу фамилию- ");
            Console.ForegroundColor = ConsoleColor.Red;
            Fam = Console.ReadLine();
            Console.ResetColor();

            Console.Write("Введите ваше имя - ");
            Console.ForegroundColor = ConsoleColor.Red;
            Name = Console.ReadLine();
            Console.ResetColor();

            Console.Write("Введите ваше отчество - ");
            Console.ForegroundColor = ConsoleColor.Red;

            SecondName = Console.ReadLine();
            Console.ResetColor();
           
            Console.ForegroundColor = ConsoleColor.Red;
            
            Console.ResetColor();
            Console.Write("Выберите ваш пол - ");
            Console.WriteLine("Если вы женщина введите 1 если вы мужчина введите 2.");
            Console.ForegroundColor = ConsoleColor.Red;
            genders = Console.ReadLine();
            Console.ResetColor();
            switch (genders)
            {
                case "1":
                    genders = "Женщина";
                    goto backTo;
                case "2":
                    genders = "Мужчина";
                    goto backTo;

                default:
                    Console.WriteLine("1 или 2 ");
                    goto backTo;

            }
        backTo:
            Console.Write("Придумайте ваш логин - ");
            Console.ForegroundColor = ConsoleColor.Red;
            login = Console.ReadLine();
            Console.ResetColor();
            Console.Write("Придумайте ваш пароль - ");
            Console.ForegroundColor = ConsoleColor.Red;
            passport = Console.ReadLine();
            Console.ResetColor();
            Console.ReadLine();

            Console.ResetColor();
            Console.WriteLine("Ваши данныые сохранены. Хотите вывести?");
            Console.WriteLine("A - да , B - нет");
            Sogl = Console.ReadLine();
            switch (Sogl)

            {
                case "A":
                    Console.WriteLine($"фамилия - {Fam}, Имя - {Name}, Отчество - {SecondName}, Ваш пол - {genders}, Ваш логин - {login}. ");
                   break;

                case "B":
                    Console.WriteLine("Вы отказались от вывода.");
                    break;


            }
            Console.ReadKey();


        }
    }
}
