namespace AdventOfCodeHelper
{
    public class Helper
    {
        public static string AdventOfCodeInput()
        {
            return File.ReadAllText($"{Directory.GetParent(System.Reflection.Assembly.GetExecutingAssembly().Location)}/input.txt");
        }
    }
}