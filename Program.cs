// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

System.Console.WriteLine("Задача №25");
System.Console.WriteLine("Enter number A: ");
int numberA = int.Parse(Console.ReadLine());

System.Console.WriteLine("Enter number B: ");
int numberB = int.Parse(Console.ReadLine());

int Exponentiation (int numA, int numB)
{
    int result = 1;
    for(int i=1; i<=numB; i++)
    {
        result = result*numA;
    } 
    return result;
}

System.Console.WriteLine($"A to the power of B = {Exponentiation (numberA, numberB)}");


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

System.Console.WriteLine("Задача №27");
System.Console.WriteLine("Enter number: ");
int number = int.Parse(Console.ReadLine());

int sumofnumber(int num)
{
    int result = 0;
    for (; num>0; num/=10)
    {
        result = result + num%10;
    }
    return result;
} 

System.Console.WriteLine($"sum of digits = {sumofnumber(number)}");

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

System.Console.WriteLine("Задача №29");

int[] Array = new int[8];

void Put (int [] Numbers)
{
  int length = Numbers.Length;
  
  for (int i = 0; i < length; i++)
  {
      Numbers[i] = new Random().Next(1, 9);
  }
  return;
}

void Print (int[] arr)
{
  int digit = arr.Length;
  for (int count = 0; count < digit; count++)
  {
      System.Console.Write(arr[count] + " ");
  }
  return;
}

Put(Array);
Print(Array);

