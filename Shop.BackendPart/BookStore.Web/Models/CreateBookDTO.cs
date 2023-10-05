using AutoMapper;
using Shop.Application.Books.Commands;
using Shop.Application.Books.Queries.GetBookDetails;
using Shop.Application.Common.Mappings;
using ShopDomainLibrary;

namespace BookStore.Web.Models
{
    public class CreateBookDTO:IMapWith<CreateBookCommand>
    {
        public string Title { get; set; }
        public string Descriptions { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<CreateBookDTO, CreateBookCommand>()
                .ForMember(bookViewModel => bookViewModel.Title,
                opt => opt.MapFrom(book => book.Title))
                .ForMember(bookViewModel => bookViewModel.Descriptions,
                opt => opt.MapFrom(book => book.Descriptions));
        }
    }
}
