
string[] array = new string[] { "hello", "2", "world", ":-)" };

// PrintArray(array, array.Length);
// Console.WriteLine();

string[] arraySort = new string[array.Length];

int j = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        arraySort[j] = array[i];
        j++;
    }
}

PrintArray(arraySort, j);


void PrintArray(string[] array, int j)
{
    Console.Write("[");

    for (int i = 0; i < j - 1; i++)
    {
        Console.Write($"{array[i]},");
    }

    Console.Write(array[j - 1]);
    Console.Write("]");
}
