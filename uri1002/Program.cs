namespace URI1002 {
    class Program {
        static void Main(string[] args) {
            double r = double.Parse(Console.ReadLine());
            double pi = 3.14159;
            double A = pi*Math.Pow(r, 2);
            Console.WriteLine($"A={A.ToString("F4")}");
        }
    }
}