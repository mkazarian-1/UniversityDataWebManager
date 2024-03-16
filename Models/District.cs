using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityDataWebManager.Models
{
    public class District : BaseEntity
    {
        public string Name { get; set; }

        [ForeignKey("Region")]
        public Guid RegionId { get; set; }
    }
}
