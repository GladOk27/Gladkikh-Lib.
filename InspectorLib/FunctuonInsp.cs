using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InspectorLib
{

    public class FunctionInsp
    {
        static public string Str = ("Иванов И.И. ; Зиронов Т.А. ; Миронов А.В. ; Васильев В.И.");
        static public string[] Str1;
        /// <summary>
        /// данный метод добавляет нового сотрудника в список сотрудников.
        /// </summary>
        static public void AddWorker()
        {
            Console.WriteLine("Введите ФИО, которое хотите добавить в список сотрудников");
            string fullname = Console.ReadLine();
            Str = Str + ";" + fullname;
            Str1 = Str.Split(new Char[] { ';' });
            Console.WriteLine($"Новый сотрудник добавлен: {Str}");

        }

        /// <summary>
        /// данный метод возвращает ФИО
        ///главного инспектора автоинспекции
        /// </summary>
        /// <returns></returns>
        static public string GetInspector(string GetInsp)
        {
            GetInsp = "Васильев Василий Иванович";
            Console.WriteLine($"Главный инспектор - {GetInsp}");
            return GetInsp;
        }

        /// <summary>
        /// данный метод возвращает название автоинспекции.
        /// </summary>
        /// <returns></returns>
        static public string GetСarInspection(string GetCar)
        {
            GetCar = "Автоинспекция г. Чита";
            Console.WriteLine($"Название - {GetCar}"); ;
            return GetCar;
        }
        /// <summary>
        /// данный метод
        ///формирует из принимаемых аргументов госномер
        /// </summary>
        /// <param name=""></param>
        /// <param name=""></param>
        /// <param name=""></param>
        /// <returns></returns>
        static public string GenerateNumber(string number, string symbol, string code)
        {
            Console.WriteLine("Введите символ");
            symbol = Console.ReadLine();
            symbol = symbol.ToUpper();
            Console.WriteLine("Введите номер");
            number = Console.ReadLine();
            Console.WriteLine("Введите код");
            code = Console.ReadLine();
            if (code == "75")
            {
                Console.WriteLine($"{ symbol + number + code}");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Ошибка!");
            }
            return code;

        }

    }

}

