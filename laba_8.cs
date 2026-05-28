using System;

namespace Project
{
    class lab_8
    {
        public static void lab_8_easy(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1. Додати новий ключ-значення до словника.");
                Console.WriteLine("2. Вивести на екран всі елементи (ключ-значення) словника, також вивести інформацією про загальну кількість значень у словнику.");
                Console.WriteLine("3. Вилучити із словника значення за ключем.");
                Console.WriteLine("4. Шукати необхідне значення у словнику за визначеним ключем.");
                Console.WriteLine("5. Вихід із програми.");
                Console.WriteLine("Введіть номер операції");
                string input = Console.ReadLine();

                if (input == "5")
                {
                    break;
                }

                switch (input)
                {
                    case "1":
                        Console.WriteLine("тут ми додаємл новий ключ-значення до словника");
                        break;
                    case "2":
                        Console.WriteLine("тут ми виводимо всі елементи словника");
                        break;
                    case "3":
                        Console.WriteLine("тут ми вилучаємо значення за ключем");
                        break;
                    case "4":
                        Console.WriteLine("тут ми шукаємо необхідне значення у словнику за визначеним ключем");
                        break;
                    case "5":
                        Console.WriteLine("тут ми завершуємо програму");
                        break;
                    default:
                        Console.WriteLine("Невірний номер завдання. Спробуйте ще раз.");
                        break;
                }
            }
        }
    }
}