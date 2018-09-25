# CalculaImc
Projeto Calcula Imc em Xamarin Forms é uma calculadora simples de IMC que tem como entradas o peso a altura e o nome da pessoa.
Foi criada também uma animação de sucesso ao gravar o cálculo por pessoa e também uma segunda tela com a listagem das pessoas calculadas
gravadas no Sql Lite.

Minha idéia era fazer além de mostrar o cálculo informar ao usuário em que categoria ele se encontra(Normal... Sobrepeso... ou Obesidade)
porém seria necessário fazer a diferenciação entre Masculino e Feminino... Eu iria fazer usando Radio Buton mas não consegui. Logo prefiri 
manter somente o cálculo.

O projeto atende a estrura MVVM que foi proposta mantendo na Classe View Model os data Bidings atualizando a View e também o método para 
Calcular o IMC.

Foi criada também uma camada Domain que passou a abrigar a Classe Modelo do projeto com os atributos de entrada (Peso, Altura e Nome).

A conexão com SQL Lite também foi acrescentada em um projeto separadamente na camada de dados conforme foi ensinado na sala de aula.

