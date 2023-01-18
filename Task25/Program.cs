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

//void ToDegree(int a, int b)
//{
  //  int result =1;
 //     for (int i = 1; i <= b; i++)
 //  {
 //   result=result*a;
 //  } 
  // Console.WriteLine(result);
//}

//Console.WriteLine("Введите число А:");
//int numberA=Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите число B:");
//int numberB=Convert.ToInt32(Console.ReadLine());

