using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;
using Volo.Abp.MultiTenancy;

namespace McApp
{
    public class OurServiceItem : BasicAggregateRoot<Guid>, IMultiTenant
    {
        public string Name { get; set; }
        public string PriceOf { get; set; }
        public Guid ParentId { get; set; }

        public Guid? TenantId { get; set; }



    }
}
