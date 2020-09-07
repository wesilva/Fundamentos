namespace OOP
{
    public class AutomacaoDeCafe
    {
        public void ServirCafe()
        {
            var cafeteiraExpressa = new CafeteiraExpressa();
            cafeteiraExpressa.Ligar();
            cafeteiraExpressa.PrepararCafe();
            cafeteiraExpressa.Desligar();
        }
    }
}