namespace UIR1017 {
    class Program {
        static void Main(string[] args) {
            
            double tempoViagem = double.Parse(Console.ReadLine());
            double velocidadeMedia = double.Parse(Console.ReadLine());
            double consumo = 12;
            double consumoMedio = (tempoViagem * velocidadeMedia)/consumo;
            Console.WriteLine($"{consumoMedio.ToString("F3")}");
        }
    }
}