/* Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.*/

string[] array = InitialArray();
string[] array2 = FinalArray(array, 3);
Console.WriteLine($"Начальный массив [{string.Join(" ", array)}]");
Console.WriteLine($"Финальный массив [{string.Join(" ", array2)}]");

string[] FinalArray(string[] input, int n)
{
    string[] output = new string[CountLess(input, n)];

    for (int i = 0, j = 0; i < input.Length; i++)
    {
        if (input[i].Length <= n)
        {
            output[j] = input[i];
            j++;
        }
    }
    return output;
}

int CountLess (string[] input, int n)
{
    int count = 0;

    for (int i = 0; i < input.Length; i++)
    {
        if (input[i].Length <= n)
        {
            count++;
        }
    }
    return count;
}

string[] InitialArray()
{
    Console.Write("Введите значения массива через пробел: ");
    return Console.ReadLine().Split(" ");
}