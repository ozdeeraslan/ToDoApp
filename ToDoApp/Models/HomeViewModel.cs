using System.ComponentModel.DataAnnotations;
using ToDoApp.Data;

namespace ToDoApp.Models
{
    public class HomeViewModel
    {
        [Required(ErrorMessage = "* Required")]
        public string Title { get; set; } = null!;


        public List<ToDoItem>? ToDoItems { get; set; } = new();
    }
}
