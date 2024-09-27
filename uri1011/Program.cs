namespace URI1011 {
    class Program {
        static void Main(string[] args) {
            double pi = 3.14159;
            double r = double.Parse(Console.ReadLine());
            double valumeEspera = (4.0/3.0)*pi*Math.Pow(r, 3);
            Console.WriteLine($"VOLUME = {valumeEspera.ToString("F3")}");
        }
    }
}