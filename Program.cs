namespace _03272
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager m = new Manager();

            Console.WriteLine( m.GetStartup().ToString() );

           // m.Startup = DateTime.UtcNow;

            Console.WriteLine( m.GetStartup().ToString());
        }
    }
}
