System.Console.Write("Enter n: ");
int number = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine();

void Мultiple(int multiples)
{
    if ((multiples % 7 == 0) & (multiples % 23 == 0))
    {
        System.Console.WriteLine("Еhe number is a multiple of 7 and 23");
    }
    else
    {
        System.Console.WriteLine("the number is not a multiple of 7 and 23");
    }
}

Мultiple(number);