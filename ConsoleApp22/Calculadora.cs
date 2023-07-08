namespace ConsoleApp22;

public class Calculadora
{
    public double Pi = 3.14;

    public double Circunferencia(double r)
    {
        return 2.0 * Pi * r;
    }

    public double Volume(double r)
    {
        return 4.0 / 3.0 * Pi * r * Math.Pow(r, 3.0);
    }
}