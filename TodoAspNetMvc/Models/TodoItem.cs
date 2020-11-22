using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TodoAspNetMvc.Models
{
    public class TodoItem
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Short Description")]
        [StringLength(35)]
        public string ShortDescription { get; set; }


        [Display(Name = "Detailed Description")]
        public string Description { get; set; }


        [Display(Name = "Creation Date")]
        public DateTime CreationDate { get; set; }

        
        [Required(ErrorMessage = "Set a deadline for the task")]
        public DateTime Deadline { get; set; }

        
        [Display(Name = "Is Complete?")]
        public bool IsComplete { get; set; }
    }
}