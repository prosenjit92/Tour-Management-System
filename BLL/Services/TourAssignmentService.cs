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
    public class TourAssignmentService
    {
        public static List<TourAssignmentDTO> Get()
        {
            var data = DataAccessFactory.TourAssignmentData().Read();
            var cfg = new MapperConfiguration(c => { c.CreateMap<TourAssignment, TourAssignmentDTO>(); });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<TourAssignmentDTO>>(data);
            return mapped;
        }
        public static TourAssignmentDTO Get(int id)
        {
            var data = DataAccessFactory.TourAssignmentData().Read(id);
            var cfg = new MapperConfiguration(c => { c.CreateMap<TourAssignment, TourAssignmentDTO>(); });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<TourAssignmentDTO>(data);
            return mapped;
        }
    }
}
