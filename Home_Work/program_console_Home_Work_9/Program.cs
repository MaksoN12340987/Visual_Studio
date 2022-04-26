System.Console.WriteLine("Введите первое число");
double numberA = Convert.ToDouble(System.Console.ReadLine());
System.Console.WriteLine("Введите второе число");
double numberB = Convert.ToDouble(System.Console.ReadLine());

double MultiplicityNumbers(double num1, double num2)
{
    double multiple = 0;
    if (num1 % num2 == 0)
    {
        System.Console.WriteLine("кратно");
        System.Environment.Exit(0);
    }
    else
    {
        multiple = num1 % num2;
    }
    return multiple;
}

double numbersMultiplicity = MultiplicityNumbers(numberA, numberB);
System.Console.Write("не кратно, остаток ");
System.Console.WriteLine(numbersMultiplicity);