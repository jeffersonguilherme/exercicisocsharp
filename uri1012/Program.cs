namespace URI1013 {
    class Program {
        static void Main(string[] args) {

            double a, b, c, areaTrigandulo, areaCirculo, areaTrapezio, areaQuadrado, areaRetangulo;
                        
            string medidas = Console.ReadLine();
            string[] medidasIntervalo = medidas.Split(' ');

            a = double.Parse(medidasIntervalo[0]); 
            b = double.Parse(medidasIntervalo[1]); 
            c = double.Parse(medidasIntervalo[2]);

            areaTrigandulo =  (a * c)/2;
            areaCirculo = 3.14159 * Math.Pow(c, 2);
            areaTrapezio = ((a + b) * c)/2;
            areaQuadrado = Math.Pow(b, 2);
            areaRetangulo = a * b;
            Console.WriteLine($"TRIANGULO: {areaTrigandulo.ToString("F3")}");
            Console.WriteLine($"CIRCULO: {areaCirculo.ToString("F3")}");
            Console.WriteLine($"TRAPEZIO: {areaTrapezio.ToString("F3")}");
            Console.WriteLine($"QUADRADO: {areaQuadrado.ToString("F3")}");
            Console.WriteLine($"RETANGULO: {areaRetangulo.ToString("F3")}");
        }
    }
}