// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

void ThreeSymbol()
{
void PrintArray(string[] array)
{   array = array.Where(x => x != null).ToArray();   
        for (int i = 0; i < array.Length; i++)
        {   Console.Write(array[i] + ", ");
        }
    Console.WriteLine();
}
Console.WriteLine("Сколько элементов ввести с клавиатуры?");
int x = Convert.ToInt32(Console.ReadLine());
string[] massiv1 = new string[x];
    for (int i = 0; i < x; i++)
    {   Console.Write($"Введите {i+1}-й элемент: ");
        string y = Convert.ToString(Console.ReadLine());
        massiv1[i] = y;
    }
string[] massiv2 = new string[x];
int k = 0;
    for (int j = 0; j < x; j++)
    {   if (massiv1[j].Length <= 3)
        {   massiv2[k] = massiv1[j];
            k++;
        }
    }
Console.WriteLine();
PrintArray(massiv2);
}
ThreeSymbol();