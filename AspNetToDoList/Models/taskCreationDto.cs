using System;
using System.ComponentModel.DataAnnotations;

namespace AspNetToDoList.Models
{
    public class TaskCreationDto
    {
       

        [MaxLength(50)]
        public string title { get; set; }

        [MaxLength(200)]
        public string Description { get; set; }
        
    }
}
