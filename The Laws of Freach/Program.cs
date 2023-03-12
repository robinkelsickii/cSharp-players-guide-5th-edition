using System.Runtime.InteropServices;

Console.Title = "The laws of Freach";

int[] array = new int[10];

for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine("Give Me 10 numbers: ");
    int numberInput = Convert.ToInt32(Console.ReadLine());

    array[i] = numberInput;
}

int smallestNumber = int.MaxValue; 

foreach (int i in array)
{
    if (i < smallestNumber)
        smallestNumber = i;
}

Console.WriteLine($"The smallest number is {smallestNumber}");