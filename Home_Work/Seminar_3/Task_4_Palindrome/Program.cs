// 4. Напишите программу, которая принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.

string enter = String.Empty;

int GetValue(string text)
{
    string getValue = String.Empty;
    int value = 0;
    bool correct = false;
    while (!correct)
    {
        System.Console.Write("Enter the number: ");
        getValue = System.Console.ReadLine()!;
        correct = int.TryParse(getValue, out value);
    }
    return value;
}

int Palindrome(int numberRal)
{
    int numberStart1 = numberRal / 10000;
    int numberStsrt2 = (numberRal / 1000) % 10;
    int numberEnd1 = (numberRal % 100) / 10;
    int numberEnd2 = (numberRal % 100) % 10;
    int totalPal = 1;
    if (numberStart1 == numberEnd2)
    {
        if (numberStsrt2 == numberEnd1)
        {
            return totalPal;
        }
    }
    else
    {
        totalPal = -totalPal;
    }
    return totalPal;
}

string PrintAnswer(int answer)
{
    string text = String.Empty;
    if (answer == 1)
    {
        text = "Yes";
    }
    else
    {
        text = "No";
    }
    return text;
}

int numberTrue = GetValue(enter);
int result = Palindrome(numberTrue);
System.Console.WriteLine(PrintAnswer(result));
