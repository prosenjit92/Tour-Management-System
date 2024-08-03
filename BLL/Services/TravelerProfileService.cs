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
    public class TravelerProfileService
    {
        public static TravelerProfileDTO Get(int id)
        {
            var data = DataAccessFactory.TravelerProfileData().Read(id);
            var cfg = new MapperConfiguration(c => { c.CreateMap<TravelerProfile, TravelerProfileDTO>(); });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<TravelerProfileDTO>(data);
            return mapped;
        }
    }
}
