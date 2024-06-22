using AutoMapper;
using Restoran.DTO.Dtos.AboutDtos;
using Restoran.DTO.Dtos.BannerDtos;
using Restoran.DTO.Dtos.FooterDtos;
using Restoran.DTO.Dtos.MenuDtos;
using Restoran.DTO.Dtos.ReservationDtos;
using Restoran.DTO.Dtos.ServiceDtos;
using Restoran.DTO.Dtos.TeamMemberDtos;
using Restoran.DTO.Dtos.TestimonialDtos;
using Restoran.Entity.Entities;

namespace Restoran.API.Mapping
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<CreateAboutDto,About>().ReverseMap();
            CreateMap<UpdateAboutDto,About>().ReverseMap();

            CreateMap<CreateBannerDto, Banner>().ReverseMap();
            CreateMap<UpdateBannerDto, Banner>().ReverseMap();

            CreateMap<CreateFooterDto,Footer>().ReverseMap();
            CreateMap<UpdateFooterDto,Footer>().ReverseMap();

            CreateMap<CreateMenuDto,Menu>().ReverseMap();
            CreateMap<UpdateMenuDto,Menu>().ReverseMap();

            CreateMap<CreateReservationDto,Reservation>().ReverseMap();
            CreateMap<UpdateReservationDto,Reservation>().ReverseMap();

            CreateMap<CreateServiceDto,Service>().ReverseMap();
            CreateMap<UpdateServiceDto,Service>().ReverseMap();

            CreateMap<CreateTeamMemberDto, TeamMember>().ReverseMap();
            CreateMap<UpdateTeamMemberDto, TeamMember>().ReverseMap();

            CreateMap<CreateTestimonialDto,Testimonial>().ReverseMap();
            CreateMap<UpdateTestimonialDto,Testimonial>().ReverseMap();
        }
    }
}
