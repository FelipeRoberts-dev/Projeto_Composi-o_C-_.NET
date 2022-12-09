using System;
using System.Globalization;
using Composicao.Entidades.Enums;
using Composicao.Entidades;

namespace Projeto_Composição
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome do Departamento: ");

            string nomeDept = Console.ReadLine();

            Console.WriteLine("Digite os dados do trabalhador");
            Console.Write("Nome: ");
            string Nome = Console.ReadLine();

            Console.WriteLine("Digite o nivel do funcionario (JUNIOR/MIDLEVEL/SENIOR): ");
            NivelTrabalhador level = Enum.Parse<NivelTrabalhador>(Console.ReadLine());
            Console.WriteLine("Base salarial: ");
            double basesalarial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Criação dos objetos 
            Departamento dept = new Departamento(nomeDept);//Passando meu departamento 

            Trabalhador trabalhador = new Trabalhador(Nome, level, basesalarial, dept);//Passando os dados do Trabalhadro
                                                                                       //(obs: Parametro (dept) carregado com o nome do departamento relacionado com objeto departamento.


            Console.WriteLine("Quantos contratos para este trabalhador? ");
            int QtdContratos = int.Parse(Console.ReadLine());

            for(int i =1;i <= QtdContratos; i++)
            {
                Console.WriteLine($"Entre #{i} dados do contrato: ");
                Console.Write("Data (DD/MM/YYYY)");

                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Valores por hora: ");

                double valoresporhora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Quantidade de horas (Horas): ");
                int horas = int.Parse(Console.ReadLine());

                HorasContrato contratos = new HorasContrato(date, valoresporhora, horas);

                trabalhador.AdicionarContrato(contratos);
            }

            Console.WriteLine();

            Console.Write("Entre com o mes e o ano para calcular a renda desse funcionario (MM/YYYY): ");

            string mesandano = Console.ReadLine();

            int mes = int.Parse(mesandano.Substring(0, 2));
            int ano = int.Parse(mesandano.Substring(3));

            Console.WriteLine("Nome: " + trabalhador.Nome);
            Console.WriteLine("Departamento: " + trabalhador.Departamento.Nome);

            Console.WriteLine("Renda de " + mesandano + ": " + trabalhador.Renda(ano,mes).ToString("F2",CultureInfo.InvariantCulture));
             

        }
    }
}