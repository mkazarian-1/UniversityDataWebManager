using System.ComponentModel.DataAnnotations;

namespace UniversityDataWebManager.Models
{
    public class BaseEntity
    {
        [Key]
        public Guid Id { get; set; }

        public BaseEntity()
        {
            Id = Guid.NewGuid();
        }
    }
}
