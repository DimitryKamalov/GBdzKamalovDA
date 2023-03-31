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
        
}
