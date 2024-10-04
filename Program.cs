namespace PracticalWork2OAiP;

public class Program
{
    public static void Main(string[] args)
    {
        // ЗАДАНИЯ НА ВЕТВЛЕНИЯ

        // Задание 1 (Определение возраста)
        Console.WriteLine("ЗАДАНИЕ 1\n");

        Console.WriteLine("Введите ваш возраст: ");
        short age = Convert.ToByte(Console.ReadLine());

        if (age < 18)
            Console.WriteLine("Ты еще подросток.");
        else if (age > 17 && age < 66)
            Console.WriteLine("Ты взрослый.");
        else
            Console.WriteLine("Ты пожилой человек.");


        // Задание 2 (Проверка чётности)
        Console.WriteLine("\n\nЗАДАНИЕ 2\n");

        Console.WriteLine("Введите число: ");
        int userNumber = Convert.ToInt32(Console.ReadLine());

        if (userNumber % 2 == 0)
            Console.WriteLine("Чётное");
        else
            Console.WriteLine("Нечётное");


        // ЗАДАНИЯ НА ЦИКЛ

        // Задание 3 (Таблица умножения)
        Console.WriteLine("\n\nЗАДАНИЕ 3\n");

        for (int i = 1; i < 11; i++)
            Console.WriteLine($"5 * {i} = {5 * i}");


        // Задание 4 (Подсчёт суммы чисел)
        Console.WriteLine("\n\nЗАДАНИЕ 4");

        Console.WriteLine("Введите положительное число: ");
        uint userPositiveNumber = Convert.ToUInt32(Console.ReadLine());

        uint sum = 0;
        uint startNumber = 1;

        while (startNumber <= userPositiveNumber)
        {
            sum += startNumber;
            startNumber++;
        }

        Console.WriteLine($"Сумма чисел от 1 до {userPositiveNumber}: {sum}");
    }
}