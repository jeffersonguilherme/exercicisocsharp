namespace URI1009{
    class Program {
        static void Main(string[] args) {
            string vendedor;
            double salario, vendas, salarioFInal;
            vendedor = Console.ReadLine();
            salario = double.Parse(Console.ReadLine());
            vendas = double.Parse(Console.ReadLine());
            vendas = vendas*0.15;
            salarioFInal = salario + vendas;
            Console.WriteLine($"TOTAL = R$ {salarioFInal.ToString("F2")}");
        }
    }
}