using System;

namespace OOP
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public DateTime DataDeNascimento { get; set; }

        public int CalcularIdade()
        {
            var dataAtual = DateTime.Now;
            var idade = dataAtual.Year - DataDeNascimento.Year;

            if(dataAtual < DataDeNascimento.AddYears(idade)) idade --;

            return idade;
        }
    }
}