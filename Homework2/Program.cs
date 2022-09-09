//  Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0



Console.WriteLine("vvedite razmer massiva");
int X = int.Parse(Console.ReadLine()!);
Console.WriteLine();

int[] createArray()
{
    var random = new Random();

    var result = new int[X];

    for (long i = 0; i < result.Length; i++)
    {
        result[i] = random.Next(-99, 100);
    }

    return result;
}

int sumOddNumbers(int[] array)
{
    var result = 0;
    for (long i = 1; i < array.Length; i = i + 2)
        result += array[i];
    return result;
}

void printArray(int[] array)
{
    Console.Write("[");

    for (var i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);

        if (i != array.Length - 1)
            Console.Write(", ");
    }

    Console.Write("]");
    Console.WriteLine();
}

var array = createArray();
printArray(array);
Console.WriteLine();
Console.WriteLine("summa elementov, stoyaschih na nechetnyh poziciyah"); 
Console.WriteLine(sumOddNumbers(array));