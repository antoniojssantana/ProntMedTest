using ProntMed.UI.AppTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProntMed.UI.AppTest.Interfaces
{
    public interface ITodoRepository
    {

        public Task<int> Gravar(TodoModel todo);

        public Task<int> Atualizar(TodoModel todo);

        public Task<IEnumerable<TodoModel>> Listar();

        public Task<TodoModel> Get(int id);

        public Task<int> Remover (int id);

    }
}
