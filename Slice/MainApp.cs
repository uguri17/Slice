using System;

namespace Slice
{
    class MainApp
    {
        static void PrintArray(Array array)
        {
            foreach (var e in array)
            {
                Console.Write($"{e} ");
            }
            Console.WriteLine();
        }
        
        static void Main(string[] args)
        {
            char[] array = new char['Z' - 'A' + 1]; // 0~25 array 생성

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (char)('A' + i); // 65..66..67...
            }

            PrintArray(array[..]); // 배열 전체
            PrintArray(array[23..]); // 23 24 25
            PrintArray(array[0..25]); // 마지막 [25]가 빠진 모습
            PrintArray(array[0..^1]); // [0] ~ [25] // [25] == ^1 // System.Index
        }
    }
}
