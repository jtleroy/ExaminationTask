
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
