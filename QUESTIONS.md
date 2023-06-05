### Desafio 1 - Converter numero inteiro e representa em termo extenso 

- `GET/NumeroExtenso`: Recebe um valor inteiro no formato Route e o converte para forma de escrita por exemplo:

	requisição: /api/v1/NumeroExtenco/10
	
	Resultado:

					  * 10 = Dez
					  * 200 = Duzentos
					  * 3000 = Tres Mil
					  * 100000 = Cem Mil
					  * ...

#### - Implementações e dificuldades encontrada

O primeiro desafio foi identificar as unidades de conversão para assim separar valores maiores no desenvolvimento a cada dezena foi adicionando <b>Ifs</b> e quando percebi já estava muito extenso, então procurei forma de melhorar o código, efetuei <b>foreach</b> para concatenar os valores por exemplo “mil e duzentos” não tive muito sucesso, a partir disso observei que era possível reaproveitar o mesmo método efetuando sua divisão por unidade, dezena e centena o problema foi saber até onde era unidade, dezena ou centena, fiz um teste de mesa e consegui achar, depois disso foi meio que automático para cada milhar era só adicionar três zeros a mais, montei um <b>switch case</b> e sai efetuando as somas e concatenações testando a API e fazendo ajustes em valores que recebem a forma singular e plural ex: Cem, Cento e um, Um Milhão, dois Milhões e assim por diante, ao final percebi que havia uma pequena falha, e se caso fosse informado numero negativos? a implementação acabou sendo simples, bastando passar para a mesma função convertendo o valor para positivo usando a função <b>Math.Abs()</b> e adicinando o nome "menos" a frente da representação.


###  Desafio 2 -  Somar todos os valores inteiro de um array

- `POST/SomaArray`: Recebe um array no body da requisição com no maximo um milhao de números e retorna a soma de todos, exemplo:
	
	requisição: /api/v1/SomaArray				
		Body: [1,2]
	
	Resultado:

					  * [1,2] = 3
					  * [1,50,230] = 281
					  * [1,2,3,4,5,6,7,8,9] = 45
					  * [50,85,13,5899,5632,586,2356,6355,2536] = 23512
					  * ...


#### - Implementações e dificuldades encontrada

Nesse exercicio se não me engano desde a versão 3.5 do .net Framework é possivel fazer uso do LINQ e ele tem uma função .SUN() que efetua a soma de uma estrutura, ele tem varias sobrecargas, sobre a performance depende de vários fatores e pode sofrer variações a depender dos diferentes ambientes, e o tempo de execução aumentará proporcionalmente ao tamanho do array. Levando em consideração a estrutura que nossa tecnologia possui hoje, acredito que a soma de um array com esse tamanhão não vá afetar de forma consideravel o processamento.


###  Desafio 3 -  Resolver expressão matemática simples

- `GET/ExpressaoMatematica`: Recebe uma expressão matemática simples em string informando no url em formato Query e retorna seu resultado, exemplo: 
	
	requisição: /api/v1/ExpressaoMatematica?expressao=1+2
	
	Resultado:
					  * 1+2 = 3
					  * 7/2 = 3.5
					  * 15*50/2 = 375
					  * 182-3+8+52+10*50/2 = 489
					  * ...


#### - Implementações e dificuldades encontrada

Nesse exercicio utilizei a biblioteca (NCalc.NetCore) eu já a conhecia, certa vez precisei efetuar um calculo de uma massa de dados em .CSV da operadora VIVO em um projeto que desenmvolvemos na empresa Vikstar o calculo se baseava na quantidade de dados processados por instancia e maquinas disponiveis.