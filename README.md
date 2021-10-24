# TODO-APP
 Aplicação de gerenciamento de tarefas

# Requisitos
 SDK .NET 5

# Uso
 Instale o httprepl com o comando: dotnet tool install -g Microsoft.dotnet-httprepl;<br>
 Execute dotnet run;<br>
 Use o httprepl para conectar ao http://localhost:(porta);<br>
 Depois use o comando: "cd" para selecionar a API;<br>
 Por último: GET (retorna o que tem na API), <br>
 GET "id" (seleciona alguma tarefa pelo Id), <br>
 POST -c "tarefa" (adiciona alguma tarefa na API), <br>
 PUT "id" -c "tarefa" (atualiza algo na API) e <br>
 DELETE "id" (remove algum objeto da lista na API)
