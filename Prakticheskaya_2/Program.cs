using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Выберите программу:");
            Console.WriteLine("1. Угадай число");
            Console.WriteLine("2. Таблица умножения");
            Console.WriteLine("3. Вывод делителей числа");
            Console.WriteLine("4. Выход из программы");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                switch (choice)
                {
                    case 1:
                        ugadaychislo();
                        break;
                    case 2:
                        tablica();
                        break;
                    case 3:
                        deliteli();
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }

    static void ugadaychislo()
    {
        Console.WriteLine("Игра 'Угадай число'!");

        Random random = new Random();
        int randomNum = random.Next(0, 101);
        int userGuess;

        while (true)
        {
            Console.Write("Угадайте число от 0 до 100: ");
            if (int.TryParse(Console.ReadLine(), out userGuess))
            {
                if (userGuess < randomNum)
                {
                    Console.WriteLine("Тепло");
                }
                else if (userGuess > randomNum)
                {
                    Console.WriteLine("Холодно");
                }
                else
                {
                    Console.WriteLine("Вы угадали число!");
                    break;
                }
            }
        }
    }

    static void tablica()
    {
        int rows = 10;
        int columns = 10;

        Console.WriteLine("Таблица умножения");

        for (int i = 1; i <= rows; i++)
        {
            for (int j = 1; j <= columns; j++)
            {
                Console.Write($"{i * j,4}");
            }
            Console.WriteLine();
        }
    }

    static void deliteli()
    {
        while (true)
        {
            Console.WriteLine("Введите число: ");
            if (int.TryParse(Console.ReadLine(), out int num))
            {
                Console.WriteLine($"Делители числа нацело:");
                for (int i = 1; i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
                break;
            }
        }
    }
}
