namespace Billetes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Euro euro = new Euro(1);
            Pesos pe = new Pesos(1);
            Dolar dolar = new Dolar(1);

            Euro res = euro - dolar;
            Console.WriteLine(res.GetCantidad());
        }
    }
}