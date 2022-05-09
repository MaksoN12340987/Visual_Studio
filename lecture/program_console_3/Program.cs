// double number1 = new Random().Next(1, 100);
// System.Console.WriteLine(number1);
// double number2 = new Random().Next(1, 100);
// System.Console.WriteLine(number2);
System.Console.WriteLine("Введите первое число");
string numberFirst = System.Console.ReadLine()!;
System.Console.WriteLine("Введите второе число");
string numberSecond = System.Console.ReadLine()!;

int number1 = System.Convert.ToInt32(numberFirst);
int number2 = System.Convert.ToInt32(numberSecond);
System.Console.WriteLine(number1 / number2);