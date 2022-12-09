using System;

namespace Composicao.Entidades
{
    //Classe para Verificar valor do Contrato do Profissional
    class HorasContrato
    {
        //Atributos Utilizados para criação do Objeto
        public DateTime Data { get; set; } 
        public double ValorPorHora { get; set; }
        public int Horas { get; set; }

        //Construtor Utilizado para Criação do Objetos
        public HorasContrato()
        {

        }

        public HorasContrato(DateTime data, double valorPorHora, int horas)
        {
            Data = data;
            ValorPorHora = valorPorHora;
            Horas = horas; 
        }


        //Metodo Utilizado para retornar Total do Valor do Funcionario
        public double TotalValor()
        {
            return Horas * ValorPorHora;
        }
    }
}
