using System;
using System.Collections.Generic;
using System.Linq;
using AspNetToDoList.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AspNetToDoList.Controllers
{
    [ApiController]
    [Route("api/tasks")]
    public class TaskController : ControllerBase
    {
       

        [HttpGet]
        public IActionResult GetTask()
        {
            var t = TasksDataStore.Current.Tasks;
            return Ok(TasksDataStore.Current.Tasks);
        }

        [HttpGet("{id}", Name ="GetTask")]
        public IActionResult GetTask(int id)
        {
            var task = TasksDataStore.Current.Tasks.FirstOrDefault(c => c.Id == id);
            if (task == null) return NotFound();
            return Ok(task);
        }

        [HttpPost]
        public IActionResult CreateTask([FromBody] TaskCreationDto task)
        {
            var maxTaskId = TasksDataStore.Current.Tasks.Max(p => p.Id);

            TaskDto finaltaskCreationDto = new TaskDto()
            {
                Id = maxTaskId+1,
                title = task.title,
                Description = task.Description,
                Status = false
            };
            TasksDataStore.Current.Tasks.Add(finaltaskCreationDto);
            return CreatedAtRoute(
                "GetTask",
                new { id = finaltaskCreationDto.Id },
                finaltaskCreationDto);
            
        }
        [HttpPut("{id}")]
        public IActionResult UpdateTask(int id)
        {
            var task = TasksDataStore.Current.Tasks.FirstOrDefault(c => c.Id == id);
            if (task == null)
            {
                return NotFound();
            }
            task.Status = true;
            return Ok();
        }

        
    }
}
