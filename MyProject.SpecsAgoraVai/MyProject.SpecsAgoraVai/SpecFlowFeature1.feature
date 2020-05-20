#language: pt-BR
Característica: Calculadora 
       Para evitar erros tolos 
       Como idiota da matemática 
       , quero que me digam a soma de dois números

@mytag
Cenário: adicione dois números
	Dado que eu inseri 50 na calculadora
	E também inseri 70 na calculadora
	Quando pressiono add
	Então o resultado deve ser 120 na tela

@mytag
Cenário: subtraia dois números
	Dado que eu inseri 90 na calculadora
	E também inseri 70 na calculadora
	Quando pressiono sub
	Então o resultado deve ser 20 na tela