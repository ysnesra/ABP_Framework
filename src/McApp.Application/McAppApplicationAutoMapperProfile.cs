using AutoMapper;
using McApp.Dto.OurService;

namespace McApp;

public class McAppApplicationAutoMapperProfile : Profile
{
    public McAppApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */

        CreateMap<OurServiceItem, OurServiceDto>().ReverseMap();
        CreateMap<CreateUpdateOurServiceDto,OurServiceItem>().ReverseMap();

    }
}
