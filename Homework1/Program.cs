// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2


Console.WriteLine("vvedite razmer massiva");
int X = int.Parse(Console.ReadLine()!);
Console.WriteLine();

int[] createArray()
{
    var random = new Random();

    var result = new int[X];

    for (long i = 0; i < result.Length; i++)
    {
        result[i] = random.Next(100, 1000);
    }

    return result;
}

int evenNumbers(int[] array)
{
    var result = 0;

    for (long i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0)
            result++;
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
Console.WriteLine("kolichestvo chetnyh chisel v massive:");
Console.WriteLine(evenNumbers(array));