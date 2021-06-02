using AutoElectronic.Application.ViewModels;
using AutoElectronic.Domain.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoElectronic.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Item, ItemViewModel>();
            CreateMap<ItemViewModel, Item>();
        }
    }
}
