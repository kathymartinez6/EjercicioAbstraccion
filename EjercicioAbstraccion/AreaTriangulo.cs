
namespace EjercicioAbstraccion
{
    public class AreaTriangulo: FormulaMatematica
    {
        public double Base;
        public double Altura;

        public AreaTriangulo(double baseTriangulo,
                             double altura)
        {
            Base = baseTriangulo;
            Altura = altura;
        }

        public int area { get; private set; }

        public override void Calcular()
        {
            area = (int)(Base * Altura);
        }

        public override void Imprimir()
        {
            Console.WriteLine($"El área del triángulo con base {Base} y altura {Altura} es: es: {area}");
        }
    }
}
