# TODO-APP
 Aplicação de gerenciamento de tarefas

# Requisitos
 SDK .NET 5

# Uso
 Instale o httprepl com o comando: dotnet tool install -g Microsoft.dotnet-httprepl;\n
 Execute dotnet run;\n
 Use o httprepl para conectar ao http://localhost:<porta>;\n
 Depois use o comando: "cd" para selecionar a API;\n
 Por último: GET (retorna o que tem na API), \nGET <id> (seleciona alguma tarefa pelo Id), \nPOST -c <tarefa> (adiciona alguma tarefa na API), PUT <id> -c <tarefa> (atualiza algo na API) e \nDELETE <id> (remove algum objeto da lista na API)
