

# 🏥 AcademiaCrud

Sistema desenvolvido em **ASP.NET Core MVC** utilizando a linguagem **C#** e o padrão arquitetural **Model-View-Controller (MVC)**.

O projeto tem como objetivo demonstrar a implementação de um sistema CRUD (Create, Read, Update e Delete) para gerenciamento de dados, utilizando boas práticas de desenvolvimento, persistência de dados com Entity Framework Core e interface responsiva com Bootstrap.

---

## 📋 Tecnologias Utilizadas

- C#
- .NET
- ASP.NET Core MVC
- SQL Server
- Entity Framework Core
- Bootstrap 5
- jQuery
- DataTables (Paginação, pesquisa e ordenação)

---

## 📦 Pacotes Utilizados

O projeto utiliza os seguintes pacotes do Entity Framework Core:

- Microsoft.EntityFrameworkCore
- Microsoft.EntityFrameworkCore.Tools
- Microsoft.EntityFrameworkCore.Design
- Microsoft.VisualStudio.Web.CodeGeneration.Design

---

## 🗄 Banco de Dados

O banco de dados foi desenvolvido utilizando o **SQL Server**.

A criação da estrutura do banco foi realizada através da abordagem **Code First**, utilizando **Migrations** do Entity Framework Core.

---

## 🚀 Funcionalidades

- Cadastro de Instrutores
- Alteração de registros
- Exclusão de registros
- Consulta de dados
- Paginação
- Pesquisa dinâmica
- Ordenação de colunas
- Interface responsiva

---

## 🎨 Interface

A interface foi desenvolvida utilizando:

- Bootstrap
- Razor Views
- jQuery
- DataTables

---

# 📷 Telas do Sistema

## Tela Inicial



![Tela Inicial](imagens/tela-inicial.png)

---

## Lista de Instrutores



![Lista de Instrutores](imagens/instrutores-index.png)

---

# ▶️ Como Executar o Projeto

## Clone o repositório

```bash
git clone [https://github.com/SEU-USUARIO/HospitalCrud.git](https://github.com/arthurfelipe72331/AcademiaCrud.git)
```

## Abra a solução

Abra o projeto utilizando o **Visual Studio 2022**.

## Configure a conexão
 
Edite o arquivo:

```
appsettings.json
```

Configurando a string de conexão para o seu SQL Server.

## Execute as Migrations

No Console do Gerenciador de Pacotes execute:

```powershell
Update-Database
```

Ou utilize o .NET CLI:

```bash
dotnet ef database update
```

## Execute o projeto

Pressione **F5** ou clique em **Iniciar** no Visual Studio.

---

# 📂 Estrutura do Projeto

```
AcademiaCrud
│
├── Controllers
├── Models
├── Views
├── Data
├── Migrations
├── wwwroot
└── Program.cs
```

---

# 💻 Desenvolvido com

- ASP.NET Core MVC
- C#
- SQL Server
- Entity Framework Core
- Bootstrap
- jQuery
- DataTables

---

# 👨‍💻 Autores

### Desenvolvedor

**Arthur Felipe Fernandes de Oliveira**

### Professor

**Wallace Oliveira dos Santos**
