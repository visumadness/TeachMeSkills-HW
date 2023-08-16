using System.IO;
using System.Text.RegularExpressions;
const string StartMessage = "Solving tasks 5 lessons";
const string ErrorMessage = "Could not find or read file!";

Console.WriteLine(StartMessage);

//////////////////////////////////////////////////////////////////////////////////

string filePath = @"C:\Users\VISU\Desktop\Test.txt";
string text = string.Empty;

using (StreamReader reader = new StreamReader(filePath))
{
    text = await reader.ReadToEndAsync();
}
Console.WriteLine(text);
if (text == string.Empty)
{
    Console.WriteLine(ErrorMessage);
    return;
}

//////////////////////////////////////////////////////////////////////////////////

var txtSplit = text.Split(' ', ',', ')', '(', '~', '[', ']', '.', '-', '"', '!', ';','?', '\n');

var words = txtSplit.OrderByDescending(x => x.Length).FirstOrDefault();

var countWord = txtSplit.Count(x => x == words);

Console.WriteLine(countWord);
Console.WriteLine(words + "\n");

////////////////////////////////////////////////////////////////////////////////

text = text
    .Replace("0", "zero")
    .Replace("1", "one")
    .Replace("2", "two")
    .Replace("3", "three")
    .Replace("4", "four")
    .Replace("5", "five")
    .Replace("6", "six")
    .Replace("7", "seven")
    .Replace("8", "eight")
    .Replace("9", "nine");

Console.WriteLine(text + "\n");

//////////////////////////////////////////////////////////////////////////////////

txtSplit = text.Split('.', '\n');

foreach (string sentence in txtSplit)
{
    if (sentence.Contains('?') == true)
    {
        Console.WriteLine(sentence.Trim());
    }
    if (sentence.Contains('!') == true)
    {
        Console.WriteLine(sentence.Trim());
        return;
    }
}

////////////////////////////////////////////////////////////////////////////////

txtSplit = text.Split('.', '!', '?');

foreach (string sentence in txtSplit)
{
    if (sentence.Contains(',') == false)
    {
        Console.WriteLine(sentence.Trim());
    }
}

////////////////////////////////////////////////////////////////////////////////


foreach (Match match in Regex.Matches(text, @"\b([A-Za-z])[A-Za-z]+?\1\b",RegexOptions.IgnoreCase))
{
    Console.Write(match.Value + "\t");
}