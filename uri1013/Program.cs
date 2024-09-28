namespace URI1013 {
    class Program {
        static void Main(string[] args) {

            string valores = Console.ReadLine();
            string[] valoresArray = valores.Split(' ');
            double valorA = double.Parse(valoresArray[0]);
            double valorB = double.Parse(valoresArray[1]);
            double valorC = double.Parse(valoresArray[2]);

            
            double maiorAB= (valorA + valorB + Math.Abs(valorA - valorB)) / 2;
            double maiorABC = (maiorAB + valorC + Math.Abs(maiorAB - valorC)) / 2;

            if(maiorAB > maiorABC){
                Console.WriteLine($"{maiorAB} eh o maior");
            }else{
                Console.WriteLine($"{maiorABC} eh o maior");
            }

            
        }
    }
}