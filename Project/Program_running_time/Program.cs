// Program_running_time

DateTime start = DateTime.Now;
{
    // блок исполняемого кода
}
double running = (DateTime.Now - start).TotalMilliseconds;
System.Console.WriteLine($"Program_running_time: {running}");