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
        public List<Pessoa> Pessoa
        {
            get
            {
                return pessoa;
            }
        }

        public void Gravar(Pessoa dados)
        {
            pessoa.Add(dados);
        }

        public bool ValidaExistencia(string id)
        {
            bool existencia = false;
            foreach (Pessoa obj in pessoa)
            {
                if (obj.Id == id)
                {
                    existencia = true;
                }
            }
            return existencia;
        }

        public bool QuantidadeNaLista()
        {
            return pessoa.Count > 0;
        }

        public void Editar(Pessoa novos_dados)
        {
            Pessoa user_ = null;
            foreach (Pessoa obj in pessoa)
            {
                if (obj.Id == novos_dados.Id)
                {
                    obj.Nome = novos_dados.Nome;
                    obj.Sobrenome = novos_dados.Sobrenome;
                    obj.Departamento = novos_dados.Departamento;
                    obj.Sexo = novos_dados.Sexo;
                }
            }
            pessoa.Remove(user_);
        }

        public void Excluir(string id)
        {
            Pessoa user_ = null;
            foreach (Pessoa obj in pessoa)
            {
                if (obj.Id == id)
                {
                   user_ = obj;
                }
            }
            pessoa.Remove(user_);
        }

    }
}
