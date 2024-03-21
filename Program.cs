static string Prompt(string message)
{
    Console.WriteLine(message);
    string input = Console.ReadLine();
    if (input == String.Empty)
    {
        Prompt("Введите строки для массива через пробел: ");
    }
    return input;
}


string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

static string[] resultArray(string[] words)
{
    string[] tempArray = new string[words.Length];
    int newLength = 0;
    for (int i = 0; i < words.Length; i++)
    {
        if (words[i].Length < 4)
        {

            tempArray[newLength] = words[i];
            newLength++;
        }
    }
string[] resultArray = new string[newLength];
for (int i = 0; i < newLength; i++)
    {
        resultArray[i] = tempArray[newLength];
    }
    return resultArray;
}



string input = Prompt("Введите строки для массива через пробел: ");
Console.WriteLine(input);
