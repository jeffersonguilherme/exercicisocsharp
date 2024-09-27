namespace URI1007{
    class Program {
        static void Main(string[] args) {
            double a, b, c, d, diferenca;
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());
            d = double.Parse(Console.ReadLine());
            diferenca = (a * b) - (c * d);
            Console.WriteLine($"DIFERENCA = {diferenca}");
        }
    }
}