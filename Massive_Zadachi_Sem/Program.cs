
void PrintNumbers()
{
int num1 = 1;
int num2 = 8;
// for (int i = num1; i < num2 + 1; i++) Console.Write($"{i}, ");
for (int i = num1; i <= num2; i++)  
// Console.Write(i+", ")
    if(i % 2 == 0)
    {
        Console.Write(i+", "); 
    }
}
PrintNumbers();
