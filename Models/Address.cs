using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityDataWebManager.Models
{
    public class Address : BaseEntity
    {
        public string Name { get; set; }
        [ForeignKey("Street")]
        public Guid StreetId { get; set; }
        public string? House { get; set; }
        public string? Building { get; set; }
        public string? Flat { get; set; }
        public string? PostalIndex {  get; set; }
    }
}
