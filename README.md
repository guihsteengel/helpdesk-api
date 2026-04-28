🚀 HelpDesk API

API REST para gerenciamento de chamados (tickets) de suporte técnico, desenvolvida com C# e .NET.
O sistema simula um fluxo simples de atendimento, permitindo criação, consulta, atualização e remoção de chamados.

🧩 Objetivo do projeto

Este projeto foi desenvolvido com foco em prática de backend, aplicando conceitos de API REST, persistência de dados e boas práticas com .NET.

🛠️ Tecnologias utilizadas
C#
.NET (ASP.NET Core Web API)
Entity Framework Core
PostgreSQL
Swagger (OpenAPI)

📌 Funcionalidades
Criar chamados (tickets de suporte)
Listar todos os chamados
Buscar chamado por ID
Atualizar chamados existentes
Remover chamados
Documentação interativa da API via Swagger

🗄️ Banco de Dados
Banco: PostgreSQL
Mapeamento de entidades com Entity Framework Core
Uso de migrations para versionamento do banco

▶️ Como executar o projeto
1. Pré-requisitos
.NET SDK instalado
PostgreSQL instalado e configurado
2. Configuração do banco

Atualize a connection string no arquivo:

appsettings.json
3. Executar migrations (se necessário)
dotnet ef database update
4. Rodar a aplicação
dotnet run

📖 Acessar documentação (Swagger)

Após executar o projeto:

https://localhost:xxxx/swagger

🧠 O que foi praticado neste projeto
Desenvolvimento de API REST com .NET
CRUD completo com Entity Framework Core
Integração com banco de dados PostgreSQL
Organização básica de backend
Documentação de API com Swagger

👤 Autor

Guilherme Stengel

LinkedIn: [Acessar perfil](https://www.linkedin.com/in/guilhermestengel/)
