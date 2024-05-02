using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsuariosMVC
{
    public class UsuariosModel
    {
        private static List<Pessoa> pessoa = new List<Pessoa>();
        public List<Pessoa> Pessoa { get { return pessoa; }}
        public void Gravar(Pessoa dados)
        {
            pessoa.Add(dados);
        }
      
    }
}
