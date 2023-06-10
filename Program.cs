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
}

// ------main------
Console.Write("Введите количество элементов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
string[] array = CreateArray(n);
ShowArray(array);