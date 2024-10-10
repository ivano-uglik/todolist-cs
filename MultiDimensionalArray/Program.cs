int[,] multiDimensional = {
{5, 24, 3 },
{-7, 8, 12 }
};

int returnMax(int[,] multiDimensionalArray)
{
    var max = 0;
    for (int i = 0; i < multiDimensionalArray.GetLength(0); i++)
    {
        for (int j = 0; j < multiDimensionalArray.GetLength(1); j++)
        {
            if (multiDimensional[i, j] > max)
            {
                max = multiDimensional[i, j];
            }
        }
    }
    return max;
}

Console.WriteLine(returnMax(multiDimensional));
Console.ReadKey();