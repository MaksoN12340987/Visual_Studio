System.Console.Write("Enter the number of the day of the week: ");
int n = Convert.ToInt32(System.Console.ReadLine());

void WeeksDays(int day)
{
    if (day < 8 & day > 0)
    {
        if (day < 6)
        {
            System.Console.WriteLine("Workday");
        }
        else
        {
            System.Console.WriteLine("Day off");
        }
    }
    else
    {
        System.Console.WriteLine("Out of time...");
    }
}

WeeksDays(n);