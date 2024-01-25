using System.ComponentModel.DataAnnotations;

namespace ToDoApp.Data
{
    public class ToDoItem
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "This field can not be empty!")]
        public string Title { get; set; } = null!;

        [Required(ErrorMessage = "This field can not be empty!")]
        public bool Done { get; set; }  
    }
}
