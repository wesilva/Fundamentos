using ProjetoA;

namespace ProjetoB
{
    class TesteClasses
    {
        public TesteClasses()
        {
            var publica = new Publica();
            //var privada = new Privada();
            //var interna = new Interna();
            //var abstrata = new Abstrata();
        }
    }

    class TesteModificador1
    {
        public TesteModificador1()
        {
            var publica = new Publica();

            publica.TestePublico();
            //publica.TestePrivado();
            //publica.TesteInternal();
            //publica.TesteProtegido();
            //publica.TesteProtegidoInterno();
            //publica.TestePrivadoProtegido();
        }
    }

    class TesteModificador2 : Publica
    {
        public TesteModificador2()
        {
            TestePublico();
            //TestePrivado();
            //TesteInternal();
            TesteProtegido();
            TesteProtegidoInterno();
            //TestePrivadoProtegido();
        }
    }
}
