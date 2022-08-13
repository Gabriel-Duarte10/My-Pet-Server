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

        }
    }
}