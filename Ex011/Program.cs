int[] array = { 23, 42, 34, 12, 43, 12, 67, 81 };
int n = array.Length;
int find = 12;
int index = 0;
while (index < n)
{
    if(array[index]==find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}