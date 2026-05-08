Projeto: Gerenciamento de Endereços (Teste Técnico AEC)
Este projeto foi desenvolvido como solução para o teste prático da AEC para a posição de Desenvolvedor C#. A aplicação consiste em uma plataforma funcional para o gerenciamento de endereços, integrando autenticação de usuários e operações completas de CRUD.

Arquitetura e Tecnologias
Optei pelo uso do ASP.NET Core MVC para garantir uma separação clara de responsabilidades. No backend, utilizei o SQL Server com ADO.NET para o gerenciamento de dados. A escolha pelo ADO.NET permitiu um controle mais granular sobre as consultas e a autenticação, garantindo performance e segurança na manipulação dos registros.

Na interface, utilizei Razor Views em conjunto com Bootstrap 5, focando em uma experiência de usuário limpa, responsiva e de fácil navegação. Todo o desenvolvimento foi realizado no ecossistema do Visual Studio 2022.

Funcionalidades Implementadas
Controle de Acesso: Sistema de login integrado ao banco de dados para validação de usuários.

Gestão de Endereços: CRUD completo (Criação, Leitura e Exclusão) de registros.

Estrutura MVC: Organização rigorosa entre Models (entidades), Views (interface dinâmica) e Controllers (regras de negócio e roteamento).

Recursos Estáticos: Gerenciamento centralizado de scripts, CSS e bibliotecas na pasta wwwroot.

Configuração Local
Para executar o projeto, é necessário configurar uma instância do SQL Server. Um ponto importante: a connection string deve ser ajustada para apontar para o seu ambiente local — preferencialmente centralizada no arquivo de configuração ou diretamente nas classes de acesso a dados para este teste.
