namespace OOP
{
    // Definição de Classe
    public class Casa
    {
        public int TamanhoEmM2 { get; set; }
        public int Andares { get; set; }
        public decimal Valor { get; set; }
        public int NumeroDeVagas { get; set; }
    }

    public class Objeto
    {
        // Definição de Objeto
        public Objeto()
        {   
            var casa = new Casa
            {
                TamanhoEmM2 = 90,
                Andares = 1,
                Valor = 155000,
                NumeroDeVagas = 2
            };
        }
    }
}