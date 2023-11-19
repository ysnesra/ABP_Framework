using System;
using Volo.Abp.Application.Dtos;

namespace McApp.Dto.OurService
{
    public class OurServiceDto : AuditedEntityDto<Guid>
    {
        public string Name { get; set; }
        public string PriceOf { get; set; }
        public Guid ParentId { get; set; }
    }
}
