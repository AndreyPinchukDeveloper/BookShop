using AutoMapper;
using Shop.Application.Common.Mappings;
using ShopDomainLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Application.Books.Queries.GetBookDetails
{
    public class BookDetailsViewModel:IMapWith<Book>
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Descriptions { get; set; }
        public DateTime NewSupply { get; set; }
        public DateTime SellDate { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Book, BookDetailsViewModel>()
                .ForMember(bookViewModel => bookViewModel.Title,
                opt => opt.MapFrom(book => book.Title))
                .ForMember(bookViewModel => bookViewModel.Descriptions,
                opt => opt.MapFrom(book => book.Descriptions))
                .ForMember(bookViewModel => bookViewModel.Id,
                opt => opt.MapFrom(book => book.Id))
                .ForMember(bookViewModel => bookViewModel.Author,
                opt => opt.MapFrom(book => book.Author))
                .ForMember(bookViewModel => bookViewModel.NewSupply,
                opt => opt.MapFrom(book => book.NewSupply))
                .ForMember(bookViewModel => bookViewModel.SellDate,
                opt => opt.MapFrom(book => book.SellDate));
        }
    }
}
