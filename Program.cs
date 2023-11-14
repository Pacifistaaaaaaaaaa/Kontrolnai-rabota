string[] SP1 = new string[5] {"12345", "darov", "world", "plm", "los"};
string[] SP2 = new string[SP1.Length];

void WIL(string[] SP1, string[] SP2)
{
    int count = 0;
    for (int i = 0; i < SP1.Length; i++)
    {
    if(SP1[i].Length <= 3)
        {
        SP2[count] = SP1[i];
        count++;
        }
    }
}