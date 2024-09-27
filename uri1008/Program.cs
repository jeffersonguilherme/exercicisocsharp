namespace URI1008{
    class Program{
        static void Main(string[] args){
            double numeroFuncionario, horas, salarioHora, salarioFinal;
            numeroFuncionario = double.Parse(Console.ReadLine());
            horas = double.Parse(Console.ReadLine());
            salarioHora = double.Parse(Console.ReadLine());
            salarioFinal = horas * salarioHora;
            Console.WriteLine($"NUMBER = {numeroFuncionario}");
            Console.WriteLine($"SALARY = U$ {salarioFinal.ToString("F2")}");

        }
    }
}