bool CheckDaysOfWeek(int num1)
{
    if (num1 < 6)
    {
        return false;
    }
    else
    {
        return true;
    }
}

Console.WriteLine("Введите цифру обозночающую день недели");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(CheckDaysOfWeek(n1));
