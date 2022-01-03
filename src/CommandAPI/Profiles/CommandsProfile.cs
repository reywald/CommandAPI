using AutoMapper;
using CommandAPI.Models;
using CommandAPI.DTOs;

namespace CommandAPI.Profiles
{
    public class CommandsProfile : Profile
    {
        public CommandsProfile()
        {
            CreateMap<Command, CommandReadDTO>();
        }
    }
}
