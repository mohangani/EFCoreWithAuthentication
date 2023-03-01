using AutoMapper;
using EFCoreApi.Models.DbModels;
using EFCoreApi.Models.InputModels;

namespace EFCoreApi.AutoMappers
{
    public class RequestDbModelMapping : Profile
    {
        public RequestDbModelMapping()
        {
            CreateMap<UserInputModel, User>();
            CreateMap<AddressInputModel, Address>();
        }
    }
}
