// ПРАКТИЧЕСКОЕ ЗАДАНИЕ ПОИСК ИНДЕКСА РУЧНОЙ МЕТОД
string[] massive = new string[4]{ "1234", "1567", "-2", "computer science" };
string[] massive2 = new string[massive.Length];

void SecondArrayWithIF(string[] massive, string[] massive2)
{
    int count = 0;
    for (int i = 0; i < massive.Length; i++)
    {
        if (massive[i].Length <= 3)
        {
            massive2[count] = massive[i];
            count++;
        }
    }
}

void Printmassive(string[] massive)
{
    for (int i = 0; i < massive.Length; i++)
    {
        Console.Write($"{massive[i]} ");
    }
    Console.WriteLine();
}
SecondArrayWithIF(massive, massive2);
Printmassive(massive2);