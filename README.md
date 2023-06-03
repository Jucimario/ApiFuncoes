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
- `GET/NumeroExtenso`: Recebe um valor inteiro e o converte para forma de escrita por exemplo:

					  * 10 = Dez
					  * 200 = Duzentos
					  * 3000 = Tres Mil
					  * 100000 = Cem Mil
					  * ...

##### - Implementações e dificuldades encontrada

O primeiro desafio foi identificar as unidades de conversão para assim separar valores maiores no desenvolvimento a cada dezena foi adicionando <b>Ifs</b> e quando percebi já estava muito extenso, então procurei forma de melhorar o código, efetuei <b>foreach</b> para concatenar os valores por exemplo “mil e duzentos” não tive muito sucesso, a partir disso observei que era possível reaproveitar o mesmo método efetuando sua divisão por unidade, dezena e centena o problema foi saber até onde era unidade, dezena ou centena, fiz um teste de mesa e consegui achar, depois disso foi meio que automático para cada milhar era só adicionar três zeros a mais, montei um <b>switch case</b> e sai efetuando as somas e concatenações testando a API e fazendo ajustes em valores que recebem a forma singular e plural ex: Cem, Cento e um, Um Milhão, dois Milhões e assim por diante, ao final percebi que havia uma pequena falha, e se caso fosse informado numero negativos? a implementação acabou sendo simples, bastando passar para a mesma função convertendo o valor para positivo usando a função <b>Math.Abs()</b> e adicinando o nome "menos" a frente da representação.
