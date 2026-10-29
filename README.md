# MINIBANCO.CONSOLE.APP MOTOR DE GESTÃO DE CONTAS

Este é o sistema do Minibanco,um programa simples desenvolvido para funcionar diretamente no Terminal de Comandos.

O objetivo principal é fazer funcionar as operações de um Banco Real, utilizando Estruturas em POO para a Movimentação de Dinheiro e gerenciar  Dados de Clientes.

-----------------------------------------------
##Como o Programa Funciona?

O projeto simula um Banco funcional pelo Terminal. com Três clientes para testes:a Maria ,o João, e a Júlia.
Ao iniciar o sistema, um menu é exibido para que o usúario possa Escolher qual operação deseja realizar.

=======
## Como foi Constrúido!!
* Conta Corrente*
* Conta Poupança*
* Conta Salario*
* Transação*

  COMO RODAR O PROGRAMA ..
  Para que o programa rode sem problemas  criei  um sistema no Container para não precisar configurar.

  '''bash
  # Comando para construir o sistema
  docker build -t minibanco-app .
  # Comando para ligar  e digitar com o menu do Banco
  docker run -it minibanco-app
  '''

-----------
##Utilização de Ferramentas.
* C# / .NET :Linguagem de programação usada para os codigos.
* Docker : / para rodar o projeto.
* Git e GitHub : Para salvar os históricos e alterações do codigo.

  ## Desafios que tive no desenvolvimento do Projeto
  * Desafio com os codigos : por ser meu primeiro mini projeto feito solo
  * Desafio com o Docker e dotnet run:foi uns dos pontos que mais deu trabalho por erro de conexão com ferramentas e argumentos e arquivo.
  * Configuração do Git: no começo tive dificuldades pra sincronizar pastas , locais, ramificação,corretase ainda aprendendo a rastrear arquivos e caminhos especificos commits isolados, branch.
 
  * SUPERAR ESSES PROBLEMAS :
  * Enfrentar e corrigir  deu muito trabalho  entende-los , e um processo que vale a pena colocando-os em pratica mesmo com alguns erros vejo a verdade do desenvolvimento funcional e pratico.
  * 


  #
  obs:tive muita dificuldade de subir o video junto aqui
