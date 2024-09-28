namespace URI1015{
    class Program {
        static void Main(string[] args) {
            double xUm, yUm, xDois, yDois, diferenca, distancia;
            string pUm = Console.ReadLine();
            string pDois = Console.ReadLine();

            string[] pontoUm = pUm.Split(' ');
            string[] pontoDois = pDois.Split(' ');

            xUm = double.Parse(pontoUm[0]);
            yUm = double.Parse(pontoUm[1]);

            xDois = double.Parse(pontoDois[0]);
            yDois = double.Parse(pontoDois[1]);

            diferenca = Math.Pow((xDois - xUm), 2) + Math.Pow((yDois - yUm), 2);
            distancia = Math.Sqrt(diferenca);

            Console.WriteLine(distancia.ToString("F4"));



        }
    }
}