using AutoMapper;
using Shop.Application.Books.Queries.GetBookDetails;
using Shop.Application.Common.Mappings;
using ShopDomainLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Application.Books.Queries.GetBookList
{
    public class BookLookupDTO:IMapWith<Book>
    {
        public Guid Id { get; set; }
        public string Title { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Book, BookLookupDTO>()
                .ForMember(bookViewModel => bookViewModel.Title,
                opt => opt.MapFrom(book => book.Title))
                .ForMember(bookViewModel => bookViewModel.Id,
                opt => opt.MapFrom(book => book.Id));
        }
    }
}
