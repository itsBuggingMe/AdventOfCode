namespace AdventOfCodeHelper
{
    public class Helper
    {
        public static string AdventOfCodeInput()
        {
            return File.ReadAllText($"{Directory.GetParent(System.Reflection.Assembly.GetExecutingAssembly().Location)}/input.txt");
        }

        public static T Write<T>(in T input)
        {
            Console.WriteLine(input);
            return input;
        }
    }
}