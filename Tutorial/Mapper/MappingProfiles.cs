using System.Collections.Generic;
using AutoMapper;
using Tutorial.Portal.EntityModel;
using Tutorial.Portal.ViewModel;

namespace Tutorial.Portal.Mapper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<User, UserViewModel>();
            CreateMap<UserViewModel, User>();
        }
    }
}
