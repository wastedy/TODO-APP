using TODO_APP.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TODO_APP.Services
{
    public static class TarefaService
    {
        static List<Tarefa> Tarefas { get; }
        static int nextId = 3;
        static TarefaService()
        {
            Tarefas = new List<Tarefa>
            {
                new Tarefa { Id = 1, Name = "Homework", Date = new DateTime(2021, 08, 23), isComplete = false},
                new Tarefa { Id = 2, Name = "Take a shower", Date = new DateTime(2021, 08, 22), isComplete = true}
            };
        }


        public static List<Tarefa> GetAll() {
            //Tarefas.Sort(); organizar a lista de tarefas sempre que ela for requisitada
            return Tarefas;
        }

        public static Tarefa Get(int id) => Tarefas.FirstOrDefault(t => t.Id == id);

        public static void Complete(int id)
        {
            var tarefa = TarefaService.Get(id);
            var index = Tarefas.FindIndex(t => t.Id == tarefa.Id);
            if (index == -1)
                return;

            tarefa.isComplete = true;
            Tarefas[index] = tarefa;
        }
        public static void Sort(List<Tarefa> Tarefas)
        {
            Tarefas.Sort((x, y) => DateTime.Compare(x.Date, y.Date)); //tentando organizar por data mas também tá dando problema
        }

        public static void Add(Tarefa tarefa)
        {
            tarefa.Id = nextId++;
            Tarefas.Add(tarefa);
        }

        public static void Delete(int id)
        {
            var tarefa = Get(id);
            if (tarefa is null)
                return;

            Tarefas.Remove(tarefa);
        }

        public static void Complete(Tarefa tarefa)
        {
            var index = Tarefas.FindIndex(t => t.Id == tarefa.Id);
            if (index == -1)
                return;

            tarefa.isComplete = true;
            Tarefas[index] = tarefa;
        }
    }
}