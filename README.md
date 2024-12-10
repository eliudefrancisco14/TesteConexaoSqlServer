# Teste de Conexão com o SQL Server.

Este é um programa que criei para me ajudar a testar a conexão com o meu banco de dados, caso ela esteja no: 

- **docker**, 
- **hospedado num server**,
- **SQL Server Management Studio (SSMS)** ou
- **Uma outra plataforma**



## Como usar

É muito simples. Só precisas passar a tua string de conexão na variável *stringconnection* desse jeito:

```c#
string connectionString = "String de conexão";
```

Após mudar a string de conexão, só precisas rodar o comando asseguir para rodar o projecto:

```bash
dotnet run
```

E terás como resultado `Conexão bem-sucedida!` caso a conexão esteja bem configurada



Não esqueça de deixar a tua estrela:star2: se te eu ajudei (*ou não*)! 
