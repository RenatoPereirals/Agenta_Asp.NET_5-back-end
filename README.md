# Agenta_Asp.NET_5-back-end
[![ASP.NET](https://img.shields.io/badge/ASP.NET-5.0-blue)](https://dotnet.microsoft.com/)
[![Entity Framework Core](https://img.shields.io/badge/Entity%20Framework%20Core-5.0.0-green)](https://docs.microsoft.com/en-us/ef/core/)
[![SQLite](https://img.shields.io/badge/SQLite-5.0.0-blue)](https://www.sqlite.org/index.html)
[![Identity Framework](https://img.shields.io/badge/Identity%20Framework-5.0.0-orange)](https://docs.microsoft.com/en-us/aspnet/core/security/authentication/identity)
[![JWT](https://img.shields.io/badge/JWT-5.0.0-yellow)](https://jwt.io/)
[![AutoMapper](https://img.shields.io/badge/AutoMapper-8.0.0-blueviolet)](https://docs.automapper.org/en/stable/)

Este é o backend do projeto Gerenciador de Eventos Pro-Eventos, desenvolvido em ASP.NET 5, utilizando um banco de dados SQLite com Entity Framework Core. O projeto adota o Identity Framework para gerenciamento de usuários, JWT para autenticação, AutoMapper para mapeamento de objetos e segue uma arquitetura MVC organizada em componentes.

## Instalação de Pré-Requisitos

Antes de iniciar, certifique-se de ter os seguintes softwares instalados:

- [.NET SDK 5.0](https://dotnet.microsoft.com/download/dotnet/5.0)
- [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/)
- [SQLite](https://www.sqlite.org/download.html)
- [AutoMapper](https://docs.automapper.org/en/stable/)

Para instalar o .NET SDK 5.0, siga as instruções fornecidas no [site oficial da Microsoft](https://dotnet.microsoft.com/download/dotnet/5.0).

## Configuração

1. Certifique-se de configurar corretamente a conexão com o banco de dados no arquivo `appsettings.Development.json`:

```json
{
  "ConnectionStrings": {
    "Default" : "Data Source=ProEventos.db"
  },
}
```
2. Configure as chaves secretas para JWT no arquivo `appsettings.Development.json`:

```json
{
    "TokenKey": "super secret key"
}
```


## Estrutura do Projeto

- **Application**: Camada responsável pela lógica de aplicação e interação com o banco de dados.
- **API**: Contém os controladores responsáveis pela comunicação com o frontend.
- **Domain**: Define os modelos de domínio e as interfaces de repositório.
- **Persistence**: Configuração do Entity Framework Core e implementação dos repositórios.

## Execução

1. Execute as migrações para criar o banco de dados:

```bash
dotnet ef database update
```

2. Inicie o servidor:

```bash
dotnet run
```

O backend estará acessível em [http://localhost:5000/](http://localhost:5000/).

## Recursos

- **Identity Framework**: Gerenciamento de usuários e autenticação.
- **JWT**: Autenticação baseada em tokens para comunicação segura.
- **Entity Framework Core**: Mapeamento objeto-relacional para interação com o banco de dados.
- **AutoMapper**: Mapeamento de objetos para simplificar a transferência de dados entre camadas.

## Contribuindo

Sinta-se à vontade para contribuir para o desenvolvimento deste projeto. Abra uma issue para relatar bugs ou sugerir melhorias. Pull requests são bem-vindos!

Sinta-se à vontade para contribuir para o desenvolvimento deste projeto. Abra uma issue para relatar bugs ou sugerir melhorias. Pull requests são bem-vindos!

