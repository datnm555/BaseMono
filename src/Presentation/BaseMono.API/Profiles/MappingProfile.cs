using AutoMapper;
using BaseMono.Entities.Models;
using BaseMono.Shared.Dtos.TodoItem;

namespace BaseMono.API.Profiles;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<TodoItem, TodoItemDto>().ReverseMap();
    }
}