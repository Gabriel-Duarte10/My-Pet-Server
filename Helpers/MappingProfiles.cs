using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using My_Pet.Data.Dto;
using My_Pet.Data.Requests;
using My_Pet.Models;

namespace My_Pet.Helpers
{
    public class MappingProfiles: Profile
    {
        public MappingProfiles()
        {
            CreateMap<Adoption, AdoptionRequest>().ReverseMap();
            CreateMap<Adoption, AdoptionDTO>().ReverseMap();

            CreateMap<Lost, LostRequest>().ReverseMap();
            CreateMap<Lost, LostDTO>().ReverseMap();

            CreateMap<Reproduction, ReproductionRequest>().ReverseMap();
            CreateMap<Reproduction, ReproductionDTO>().ReverseMap();

            CreateMap<Rescue, RescueRequest>().ReverseMap();
            CreateMap<Rescue, RescueDTO>().ReverseMap();

            CreateMap<Sale, SaleRequest>().ReverseMap();
            CreateMap<Sale, SaleDTO>().ReverseMap();

            CreateMap<Announcement, AnnouncementRequest>().ReverseMap();
            CreateMap<Announcement, AnnouncementDTO>().ReverseMap();

            CreateMap<User, UserDTO>()
            .ForMember(d => d.Id, o => o.MapFrom(s => s.Id))
            .ForMember(d => d.email, o => o.MapFrom(s => s.email))
            .ForMember(d => d.phone, o => o.MapFrom(s => s.phone))
            .ForMember(d => d.name, o => o.MapFrom(s => s.name))
            .ReverseMap();
        }
    }
}