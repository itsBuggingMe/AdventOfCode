Console
    .WriteLine("Advent of code DAY 2. One semicolon used. \nPart One: " + File
    .ReadAllText(Directory
    .GetParent(System.Reflection.Assembly
    .GetExecutingAssembly().Location) + "/input.txt")
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
    .GetExecutingAssembly().Location) + "/input.txt")
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