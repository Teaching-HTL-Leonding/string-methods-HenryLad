

#region String.Contains
bool Contains(char c, string s)
{
    for (int i = 0; i < s.Length; i++)
    {
        if (s[i] == c)
        {
            return true;
        }
    }
    return false;
}

#endregion
#region String.IndexOf

int IndexOf(char c, string s)
{
    for (int i = 0; i < s.Length; i++)
    {
        if (s[i] == c)
        {
            return i;
        }
    }
    return -1;
}

#endregion
#region String.LastIndexOf

int LastIndexOf(char c, string s)
{
    for (int i = s.Length - 1; i >= 0; i--)
    {
        if (s[i] == c)
        {
            return i;
        }
    }
    return -1;
}

#endregion
#region TrimEnd TrimStart Trim


#endregion
#region String.SubString

string SubString(int SubString1, string s, int SubString2)
{
    string SubString = "";
    for (int i = SubString1; i < SubString2 + 1; i++)
    {
        SubString += s[i];
    }
    return SubString;
}
{
    
}


#endregion
#region String.Remove
string Remove(int SubString1, string s, int SubString2)
{
    string Remove = "";
    for (int i = 0; i < s.Length; i++)
    {
        if (i < SubString1 || i > SubString2)
        {
            Remove += s[i];
        }
    }
    return Remove;
}

#endregion
void CallMethod()
{
    char c;
    string s;
    int SubString1;
    int SubString2;
    string Descion;
   do
   {
      System.Console.WriteLine("Please enter which Method you want to use");
      Descion = System.Console.ReadLine()!;
      switch (Descion)
      {
         case "Contains":
            System.Console.WriteLine("Please enter a char");
            c = char.Parse(System.Console.ReadLine()!);
            System.Console.WriteLine("Please enter a string");
            s = System.Console.ReadLine()!;
            System.Console.WriteLine("Contains: " + Contains(c, s));
            break;
         case "IndexOf":
            System.Console.WriteLine("Please enter a char");
            c = System.Console.ReadLine()![0];
            System.Console.WriteLine("Please enter a string");
            s = System.Console.ReadLine()!;
            System.Console.WriteLine("IndexOf: " + IndexOf(c, s));
            break;
         case "LastIndexOf":
            System.Console.WriteLine("Please enter a char");
            c = char.Parse(System.Console.ReadLine()!);
            System.Console.WriteLine("Please enter a string");
            s = System.Console.ReadLine()!;
            System.Console.WriteLine("LastIndexOf: " + LastIndexOf(c, s));
            break;
         case "Trim":
            System.Console.WriteLine("Sry this Method isn't working jet.");
            CallMethod();
            break;
         case "SubString":
            System.Console.WriteLine("Please enter a string");
            s = System.Console.ReadLine()!;
            System.Console.WriteLine("Please enter a start index");
            SubString1 = int.Parse(System.Console.ReadLine()!);
            System.Console.WriteLine("Please enter a end index");
            SubString2 = int.Parse(System.Console.ReadLine()!);
            System.Console.WriteLine("SubString: " + SubString(SubString1, s, SubString2));
            break;
         case "Remove":
            System.Console.WriteLine("Please enter a string");
            s = System.Console.ReadLine()!;
            System.Console.WriteLine("Please enter a start index");
            SubString1 = int.Parse(System.Console.ReadLine()!);
            System.Console.WriteLine("Please enter a end index");
            SubString2 = int.Parse(System.Console.ReadLine()!);
            System.Console.WriteLine("Remove: " + Remove(SubString1, s, SubString2));
            break;
         case "exit":
            Environment.Exit(0);
            break;
            default:
            System.Console.WriteLine("Please enter a valid Method");
            CallMethod();
            break;
   }}while(Descion != "exit");
    
}
CallMethod();
