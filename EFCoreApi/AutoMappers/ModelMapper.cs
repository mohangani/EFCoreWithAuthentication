using AutoMapper;
using EFCoreApi.Models.DbModels;
using EFCoreApi.Models.InputModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreApi.AutoMappers
{
    public class RequestDbModelMapping : Profile
    {
        public RequestDbModelMapping()
        {
            CreateMap<UserInputModel,User>();
        }
    }
}
