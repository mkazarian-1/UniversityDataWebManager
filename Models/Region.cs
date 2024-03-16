using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityDataWebManager.Models
{
    public class Region : BaseEntity
    {
        public string Name { get; set; }
        
        [ForeignKey("Country")]
        public Guid CountryId { get; set; }
    }
}
