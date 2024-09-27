namespace UIR1010 {
    class Program {
        static void Main(string[] args) {
             string pedidoUm = Console.ReadLine();
             string pedidoDois = Console.ReadLine();

             string[] strPedidoUm = pedidoUm.Split(' ');
             string[] strPedidoDois = pedidoDois.Split(' ');

             string codPecaUm = strPedidoUm[0];
             double quantPecaUm = double.Parse(strPedidoUm[1]);
             double valorPecaUm = double.Parse(strPedidoUm[2]);

             string codPecaDois = strPedidoDois[0];
             double quantPecaDois = double.Parse(strPedidoDois[1]);
             double valorPecaDois = double.Parse(strPedidoDois[2]);
            
            double valorPedidoUm = quantPecaUm*valorPecaUm;
            double valorPedidoDois = quantPecaDois*valorPecaDois;

            double valorPedidoTotal = valorPedidoUm + valorPedidoDois;

            Console.WriteLine($"VALOR A PAGAR: R$ {valorPedidoTotal.ToString("F2")}");

        }
    }
}