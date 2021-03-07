using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ProntMed.UI.AppTest.Data;
using ProntMed.UI.AppTest.Interfaces;
using ProntMed.UI.AppTest.Models;
using ProntMed.UI.AppTest.Repository;
using ProntMed.UI.AppTest.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProntMed.UI.AppTest.Controllers
{
   
    [ApiController]
    [Route("api/[controller]")]
    public class TodosController : ControllerBase
    {
        private readonly ITodoRepository _todoRepository;
        private readonly IMapper _mapper;

        public TodosController(ITodoRepository todoRepository, IMapper mapper)
        {
            
            _todoRepository = todoRepository;
            _mapper = mapper;
        }

        [Route("/api/[controller]")]
        [HttpPost("/api/[controller]")]
        public async Task<int> Criar([FromBody] TodoNameView name)
        {
            
            TodoModel _model = _mapper.Map<TodoModel>(name);
            return await _todoRepository.Gravar(_model);
        }

        [HttpPut("{id:int}")]
        [Route("api/[controller]")]
        public async Task<int> Atualizar(int id, TodoView todoView)
        {
            TodoModel _model = _mapper.Map<TodoModel>(todoView);
            _model.Id = id;
            return await _todoRepository.Atualizar(_model);
        }

        [HttpDelete("{id:int}")]
        [Route("api/[controller]")]
        public async Task<int> Remover(int id)
        {
            TodoModel _model = new TodoModel();
            return await _todoRepository.Remover(id);
        }


        [HttpGet("")]
        [Route("/api/[controller]")]
        public async Task<IEnumerable<TodoModel>> Listar()
        {
            return await _todoRepository.Listar();
        }

        [HttpGet("{id:int}")]
        [Route("api/[controller]")]
        public async Task<TodoView> GetId(int id)
        {
            TodoModel _model = new TodoModel();
            return _mapper.Map<TodoView>(await _todoRepository.Get(id));
        }


    }

}
