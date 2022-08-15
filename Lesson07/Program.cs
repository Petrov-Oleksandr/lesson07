
static bool Compare(string str1, string str2)
{
    if (str1==str2)
    {
     return true;
    }
    return false;   
}

static void Analyze(string str1)
{
    int digit = 0;
    int lower = 0;
    int letter = 0;
    int punctuation = 0; 
    int other = 0;  

    for (int i = 0; i < str1.Length; i++)
    {
        if (Char.IsDigit(str1[i]))
        {
         digit++;
        }        
        if (Char.IsLower(str1[i]))
        {
         lower++;
        }        
        if (Char.IsLetter(str1[i]))
        {
          letter++;
        }        
        if (Char.IsPunctuation(str1[i]))
        {
          punctuation++;
        }        
    }
    other = str1.Length - digit - letter - punctuation;

    Console.WriteLine($"Digits characters = {digit}");
    Console.WriteLine($"Lowers characters = {lower}");
    Console.WriteLine($"Letters characters = {letter}");
    Console.WriteLine($"Punctuations characters = {punctuation}");
    Console.WriteLine($"Other characters = {other}");

}

static string Sort(string str1)
{
    string str2 = str1.ToLower();

    char[] alphabet = str2.ToCharArray();

    for (int b = 0; b < str1.Length; b++)
    {
        for (int i = 1; i < str1.Length; i++)
        {           
            int cmpVal = str1[i].CompareTo(str1[i - 1]);

            if (cmpVal < 0)
            {
                char x = alphabet[i];
                alphabet[i] = alphabet[i - 1];
                alphabet[i - 1] = x;
            }
            str1 = new string(alphabet);
        }     
    }
    Console.WriteLine(str1);
    return str1;
}

static string Duplicate(string str1)
{
    string str2 = str1.ToLower();
    char[] duplicate = str2.ToCharArray();
    char[] duplicate1 = new char[str1.Length];

    int y = 0;

    for (int i = 0; i < str1.Length; i++)
    {
        for (int x = i + 1; x < str1.Length; x++)
        {
            if (duplicate[i] == duplicate[x])
            {
                duplicate1[y] = duplicate[i];
                y++;
            }
        }         
    }
    str1 = new string(duplicate1);
    return str1;
}


string str1 = "555a";
string str2 = "555a";
string str3 = "~53!.,dvrrHGYMT";
string str4 = "Hello";
string str5 = "Hello and hi";

Console.WriteLine(Compare(str1, str2));

Analyze(str3);

Sort(str4);

Console.WriteLine(Duplicate(str5)); 