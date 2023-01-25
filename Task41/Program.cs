using static System.Console;

Write("Введите числа через запятую: ");
string[] numbers = ReadLine()!.Split(",", StringSplitOptions.RemoveEmptyEntries);
WriteLine($"Положительных чисел введено: {countNumbers(numbers)}");

int countNumbers(string[] arr)
{
    int count = 0;
    foreach (string a in arr)
    {
        if (int.Parse(a) > 0)
        {
            count +=1;
        }
    }
    return count;
}