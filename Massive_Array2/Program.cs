// // ВАРИАНТ №1 ПОИСК ИНДЕКСА РУЧНОЙ МЕТОД
// int[] array = { 1, 21, 13, 41, 18, 15, 61, 17, 18 };

// int n = array.Length;
// int find = 18;

// int index = 0;

// while (index < n)
// {
//     if (array[index] == find)
//     {
//         Console.WriteLine(index);
//         break;
//     }
//     index++;
// }

// // ВАРИАНТ №2 ПОИСК ИНДЕКСА РАНДОМНЫЙ МЕТОД
// void FillArray(int[] collection)
// {
//     int Length = collection.Length;
//     int index = 0;
//     while (index < Length)
//     {
//         collection[index] = new Random().Next(1, 10);
//         index++;
//     }
// }

// void PrintArray(int[] col)
// {
//     int count = col.Length;
//     int position = 0;
//     while (position < count)
//     {
//         Console.WriteLine(col[position]);
//         position++;
//     }
// }

// int IndexOf(int[] collection, int find)
// {
//     int count = collection.Length;
//     int index = 0;
//     int position = -1;
//     while (index < count)
//     {
//         if (collection[index] == find)
//         {
//             position = index;
//             break;
//         }
//         index++;
//     }
//     return position;
// }

// int[] array = new int[10];

// FillArray(array);
// array[5] = 5;
// array[7] = 5;
// PrintArray(array);
// Console.WriteLine();

// int pos = IndexOf(array, 55);
// Console.WriteLine("позиция числа - " + pos);

// // ВАРИАНТ №3 ПОИСК ИНДЕКСА РУЧНОЙ МЕТОД
// string[] array = { "Hello", "2", "world", ":-)" };

// int n = array.Length;
// int Size = 3;

// int index = 0;

// while (index < n)
// {
//     if (array[index] <= Size)
//     {
//         Console.WriteLine(array);
//     }
//     index++;
// }

// Выведение нового МАССИВА из строк, длина которых меньше 3

// string[] array1 = new string[4] {"Hello", "2", "world", ":-)"};
// string[] array2 = new string[array1.Length];
// void SecondArrayWithIF(string[] array1, string[] array2)
// {
//     int count = 0;
//     for (int i = 0; i < array1.Length; i++)
//     {
//     if(array1[i].Length <= 3)
//         {
//         array2[count] = array1[i];
//         count++;
//         }
//     }
// }
// void PrintArray(string[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }
// SecondArrayWithIF(array1, array2);
// PrintArray(array2);