using FetchApiSirene.DataAccess.Models.Dto;

namespace FetchApiSirene.BusinessLogic.Services
{
    public interface IEstablishmentInterface
    {
        List<EstablishmentsDto> GetAsync();
    }
}




