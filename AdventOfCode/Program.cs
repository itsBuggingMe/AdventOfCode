using AdventOfCodeHelper;

namespace AdventOfCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(File.ReadAllText($"{Directory.GetParent(System.Reflection.Assembly.GetExecutingAssembly().Location)}/input.txt").Split("\n").Sum((line) => int.Parse(line.SkipWhile((charInString) => !char.IsDigit(charInString)).First() + "" + line.Reverse().SkipWhile((charInString) => !char.IsDigit(charInString)).First())));


            Console.WriteLine(Helper.AdventOfCodeInput().Split("\n").Sum(
                (line) => char.IsDigit(line[0]) ? (line[0] - '0') : new string[] {"one", "two", "three", "four", "five", "six", "seven", "eight", "nine" }.Where()
                ));

            Console.WriteLine();
        }

        private static string IsolateFrontSection(string line)
        {
            return string.Join("", line.ToCharArray().TakeWhile((c) => !char.IsDigit(line[0]) && !char.IsDigit(c))) + (char.IsDigit(line[0]) ? line[0] : "");
        }
    }
}