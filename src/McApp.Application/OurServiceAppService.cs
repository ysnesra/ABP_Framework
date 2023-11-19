using McApp.Dto.OurService;
using McApp.Services;
using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace McApp
{
    public class OurServiceAppService : CrudAppService<
        OurServiceItem, //The Book entity
        OurServiceDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateOurServiceDto>, IOurServiceAppService //Used to create/update a book
    {
        public OurServiceAppService(IRepository<OurServiceItem, Guid> repository) : base(repository)
        {
        }
    }
}
