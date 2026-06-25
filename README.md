# ProductClientHub API

Projeto desenvolvido durante o curso gratuito de C# da [Rocketseat](https://www.rocketseat.com.br/), com foco em fundamentos de desenvolvimento de APIs com ASP.NET Core.

## 🚀 Tecnologias

- [.NET 8](https://dotnet.microsoft.com/)
- [ASP.NET Core](https://learn.microsoft.com/en-us/aspnet/core/)
- C#

## 📁 Estrutura do projeto
ProductClientHub/

├── ProductClientHub.API/           # Camada de apresentação (Controllers, configurações)

│   ├── Controllers/

│   └── Program.cs

├── ProductClientHub.Communication/ # Contratos de comunicação (Requests e Responses)

│   ├── Requests/

│   └── Responses/

└── ProductClientHub.Exceptions/    # Exceções customizadas

└── ExceptionsBase/

## ⚙️ Como executar

### Pré-requisitos

- [.NET 8 SDK](https://dotnet.microsoft.com/download)
- Visual Studio 2022 ou VS Code

### Passo a passo

```bash
# Clone o repositório
git clone https://github.com/ganhodev/ProductClientHub.git

# Acesse a pasta do projeto
cd ProductClientHub

# Restaure as dependências
dotnet restore

# Execute o projeto
dotnet run --project ProductClientHub.API
```

## 📌 Endpoints disponíveis

### Clientes

| Método | Rota | Descrição |
|--------|------|-----------|
| `POST` | `/api/clients` | Cadastra um novo cliente |

## 📖 Sobre o curso

Este projeto faz parte do curso **"C# do Zero"** da Rocketseat, abordando:

- Fundamentos de C# e .NET
- Criação de APIs RESTful com ASP.NET Core
- Organização em camadas
- Tratamento de exceções
- Boas práticas de desenvolvimento

## 🎓 Status

> Projeto em desenvolvimento — sendo atualizado conforme o avanço do curso.