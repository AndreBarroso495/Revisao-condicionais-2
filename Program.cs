using System;

namespace Atividade_revisão
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Selecione o tipo de combustível :");
            Console.WriteLine("A - Álcool");
            Console.WriteLine("G - Gasolina");
            string combustivel = Console.ReadLine();

            Console.WriteLine("Digite a quantidade de combustivel");
            float quantidadeCombustivel = float.Parse(Console.ReadLine());

            float desconto;
            switch (combustivel.ToLower())
            {
                case "A":
                 if ( quantidadeCombustivel>20)
                 {
                        desconto = 0.05f;
                     
                 }
                 else
                 {
                     desconto = 0.03f;
                     Console.WriteLine($"Valor a ser pago{desconto}");
                     
                 }
                    break;
                    case "G":
                    if (quantidadeCombustivel>20)
                    {
                        desconto = 0.06f;
                        
                    }
                    else
                    {
                        desconto = 0.04f;
                        
                    }
                    break;
                default:
                    break;
            }
            

               
               
           }
    }
}
