using ProntMed.UI.AppTest.Data;
using ProntMed.UI.AppTest.Interfaces;
using ProntMed.UI.AppTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

namespace ProntMed.UI.AppTest.Repository
{
    public class TodoRepository : ITodoRepository
    {
        public DbSet<TodoModel> Todos { get; set; }
        private readonly TodoDbContext _todoContexto;

        public TodoRepository(TodoDbContext contexto)
        {
            _todoContexto = contexto;
        }
        public async Task<int> Atualizar(TodoModel todo)
        {
            try
            {
                _todoContexto.Todos.Update(todo);
                return await _todoContexto.SaveChangesAsync();
            }
            catch (Exception ex) // Implementar Log de Exceção;
            {
                return 0;
            }
        }

        public async Task<TodoModel> Get(int id)
        {
            try
            {
                TodoModel todo = new TodoModel() { Id = id };
                return await _todoContexto.Todos.FindAsync(todo.Id);
            }
            catch (Exception ex) // Implementar Log de Exceção;
            {
                return null;
            }
        }

        public async Task<int> Gravar(TodoModel todo)
        {
            try
            {
                _todoContexto.Todos.Add(todo);
                return _todoContexto.SaveChanges();
            }
            catch (Exception ex) // Implementar Log de Exceção;
            {
                return 0;

            }
        }

        public async Task<IEnumerable<TodoModel>> Listar()
        {
            try
            {
                return _todoContexto.Todos.ToList();
            }
            catch (Exception ex) // Implementar Log de Exceção;
            {
                return null;
            }
        }

        public async Task<int> Remover(int id)
        {
            try
            {
                TodoModel todo = new TodoModel() { Id = id };
                _todoContexto.Todos.Remove(todo);
                var _registros = _todoContexto.SaveChanges();
                return _registros;
            }
            catch (Exception ex) // Implementar Log de Exceção;
            {
                return 0;
            }
        }
    }
}
