using AutoMapper;
using CoreCodeCamp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreCodeCamp.Data
{
    public class CampProfile: Profile
    {
        public CampProfile()
        {
            this.CreateMap<Camp, CampModel>()
                .ForMember(c => c.Venue, o => o.MapFrom(m => m.Location.VenueName))
                .ForMember(c => c.AddressLine1, o => o.MapFrom(m => m.Location.Address1))
                .ForMember(c => c.AddressLine2, o => o.MapFrom(m => m.Location.Address2))
                .ForMember(c => c.AddressLine3, o => o.MapFrom(m => m.Location.Address3))
                .ForMember(c => c.CityorTown, o => o.MapFrom(m => m.Location.CityTown))
                .ForMember(c => c.StateorProvince, o => o.MapFrom(m => m.Location.StateProvince))
                .ForMember(c => c.PostCode, o => o.MapFrom(m => m.Location.PostalCode))
                .ForMember(c => c.Country, o => o.MapFrom(m => m.Location.Country))
                .ReverseMap();
        }
    }
}
