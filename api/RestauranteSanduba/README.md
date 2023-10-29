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

### M�dulos do sistema
A aplica��o est� consolidada dentro da pasta `\src` e dentro dela teremos:
- Core
	- Domain
	- SharedKernel
- Application
	- API


### Comandos

#### Lint (Forma��o)
```powershell
dotnet format RestauranteSanduba.sln
```