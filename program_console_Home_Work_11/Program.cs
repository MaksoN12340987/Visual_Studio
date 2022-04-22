System.Console.Write("Уnter the first number: ");
int numberA = Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("Уnter the second number: ");
int numberB = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine();

void Мultiple(int multiplesA, int multiplesB)
{
    if ((multiplesA * multiplesA) == multiplesB)
    {
        System.Console.WriteLine("The first number is the square of the second");
        System.Environment.Exit(0);
    }
    if ((multiplesB * multiplesB) == multiplesA)
    {
        System.Console.WriteLine("The second number is the square of the first");
        System.Environment.Exit(0);
    }
    else
    {
        System.Console.WriteLine("No");
    }
}

Мultiple(numberA, numberB);