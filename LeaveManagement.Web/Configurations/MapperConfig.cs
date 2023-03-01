using AutoMapper;
using LeaveManagement.Web.Data.Migrations;
using LeaveManagement.Web.Models;

namespace LeaveManagement.Web.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<LeaveType, LeaveTypeVM>().ReverseMap();
        }
    }
}
