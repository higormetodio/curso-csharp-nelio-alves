using ExercicioResolvido.Entities;
using ExercicioResolvido.Entities.Enums;

Console.Clear();

List<Shape> shapes = new List<Shape>();

Console.Write("Enter the number of shapes: ");
int number = int.Parse(Console.ReadLine());

for (int i = 1; i <= number; i++)
{
    Console.WriteLine($"Shape #{i} data:");
    Console.Write("Rectangle or Circle (r/c)? ");
    char answer = char.Parse(Console.ReadLine());
    Console.Write("Color (Black/Blue/Red): ");
    Color color = Enum.Parse<Color>(Console.ReadLine());

    switch (answer)
    {
        case 'r':
            Console.Write("Width: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            double height = double.Parse(Console.ReadLine());
            shapes.Add(new Rectangle(width, height, color));
            break;
        case 'c':
            Console.Write("Radius: ");
            double radius = double.Parse(Console.ReadLine());
            shapes.Add(new Circle(radius, color));
            break;
    }
}

Console.WriteLine("SHAPE AREAS:");
foreach (var shape in shapes)
{
    Console.WriteLine(shape.Area().ToString("F2"));
}

