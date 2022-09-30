System.Console.WriteLine("Добрый день!");
int n = 0;
int v = 100;
while (n < v)
{
    Console.Write("Выберите задачу которую хотите проверить 34, 36 или 38:  ");
    int choice = int.Parse(Console.ReadLine());
    while (choice == 34)
    {
        Console.WriteLine();
        Console.WriteLine("Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.");
        Console.WriteLine();
        if (choice == 34) task1();
        if (choice == 34) task1();
        if (choice == 34) task1();
        break;

    }
    while (choice == 36)
    {
        Console.WriteLine();
        Console.WriteLine("Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.");
        Console.WriteLine();
        if (choice == 36) task2();
        if (choice == 36) task2();
        if (choice == 36) task2();
        break;
    }
    while (choice == 38)
    {
        Console.WriteLine();
        Console.WriteLine("Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.");
        Console.WriteLine();
        if (choice == 38) task3();
        if (choice == 38) task3();
        if (choice == 38) task3();
        break;
    }
    n++;
}

void task1()
{
    int ReadData(string msg)
    {
        Console.Write(msg);
        int number = int.Parse(Console.ReadLine() ?? "0");
        return number;
    }
    int[] FillArr(int len)
    {
        int[] array = new int[len];
        for (int i = 0; i < len; i++)
        {
            array[i] = new Random().Next(100, 999);
        }
        return array;
    }
    int Test(int[] arr)
    {
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 == 0) sum++;
        }
        return sum;
    }
    void PrintArr(int[] arr)
    {
        Console.Write("[");
        for (int i = 0; i < arr.Length - 1; i++)
        {
            Console.Write(arr[i] + ", ");
        }
        Console.Write(arr[arr.Length - 1] + "]");
        Console.WriteLine();
    }

    int arrLen = ReadData("Введите длину массива: ");
    int[] arr = FillArr(arrLen);
    PrintArr(arr);
    Console.Write("количество чётных чисел в массиве = " + Test(arr));
    Console.WriteLine();
}

void task2()
{
    int ReadData(string msg)
    {
        Console.Write(msg);
        int number = int.Parse(Console.ReadLine());
        return number;
    }
    int[] FillArr(int len)
    {
        int[] array = new int[len];
        for (int i = 0; i < len; i++)
        {
            array[i] = new Random().Next(-99, 99);
        }
        return array;
    }
    int Test(int[] arr)
    {
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 != 0) sum = sum + arr[i];
        }
        return sum;
    }
    void PrintArr(int[] arr)
    {
        Console.Write("[");
        for (int i = 0; i < arr.Length - 1; i++)
        {
            Console.Write(arr[i] + ", ");
        }
        Console.Write(arr[arr.Length - 1] + "]");
        Console.WriteLine();
    }

    int arrLen = ReadData("Введите длину массива: ");
    int[] arr = FillArr(arrLen);
    PrintArr(arr);
    Console.Write("Сумма элементов, стоящих на нечётных позициях = " + Test(arr));
    Console.WriteLine();
}
void task3()
{
    int ReadData(string msg)
    {
        Console.Write(msg);
        int number = int.Parse(Console.ReadLine());
        return number;
    }
    int[] FillArr(int len)
    {
        int[] array = new int[len];
        for (int i = 0; i < len; i++)
        {
            array[i] = new Random().Next(1, 99);
        }
        return array;
    }
    int Min(int[] arr)
    {
        int min = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (min > arr[i]) min = arr[i];
        }
        return min;
    }
    int Max(int[] arr)
    {
        int max = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (max < arr[i]) max = arr[i];
        }
        return max;
    }
    void PrintArr(int[] arr)
    {
        Console.Write("[");
        for (int i = 0; i < arr.Length - 1; i++)
        {
            Console.Write(arr[i] + ", ");
        }
        Console.Write(arr[arr.Length - 1] + "]");
        Console.WriteLine();
    }

    int arrLen = ReadData("Введите длину массива: ");
    int[] arr = FillArr(arrLen);
    PrintArr(arr);
    Console.WriteLine("Мах = "+ Max(arr) + " Min = "+ Min(arr));
    Console.Write("Разницу между максимальным и минимальным элементом массива = " + (Max(arr) - Min(arr)));
    Console.WriteLine();
}