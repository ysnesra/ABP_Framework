using McApp.Dto.OurService;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace McApp.Services
{
    public interface IOurServiceAppService : ICrudAppService< //Defines CRUD methods
        OurServiceDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateOurServiceDto> //Used to create/update a book
    {

    }
}
