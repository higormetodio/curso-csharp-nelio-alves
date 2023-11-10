using ExercicioResolvido.Entities;

HashSet<LogRecord> set = new HashSet<LogRecord>();

Console.WriteLine("Enter file full path: ");
string path = Console.ReadLine();

try
{
    using (StreamReader sr = File.OpenText(path))
    {
        while (!sr.EndOfStream)
        {
            string[] lines = sr.ReadLine().Split(' ');
            string name = lines[0];
            DateTime instant = Convert.ToDateTime(lines[1]);
            set.Add(new LogRecord { UserName = name, Instant = instant });
        }

        Console.WriteLine($"Total users: {set.Count}");
    }
}
catch (IOException e)
{
    Console.WriteLine(e.Message);
}