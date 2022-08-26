using System;

namespace md02_CadernoExercicios_03
{
    class Program
    /*
     3. Crie um algoritmo que calcula o desconto previdenciário de um funcionário. Dado um
        salário, o programa deve retornar o valor do desconto proporcional ao mesmo. O cálculo
        segue a regra: o desconto é de 11% do valor do salário, entretanto, o valor máximo de
        desconto é 720,00. Sendo assim, ou o algoritmo retorna o valor equivalente a 11% sobre
        o salário ou 720,00
    */
    {
        static void Main(string[] args)
        {
            string s="n";
            do
            {
                double salario, salComDesc, desconto;
                Console.WriteLine("Digite o salário do funcionário");
                salario = Convert.ToDouble(Console.ReadLine());
                desconto = salario * 0.11;
                salComDesc = salario - desconto;
                if (desconto > 720.00)
                {
                    desconto = 720.00;
                }
                salComDesc = salario - desconto;

                Console.WriteLine("\nSalário Bruto: R$ {0}", salario.ToString("0.00"));
                Console.WriteLine("\nDesconto previdenciário: R$ {0}", desconto.ToString("0.00"));
                Console.WriteLine("\nSalário Líquido: R$ {0}", salComDesc.ToString("0.00"));
                Console.WriteLine("\nDeseja calcular o salário de outro funcionário?" +
                    "\nS - para sair.\nN - para continuar.");
                s = Console.ReadLine();
          

            } while (s == "n");
            Console.WriteLine("Obrigado por utilizar o sistema!");

        }
    }
}
