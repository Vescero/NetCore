using System;                           // Подклөчение пространства имён

namespace ConditionalConstructions      // Объявление пространства имён
{
    class Program                       // Объявление класса
    {
        static void Main()              // Объявление метода 
        {                                       // Действия метода
            ConstructionIfElse();               // Вызов метода
            ConstructionIfElseWithLogicOp();    // Вызов метода
            ConstructionSwitchCase();           // Вызов метода
            ConstructionSwitchCaseWithGoTo();   // Вызов метода
            ConstructionTernarn();              // Вызов метода
        }                               // Конец объявения метода Main

        /// <summary>
        /// Использование условных операторов для выполнения проверки кода
        /// </summary>
        /// <remarks>
        /// Проверка на выполнение условий в коде
        /// </remarks>
        /// <returns>
        /// Вывод на экран результата после проверки условий
        /// </returns>
        static void ConstructionIfElse()  // Объявление метода
        {
            // Инициализация переменной1 со значением 8
            int num1 = 8;
            // Инициализация переменной2 со значением 6
            int num2 = 6;
            // Установка условия выполнения
            // Если переменная1 больше переменной 2
            if (num1 > num2)
            {
                // Вывод на экран результат проверки
                Console.WriteLine($"Число {num1} больше числа {num2}");
            }
            // В ином случае
            else if (num1 < num2)
            {
                // Вывод на экран результ проверки
                Console.WriteLine($"Число {num1} меньше числа {num2}");
            }
            // Если они равны
            else
            {   // Вывод на экран результат проверки
                Console.WriteLine($"Число {num1} равно числу {num2}");
            }
            Console.WriteLine("--- Конец метода ConstructionIfElse ---");
        }                                  // Конец объявления метода ConstructionIfElse

        /// <summary>
        /// Использование логических операторов для объеденения условий
        /// </summary>
        /// <remarks>
        /// Условие будет выполнено если num1>num и num1=8
        /// </remarks>
        /// <returns>
        /// Вывод на экран результат проверки на условие
        /// </returns>
        static void ConstructionIfElseWithLogicOp() // Объявление метода
        {
            // Инициализация переменной1 со значением 8
            int num1 = 8;
            // Инициализация переменной2 со значением 6
            int num2 = 6;
            // Проверка выполнения условий 
            // Если переменная1 больше переменно2 и переменная1 = 8
            if (num1 > num2 && num1 == 8)
            {
                // Вывод на экран результата при удачном выполнении условия if
                Console.WriteLine($"Число {num1} больше числа {num2}");
            }
            // Иначе
            else
            {   // Вывод на экран сообщения об ошибке
                Console.WriteLine("Условие не выполнено");
            }
            Console.WriteLine("--- Конец метода ConstructionIfElseWithLogicOp ---");
        }                               // Конец объвления метода ConstructionIfElseWithLogicOp
        
        /// <summary>
        /// Обработка нескольких условий 
        /// </summary>
        /// <remarks>
        /// Выполнение кода в зависимости от ввода пользователя
        /// </remarks>
        /// <returns>
        /// Вывод на экран запрашиваемой пользователем информации
        /// </returns>
        static void ConstructionSwitchCase()
        {
            // Просим пользователя ввести букву
            Console.WriteLine("Нажмите y или n");
            // Читаем результат и записываем его в переменную
            string selection = Console.ReadLine();
            // Подставляем введенное пользователем значение в условие
            switch (selection)
            {
                // Если ввели y
                case "y":
                    // Вывод на экран сообщения
                    Console.WriteLine("Вы нажали букву y");
                    // Выход из условия
                    break;
                // Если ввели n
                case "n":
                    // Вывод на экран сообщения
                    Console.WriteLine("Вы нажали букву n");
                    // выход из условия
                    break;
                // Если ввели любое другое значение
                default: 
                    // Вывод на экран сообщения
                    Console.WriteLine("Вы нажали недопустимую букву");
                    // Выход из условия
                    break;
            }
            Console.WriteLine("--- Конец метода ConstructionSwitchCase ---");
        }                               // Конец объявления метода ConstructionSwitchCase

        /// <summary>
        /// Обработка нескольких условий с переходом к другим
        /// </summary>
        /// <remarks>
        /// Выполнение кода в зависимости от ввода пользователя и перенаправление его выполнения
        /// </remarks>
        /// <returns>
        /// Вывод на экран запрашиваемой пользователем информации
        /// </returns>
        static void ConstructionSwitchCaseWithGoTo()
        {
            // Инициализация переменной со значением 1
            int number = 1;
            // Подставляем значение в условие
            switch (number)
            {   // Если значение 1
                case 1:
                    // Вывод на экран сообщения
                    Console.WriteLine("Case 1");
                    // Переход к case 5
                    goto case 5;
                // Если значение 3
                case 3:
                    // Вывод на экран сообщения
                    Console.WriteLine("Case 2");
                    // Выход из условия
                    break;
                // Если значение 5
                case 5:
                    // Вывод на экран сообщения
                    Console.WriteLine("Case 5");
                    // Выход из условия
                    break;
                // Если другое значение
                default:
                    Console.WriteLine("Недопустимое значение");
                    break;
            }
            Console.WriteLine("--- Конец метода ConstructionSwitchCaseWithGoTo ---");
        }                               // Конец объявления метода ConstructionSwitchCaseWithGoTo
        
        /// <summary>
        /// Выполнение тернарной операции 
        /// </summary>
        /// <remarks>
        /// Пользователь вводит знак операции 
        /// </remarks>
        /// <returns>
        /// Вывод на экран результата тернарной операции 
        /// </returns>
        static void ConstructionTernarn()
        {
            // Инициализация переменной со значением 3
            int x = 3;
            // Инициализация переменной со значением 2
            int y = 2;
            // Вывод на экран условия
            Console.WriteLine(" x=3 y=2 ");
            // Просим пользователя указать значения операции
            Console.WriteLine("Нажмите + или -");
            // Читаем результат и записываем его в переменную
            string selection = Console.ReadLine();
            // Инициализация переменной результатом выполнения условий тернарной операции
            int z = selection == "+" ? (x + y) : (x - y);
            // Вывод на экран результа операции
            Console.WriteLine(z);
            Console.WriteLine("--- Конец метода ConstructionTernarn ---");
        }                               // Конец объявления метода ConstructionTernarn
    }                                   // Конец объявления класса Program
}                                       // Конец объявления пространства имён
