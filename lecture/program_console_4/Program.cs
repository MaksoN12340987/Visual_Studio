Console.WriteLine("Введите имя пользователя");
string username = Console.ReadLine()!;

if(username.ToLower() == "maksim")
{
    Console.WriteLine("Hello my friands");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
Console.ReadKey(); 