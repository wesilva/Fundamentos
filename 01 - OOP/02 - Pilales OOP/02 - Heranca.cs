using System;

namespace OOP
{
    public class Funcionario : Pessoa
    {
        public DateTime DataDeAdmissao { get; set; }
        public string Registro { get; set; }
    }

    public class Processo
    {
        public void Execucao()
        {
            var funcionario = new Funcionario()
            {
                Nome = "Wellington",
                DataDeNascimento = Convert.ToDateTime("1991/01/01"),
                DataDeAdmissao = DateTime.Now,
                Registro = "34278"
            };
            funcionario.CalcularIdade();
        }
    }
}