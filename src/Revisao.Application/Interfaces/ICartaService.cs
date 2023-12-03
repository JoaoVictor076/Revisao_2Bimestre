using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Revisao.Application.ViewModels;
using Revisao.Domain.Entities;

namespace Revisao.Application.Interfaces
{
    public interface ICartaService
    {

        //IEnumerable<CartasViewModel> ObterTodos();
        Task Adicionar(NovaCartaViewModel novaCartaViewModel);

       public IEnumerable<CartasViewModel> ObterTodas();
    }
}
