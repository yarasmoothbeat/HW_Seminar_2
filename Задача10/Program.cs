void SecondNumber(int num1)
{
    int num = (num1 - (num1 / 100) * 100 - num1 % 10) / 10;
    Console.WriteLine(num);
}

Console.WriteLine("Введите трехзначное число");
int n1 = Convert.ToInt32(Console.ReadLine());
SecondNumber (n1);