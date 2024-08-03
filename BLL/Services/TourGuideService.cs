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
    public class TourGuideService
    {
        public static List<TourGuideDTO> Get()
        {
            var data = DataAccessFactory.TourGuideData().Read();
            var cfg = new MapperConfiguration(c => {c.CreateMap<TourGuide, TourGuideDTO>();});
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<TourGuideDTO>>(data);
            return mapped;
        }
        public static TourGuideDTO Get(int id)
        {
            var data = DataAccessFactory.TourGuideData().Read(id);
            var cfg = new MapperConfiguration(c => {c.CreateMap<TourGuide, TourGuideDTO>();});
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<TourGuideDTO>(data);
            return mapped;
        }
    }
}
