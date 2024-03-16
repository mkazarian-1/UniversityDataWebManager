using System.ComponentModel.DataAnnotations.Schema;
using UniversityDataWebManager.Data;

namespace UniversityDataWebManager.Models
{
    public class Street : BaseEntity
    {
        public string Name { get; set; }

        [ForeignKey("City")]
        public Guid CityId { get; set; }

        public StreetType StreetType { get; set; }  
    }
}
