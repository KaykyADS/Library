# 📚 Biblioteca - Sistema ASP.NET Core MVC

Este projeto é um sistema simples de **gestão de biblioteca**, desenvolvido em **ASP.NET Core MVC** com **Entity Framework Core**.  
Ele permite gerenciar **autores, livros e empréstimos**, com operações CRUD (Create, Read, Update, Delete).

---

## 🚀 Tecnologias utilizadas
- [.NET 9+](https://dotnet.microsoft.com/)  
- [ASP.NET Core MVC](https://learn.microsoft.com/aspnet/core/mvc)  
- [Entity Framework Core](https://learn.microsoft.com/ef/core/)  
- [SQL Server LocalDB](https://learn.microsoft.com/sql/database-engine/configure-windows/sql-server-express-localdb)  

---

## 📂 Estrutura do projeto

Biblioteca/
├── Controllers/
│ ├── AuthorsController.cs # CRUD de autores
│ ├── BooksController.cs # CRUD de livros
│ └── LoansController.cs # CRUD de empréstimos
│
├── Models/
│ ├── Author.cs # Entidade Autor
│ ├── Book.cs # Entidade Livro (relacionado a Autor)
│ └── Loan.cs # Entidade Empréstimo (relacionado a Livro)
│
├── Data/
│ └── Context.cs # DbContext (EF Core)
│
├── Migrations/ # Arquivos de migrations do EF Core
│
├── Views/
│ ├── Authors/ # Views de Autores
│ │ ├── Index.cshtml
│ │ ├── Create.cshtml
│ │ ├── Edit.cshtml
│ │ └── Details.cshtml
│ │
│ ├── Books/ # Views de Livros
│ │ ├── Index.cshtml
│ │ ├── Create.cshtml
│ │ ├── Edit.cshtml
│ │ └── Details.cshtml
│ │
│ └── Loans/ # Views de Empréstimos
│ ├── Index.cshtml
│ ├── Create.cshtml
│ ├── Edit.cshtml
│ └── Details.cshtml
│
├── wwwroot/ # Arquivos estáticos (CSS, JS, imagens)
│
├── appsettings.json # Configurações (ex: Connection String)
├── Program.cs # Configuração inicial da aplicação
├── Startup.cs (se houver) # Configuração de serviços e pipeline
└── Biblioteca.csproj # Arquivo de projeto .NET


---

## 📖 Funcionalidades

✅ CRUD de **Autores**  
✅ CRUD de **Livros** (cada livro vinculado a um autor)  
✅ CRUD de **Empréstimos (Loans)**  
   - Associar um livro a um usuário/cliente  
   - Registrar data do empréstimo e data de devolução  
   - Marcar devoluções  
✅ Validação de disponibilidade do livro (`Available`)  

---
