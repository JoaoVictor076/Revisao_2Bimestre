﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Revisao.Domain.Entities;

namespace Revisao.Domain.Interfaces
{
    public interface ICartasRepository
    {
        IEnumerable<Cartas> ObterTodas();

        Task Adicionar(Cartas cartas);
    }
}
