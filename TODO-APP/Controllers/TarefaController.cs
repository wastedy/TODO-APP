using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TODO_APP.Models;
using TODO_APP.Services;

namespace TODO_APP.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TarefaController : ControllerBase
    {
        public TarefaController()
        {
        }
        [HttpGet]
        public ActionResult<List<Tarefa>> GetAll() => TarefaService.GetAll();

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

        [HttpPut("{id}")]
        public IActionResult Update(int id, string aux)
        {
            if(aux != "complete") //tentando fazer ele ler o conteudo do comando PUT do httprepl
                return BadRequest();

            var tarefa = TarefaService.Get(id);
            if (tarefa is null)
                return NotFound();

            TarefaService.Complete(tarefa);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var tarefa = TarefaService.Get(id);

            if (tarefa is null)
                return NotFound();

            TarefaService.Delete(id);

            return NoContent();
        }
    }
}