string[] sp1 = new string[5] {"12345", "darov", "world", "plm", "los"};
string[] sp2 = new string[sp1.Length];

void Wil(string[] sp1, string[] sp2)
{
    int count = 0;
    for (int i = 0; i < sp1.Length; i++)
    {
    if(sp1[i].Length <= 3)
        {
        sp2[count] = sp1[i];
        count =+1;
        }
    }
}
void Print(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
Wil(sp1, sp2);
Print(sp2);