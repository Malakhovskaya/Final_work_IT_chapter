/* Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → [ ] */

string[] Array = new string[5] {"Hello", "How", "are", "you", "?"};
string[] NewArray = new string[Array.Length];
void GetArray(string[] Array, string[] NewArray)
{
    int count = 0;
    for (int i = 0; i < Array.Length; i++)
    {
    if(Array[i].Length <= 3)
        {
        NewArray[count] = Array[i];
        count++;
        }
    }
}
void PrintArray(string[] Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
        Console.Write($"{Array[i]} ");
    }
    Console.WriteLine();
}
GetArray(Array, NewArray);
PrintArray(NewArray);

