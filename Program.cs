void PrintArray(string[] array)
{   for (int i = 0; i < array.Length; i++)
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
    {
        if (massiv1[j].Length <= 3)
        {   massiv2[k] = massiv1[j];
            k++;
        }
    }
Console.WriteLine();
PrintArray(massiv2);
