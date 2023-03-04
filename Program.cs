// подать на вход числа А и Б и выдать результат возведения А в степень Б
int ReadNumber (string message)
{
    Console.WriteLine (message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int m = ReadNumber ("Введите количество вводимых чисел:");
int numberB = 0;
for (int count = 0; count < m; count++)
{
    int numberA = ReadNumber("Введите число:");
    if (numberA > 0)
    {
        numberB++;
    }
}
Console.WriteLine ("Количество чисел больше нуля = " + numberB);

