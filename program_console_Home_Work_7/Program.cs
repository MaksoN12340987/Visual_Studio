int greatest = 0;

int NumberRandom(int save)
{
    save = new Random().Next(10, 100);
    return save;
}

int GreatestNumber(int number)
{
    int saveOne = number % 10;
    int saveTwo = number / 10;
    if (saveOne > saveTwo)
    {
        return saveOne;
    }
    else
    {
        return saveTwo;
    }
    
}

int temporary = NumberRandom(greatest);
System.Console.WriteLine(temporary);
greatest = GreatestNumber(temporary);
System.Console.WriteLine(greatest);