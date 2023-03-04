// подсчитать количество чисел больше нуля в введённых числах количеством m
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

