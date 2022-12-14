Console.Clear();
Console.WriteLine("введите номер строки");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите номер столбца");
int m = Convert.ToInt32(Console.ReadLine());
int [,] numbers = new int [10,10];
ArrayRandom(numbers);

for (int j = 0; j < numbers.GetLength(1); j++)
{
    double result = 0;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        result += numbers[j, i];
    }
    result = result / n;
    Console.Write(result + "; ");
}

void ArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array [i,j] = new Random().Next(-10, 11);
                Console.Write($"{array[i, j]} \t");
            }   
            Console.WriteLine();
        }
}