using Shapes;

IShapes shape;
Dictionary<string,string> answer = new Dictionary<string,string>();
while (true)
{ 
    Console.WriteLine("выберите фигуру: 1 - круг, 2 - треугольник");
    string choise = Console.ReadLine();

    if (choise == "1")
    {
        Console.WriteLine("Введите радиус круга");
        shape = new Circle(Console.ReadLine());
        answer = shape.getInfo();
    }
    else
    {
        Console.WriteLine("Введите три стороны треугольника через пробел");
        shape = new Triangle(Console.ReadLine());
        answer = shape.getInfo();
    }
    foreach (var ans in answer)
    {
        Console.WriteLine($"{ans.Key}: {ans.Value}");
    }
    Console.WriteLine();
    Console.WriteLine();
}