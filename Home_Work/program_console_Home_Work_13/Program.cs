System.Console.Write("enter the number:");
int number = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine();

int Positive(int pos)
{
    if (pos < 0)
    {
        pos = pos * -1;
    }
    return pos;
}

int ThirdNumber(int third)
{
    int save = 0;
    int range = 1000;
    int coll = 0;
    int collend = 0;
    int threeNumbers = 100;
    if (third < 100)
    {
        System.Console.WriteLine("No third digit");
        System.Environment.Exit(0);
    }
    if (third > 99 & third < range)
    {
        save = third % 10;
    }
    else
    {
        while (third > range)
        {
            if (third < (range * 10))
            // 12345654987
            // 10000000000
            // 10000 / 100
            {
                coll = range;
            }
            range = range * 10;
        }
        collend = coll / threeNumbers;
        save = (third / collend) % 10;
    }
    return save;
}

int positive = Positive(number);
int third = ThirdNumber(positive);
System.Console.WriteLine(third);