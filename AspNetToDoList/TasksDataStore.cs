using System;
using System.Collections.Generic;
using AspNetToDoList.Models;

namespace AspNetToDoList
{
    public class TasksDataStore
    {

        public static TasksDataStore Current { get; } = new TasksDataStore();

        public List<TaskDto> Tasks { get; set; }


        public TasksDataStore()
        {
            Tasks = new List<TaskDto>()
            {
                new TaskDto()
                {
                    Id=1,
                    title="Title1",
                    Description= "Description1",
                    Status=false
                },
                new TaskDto()
                {
                    Id=2,
                    title="Title2",
                    Description= "Description2",
                    Status=false
                },
                new TaskDto()
                {
                    Id=3,
                    title="Title3",
                    Description= "Description3",
                    Status=false
                }
            };
        }

        
    }
}
