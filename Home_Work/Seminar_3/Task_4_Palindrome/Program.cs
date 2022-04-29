// 4. Напишите программу, которая принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.

System.Console.Write("Enter the number: ");
int number = Convert.ToInt32(Console.ReadLine());

// string enter = System.Console.ReadLine();

// string NumderFive(string text)
// {
//     int number = Convert.ToInt32(text);
//     if (number > 9999 & number < 100000) ;
//     else
//     {
//         System.Console.WriteLine("enter a number greater than 99");
//         System.Environment.Exit(0);
//     }
// }

// string result = NumderFive(enter);

int Palindrome(int numberRal)
{
    int numberStsrt1 = numberRal / 10000;
    int numberEnd1 = (numberRal % 100) / 10;
    int numberStsrt2 = (numberRal / 1000) % 10;
    int numberEnd2 = (numberRal % 100) % 10;
    int total = 1;
    if (numberStsrt1 == numberEnd1)
    {
        if (numberStsrt2 == numberEnd2)
        {
            return total;
        }
    }
    else
    {
        total = -total;
        return total;
    }
}

int result = Palindrome(number);
System.Console.WriteLine(result);