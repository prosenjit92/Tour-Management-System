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
    public class TourService
    {
        public static List<TourDTO> Get()
        {
            var data = DataAccessFactory.TourData().Read();
            var cfg = new MapperConfiguration(c => { c.CreateMap<Tour, TourDTO>(); });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<TourDTO>>(data);
            return mapped;
        }
        public static TourDTO Get(int id)
        {
            var data = DataAccessFactory.TourData().Read(id);
            var cfg = new MapperConfiguration(c => { c.CreateMap<Tour, TourDTO>(); });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<TourDTO>(data);
            return mapped;
        }
    }
}
