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
            CreateMap<PokemonDto, Pokemon>();
            CreateMap<Category, CategoryDto>();
            CreateMap<CategoryDto, Category>();
            CreateMap<Country, CountryDto>();
            CreateMap<CountryDto, Country>();
            CreateMap<Owner,OwnerDto>();
            CreateMap<OwnerDto,Owner>();
            CreateMap<Review,ReviewDto>();
            CreateMap<ReviewDto,Review>();
            CreateMap<Reviewer, ReviewerDto>();
            CreateMap<ReviewerDto, Reviewer>();
            
        }
    }
}
