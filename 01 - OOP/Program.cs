using System;

namespace OOP
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine(" ");
            Console.WriteLine("1 - Encapsulamento");
            Console.WriteLine("2 - Heranca Composicao 1");
            Console.WriteLine("3 - Heranca Composicao 2");
            Console.WriteLine("4 - Interface Implementacao");
            Console.WriteLine("5 - Sair");

            var opcao = Console.ReadKey();

            switch (opcao.KeyChar)
            {
                case '1':
                    new AutomacaoDeCafe().ServirCafe();
                    break;
                case '2':
                    new TetesHerancaComposicao();
                    break;
                case '3':
                    new TestesHerancaComposicao2();
                    break;
                case '4':
                    new TesteInterfaceImplementacao();
                    break;
            }

            if (opcao.KeyChar != '5')
                Main();
        }
    }
}
