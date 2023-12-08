namespace AdventOfCodeAll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(File.ReadAllText(Directory.GetParent(System.Reflection.Assembly.GetExecutingAssembly().Location) + "/input3.txt"));
        }
    }
}