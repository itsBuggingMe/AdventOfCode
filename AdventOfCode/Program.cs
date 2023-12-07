using AdventOfCodeHelper;

namespace AdventOfCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Advent of code DAY 1. One semicolon used.\nPart one: {File.ReadAllText($"{Directory.GetParent(System.Reflection.Assembly.GetExecutingAssembly().Location)}/input.txt").Split("\n").Sum((line) => int.Parse(line.SkipWhile((charInString) => !char.IsDigit(charInString)).First() + "" + line.Reverse().SkipWhile((charInString) => !char.IsDigit(charInString)).First()))}\nPart two {File.ReadAllText($"{Directory.GetParent(System.Reflection.Assembly.GetExecutingAssembly().Location)}/input.txt").Split("\n").Sum((line) => Convert.ToInt32(line.Aggregate("", (PrevAcc, _char) => (PrevAcc.Length != 0 && PrevAcc[^1] != '.') || PrevAcc.Length == 0 ? !new string[] { "orez", "eno", "owt", "eerht", "ruof", "evif", "xis", "neves", "thgie", "enin", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" }.All((nums) => !string.Join("", (PrevAcc + _char).Reverse()).StartsWith(nums)) ? PrevAcc + _char + '.' : PrevAcc + _char : PrevAcc, (finalFString) => new string[] { "orez", "eno", "owt", "eerht", "ruof", "evif", "xis", "neves", "thgie", "enin", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" }.ToList().FindIndex((s) => string.Join("", finalFString[..^1].Reverse()).StartsWith(s))) % 10 + "" + string.Join("", line.Reverse()).Aggregate("", (PrevAcc, _char) => (PrevAcc.Length != 0 && PrevAcc[^1] != '.') || PrevAcc.Length == 0 ? !new string[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" }.All((nums) => !string.Join("", (PrevAcc + _char).Reverse()).StartsWith(nums)) ? PrevAcc + _char + '.' : PrevAcc + _char : PrevAcc, (finalFString) => new string[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" }.ToList().FindIndex((s) => string.Join("", finalFString[..^1].Reverse()).StartsWith(s))) % 10))}");
        }

        /*
        private static int GetCountFront(string line)
        {
            return line.Aggregate("", 
                (PrevAcc, _char) => (PrevAcc.Length != 0 && PrevAcc[^1] != '.') || PrevAcc.Length == 0 ? 
                    !new string[] { "orez", "eno", "owt", "eerht", "ruof", "evif", "xis", "neves", "thgie", "enin", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" }.All((nums) => !string.Join("", (PrevAcc + _char).Reverse()).StartsWith(nums)) ? PrevAcc + _char + '.' : PrevAcc + _char : PrevAcc,
                
                (finalFString) =>
                    new string[] { "orez", "eno", "owt", "eerht", "ruof", "evif", "xis", "neves", "thgie", "enin", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" }.ToList().FindIndex((s) => string.Join("", finalFString[..^1].Reverse()).StartsWith(s)))
                 % 10;
        }

        private static int GetCountBack(string line)
        {
            return string.Join("", line.Reverse()).Aggregate("",
                (PrevAcc, _char) => (PrevAcc.Length != 0 && PrevAcc[^1] != '.') || PrevAcc.Length == 0 ?
                    !new string[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" }.All((nums) => !string.Join("", (PrevAcc + _char).Reverse()).StartsWith(nums)) ? PrevAcc + _char + '.' : PrevAcc + _char : PrevAcc,

                (finalFString) =>
                    new string[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" }.ToList().FindIndex((s) => string.Join("", finalFString[..^1].Reverse()).StartsWith(s)))
                 % 10;
        }

        private static readonly string[] Nums = new string[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        private static readonly string[] NumsRev = new string[] { "orez", "eno", "owt", "eerht", "ruof", "evif", "xis", "neves", "thgie", "enin", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        private static readonly string[] NumsDig = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };*/
    }
}