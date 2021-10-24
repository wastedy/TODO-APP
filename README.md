# TODO-APP
 Aplicação de gerenciamento de tarefas

# Requisitos
 SDK .NET 5

# Uso
 Instale o httprepl com o comando: dotnet tool install -g Microsoft.dotnet-httprepl;
 Execute dotnet run;
 Use o httprepl para conectar ao http://localhost:<porta>;
 Depois use o comando: "cd" para selecionar a API;
 Por último: GET (retorna o que tem na API), GET <id> (seleciona alguma tarefa pelo Id), POST -c <tarefa> (adiciona alguma tarefa na API), PUT <id> -c <tarefa> (atualiza algo na API) e DELETE <id> (remove algum objeto da lista na API)
