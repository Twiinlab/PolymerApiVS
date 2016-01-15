using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using PolymerApi.Models;

namespace PolymerApi.Controllers
{
    [Route("api/[controller]")]
    public class TodoController : Controller
    {
        static private List<Todo> todolist = new List<Todo>();

        public TodoController()
        {
            if (todolist.Count == 0)
            {
                todolist.Add(new Todo { rid = 0, task = "Happy Polymer Coding", user = "Ruben Chavarri", time = "" });
            }
        }
        // GET: api/values
        [HttpGet]
        public IEnumerable<Todo> Get()
        {
            return todolist;
        }

        // GET api/values/5
        [HttpGet("{id;int}")]
        public IActionResult Get(int id)
        {
            return new ObjectResult(todolist[id]);
            //return "value";
        }

        // PUT api/values/5
        [HttpPut("{id:int}")]
        public IActionResult Put(int id, [FromBody]Todo todo)
        {
            todolist[todo.rid] = todo;
            return new ObjectResult(todo);
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]Todo todo)
        {
            todo.rid = todolist.Count;
            todolist.Add(todo);
            return new ObjectResult(todo);
        }


        // DELETE api/values/5
        [HttpDelete("{id:int}")]
        public IActionResult Delete(int rid)
        {
            todolist.RemoveAt(rid);
            return new HttpStatusCodeResult(200);
        }
    }
}
