﻿using System;               // Подключаемое пространство имён

namespace Variable          // Объявление нового пространства имён 
{
    class Program           // Объявление нового класса 
    {
        static void Main()  // Объявление нового метода 
        {   // Действия метода
            // Инициализируем переменную name со значением "Tom"
            string name = "Tom";
            // Выводим на экран значение переменной name
            Console.WriteLine(name);    // Tom
            // Заменяем значение переменной с "Tom" на "Bob"
            name = "Bob";
            // Выводим на экран значение переменной name
            Console.WriteLine(name);    // Bob
        }                   // Конец объявления метода Main
    }                       // Конец объявления класса  Program
}                           // Конец объявления пространства имён Variable
