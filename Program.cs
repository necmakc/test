// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо 
// задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше 
// обойтись исключительно массивами.

//------functions------
string[] CreateArray(int n)
{
    string[] stringArray = new string[n];
    for (int i = 0; i < n; i++)
    {
        Console.Write($"Введите элемент {i + 1} из {n}: ");
        stringArray[i] = Console.ReadLine();
    }
    return stringArray;
}

void ShowArray(string[] stringArray)
{
    for (int i = 0; i < stringArray.Length; i++)
        Console.Write(stringArray[i] + " ");
    Console.WriteLine();
}

string[] GetNewArray(string[] stringArray)
{
    int count = 0;
    for (int i = 0; i < stringArray.Length; i++)
        if (stringArray[i].Length <= 3)
            count++;
    string[] newArray = new string[count];
    int j = 0;
    for (int i = 0; i < stringArray.Length; i++)
        if (stringArray[i].Length <= 3)
        {
            newArray[j] = stringArray[i];
            j++;
        }
    return newArray;
}

// ------main------
Console.Write("Введите количество элементов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
string[] array = CreateArray(n);
Console.WriteLine("Исходный массив");
ShowArray(array);
Console.WriteLine("Новый массив");
ShowArray(GetNewArray(array));