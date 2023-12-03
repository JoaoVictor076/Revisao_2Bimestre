using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaH1.Data.Providers.MongoDb.Collections
{
	[BsonCollection("Cartas")]
	public class CartasCollection : Document
	{
        #region 2 - Propriedades

        [MinLength(3, ErrorMessage = "Minimo de 3 letras.")]
        [MaxLength(255, ErrorMessage = "maximo ....")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O endereço é obrigatorio...")]
        public string Endereco { get; set; }

        [Range(1, 15)]
        [Required]
        public int Idade { get; set; }
        [MaxLength(500, ErrorMessage = "maximo ....")]
        [Required]
        public string Textinho { get; set; }

        #endregion
    }
}
