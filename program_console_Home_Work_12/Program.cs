System.Console.Write("enter the number:");
int number = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine();

void NumbeThree(int third)
{
    if (third > 99);
    else
    {
        System.Console.WriteLine("enter a number greater than 99");
        System. Environment. Exit(0);
    }
}

int TwoNumber(int two)
{
    int save = (two / 10) % 10;
    return save;
}

NumbeThree(number);
int TWO = TwoNumber(number);
System.Console.WriteLine(TWO);