using System.ComponentModel.DataAnnotations;

namespace vscodeweb.data.Models
{
    public class Todos {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
        public bool IsComplete { get; set; }
    }
}
