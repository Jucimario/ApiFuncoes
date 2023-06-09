# API FUNÇÕES

## Descrição do Projeto
<p align="center">* API Funções executa funções referente aos desafios solicitados</p>

<p align="center">
 <a href="#tecnologias">Tecnologias</a> •  
 <a href="#funcionalidades">Funcionalidades</a>
</p>

<h4 align="center"> 
	🚧  .NET 6 Em Contrução...  🚧
</h4>

### Tecnologias

As seguintes ferramentas foram usadas na construção do projeto:

- [.Net 6](https://dotnet.microsoft.com/en-us/download/dotnet/6.0) Tecnologia da API
- [GitFlow](https://www.atlassian.com/br/git/tutorials/comparing-workflows/gitflow-workflow) Padrão de versionamento

### Funcionalidades

#### Converter numero inteiro e representa em termo extenso 

- `GET/NumeroExtenso`: Recebe um valor inteiro no formato Route e o converte para forma de escrita por exemplo:

	requisição: /api/v1/NumeroExtenco/10
	
	
	
	Resultado:

					  * 10 = Dez
					  * 200 = Duzentos
					  * 3000 = Tres Mil
					  * 100000 = Cem Mil
					  * ...			  


#### Somar todos os valores inteiro de um array

- `POST/SomaArray`: Recebe um array no body da requisição com no maximo um milhao de números e retorna a soma de todos, exemplo:
	
	requisição: /api/v1/SomaArray	

	
		Body: [1,2]
		
		
	
	Resultado:

					  * [1,2] = 3
					  * [1,50,230] = 281
					  * [1,2,3,4,5,6,7,8,9] = 45
					  * [50,85,13,5899,5632,586,2356,6355,2536] = 23512
					  * ...

#### Resolver expressão matemática simples

- `GET/ExpressaoMatematica`: Recebe uma expressão matemática simples em string informando no url em formato Query e retorna seu resultado, exemplo: 
	
	requisição: /api/v1/ExpressaoMatematica?expressao=1+2
	
	
	
	Resultado:
	
					  * 1+2 = 3
					  * 7/2 = 3.5
					  * 15*50/2 = 375
					  * 182-3+8+52+10*50/2 = 489
					  * ...
					  
					  
#### Receber uma lista de objetos(Produto) e retornar uma nova lista sem objetos repetidos

- `POST/ObjetoUnico`: Recebe uma lista de objeto no body da requisição (no caso Produto) e retorna uma nova lista com objetos unicos sem repetição, exemplo:
	
	requisição: /api/ObjetoUnico
	
	
		Body: [
				{
					"id": 1,
					"nome": "Laranja"
				},
				{
					"id": 3,
					"nome": "Banana"
				},
				{
					"id": 1,
					"nome": "Laranja"
				},
				{
					"id": 1,
					"nome": "Laranja"
				},
				{
					"id": 2,
					"nome": "Limão"
				},
				{
					"id": 3,
					"nome": "Banana"
				},
				{
					"id": 2,
					"nome": "Limão"
				}
			]
			
	
	Resultado:

					   [
							{
								"id": 1,
								"nome": "Laranja"
							},
							{
								"id": 2,
								"nome": "Limão"
							},
							{
								"id": 3,
								"nome": "Banana"
							}
						]

