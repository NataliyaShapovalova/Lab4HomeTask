int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int number=ReadInt("Введите число:");

int len=NumberLen(number);

SumNumbers(number,len);

int NumberLen(int number)
{
int index=0;
while (number>0)
{
    number/=10;
    index++;
}
return index;
}

 int SumNumbers( int number, int len)
{
    int sum=0;
    for (int j = 1; j <=len; j++)
    {
        sum+=number%10;
        number/=10;
    }
    return sum;
}

System.Console.WriteLine(SumNumbers(number,len));