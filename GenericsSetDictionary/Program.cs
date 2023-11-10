HashSet<Student> students = new HashSet<Student>();

Console.Write("How many students for course A? ");
int numberStudentsA = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= numberStudentsA; i++)
{
    students.Add(new Student { Id = Convert.ToInt32(Console.ReadLine()), Course = 'A' });
}

Console.Write("How many students for course B? ");
int numberStudentsB = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= numberStudentsB; i++)
{
    students.Add(new Student { Id = Convert.ToInt32(Console.ReadLine()), Course = 'B' });
}

Console.Write("How many students for course C? ");
int numberStudentsC = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= numberStudentsC; i++)
{
    students.Add(new Student { Id = Convert.ToInt32(Console.ReadLine()), Course = 'C' });
}

Console.WriteLine();

Console.WriteLine($"Total students: {students.Count}");