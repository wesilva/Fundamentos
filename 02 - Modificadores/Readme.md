# Modificadores de acesso

### public:
- Access is not restricted
- O acesso não é restrito

### private:
- Access is limited to the containing type.
- O acesso é limitado ao tipo contido

### internal: 
- Access is limited to the current assembly
- Apenas o assembly(dll) pode fazer o uso da classe

 ### protected:
- Access is limited to the containing class or types derived from the containing class.
- Somente a classe que esta herdando pode acessar o método

### protected internal: (somente para métodos)
- Access is limited to the current assembly or types derived from the containing class.
- Classes limitadas ao próprio assembly ou tipos derivadas da classe contida
- Tem o fator duplo de validação, mas permite que umas das duas condições sejam atendidas

### private protected: (somente para métodos)
- Access is limited to the containing class or types derived from the containing class within the current
- assembly.Available since C# 7.2
- O acesso é limitado apenas para as classes que derivam(fazem a herança) e estam dentro do mesmo assembly
- Tem o fator duplo de validação, tem que ser uma herança e estar no mesmo assembly
