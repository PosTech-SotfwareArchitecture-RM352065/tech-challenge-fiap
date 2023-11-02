# API Restaurante Sanduba
Esta API foi construida como parte das entregas da p�s-gradu��o de Software Architecture da FIAP PosTech. O objetivo foi explorar, para o contexto de um restaurante com autoatendimento, novas t�ncologias e paradigmas como:
- DDD
- Event Sourcing
- Microservices
- TDD

## Desenho e arquitetura do sistema

### Tecnologias utilizadas
- [.NET 7](https://dotnet.microsoft.com/pt-br/download/dotnet/7.0)
- [Entity Framework Core](https://learn.microsoft.com/en-us/ef/core/)
- [ASP.NET Core](https://learn.microsoft.com/pt-br/aspnet/core/introduction-to-aspnet-core?view=aspnetcore-7.0)
- [Swashbuckcle](https://aka.ms/aspnetcore/swashbuckle)
- [SpecFlow](https://specflow.org/)
- [AspNetCore.Diagnostics.HealthChecks](https://github.com/Xabaril/AspNetCore.Diagnostics.HealthChecks)

### M�dulos do sistema
A aplica��o est� consolidada dentro da pasta `\src` e est� desenhada pelo padr�o de [Ports and Adapters] dentro dela teremos:
- Core
	- Domain
	- Appli
- Application
	- API


### Comandos

#### Inicializar o banco de dados
```powershell
dotnet ef database update --project .\src\adapter\driven\Infrastructure\Infrastructure.csproj
```

