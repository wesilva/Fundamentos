# Pilares fundamentais da OOP

- **Estado**
- **Comportamento**
- **Herança**
- **Abstração**
- **Polimorfismo**
- **Encapsulamento**
---
### Na orientação a objetos deve-se sempre buscar o baixo acoplamento e alta coesão entre os objetos
 - **Acoplamento:** Uma dependência direta entre um objeto e outro. Quando um objeto muda o outro muda por consequência
 - **Coesão:** Objetos executando uma única responsabilidade livres de uma dependência direta com um outro objeto
 ---
### Definição de Classe
 - Estrutura de dados(código) que tem a função de mapear um objeto do mundo real
### Definição de Objeto
 - É a instância de uma classe alocada na memória (as propriedades da classe passa a ter valores)
### Definição de Estado
 - É representado pelas propriedades da classe (possui informações que vão estar no objeto que é a instância da classe. Ex: Nome = João, Data = 01/01/1900)
### Definição de Comportamento
 - São métodos que processam uma nova informação através da própria classe retornando uma nova informação ou alterando o estado da classe (Ex: Método que retorna a idade em uma classe que só tem a data de nascimento, ou um método que altera o estado da classe ex: mudar o valor da propriedade Nome)
### Definição de Herança
 - Extende uma classe através de uma especialização
 - Analisar se a (classe que esta herdando) **é um** (a classe que este sendo herdada) Ex: Funcionário __é uma__ pessoa
### Definição de Abstração
 - Criar conceitos genéricos que possam ser abstraídos por outras classes
 - É um pilar da OOP suportado pela herança e oferece um conjunto de estados e comportamentos que abstraem uma certa especialização (conceito de super classe)
 - A abstração vai apenas do conceito de você especializar alguma coisa numa classe que esta herdando e fornecer formas genéricas de comportamento para qualquer grupo de classes que herde da super classe
 - O keyword __abstract__ não é obrigatório só para se fazer uma abstração
 - É a base para o polimorfismo e encapsulamento
### Definição de Polimorfismo
 - Poli-morfismo (muitos comportamentos)
 - Permite uma classe assumir diversos comportamentos independente dela ser uma classe abstrata, e sim dela estar sendo herdada e permitir ter métodos abstratos ou até mesmo com modificador virtual, que permita que a classe que estiver herdando modifique os comportamentos desses métodos
### Definição de Encapsulamento
 - É a arte de encapsular comportamentos através da exposição de métodos públicos e também a escrita de métodos privados
 - Fazer o uso de um método sem saber como internamente ele funciona
### Interface X Implementação
 - Usar uma interface em vez de uma implementação pura
 - Interface é uma espécie de contrato simples, toda classe que implementa uma interface é obrigada a implementar os métodos especificados na interface
 - Interface é diferente de uma classe abstrata, pois uma classe abstrata além de fazer a mesma obrigatoriedade de implementação dos métodos ela também implementa alguns comportamentos que podem ser derivados
### Herança X Composição
 - A herança tem um maior acoplamento em relação à composição
 - Prefira sempre uma composição ao invés de uma herança, porque herança causa um forte acoplamento e além de tudo pode forçar a ter comportamentos que você não queira
 - Composição da um baixo acoplamento e maior coesão