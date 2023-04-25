using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Models
{
    public class Pessoa
    {
        private string nome;
        private string logradouro;
        private string numero;
        private string bairro;
        private string cidade;
        private string estado;
        private string cep;

        [MaxLength(30)]
        public string Nome { get => nome; set => nome = value; }
        
        
        [MaxLength(40)]
        public string Logradouro { get => logradouro; set => logradouro = value; }
        [MaxLength(10)]
        public string Numero { get => numero; set => numero = value; }
        [MaxLength(20)]
        public string Bairro { get => bairro; set => bairro = value; }

        [MaxLength(30)]
        public string Cidade { get => cidade; set => cidade = value; }

        [MaxLength(20)]
        public string Estado { get => estado; set => estado = value; }
        [MaxLength(10)]
        public string Cep { get => cep; set => cep = value; }
    }
}
