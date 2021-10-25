using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TODO_APP.Models;
using TODO_APP.Services;

namespace TODO_APP.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TarefaController : ControllerBase
    {
        public TarefaController()
        {
        }
        [HttpGet]
        public ActionResult<List<Tarefa>> GetNotCompleted() => TarefaService.GetNotCompleted();

        [HttpGet("{id}")]
        public ActionResult<Tarefa> Get(int id)
        {
            var tarefa = TarefaService.Get(id);

            if (tarefa == null)
                return NotFound();

            return tarefa;
        }

        [HttpPost]
        public IActionResult Create(Tarefa tarefa)
        {
            TarefaService.Add(tarefa);
            return CreatedAtAction(nameof(Create), new { id = tarefa.Id }, tarefa);
        }
    }

    [Route("api/ConcluirTarefas")]
    public class ConcluirTarefasController: ControllerBase
    {
        public ConcluirTarefasController()
        {
        }
        [HttpGet("{id}")]
        public IActionResult Complete(int id){

            var tarefa = TarefaService.Get(id);
            if (tarefa is null)
                return NotFound();

            TarefaService.Complete(tarefa);

            return Content("Tarefa concluída.");
        }
    }
}