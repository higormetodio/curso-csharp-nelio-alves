string[] numbers = Console.ReadLine().Split(' ');

int rows = int.Parse(numbers[0]);
int columns = int.Parse(numbers[1]);

int[,] matrix = new int[rows, columns];

for (int i = 0; i < rows; i++)
{
    string[] result = Console.ReadLine().Split(' ');
    for (int j = 0; j < columns; j++)
    {
        matrix[i, j] = int.Parse(result[j]);
    }
}

int posicion = int.Parse(Console.ReadLine());

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        if (matrix[i, j] == posicion)
        {
            Console.WriteLine($"Position: {i},{j}");

            if (j - 1 >= 0)
            {
                Console.WriteLine($"Left: {matrix[i, j - 1]}");
            }

            if (j + 1 < columns)
            {
                Console.WriteLine($"Right: {matrix[i, j + 1]}");
            }

            if (i - 1 >= 0)
            {
                Console.WriteLine($"Up: {matrix[i - 1, j]}");
            }

            if (i + 1 < rows)
            {
                Console.WriteLine($"Down: {matrix[i + 1, j]}");
            }
        }

    }
}

