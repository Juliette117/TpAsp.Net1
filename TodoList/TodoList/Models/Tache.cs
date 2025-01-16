using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TodoList.Models
{
    public class Tache
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Tâches à faire")]
        [Required(ErrorMessage = "Veuillez entre un titre")]
        public string? Title { get; set; }

        [StringLength(500)]
        public string? Description { get; set; }

        public bool IsChecked { get; set; }
    }
   
}



