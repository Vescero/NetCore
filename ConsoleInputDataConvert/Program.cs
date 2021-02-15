using System;                               // Подлючение пространства имён

namespace ConsoleInputDataConvert           // Объявление новоого пространства имён
{
    class Program                           // Обьявление нового класаа
    {
        static void Main()                  // Объявление нового метода
        {   // Действия метода
            // Просим пользователя ввести имя
            Console.WriteLine("Введите имя: ");
            // Читаем ответ
            string name = Console.ReadLine();
            // Просим пользователя ввести возраст
            Console.WriteLine("Введите возраст: ");
            // Читаем ответ
            int age = Convert.ToInt32(Console.ReadLine());
            // Просим пользователя ввести рост
            Console.WriteLine("Введтие рост: ");
            // Читаем ответ
            double height = Convert.ToDouble(Console.ReadLine());
            // Просим пользователя ввести размер зарплаты
            Console.WriteLine("Введите размер зарплаты: ");
            // Читаем ответ
            decimal salary = Convert.ToDecimal(Console.ReadLine());
            // Выводим на экран значения введеных пользователем переменных
            Console.WriteLine($"Имя: {name} Возраст: {age} Рост: {height} Зарплата: {salary}");
        }                                   // Конец объявления метода Main
    }                                       // Конец объявления класса Program
}                                           // Конец объявления пространства имён 
