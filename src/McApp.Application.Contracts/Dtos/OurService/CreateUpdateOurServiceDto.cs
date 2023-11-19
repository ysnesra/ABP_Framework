
using System.ComponentModel.DataAnnotations;

namespace McApp.Dto.OurService
{
    public class CreateUpdateOurServiceDto
    {
        [Required]
        [StringLength(128)]
        public string Name { get; set; }
        
        [Required]
        public string PriceOf { get; set; }
    }
}
