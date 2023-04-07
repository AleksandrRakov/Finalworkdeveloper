// Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
//  длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями,
//  лучше обойтись исключительно массивами.

Console.WriteLine("Введите количество элементов");
int size = Convert.ToInt32(Console.ReadLine());
string[] array = new string[size];

void EnterArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"элемент {i} : ");
        array[i] = Convert.ToString(Console.ReadLine());
    }
}

void PrintArray(string[] arr)
{
    Console.Write($"[ ");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}; ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write($" ]");
}


string[] NewArray(string[] arr)
{
    int a = new Random().Next(0,4);
    string[] newArr = new string[a];
    
    for (int j = 0; j < a; j++)
        {
            int i = new Random().Next(0, size);
            newArr[j] = arr[i];
        }
    return newArr;
}


EnterArray(array);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();
string[] newArray = NewArray(array);
PrintArray(newArray);



