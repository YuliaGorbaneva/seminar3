int[] PowArray(int number)
{
    int[] result = new int[number];
    for (int i = 0; i < number; i++)
    {
        result [i] = (int)Math.Pow(i+1,2);
    }
return result;
}

PrintArray(PowArray(10));

void PrintArray(int[] result)
{
    for (int i = 0; i < result.Length; i++)
    {
        System.Console.WriteLine(result [i]);
    }
}
