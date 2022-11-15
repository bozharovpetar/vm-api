using System.ComponentModel.DataAnnotations;

namespace VM.Domain.Models
{
    public class Entity
    {
        [Key]
        public Guid Id { get; set; }
    }
}
