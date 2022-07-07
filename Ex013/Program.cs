// //вид1
// void Method1()
// {
//     Console.WriteLine("текст");
// }
// //Method1();


// //вид2
// void Method2(string msq)
// {
//     Console.WriteLine(msq);
// }
// //Method2("текст 2");

// void Method21(string msq, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msq);
//         i++;
//     }
// }
// // Method21(msq: "текст", count: 5);
// // Method21(count: 5, msq: "текст");


// //вид3
// int Method3()
// {
//     return DateTime.Now.Year;
// }
// int year = Method3();
// //Console.WriteLine(year);


// //вид4


// // string Method4(int count, string text)
// // {
// //     int i = 0;
// //     string result = String.Empty;
// //     while (i < count)
// //     {
// //         result = result + text;
// //         i++;
// //     }
// //     return result;
// // }
// // string res = Method4(5,"q");
// // Console.WriteLine(res);


// string Method4(int count, string text)
// {
//     string result = String.Empty;
//     for (int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }
// string res = Method4(5, "q");
// //Console.WriteLine(res); 


// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{j} x {i} = {j*i}");
//     }
//     Console.WriteLine();
// }



// ==== редактирование текста
// Console.WriteLine("Enter your text: ");
// string text = Console.ReadLine();


// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;
//     int lenght = text.Length;
//     for (int i = 0; i < lenght; i++)
//     {
//         if (text[i] == oldValue)
//         result = result + $"{newValue}";
//         else
//         result = result + $"{text[i]}";
//     }
//     return result;
// }
// string newText = Replace(text, ' ', '_');
// Console.WriteLine(newText);


int[] arr = { 2, 1, 7, 6, 4, 9, 3, 5, 8 };

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length-1; i++)
    {
        int minPosition = i;
        for (int j = i+1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}



PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);