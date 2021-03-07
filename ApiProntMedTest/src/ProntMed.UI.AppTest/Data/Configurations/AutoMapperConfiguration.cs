using AutoMapper;
using ProntMed.UI.AppTest.Interfaces;
using ProntMed.UI.AppTest.Models;
using ProntMed.UI.AppTest.Repository;
using ProntMed.UI.AppTest.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProntMed.UI.AppTest.Data.Configurations
{
    public class AutoMapperConfiguration : Profile
    {
        public AutoMapperConfiguration()
        {
            CreateMap<TodoModel, TodoNameView>().ReverseMap();
            CreateMap<TodoModel, TodoView>().ReverseMap();
            CreateMap<ITodoRepository, TodoRepository>().ReverseMap();
        }
    }
}
