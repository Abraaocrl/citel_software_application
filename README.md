# Citel Software Application

Esse projeto é direcionado para avaliação técnica da seleção para vaga de desenvolvedor .net da Citel Software.

## Requisitos

- .NET 6 SDK
- MySQL 8.0.5

## Dependências 

- Entity Framework Core
- Mapster
- Swagger

## Arquitetura

O projeto possui três componentes compondo uma arquitetura de microsserviços.
Cada compontent funciona de maneira independente e não possui referência a nenhum projeto da solução.
Os componentes são:

### API de Categorias

API web usando a biblioteca ASP.NET implementando o repository pattern para controlar o acesso aos dados e seguindo os princípios SOLID. 
O banco de dados conectado com a API possui apenas a tabela de Categorias.

### API de Produtos

API web usando a biblioteca ASP.NET implementando o repository pattern para controlar o acesso aos dados e seguindo os princípios SOLID. 
O banco de dados conectado com a API possui apenas a tabela de Produtos.

### Interface Web de administração

Aplicação Web ASP.NET MVC com páginas Razor usando Bootstrap para estilização, fazendo as requisições para as APIs através do HttpClient nativo .Net

## Inicialização

Para que o projeto seja testado, siga as seguintes instruções:
- Instale os requisitos
- Configure a execução simultânea para que todos os projetos sejam executados simultâneamente

## FAQ

### Como configurar o banco de dados?
Os bancos são configurados usando a função Code First do Entity Framework, todos os códigos necessários para a criação do banco e quaisquer alterações necessárias são executadas ao compilar o projeto.
