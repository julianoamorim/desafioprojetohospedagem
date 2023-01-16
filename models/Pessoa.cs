using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafioprojetohospedagem.models
{
    public class Pessoa
    {
        public Pessoa(string nome){
            Nome = nome;
        }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string NomeCompleto => $"{Nome} {SobreNome}".ToUpper();
    }
}