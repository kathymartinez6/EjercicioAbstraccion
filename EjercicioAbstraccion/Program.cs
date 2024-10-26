namespace EjercicioAbstraccion
{
class Program
{
    static void Main(string[] args)
    {
            ArgumentNullException.ThrowIfNull(args);

            while (true)
        {
            Console.WriteLine("Seleccione la fórmula matemática:");
            Console.WriteLine("1. Área de un rectángulo");
            Console.WriteLine("2. Perímetro de un cuadrado");
            Console.WriteLine("3. Volumen de un cubo");
            Console.WriteLine("4. Salir");

            int opcion = Convert.ToInt32(Console.ReadLine());

            FormulaMatematica? formula = null;

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese el largo del rectángulo: ");
                    double largo = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Ingrese el ancho del rectángulo: ");
                    double ancho = Convert.ToDouble(Console.ReadLine());
                    formula = new AreaTriangulo(largo, ancho);
                    break;

                case 2:
                    Console.Write("Ingrese el lado del cuadrado: ");
                    double ladoCuadrado = Convert.ToDouble(Console.ReadLine());
                    formula = new PerimetroCuadrado(ladoCuadrado);
                    break;

                case 3:
                    Console.Write("Ingrese el lado del cubo: ");
                    double ladoCubo = Convert.ToDouble(Console.ReadLine());
                    formula = new VolumenCubo(ladoCubo);
                    break;

                case 4:
                    return;

                default:
                    Console.WriteLine("Opción no válida.");
                    continue;
            }

            formula.Calcular();
            formula.Imprimir();
            Console.WriteLine();
        }
    }

  }
}
