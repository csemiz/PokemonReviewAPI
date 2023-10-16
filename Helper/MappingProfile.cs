using AutoMapper;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using PokemonReviewAPI.Dto;
using PokemonReviewAPI.Models;

namespace PokemonReviewAPI.Helper
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Pokemon, PokemonDto>();
            CreateMap<Category, CategoryDto>();
            CreateMap<Country, CountryDto>();
            CreateMap<Owner,OwnerDto>();
            CreateMap<Review,ReviewDto>();
            CreateMap<Reviewer, ReviewerDto>();
            
        }
    }
}
