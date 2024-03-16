using System.ComponentModel.DataAnnotations.Schema;
using UniversityDataWebManager.Data;

namespace UniversityDataWebManager.Models
{
    public class City : BaseEntity
    {
        public string Name { get; set; }

        [ForeignKey("District")]
        public Guid DistrictId { get; set; }

        public CityType CityType { get; set; }
    }
}
