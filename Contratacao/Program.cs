
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contratacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cont = 0;
            int continuar = 1;
            double total = 0;     
            int horas;
            double desc;        
            double preco;
            int vendas;
            double PV; 
            double sf;      
            double CONTSALARIO = 0;



            while (continuar == 1)
            {
                Console.Clear();
                Console.WriteLine("Insira o tipo de contrato: 1(assalariado) / 2(Comissionado) / 3(horista)");
                int tipo = int.Parse(Console.ReadLine());

                cont++;

                switch (tipo)
                {
                    case 1:
                        Console.WriteLine("Insira o salário fixo: ");
                        sf = double.Parse(Console.ReadLine());
                        Console.WriteLine("Insira o valor do desconto: ");
                        desc = double.Parse(Console.ReadLine());
                        total = sf - desc; break;
                    case 2:
                        Console.WriteLine("Insira a Quantidade de vendas: ");
                        vendas = int.Parse(Console.ReadLine());
                        Console.WriteLine("Insira o valor por venda: ");
                        PV = int.Parse(Console.ReadLine());
                        total = PV * vendas; break;
                    case 3:
                        Console.WriteLine("Insira a quantidade de horas trabalhadas: ");
                        horas = int.Parse(Console.ReadLine());
                        Console.WriteLine("Insira o preço da hora: ");
                        preco = int.Parse(Console.ReadLine());

                        total = horas * preco; break;
                    default: Console.WriteLine("Opção Inválida"); break;
                }

                CONTSALARIO = CONTSALARIO + total;

                Console.WriteLine("Valor Atual da Folha de Pagamento: " + CONTSALARIO);

                Console.WriteLine("Você deseja continuar: 1(SIM) / 2(NÃO) ");
                continuar = int.Parse(Console.ReadLine());



            }
            Console.Clear();
            Console.WriteLine("Foram cadastrados " + cont + " funcionários, o Total da folha de pagamento é de: R$" + CONTSALARIO + " e o Salário médio da empresa é de: R$" + CONTSALARIO / cont);


            Console.ReadKey();
        }
    }
}
