/*
Написать программу, которая из имеющегося массива строк формирует новый массив 
из строк,длина которых меньше, либо равна 3 символам.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте 
выполнения алгоритма.
При решении не рекомендуется пользоваться коллекциями,лучше обойтись 
исключительно массивами.
Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/


Console.Clear();
System.Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
string[] firstArray = InputArray();

int lenArr = 0;
for (int i = 0; i <= firstArray.Length - 1; i++)
{
    if (firstArray[i].Length <= 3) lenArr++;
}

string[] newArr = new string[lenArr];
int count = 0;

for (int i = 0; i <= firstArray.Length - 1; i++)
{
    if (firstArray[i].Length <= 3)
    {
        newArr[count] = firstArray[i];
        count++;
    }
}

string[] InputArray()
{
    string[] firstArray;
    firstArray = new string[size];
    for (int i = 0; i < firstArray.Length; i++)
    {
        System.Console.WriteLine($"Введите значение элемента: {i}");
        firstArray[i] = Console.ReadLine();
    }
    return firstArray;
}
System.Console.WriteLine($"Введенный массив: [{string.Join(" , ", firstArray)}]");
Console.Write($"Новый массив: [{string.Join(" , ", newArr)}]");