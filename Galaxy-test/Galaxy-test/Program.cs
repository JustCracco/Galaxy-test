namespace Galaxy_test
{
    class Program
    {
        static void Main(string[] args)
        {
            Film test_film1 = new Film("Spider-Man", "Sam Raimi", 4.8, false);

            Console.WriteLine(test_film1.getRegista());
        }
    }
}