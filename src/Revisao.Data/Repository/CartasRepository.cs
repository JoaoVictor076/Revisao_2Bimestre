using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using H1Store.Catalogo.Data.Providers.MongoDb.Interfaces;
using ListaH1.Data.Providers.MongoDb.Collections;
using Newtonsoft.Json;
using Revisao.Domain.Entities;
using Revisao.Domain.Interfaces;

namespace Revisao.Data.Repository
{
    public class CartasRepository : ICartasRepository
    {
        private readonly IMongoRepository<CartasCollection> _cartaRepository;
        private readonly IMapper _mapper;

        #region - Construtores

        public CartasRepository(IMongoRepository<CartasCollection> cartaRepository, IMapper mapper)
        {
            _cartaRepository = cartaRepository;
            _mapper = mapper;
        }

        #endregion

        #region - Funções
        public async Task Adicionar(Cartas carta)
        {          
                await _cartaRepository.InsertOneAsync(_mapper.Map<CartasCollection>(carta));
            
        }
        public IEnumerable<Cartas> ObterTodas()
        {
            var categoriaList = _cartaRepository.FilterBy(filter => true);

            return _mapper.Map<IEnumerable<Cartas>>(categoriaList);
        }
        #endregion

        #region - Metodos

        //public List<Cartas> LerCartasDoArquivo()
        //{
        //    if (!File.Exists(_cartasCaminhoArquivo))
        //        return new List<Cartas>();
        //    string json = File.ReadAllText(_cartasCaminhoArquivo);
        //    return JsonConvert.DeserializeObject<List<Cartas>>(json);
        //}
        //public void EscreverCartasNoArquivo(List<Cartas> cartas)
        //{
        //    string json = JsonConvert.SerializeObject(cartas);
        //    File.WriteAllText(_cartasCaminhoArquivo, json);
        //}
        #endregion

    }

}

