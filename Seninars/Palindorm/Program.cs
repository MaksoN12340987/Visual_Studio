// Напишите программу, которая принимает число и проверяет, является ли оно палиндромом.

System.Console.Write("enter the number:");
int number = Convert.ToInt32(Console.ReadLine());



int NumOfDig(int n)
{
    int range = 10;
    int coll = 10;
    if (range < n)
    {
        while (n > range)
        {
            if (n < (range * 10))
            {
                coll = range;
            }
            range = range * 10;
        }
    }
    return coll;
}

int Dig(int coll)
{
    int dig = 1;
    if (coll == 10 ^ coll > 10)
    {
        dig = 2;
        while (coll > 10)
        {
            coll = coll / 10;
            dig++;
        }
    }
    return dig;
}

int result = NumOfDig(number);
System.Console.WriteLine(result);
result = Dig(result);
System.Console.WriteLine(result);