System.Console.WriteLine("Введите число из 3х знаков");
int a = Convert.ToInt32(System.Console.ReadLine());

int RangeThird(int range)
{
    int ok = range;
    if (range > 99 & range < 1000);
    else
    {
        System.Console.WriteLine("Ошибка, введите число из 3х знаков");
        System. Environment. Exit(0);
    }
    return ok;
}

int TwoNumber(int number)
{
    int twoNumber = 0;
    number = number % 100;
    twoNumber = number / 10;
    return twoNumber;
}

int Third = RangeThird(a);

int TWO = TwoNumber(Third);

System.Console.WriteLine(TWO);