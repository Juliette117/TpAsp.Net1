using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TodoList.Models
{
    public class Tache
    {
        public int Id { get; set; }
        [Display(Name = "Tâches à faire")]
        [Required(ErrorMessage = "Le nom de la tâche est obligatoire.")]
        public string Titre { get; set; }
        public string? Description { get; set; }
    }
}
