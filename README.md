# TODO-APP
 API de lista de tarefas.

# Requisitos
 Httprepl,<br>
 SDK .NET 5.

# Passo a passo
 ### Instale o httprepl com o comando:
    dotnet tool install -g Microsoft.dotnet-httprepl
    
 ### Execute 
    dotnet run
 
 ### Use o httprepl para conectar à API
    httprepl http://localhost:5000
 
 ### Digite para listar as APIs:
    ls
 
 ### Depois use o comando para selecionar a API:
    cd Tarefa
 
 ### Para retornar o que tem na API:
    GET
 
 ### Retornar alguma tarefa específica pelo Id:
    GET <id>
 
 ### Adicionar alguma tarefa na lista de tarefas da API:
    POST -c "{"name": "exemplo", "Date": "2021-10-24", "isComplete": false}"
 
 ### Atualizar o estado de conclusão de alguma tarefa:
    PUT <id> -c "complete"
 
 ### Remover alguma tarefa da API:
    DELETE <id>
