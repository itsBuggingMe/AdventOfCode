namespace AdventOfCodeAll
{
    internal static class Days
    {
        public static void Run(int day)
        {
            switch(day)
            {
                case 1:
                    DayOne();
                    break;
                case 2:
                    DayTwo();
                    break;
                case 3:
                    DayOne();
                    break;
                default:
                    throw new NotImplementedException();
            }
        }

        private static void DayOne() => Console
            .WriteLine("Advent of code DAY 1. One semicolon used. \n Part One: " + File
            .ReadAllText(Directory
            .GetParent(System.Reflection.Assembly
            .GetExecutingAssembly().Location) + "/input1.txt")
            .Split("\n")
            .Sum((line) => int
            .Parse(line
            .SkipWhile((charInString) => !char
            .IsDigit(charInString))
            .First() + "" + line
            .Reverse()
            .SkipWhile((charInString) => !char
            .IsDigit(charInString))
            .First())) + "\n Part Two: " + File
            .ReadAllText(Directory
            .GetParent(System.Reflection.Assembly
            .GetExecutingAssembly().Location) + "/input1.txt")
            .Split("\n")
            .Sum((line) => Convert
            .ToInt32(line
            .Aggregate("", (PrevAcc, _char) => (PrevAcc.Length != 0 && PrevAcc[^1] != '.') || PrevAcc.Length == 0 ? !new string[] { "orez", "eno", "owt", "eerht", "ruof", "evif", "xis", "neves", "thgie", "enin", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" }
            .All((nums) => !string
            .Join("", (PrevAcc + _char)
            .Reverse())
            .StartsWith(nums)) ? PrevAcc + _char + '.' : PrevAcc + _char : PrevAcc, (finalFString) => new string[] { "orez", "eno", "owt", "eerht", "ruof", "evif", "xis", "neves", "thgie", "enin", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" }
            .ToList()
            .FindIndex((s) => string
            .Join("", finalFString[..^1]
            .Reverse())
            .StartsWith(s))) % 10 + "" + string
            .Join("", line
            .Reverse())
            .Aggregate("", (PrevAcc, _char) => (PrevAcc.Length != 0 && PrevAcc[^1] != '.') || PrevAcc.Length == 0 ? !new string[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" }
            .All((nums) => !string
            .Join("", (PrevAcc + _char)
            .Reverse())
            .StartsWith(nums)) ? PrevAcc + _char + '.' : PrevAcc + _char : PrevAcc, (finalFString) => new string[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" }
            .ToList()
            .FindIndex((s) => string
            .Join("", finalFString[..^1]
            .Reverse())
            .StartsWith(s))) % 10)));

        private static void DayTwo() => Console
            .WriteLine("Advent of code DAY 2. One semicolon used. \nPart One: " + File
            .ReadAllText(Directory
            .GetParent(System.Reflection.Assembly
            .GetExecutingAssembly().Location) + "/input2.txt")
            .Split('\n')
            .Sum((Aline) => Aline[(Aline
            .TakeWhile((c) => c != ':')
            .Count() + 2)..]
            .Replace(" ", "")
            .Replace("blue", "b")
            .Replace("red", "r")
            .Replace("green", "g")
            .Replace("\r", "")
            .Split(';')
            .All((bagBatch) => bagBatch
            .Split(',')
            .All((colorCount) => colorCount[^1] == 'r' ? Convert
            .ToInt32(colorCount[..^1]) <= 12 : (colorCount[^1] == 'g' ? Convert
            .ToInt32(colorCount[..^1]) <= 13 : Convert
            .ToInt32(colorCount[..^1]) <= 14))) ? Convert
            .ToInt32(string.Join("", Aline[5..]
            .TakeWhile(char
            .IsDigit))) : 0) + "\nPart 2: " + File
            .ReadAllText(Directory
            .GetParent(System.Reflection.Assembly
            .GetExecutingAssembly().Location) + "/input2.txt")
            .Split('\n')
            .Sum(Aline => new char[] { 'a', 'b', 'c' }
            .Aggregate(1, (prevInt, oneKey) => prevInt * Aline[(Aline
            .TakeWhile(c => c != ':')
            .Count() + 2)..]
            .Replace(" ", "")
            .Replace("red", "a")
            .Replace("green", "b")
            .Replace("blue", "c")
            .Replace("\r", "")
            .Split(';')
            .Aggregate(0, (prevInt, thisBatch) => thisBatch.Contains(oneKey) ? (prevInt < Convert
            .ToInt32(string
            .Join("", thisBatch[..thisBatch
            .IndexOf(oneKey)]
            .Reverse()
            .TakeWhile(char
            .IsDigit)
            .Reverse())) ? Convert
            .ToInt32(string
            .Join("", thisBatch[..thisBatch
            .IndexOf(oneKey)]
            .Reverse()
            .TakeWhile(char
            .IsDigit)
            .Reverse())) : prevInt) : prevInt))));


    }
}
