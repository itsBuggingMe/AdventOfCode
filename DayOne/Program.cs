Console
    .WriteLine("Advent of code DAY 1. One semicolon used. \n Part One: " + File
    .ReadAllText(Directory
    .GetParent(System.Reflection.Assembly
    .GetExecutingAssembly().Location) + "/input.txt")
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
    .GetExecutingAssembly().Location) + "/input.txt")
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