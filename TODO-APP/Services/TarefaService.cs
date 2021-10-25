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
                new Tarefa { Id = 1, Name = "Homework", Date = DateTime.ParseExact("23-08-2021", "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture), isComplete = false},
                new Tarefa { Id = 2, Name = "Take a shower", Date = DateTime.ParseExact("22-08-2021", "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture), isComplete = true},
                new Tarefa { Id = 3, Name = "Take a breath", Date = DateTime.ParseExact("24-08-2021", "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture), isComplete = false}
            };
        }


        public static List<Tarefa> GetNotCompleted() {
            TarefaService.Ordenar(Tarefas);
            List<Tarefa> Tarefas2 = new List<Tarefa>();
            foreach(Tarefa a in Tarefas){
                if(!a.isComplete)
                    Tarefas2.Add(a);
            }
            return Tarefas2;
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
        public static void Ordenar(List<Tarefa> Tarefas)
        {
            var Tarefas2 = from t in Tarefas
            orderby t.Date
            select t;

            Tarefas = Tarefas2.ToList();
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
