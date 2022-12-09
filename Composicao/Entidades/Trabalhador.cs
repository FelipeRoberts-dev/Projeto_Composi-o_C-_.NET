using Composicao.Entidades.Enums;
using System.Collections.Generic;
namespace Composicao.Entidades
{
     class Trabalhador
    {
        public string Nome { get; set; }
        public  NivelTrabalhador Nivel { get; set; } // Atributo derivado Do Enum
        public double BaseSalarial { get; set; }
        public Departamento Departamento { get; set; } //Associação Do objeto Departamento

        //Listas para armazenar todos contratos desse trabalhador
        public List<HorasContrato> Contratos { get; set; } = new List<HorasContrato>();  //Associação Do objeto HorasContrato

        //Construtores classe Trabalhador
        public Trabalhador()
        {

        }
        
        public Trabalhador(string nome, NivelTrabalhador nivel, double baseSalarial, Departamento departamento) { 
            Nome = nome;
            Nivel = nivel;
            BaseSalarial = baseSalarial;
            Departamento = departamento;
        }

        //Métodos Classe Main trabalhador

        //Função para adicioanar contrato para o trabalhador
        public void AdicionarContrato(HorasContrato contrato)
        {
            Contratos.Add(contrato);
        }

        //Função para Remover contrato do Trabalhador
        public void RemoverContrato(HorasContrato contrato)
        {
            Contratos.Remove(contrato);
        }

        //Função para verificar o tanto que o funcionario ganhou
        public double Renda(int ano, int mes)
        {
            double soma = BaseSalarial;

            foreach(HorasContrato contratos in Contratos)
            {
                if(contratos.Data.Year == ano && contratos.Data.Month == mes)
                {
                    soma += contratos.TotalValor();
                }
            }
            return soma;    
        }
    }

}
