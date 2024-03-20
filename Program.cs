static string Prompt (string message)
{
Console.WriteLine(message);
string input = Console.ReadLine();
if (input == String.Empty)
{
Prompt("Введите строки для массива через пробел: ");
}
return input;
}
string input = Prompt("Введите строки для массива через пробел: ");
Console.WriteLine(input);

string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
for (int i = 0; i < words.Length; i++)
{
    if 
Console.Write(words[i]);   
}

