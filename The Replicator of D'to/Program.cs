Console.Title = "The Replicator of D'to";

int[] numbers = new int[5];

for (int i = 0 ; i < numbers.Length; i++)
{
    Console.WriteLine("Enter a Number");
    int value = Convert.ToInt32(Console.ReadLine());

    numbers[i] = value;
}

int[] copy = new int[numbers.Length];

for (int i = 0 ;i < numbers.Length; i++)
{
    copy[i] = numbers[i];
}

for (int i = 0 ; i < numbers.Length; i++)
    Console.WriteLine(copy[i]);