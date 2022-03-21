# (ASP.NET Minimal APIs | por André Baltieri)[https://youtu.be/s_ihuUjnsec]

## Descrição
- _Nova forma de criar um template/projeto mais limpo_


## Tecnologias utilizada
- EntityFramework
- Migration
- SQLite

## Iniciando o projeto
Direto no prompt, rodamos o comando:
- `dotnet new web -o MiniTodo`

- rodar a aplicação 
	- `dotnet watch run` ... Hot Reloading Ativo (Alterações executadas auto)

- Instalando os pacotes para trabalhar com o banco
	- `dotnet add package Microsoft.EntityFrameworkCore.Sqlite` 
	- `dotnet add package Microsoft.EntityFrameworkCore.Design`
	- `dotnet add package Microsoft.EntityFrameworkCore.Tolls`

- Criando as Migrations a partir do CMD
	- `dotnet ef migrations add InitialCreation` e `dotnet ef database update` (Aqui não deu)
	- Direto pelo gerenciador: `add-Migration InitialCreation` e `update-database` 

- Instalar o pacote Flunt para criar validações no modelview
	- `dotnet add package Flunt`

- Para documentarmos nossa API ...
	- `dotnet add package swashbuckle.AspNetCore`

- Parei em https://youtu.be/s_ihuUjnsec?t=1676
- Instalar Postman