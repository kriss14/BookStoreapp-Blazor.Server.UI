using AutoMapper;
using Blazored.LocalStorage;
using BookStoreApp_Blazor.Server.UI.Controllers;
using BookStoreApp_Blazor.Server.UI.Data;
using BookStoreApp_Blazor.Server.UI.Services.Base;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookStoreApp_Blazor.Server.UI.Services
{ 
    public interface IGetData
    {
        Task<ActionResult<IEnumerable<AuthorReadOnlyDto>>> GetAuthors();
    }
    public class Author : IGetData
    {
        private readonly IAuthorsController authorsController;
        private readonly BookStoreDbContext context;
        private readonly IMapper mapper;

        public Author(BookStoreDbContext context, IMapper mapper) 
        {
            this.context = context;
            this.mapper = mapper;
        }

        public async Task<ActionResult<IEnumerable<AuthorReadOnlyDto>>> GetAuthors()
        {
            var authors =await context.Authors.ToListAsync();
            return null;
        }
    }
}
