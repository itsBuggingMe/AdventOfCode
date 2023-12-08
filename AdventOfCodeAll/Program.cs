using AdventOfCodeHelper;

namespace AdventOfCodeAll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console
                .WriteLine(Helper
                .AdventOfCodeInput()
                .Replace('.', '\0')
                .Replace("\n", "")
                .Select(c => (c == '\0' || char.IsDigit(c)) ? (char)ushort.MaxValue : c)
                .Aggregate(Tuple.Create("", "", 0), (tuple, input) => EnumerateStartOne(tuple, input)).Item2
                .Aggregate(Tuple.Create('l', -1, ""), (acc, c) => ReversePlaceChar(acc, c)).Item3
                /*ready for hashset*/.Aggregate());
        }

        private static Tuple<string, string, int> EnumerateStartOne(Tuple<string, string, int> inAgg, char input)
        {
            if (input == '\0' && inAgg.Item1.Length == 0)
            {
                return Tuple.Create("", inAgg.Item2 + input, 0);
            }
            else
            {
                if (input == '\0')
                {
                    return Tuple.Create("", inAgg.Item2 + (char)((inAgg.Item3 + 1) * 1000 + Convert.ToInt32(inAgg.Item1)));
                }
                else
                {
                    return Tuple.Create(inAgg.Item1, inAgg.Item2 + input);
                }
            }
        }

        //pedestal, char left in num, total so far
        private static Tuple<char, int, string> ReversePlaceChar(Tuple<char, int, string> inAgg, char input)
        {
            if (inAgg.Item2 > 0)
            {
                return Tuple.Create(inAgg.Item1, inAgg.Item2 - 1, inAgg.Item3 + inAgg.Item1);
            }
            else
            {
                if (input > 0 && input < ushort.MaxValue - 8)
                {//its a encoded
                    return Tuple.Create(input, input % 1000, inAgg.Item3 + '\0');
                }
                else
                {
                    return Tuple.Create(inAgg.Item1, inAgg.Item2, inAgg.Item3 + input);
                }
            }
        }

    }
}