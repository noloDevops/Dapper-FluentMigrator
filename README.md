# Dapper-FluentMigrator
This is a project to help understand how Dapper-FluentMigrator works for managing Sql migration in a project

It is based on the steps detailed on 👉🏾 [Dapper-FluentMigrator](https://code-maze.com/dapper-migrations-fluentmigrator-aspnetcore)

In terms of the Database itself👀 we went with 🐳Docker's (Azure Sql Edge)[https://hub.docker.com/_/microsoft-azure-sql-edge] Image to sandbox the cloud☁️ sql environment locally🏠

If you are using a Mac M1 please run the following command to use an image to spawn a container : docker run --cap-add SYS_PTRACE -e 'ACCEPT_EULA=1' -e 'MSSQL_SA_PASSWORD=Password.1' -p 1433:1433 --name azuresqledge -d mcr.microsoft.com/azure-sql-edge

