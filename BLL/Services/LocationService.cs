using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class LocationService
    {
        public static void Create(LocationDTO L)
        {
            
            var cfg = new MapperConfiguration(c => { c.CreateMap<LocationDTO, Location>(); });
            var mapper = new Mapper(cfg);
            var data = mapper.Map<Location>(L);
            DataAccessFactory.LocationData().Create(data); 
        }
        public static  LocationDTO Update(LocationDTO updatedLocation)
        {
            var cfg = new MapperConfiguration(c => { c.CreateMap<LocationDTO, Location>(); });
            var mapper = new Mapper(cfg);
            var updatedData = mapper.Map<Location>(updatedLocation);
            DataAccessFactory.LocationData().Update(updatedData);
            return updatedLocation;
        }

    }
}
