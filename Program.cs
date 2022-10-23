// Создадим функцию замены символов

Console.WriteLine("Hello, World!");

string Replace(string strInput, char charFind, char charNew)
{
    string strNew = String.Empty;
    for(int i = 0; i < strInput.Length; i++)
    {
        if (strInput[i] == charFind)
            strNew = strNew + $"{charNew}";
        else
            strNew = strNew + $"{strInput[i]}";
    }
    return strNew;
}
