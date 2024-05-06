using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

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
            GravarDados();
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
            GravarDados();
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
            GravarDados();
        }
        private void GravarDados()
        {
            StreamWriter sw = File.CreateText("dados.txt");
            foreach (Pessoa p in pessoa)
            {
                sw.WriteLine($"{p.Id}%{p.Nome}%{p.Sobrenome}%{p.Departamento}%{p.Sexo}%");
            }
            sw.Close();
        }
        public void Lerdados() //lê o endereço do banco
        {
            try
            {
                using (StreamReader sr = new StreamReader("dados.txt"))
                {
                    string linha = string.Empty;
                    while ((linha = sr.ReadLine()) != null)
                    {
                        string[] dados = linha.Split('%');
                            pessoa.Add(new Pessoa(dados[0], dados[1], dados[2], dados[3], Convert.ToChar(dados[4])));
                    }
                }
            }
            catch
            {
            }
        }
    }
}
