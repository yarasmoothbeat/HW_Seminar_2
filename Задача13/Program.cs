void SearchThirdNumber(int num1)
{
    if (num1 / 100 < 1)
    {
        Console.WriteLine("Третьей цифры нет");
    }
    else
    {
        string str = Convert.ToString(num1);
        Console.WriteLine(str[2]);
    }
}

Console.WriteLine("Введите число");
int n1 = Convert.ToInt32(Console.ReadLine());
SearchThirdNumber(n1);