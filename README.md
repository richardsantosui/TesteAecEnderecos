Projeto: Gerenciamento de Endereços (Teste Técnico AEC)
Sobre o Projeto

Este projeto foi desenvolvido como solução para o teste técnico da AEC para a vaga de Desenvolvedor C#. A aplicação consiste em uma plataforma de gerenciamento de endereços com autenticação de usuários e operações de CRUD.

Arquitetura e Tecnologias

O projeto foi desenvolvido utilizando ASP.NET Core MVC, seguindo a separação entre Models, Views e Controllers para melhor organização e manutenção do código.

No backend, foi utilizado SQL Server com ADO.NET para gerenciamento e manipulação dos dados. A escolha do ADO.NET teve como objetivo permitir maior controle sobre as consultas SQL e integração direta com o banco de dados.

No frontend, foram utilizadas Razor Views juntamente com Bootstrap 5, permitindo uma interface responsiva, organizada e de fácil navegação.

O desenvolvimento foi realizado no Visual Studio 2022.

Funcionalidades Implementadas
Sistema de autenticação integrado ao banco de dados para validação de usuários.
CRUD de endereços com funcionalidades de cadastro, listagem e exclusão de registros.
Estrutura MVC organizada entre Controllers, Models e Views.
Gerenciamento de arquivos estáticos utilizando a pasta wwwroot.
Configuração Local

Para executar o projeto localmente, é necessário possuir uma instância do SQL Server configurada. A connection string deve ser ajustada para apontar para o ambiente local utilizado nos testes.
