
using CalculadoraBasica;

public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Calculadora!");
        #region
        //    Console.WriteLine("Calculadora!");
        //    double resultado = 0;
        //    while (true)
        //    {
        //        try { 
        //            Console.WriteLine("Digite um valor: ");
        //            double valor1 = double.Parse(Console.ReadLine());
        //            Console.WriteLine("Digite um valor: ");
        //            double valor2 = double.Parse(Console.ReadLine());


        //        if (valor1 >=0 || valor2 >=0)
        //        {
        //            resultado += valor1 + valor2;
        //            Console.WriteLine($"Resultado: {resultado}");
        //        }

        //    }catch(Exception ex)
        //        {
        //            Console.WriteLine("Estamos finalizando, dado de entrada invalido. ");
        //            Console.WriteLine($"Resultado final: {resultado}");
        //            Console.WriteLine(ex);
        //            break;
        //        }
        //}
        #endregion

        List<Calculadora> ListaDeCalculos = new List<Calculadora>();
        ChamadaDigitar();
        void ChamadaDigitar()
        {
            /*Aqui estou criando uma lista do tipo calculadora*/

            while (true)
            {
                try/*Tenta fazer isso*/
                {

                    Console.WriteLine("Digite um valor: ");
                    var fator1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o sinal: ");
                    var fatorConta = Console.ReadLine();
                    Console.WriteLine("Digite um valor: ");
                    var fator2 = double.Parse(Console.ReadLine());
                    Calculadora conta = new Calculadora(fator1, fatorConta, fator2);
                    ListaDeCalculos.Add(conta);

                }
                catch (Exception e)
                {
                    Console.WriteLine("Finalizando.!.!.!");
                    Console.WriteLine("Passou um valor fora do pedido");
                    Console.WriteLine($"Cálculos já feitos: ");
                    break;
                }
            }
            PercorreArray();
        }
        void PercorreArray()
        {
            foreach (var item in ListaDeCalculos)
            {
                if (ListaDeCalculos.Count <= 0)
                {
                    Console.WriteLine("Array vazio");
                }
                else
                {
                    Console.WriteLine($"{item.fator1} {item.fatorConta} {item.fator2} = {item.resultado}");
                    var caminhoDoArquivo = "ContasEmJason.txt";
                    using (var fluxoDeArquivo = new FileStream(caminhoDoArquivo, FileMode.Append))
                    {
                        using (var salva = new StreamWriter(fluxoDeArquivo))

                        {
                            salva.WriteLine($"{item.fator1} {item.fatorConta} {item.fator2} = {item.resultado}");
                            salva.Flush();
                        }
                    }

            }
        }

    }



}
}