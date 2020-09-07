namespace OOP
{
    public class CafeteiraExpressa : Eletrodomestico
    {
        public CafeteiraExpressa(string nome, int voltagem)
            : base(nome, voltagem) {  }

        public CafeteiraExpressa()
            : base("Padrão", 220) {  }

        private static void AquecerAgua() {  }

        private static void MoerGraos() {  }

        public void PrepararCafe()
        {
            Testar();
            AquecerAgua();
            MoerGraos();
        }

        public override void Testar()
        {
            // Teste da cafeteira
        }

        public override void Ligar()
        {
            // Resfriar o aquecedor
        }

        public override void Desligar()
        {
            // Verificar recipiente de água
        }

    }
}