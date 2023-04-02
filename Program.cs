using static System.Console;

class Program
{
    static void Main()
    {
        Write("Ingrese la figura (círculo, cuadrado, triángulo): ");
        string figura = ReadLine().ToLower();

        double area = 0;
        switch (figura)
        {
            case "círculo":
                Write("Ingrese el radio: ");
                double radio = double.Parse(ReadLine());
                area = Math.PI * radio * radio;
                break;

            case "cuadrado":
                Write("Ingrese la medida del lado: ");
                double lado = double.Parse(ReadLine());
                area = lado * lado;
                break;

            case "triángulo":
                Write("Ingrese la medida de la base: ");
                double baseTriangulo = double.Parse(ReadLine());
                Write("Ingrese la medida de la altura: ");
                double alturaTriangulo = double.Parse(ReadLine());
                area = (baseTriangulo * alturaTriangulo) / 2;
                break;

            default:
                WriteLine("La figura ingresada no es válida.");
                return;
        }

        WriteLine($"El área del {figura} es: {area}");
    }
}
