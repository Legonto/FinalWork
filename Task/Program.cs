/* Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.
*/
string[] arr  = new string[] {"Hello", "23", "world", ":-)", "1234", "1567", "-2", "computer science", "Russia", "Denmark", "Kazan"};
Console.WriteLine("Наш изначальный массив:");
Console.WriteLine($"[{String.Join("; ", arr)}]");
// сначала определим длину нового массива, сколько элементов соответствует нашему условию
int length = 3;
int size = 0;
for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= length)
        {
        size++;
        }
    }
if (size == 0)
{
    Console.WriteLine ("Нет элементов больше 3"); 
}  
else
{
    string[] finalArray = new string[size];
    int j = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= length)
        {
            finalArray[j] = arr[i];
        j++;
        }
    }
Console.WriteLine("Наш новый массив:");
Console.WriteLine($"[{String.Join("; ", finalArray)}]");
}