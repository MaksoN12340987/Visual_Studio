System.Console.WriteLine("enter the number:");
int number = Convert.ToInt32(Console.ReadLine());

int parityNumber(int save)
{
    int parity = 0;
    if (save % 2 == 0)
    {
        parity = 1;
    }
    return parity;
}

int PARINTY = parityNumber(number);
if (PARINTY == 1)
{
    System.Console.WriteLine("number is even");
}
else
{
    System.Console.WriteLine("number is not even");
}

