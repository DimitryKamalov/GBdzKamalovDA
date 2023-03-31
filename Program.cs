using System;

class Program 
{
    static void Main(string[] args) 
    {
        // объявление размера массива
        Console.Write("Введите количество элементов массива: ");
        int n = int.Parse(Console.ReadLine());
        string[] arr = new string[n];

        // задание элементов массива
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write($"Введите {i + 1}-й элемент массива: ");
            arr[i] = Console.ReadLine();
        }

        // объявление нового массива
        string[] newArr = new string[n];
        int count = 0;
        
         // цикл для проверки длины строк
        for (int i = 0; i < arr.Length; i++)
        {
            // если длина строки меньше или равна 3 символам
            if (arr[i].Length <= 3)
            {
                // добавить строку в новый массив
                newArr[count] = arr[i];
                count++;
            }
        }

         // вывод нового массива на экран
        Console.WriteLine($"Элементов в новом массиве: {count}");
        Console.WriteLine("Новый массив:");
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(newArr[i]);
        }
    }
}
