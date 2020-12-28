using System;

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetToDoList.Entities
{
    public class TaskSchema
    {
      
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string title { get; set; }

        [MaxLength(200)]
        public string Description { get; set; }

        public bool Status { get; set; }



            
    }
}
