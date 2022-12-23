Main();

void Main()
{
	bool isWorking = true;
	while (isWorking)
	{
		Console.Write("Input command: ");
		switch (Console.ReadLine())
		{
			case "Task34": Task34(); break;
			case "Task36": Task36(); break;
			case "Task38": Task38(); break;
			case "exit": isWorking = false; break;
		}
		Console.WriteLine();
	}
}
//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
void Task34()
{
    int length = ReadInt("Array length");
    int[] array = GetRandomArray(length, 100, 1000);
    PrintArray(array);
    Console.WriteLine();
    int count = FindEvenNumbers(array);
    Console.WriteLine($"Количество четных чисел в массиве равно {count}");
}

int ReadInt(string argument)
{
	Console.Write($"Input {argument}: ");
	return int.Parse(Console.ReadLine());
}

int[] GetRandomArray(int length, int minValue, int maxValue)
{
	int[] array = new int[length];
	Random random = new Random();

	for (int i = 0; i < array.Length; i++)
	{
		array[i] = random.Next(minValue, maxValue + 1);
	}

	return array;
}
void PrintArray(int[] array)
{
	for (int i = 0; i < array.Length; i++)
	{
		Console.Write($"{array[i]}  ");
	}
}
int FindEvenNumbers(int[] array)
{   int count = 0;
	for (int i = 0; i < array.Length; i++)
	{
        if (array[i] % 2 == 0) 
        {
        count++;
        }
		
	}
    return count;
}
//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
void Task36()
{
    int length = ReadInt("Array length");
    int[] array = GetRandomArray(length, 1, 10);
    PrintArray(array);
    Console.WriteLine();
    int sum = FindSumOddNumbers(array);
    Console.WriteLine($"Сумма чисел на нечетных позициях {sum}");
}
int FindSumOddNumbers(int[] array)
{   int sum = 0;
	for (int i = 0; i < array.Length; i++)
	{
        if (i%2 != 0) 
        {
        sum +=array[i];
        }
		
	}
    return sum;
}
//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
 void Task38()
{
    int length = ReadInt("Array length");
    double[] ReArray = GetRandom(length);
    PrintReArray(ReArray);
    Console.WriteLine();
    DiffMaxMin(ReArray);
   // Console.WriteLine($"Сумма чисел на нечетных позициях {sum}");

}
double[] GetRandom(int length)
{
	double[] ReArray = new double [length];
	Random random = new Random();

	for (int i = 0; i < ReArray.Length; i++)
	{
		ReArray[i] = random.Next(1, 100) + random.NextDouble();
;
	}
    return ReArray;
}
void PrintReArray(double[] ReArray)
{
	for (int i = 0; i < ReArray.Length; i++)
	{
		Console.Write($"{Math.Round(ReArray[i], 2)}  ");
	}
}
void DiffMaxMin(double[] ReArray)
{   double Max = ReArray[0];
    double Min = ReArray[0];
	for (int i = 1; i < ReArray.Length; i++)
    {
        if (ReArray[i] > Max) 
        {
        Max =ReArray[i];
    
        }
       if (ReArray[i] < Min)
       {
        Min = ReArray[i];
       }
	}
		Console.WriteLine($"Максимальный элемент {Math.Round(Max,2)}");
		Console.WriteLine($"Минимальный элемент {Math.Round(Min,2)}");
        Console.WriteLine($"Разница между максимальным и минимальным элементом массива {Math.Round(Max-Min,2)}");
    	
}