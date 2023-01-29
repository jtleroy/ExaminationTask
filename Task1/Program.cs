
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

Console.WriteLine("Заполните массив через пробел случаными словами, числами или знаками:  ");

string[] subs = Console.ReadLine().Split(' '); 

int res = ProblemSolution(subs);
// Console.WriteLine(res);

string[] Array2 = new string[res];
int k = 0;

for (int i = 0; i < subs.Length; i++)
{
    
    for (int j = k; j < Array2.Length; j++)
    {
       if (subs[i].Length <= 3)
        {
          Array2[j] = subs[i];
          k = i+1;
        }
    }
}

PrintArray(Array2);