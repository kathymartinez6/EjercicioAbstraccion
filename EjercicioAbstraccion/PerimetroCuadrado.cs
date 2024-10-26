

namespace EjercicioAbstraccion
{
    public class PerimetroCuadrado(double Lado) : FormulaMatematica
    {
        private double Lado { get; set; } = Lado;
        private double Perimetro { get; set; }
        public override void Calcular()
        {
            Perimetro = Lado * 4;
        }

        public override void Imprimir()
        {
            Console.WriteLine($"El perímetro del cuadrado es: {Perimetro}");
        }
    }
}
