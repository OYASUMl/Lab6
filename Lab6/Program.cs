namespace Lab6;

// Объявляем класс Program
class Program
{
    // Объявляем точку входа в программу с помощью статистического метода Main
    static void Main(string[] args)
    {
        Console.WriteLine("Введите команду (exit - Выход из программы, help - Список команд)");

        // Бесконечный цикл, пока не будет объявлено об выходе
        while (true)
        {
            // Присваиваем переменной input типа string значение указанное пользователем
            string input = Console.ReadLine();

            if (input == "exit")
            {
                Console.WriteLine("Выход из программы");
                break; 
            }

            else if (input == "help")
            {
                Console.WriteLine("Список команд: start - Запуск процесса. (любое число) - Квадрат числа. error - Ошибка!. Любая другая команда - Неизвестная команда");
            }

            else if (input == "start")
            {
                Console.WriteLine("Запуск процесса...");
            }

            // Преобразуем ввод input
            else if (int.TryParse(input, out int num1) && int.TryParse(input, out int num2))
            {
                // Квадрат числа
                int sum = num1 * num2;
                Console.WriteLine($"Квадрат числа: {sum}");
            }

            else if (input == "error")
            {
                Console.WriteLine("Ошибка!");
            }

            else
            {
                Console.WriteLine("Неизвестная команда");
            }
        }
    }
}