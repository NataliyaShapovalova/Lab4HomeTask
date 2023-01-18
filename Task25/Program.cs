Double ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
double a = ReadInt("Введите число A:");
double b = ReadInt("Введите число B:");

Double ToDegree(double a, double b)
{
    return Math.Pow (a, b);
}
System.Console.WriteLine(ToDegree(a,b));

