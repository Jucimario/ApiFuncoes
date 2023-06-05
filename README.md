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

- `POST/SomaArray`: Recebe um array no body da requisição com no maximo um milhao de números e retorna a soma de todos, exemplo:
	
	requisição: /api/v1/SomaArray				
		Body: [1,2]
	
	Resultado:

					  * [1,2] = 3
					  * [1,50,230] = 281
					  * [1,2,3,4,5,6,7,8,9] = 45
					  * [50,85,13,5899,5632,586,2356,6355,2536] = 23512
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