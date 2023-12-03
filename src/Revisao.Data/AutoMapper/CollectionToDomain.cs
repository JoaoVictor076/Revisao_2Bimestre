using AutoMapper;

using ListaH1.Data.Providers.MongoDb.Collections;
using Revisao.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaH1.Data.AutoMapper
{
	public class CollectionToDomain : Profile
	{
		public CollectionToDomain()
		{

			CreateMap<CartasCollection, Cartas>()
			   .ConstructUsing(q => new Cartas(q.Nome, q.Endereco,q.Idade,q.Textinho));

		}
	}
}
