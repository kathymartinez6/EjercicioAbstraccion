
namespace EjercicioAbstraccion
{
    public class VolumenCubo(double Lado) : FormulaMatematica
    {
        public double Lado = Lado;
        public double Volumen;

        public override void Calcular()
        {
            Volumen = Math.Pow(Lado, 3);
        }

        public override void Imprimir()
        {
            Console.WriteLine($"El volumen de un cubo con lado {Lado} es: {Volumen}");
        }
    }
}
