using AutoMapper;
using BookStoreApp_Blazor.Server.UI.Data;
using BookStoreApp_Blazor.Server.UI.Models.Author;
using BookStoreApp_Blazor.Server.UI.Models.Book;
using BookStoreApp_Blazor.Server.UI.Models.User;
using System.Runtime.InteropServices;

namespace BookStoreAPI.Configurations
{
    public class MapperConfig :Profile
    {
        public MapperConfig()
        {
            CreateMap<AuthorCreateDto, Author>().ReverseMap();
            CreateMap<AuthorUpdateDto, Author>().ReverseMap();
            CreateMap<AuthorReadOnlyDto, Author>().ReverseMap();

            CreateMap<BookCreateDto, Book>().ReverseMap();
            CreateMap<BookUpdateDto, Book>().ReverseMap();
            CreateMap<Book,BookReadOnlyDto>()
                .ForMember(q=> q.AuthorName, d=>d.MapFrom(map=> $"{map.Author.FirstName} {map.Author.LastName}"))
                .ReverseMap();            
            
            CreateMap<Book,BookDetailsDto>()
                .ForMember(q=> q.AuthorName, d=>d.MapFrom(map=> $"{map.Author.FirstName} {map.Author.LastName}"))
                .ReverseMap();

            CreateMap<AppUser, UserDto>().ReverseMap();
        }
    }
}
