namespace Revisao.Primeiro.Trimestre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region tipos inteiros

            //tipo de valor
            var inteiroUm = int.MinValue;
            var inteiroDois = int.MaxValue;

            Console.WriteLine($"int");
            Console.WriteLine($"Min value: {inteiroUm}");
            Console.WriteLine($"Max value: {inteiroDois}");

            var shortUm = short.MinValue;
            var shortDois = short.MaxValue;

            Console.WriteLine($"\nshort");
            Console.WriteLine($"Min value: {shortUm}");
            Console.WriteLine($"Max value: {shortDois}");
            
            var longUm = long.MinValue;
            var longDois = long.MaxValue;

            Console.WriteLine($"\nlong");
            Console.WriteLine($"Min value: {longUm}");
            Console.WriteLine($"Max value: {longDois}");

            #endregion tipos inteiros

            #region tipos ponto flutuante

            var floatUm = float.MinValue;
            var floatDois = float.MaxValue;

            Console.WriteLine("\n float");
            Console.WriteLine($"Min value: {floatUm}");
            Console.WriteLine($"Max value: {floatDois}");
            
            var decimalUm = decimal.MinValue;
            var decimalDois = decimal.MaxValue;

            Console.WriteLine("\n decimal");
            Console.WriteLine($"Min value: {decimalUm}");
            Console.WriteLine($"Max value: {decimalDois}");
            
            var doubleUm = double.MinValue;
            var doubleDois = double.MaxValue;

            Console.WriteLine("\n double");
            Console.WriteLine($"Min value: {doubleUm}");
            Console.WriteLine($"Max value: {doubleDois}");

            #endregion tipos ponto flutuante

            #region outros tipos

            var dataUm = DateTime.Now;

            Console.WriteLine(dataUm.ToString("dd/MM/yyyy"));
            Console.WriteLine(dataUm.ToString("yyyy/MM/dd"));
            Console.WriteLine(dataUm.ToString("MM/dd/yyyy"));


            var booleanoUm = false;
            var booleanoDois = true;
            bool booleanoTres = true;

            var stringUm = "teste";
            var stringDois = "teste" + "teste";
            var stringTres = string.Concat("teste ", "teste");
            var stringQuatro = "";
            var stringCinco = string.Empty;
            var stringSeis = $"Concatenação: {stringUm} {stringDois}";

            #endregion outros tipos

            #region conversoes

            Console.WriteLine("Por favor, informe um " +
                "valorpara SOMA:");

            var valorDigitado = Console.ReadLine();

            //se o valor for inválido estoura uma exceção 
            var valorConvertido = int.Parse(valorDigitado);

            // se o valor for inválido retorna um valor padrão
            int.TryParse(valorDigitado, out int valorConvertidoTry);

            #endregion conversoes

            #region objetos

            // variavel tipo de referencia
            var i30 = new HyundaiI30();

            AbstractCarro carroUm;
            AbstractCarro carroDois;

            carroUm = i30;
            carroDois = carroUm;
            carroUm = new HyundaiHB20();

            Console.WriteLine(carroUm.ToString());
            Console.WriteLine(carroDois.ToString());
            Console.WriteLine(carroDois.Marca.ToLower());
            Console.WriteLine(carroDois.Marca.ToUpper());
            Console.WriteLine(carroDois.Marca.Count());
            Console.WriteLine(carroDois.Marca.Trim());

            #endregion objetos

            #region estruturas de condicao

            if (string.IsNullOrWhiteSpace(carroDois.Modelo))
                throw new ArgumentException("Valor digitado não pode ser nulo!");

            switch (carroDois.Marca)
            {
                case "Hyundai":
                    Console.WriteLine("Koreana");
                    break;
                case "Volkswagen":
                    Console.WriteLine("Alemã");
                    break;
                default:
                    Console.WriteLine("não identificada!");
                    break;
            }

            #endregion estruturas de condicao

            #region estruturas de repeticao

            var isSair = false;

            do
            {
                Console.WriteLine("Deseja sair? S/N");
                isSair = Console.ReadLine().ToUpper() == "S";
            } while (!isSair);

            var contador = 0;
            while (contador <= 100)
            {
                Console.WriteLine(contador);
                contador++;
            }

            for (var i = 0; i <= 100; i++)
            {
                Console.WriteLine(i);
            }

            #endregion estruturas de repeticao
        }
    }
}