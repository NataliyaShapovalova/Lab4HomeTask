//int ReadInt(string message)
//{
 //   Console.Write(message);
  //  return Convert.ToInt32(Console.ReadLine());
//}
//int lenArray=ReadInt("Введите длинну массива:");
//int[]randomArray=new int[lenArray];
//for (int i = 0; i < randomArray.Length; i++)
//{
   // randomArray[] = new Random().Next(1,9);
//}
//System.Console.WriteLine(randomArray[]+"");

    int[]myArray=new int [8];
    Random rand=new Random();
    for (int i = 0; i < myArray.Length; i++)
    {
       myArray[i] =rand.Next(8);
       System.Console.WriteLine("Значение элемента массива"+x+"="+myArray[i]);
    }