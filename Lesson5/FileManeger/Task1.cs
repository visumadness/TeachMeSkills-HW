using FileManeger;
using System.Text;
using static System.Net.Mime.MediaTypeNames;
using System.Text.RegularExpressions;

namespace FileManager
{
    internal static class Task1
    {
        private const string EmptySourceError = "Empty source.";
        private const string ThereIsNothingToUpdate = "There is nothing to update";
        private const string SourceIsUpdated = "Source is updated";
        private const string FileNameArgValidationFailed = "Unable to find file or it's not speciefied";
        private const string ChooseActionMessage = "Please choose action (enter any symbol out of menu to exit):";

        private static readonly char[] SentenceChars = new char[] { '.', '!', '?'};
        private static readonly char[] PunctiationChars = new char[] { ' ', ',', ')', '(', '~', '[', ']', '.', '-', '"', '!', ';', '?', '\n' };
        private static readonly char[] CommaChars = new char[] { '.', '\n' };
        private static string filePath = @"file path";
        private static string text = string.Empty;


        internal static int Main()
        {
            string text = string.Empty;
            text = File.ReadAllText(filePath);

            if (text == string.Empty)
            {
                Console.WriteLine(EmptySourceError);
                return 1;
            }

            MenuAction action;
            do
            {
                ShowMenu();
                action = GetUserMenuAction(Console.ReadLine());
                Console.WriteLine(ExecuteActionOnFile(action, text));
                return 0;
            }
            while (action != MenuAction.Exit);
        }

        private static void ShowMenu()
        {

            Console.WriteLine(ChooseActionMessage);
            var allActions = Enum.GetValues<MenuAction>();
            foreach (var action in allActions)
            {
                Console.WriteLine(GetMessageByMenuAction(action));
            }
        }

        static MenuAction GetUserMenuAction(string input) =>
                    int.TryParse(input, out var actionNumber)
                    ? Enum.IsDefined((MenuAction)actionNumber) ? (MenuAction)actionNumber : MenuAction.Exit
                    : MenuAction.Exit;

        private static string ExecuteActionOnFile(MenuAction action, string fileName)
        {
            string filePath = @"C:\Users\VISU\Desktop\Test.txt";
            var sourceText = File.ReadAllText(filePath);
            if (string.IsNullOrWhiteSpace(sourceText))
            {
                return EmptySourceError;
            }

            return action switch
            {
                MenuAction.Exit => "Goodbye!",
                MenuAction.FindLargestWord => FindLargestWordAction(sourceText),
                MenuAction.ReplaceNumbersWithWords => ReplaceNumbersWithWordsAction(sourceText),
                MenuAction.ShowIntonationSentences => IntonationSentencesAction(sourceText),
                MenuAction.ShowSimpleSentences => ShowSimpleSentencesAction(sourceText),
                MenuAction.FindWordsWithSameStartAndEnd => FindWordsWithSameStartAndEndAction(sourceText),
                _ => string.Empty
            };
        }

        private static string FindLargestWordAction(string source)
        {
            var allWords = GetAllWords(source);

            var words = allWords.OrderByDescending(x => x.Length).FirstOrDefault();

            var countWord = allWords.Count(x => x == words);

            return $"The lergest word is \"{words}\"\n It has {countWord} repetitions";
        }

        private static string ReplaceNumbersWithWordsAction(string source)
        {
            string updatedText = null;
            for (var i = 0; i < 9; i++)
            {
                var replaceWith = GetDigitRepresentation(i);
                updatedText = source.Replace(i.ToString(), replaceWith);
            }

            if (source == updatedText)
            {
                return ThereIsNothingToUpdate;
            }

            File.WriteAllText(filePath, updatedText);
            return SourceIsUpdated;
        }

        private static string IntonationSentencesAction(string source)
        {
            var sentences = filePath.Split(SentenceChars);

            foreach (string sentence in sentences)
            {
                if (sentence.Contains('?') == true)
                {
                    Console.WriteLine(sentence.Trim());
                }
                if (sentence.Contains('!') == true)
                {
                    Console.WriteLine(sentence.Trim());
                }
            }
            return @$"Questins:{Environment.NewLine}'?'{Environment.NewLine}Exclamations:{Environment.NewLine}'!'";
        }

        private static string ShowSimpleSentencesAction(string source)
        {
            var sentences = source.Split(SentenceChars);
            
            foreach (string sentence in sentences)
            {
                if (sentence.Contains(',') == false)
                {
                    Console.WriteLine(sentence.Trim());
                }
            }

            return $"Simple sentences:{Environment.NewLine}','";
        }

        private static string FindWordsWithSameStartAndEndAction(string source)
        {
            var words = GetAllWords(source);
            var repeatingSymbolWords = new StringBuilder();
            foreach (var word in words)
            {
                var startingSymbol = word[0];
                if (word.EndsWith(startingSymbol))
                {
                    repeatingSymbolWords.AppendLine(word);
                }
            }

            
            return $"Repeating symbol words:{Environment.NewLine}{repeatingSymbolWords}";
        }


        private static string[] GetAllWords(string source)
        {
            var wordSeparators = CombineArrays(SentenceChars, PunctiationChars, CommaChars);
            return source.Split(wordSeparators, StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
        }

        private static string GetDigitRepresentation(int digit) => digit switch
        {
            1 => "one",
            2 => "two",
            3 => "three",
            4 => "four",
            5 => "five",
            6 => "six",
            7 => "seven",
            8 => "eight",
            9 => "nine",
            0 => "zero",
            _ => throw new ArgumentException("Not a digit")
        };

        private static string GetMessageByMenuAction(MenuAction action) => action switch
        {
            MenuAction.Exit => $"{(int)MenuAction.Exit} - Exit",
            MenuAction.FindLargestWord => $"{(int)MenuAction.FindLargestWord} - Show the largest word and its repetitions",
            MenuAction.ReplaceNumbersWithWords => $"{(int)MenuAction.ReplaceNumbersWithWords} - Replace numbers with words",
            MenuAction.ShowIntonationSentences => $"{(int)MenuAction.ShowIntonationSentences} - Show intonation sentences",
            MenuAction.ShowSimpleSentences => $"{(int)MenuAction.ShowSimpleSentences} - Show simple sentences",
            MenuAction.FindWordsWithSameStartAndEnd => $"{(int)MenuAction.FindWordsWithSameStartAndEnd} - Show words with same first and last letters",
            _ => string.Empty
        };

        private static char[] CombineArrays(params char[][] arrays)
        {
            var commonLength = 0;
            foreach (var array in arrays)
            {
                commonLength += array.Length;
            }

            var resultArray = new char[commonLength];
            var indexToInsert = 0;
            foreach (var array in arrays)
            {
                Array.Copy(array, 0, resultArray, indexToInsert, array.Length);
                indexToInsert += array.Length;
            }

            return resultArray;
        }

    }
}



