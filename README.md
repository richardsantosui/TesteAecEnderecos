O projeto foi desenvolvido como solução para o teste prático da AEC para a vaga de Desenvolvedor C#. A proposta da aplicação é oferecer uma plataforma simples de gerenciamento de endereços, contando com autenticação de usuários e operações básicas de manipulação de dados.

O desenvolvimento foi realizado utilizando ASP.NET Core MVC no backend, aplicando a estrutura padrão do framework para separação das responsabilidades da aplicação. O banco de dados utilizado foi o SQL Server, com integração feita através do ADO.NET para realização das consultas, autenticação dos usuários e manipulação dos registros cadastrados.

Na parte visual, foram utilizados HTML, Razor Views e Bootstrap 5, permitindo a criação de uma interface responsiva, organizada e de fácil navegação. O projeto foi desenvolvido no Visual Studio 2022.

Entre as funcionalidades implementadas estão o sistema de login integrado ao banco de dados, permitindo validação de acesso dos usuários, além do CRUD de endereços, onde é possível cadastrar, visualizar e excluir registros. A aplicação também conta com organização estrutural baseada no padrão MVC, separando Controllers, Models e Views para facilitar manutenção, leitura e escalabilidade do código.

Os Controllers ficaram responsáveis pelo controle das rotas, validações e regras de negócio da aplicação. Os Models representam as entidades utilizadas no sistema e auxiliam na organização dos dados. Já as Views foram utilizadas para construção da interface com Razor, permitindo integração dinâmica entre frontend e backend. A pasta wwwroot foi utilizada para armazenar arquivos estáticos como folhas de estilo, scripts JavaScript e bibliotecas auxiliares.

Para execução local do projeto, é necessário configurar uma instância do SQL Server e ajustar a connection string presente nos Controllers para apontar corretamente para o banco de dados utilizado no ambiente local.

O desenvolvimento foi realizado buscando manter uma estrutura limpa, organizada e funcional, aplicando conceitos básicos do ASP.NET Core MVC, integração com banco de dados e boas práticas de organização de projeto.
