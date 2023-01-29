
//метод, который находит количество элементов, отвечающих условию задачи
int ProblemSolution(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {

        if (array[i].Length <= 3)
        {
            count = count + 1;

        }
    }
    return count;
}

// Метод для вывода массива в консоль
void PrintArray(string[] array)
{
    Console.Write(" -> [");
    for (int i = 0; i < array.Length - 1; i++)
    {

        Console.Write(array[i] + " ");
    }
    Console.Write(array[array.Length - 1]+ "]");
}