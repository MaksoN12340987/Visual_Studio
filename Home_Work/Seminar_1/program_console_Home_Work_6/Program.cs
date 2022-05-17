System.Console.WriteLine("Введите число");
int a = Convert.ToInt32(System.Console.ReadLine());

int lostNumber(int number)
{
    int numberLost = 0;
    numberLost = number % 10;
    return numberLost;
}

int lost = lostNumber(a);
System.Console.WriteLine(lost);