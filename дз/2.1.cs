string s1 = "1 2 3";
string s = "1 2 3 4 5 6 1 2 3 4 5 1 2 3 4 1 2 3";

int Count(string mainString, string subString)
{
    int count = 0;
    int mainLength = mainString.Length;
    int subLength = subString.Length;

    for (int i = 0; i <= mainLength - subLength; i++)
    {
        bool found = true;
        for (int j = 0; j < subLength; j++)
        {
            if (mainString[i + j] != subString[j])
            {
                found = false;
                break;
            }
        }
        if (found)
        {
            count++;
        }
    }
    return count;
}

int count = Count(s, s1);
Console.WriteLine($"Количество вхождений {count}");
