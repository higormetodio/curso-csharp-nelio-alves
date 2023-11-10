using System.Diagnostics.Contracts;

namespace ListaExercicio
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; private set; }

        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }
        public void IncreaseSalary(double percent)
        {
            Salary += Salary * (percent / 100.0);
        }

        public override string ToString()
        {
            return $"{Id}, {Name}, {Salary:F2}";
        }
    }
}