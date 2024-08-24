using AutoMapper;
using HotelProject.DtoLayer.Dtos.ContactDto;
using HotelProject.DtoLayer.Dtos.GuestDto;
using HotelProject.DtoLayer.Dtos.RoomDto;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.WebApi.Mapping
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig() 
        {
            CreateMap<Room, RoomAddDto>().ReverseMap();
            CreateMap<Room, RoomUpdateDto>().ReverseMap();

            CreateMap<Contact, CreateContactDto>().ReverseMap();

            CreateMap<Guest, CreateGuestDto>().ReverseMap();
            CreateMap<Guest, UpdateGuestDto>().ReverseMap();
        }
       
    }
}
