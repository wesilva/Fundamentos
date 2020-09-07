using System.Runtime.CompilerServices;

// Extende a visibilidade das classes privada e interna para o ProjetoB 
// e os métodos internal, protegidoInterno e privadoProtegido(somente por herança)
//[assembly: InternalsVisibleTo("ProjetoB")] 
namespace ProjetoA
{
    #region Classes   
    public class Publica
    {
        public void TestePublico() { }
        private void TestePrivado() { }
        internal void TesteInternal() { }
        protected void TesteProtegido() { }
        protected internal void TesteProtegidoInterno() { }
        private protected void TestePrivadoProtegido() { }
    }

    public sealed class Selada { } // sealed não pode ser herdada(não pode extende-lá)

    class Privada { }

    internal class Interna { }

    abstract class Abstrata { }

    #endregion

    #region Testes

    class TesteClasses
    {
        public TesteClasses()
        {
            var publica = new Publica();
            // classe privada e interna faz o mesmo papel(só permite acessar de dentro do próprio assembly)
            var privada = new Privada();
            var interna = new Interna();
            // Classe abstrata não pode ser instanciada, somente herdada
            //var abstrata = new Abstrata(); 
        }
    }

    // Não é possível fazer herança de classe selada
    // class TesteSelada : Selada { }

    class TesteModificador1
    {
        public TesteModificador1()
        {
            var publica = new Publica();

            publica.TestePublico();
            //publica.TestePrivado();
            publica.TesteInternal();
            //publica.TesteProtegido();
            publica.TesteProtegidoInterno();
            //publica.TestePrivadoProtegido();
        }
    }

    class TesteModificador2 : Publica
    {
        public TesteModificador2()
        {
            TestePublico();
            //TestePrivado();
            TesteInternal();
            TesteProtegido();
            TesteProtegidoInterno();
            TestePrivadoProtegido();
        }
    }

    #endregion
}