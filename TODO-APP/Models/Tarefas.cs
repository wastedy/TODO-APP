using System;

namespace TODO_APP.Models
{
    public class Tarefa
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public bool isComplete { get; set; }
    }
}