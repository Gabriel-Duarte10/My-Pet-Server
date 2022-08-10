using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using My_Pet.Data.Requests;
using My_Pet.Models;

namespace My_Pet.Helpers
{
    public class MappingProfiles: Profile
    {
        public MappingProfiles()
        {
            CreateMap<Adoption, AdoptionRequest>().ReverseMap();
            // CreateMap<Adoption, AdoptionRequest>().ReverseMap();

            CreateMap<Lost, LostRequest>().ReverseMap();
            // CreateMap<Adoption, AdoptionRequest>().ReverseMap();

            CreateMap<Reproduction, ReproductionRequest>().ReverseMap();
            // CreateMap<Adoption, AdoptionRequest>().ReverseMap();

            CreateMap<Rescue, RescueRequest>().ReverseMap();
            // CreateMap<Adoption, AdoptionRequest>().ReverseMap();

            CreateMap<Sale, SaleRequest>().ReverseMap();

        }
    }
}