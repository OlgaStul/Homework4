/*  Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12   */

int GetNumber(string message)
{
    int result = 0;
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число. Повторите ввод");
        }
    }
    return Math.Abs(result);           // модуль числа
}

int number = GetNumber("Введите любое число");

void SumNumber(int GetNumber)
{
    int lastDigit = 0;
    int sum = 0;
    while (number > 0)                 // Цифры извлекаются из числа при помощи оператора деления по модулю, 
    {                                  // начиная с конца. После суммирования цифра «уничтожается» при помощи
      lastDigit = number % 10;         // оператора целочисленного деления. Когда число становится равным 0 
      sum = sum + lastDigit;           // (все цифры были обработаны и «уничтожены»), цикл завершает свою работу.
      number = number / 10;
    }
    Console.WriteLine($"Сумма всех цифр в данном числе равна {sum}");
}

SumNumber(number);
