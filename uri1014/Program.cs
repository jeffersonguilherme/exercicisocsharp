namespace URI1014 {
    class Program {
        static void Main(string[] args) {
            double x, y, consumo;
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            consumo = x / y;
            Console.WriteLine($"{consumo.ToString("F3")} km/l");

        }
    }
}
