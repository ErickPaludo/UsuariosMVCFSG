using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsuariosMVC
{
    public class Pessoa 
    {
        private string id { get; set; }
        private string nome { get; set; }
        private string sobrenome { get; set; }
        private string departamento { get; set; }
        private char sexo { get; set; }
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Sobrenome
        {
            get { return sobrenome; }
            set { sobrenome = value; }
        }
        public string Departamento
        {
            get { return departamento; }
            set { departamento= value; }
        }
        public char Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        public Pessoa()
        {
        }

        public Pessoa(string id, string nome, string sobrenome, string departamento, char sexo)
        {
            this.id = id;
            this.nome = nome;
            this.sobrenome = sobrenome;
            this.departamento = departamento;
            this.sexo = sexo;
        }
    }
}
