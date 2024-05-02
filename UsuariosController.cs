using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsuariosMVC
{
    public class UsuariosController
    {
        IUsuariosView usuariosView;
        UsuariosModel usuariosModel;
        public UsuariosController(IUsuariosView usuariosView, UsuariosModel usuariosModel)
        {
            this.usuariosView = usuariosView;
            this.usuariosModel = usuariosModel;
           usuariosView.SetController(this);
        }
        public void Gravar()
        {
            usuariosModel.Gravar(new Pessoa(usuariosView.Id, usuariosView.Nome, usuariosView.Sobrenome, usuariosView.Departamento, (usuariosView.Masculino) ? 'M' : 'F'));
            Clear();
            AtualizaTable();
        }
        public void Novo()
        {
            if (IsNull() != true)
            {
               Clear();
            }
            else
            {
                DialogResult result = MessageBox.Show("Os dados auais não foram salvos, deseja proceguir?","Aviso",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Clear();
                }
                
            }
        }
        public void AtualizaTable()
        {
            foreach(Pessoa obj in usuariosModel.Pessoa)
            {
                usuariosView.Table.Rows.Add(obj.Id,obj.Nome,obj.Sobrenome,obj.Sexo,obj.Departamento);
            }
        }
        private bool IsNull()
        {
            if(!string.IsNullOrEmpty(usuariosView.Id) && !string.IsNullOrEmpty(usuariosView.Nome) && !string.IsNullOrEmpty(usuariosView.Sobrenome) && !string.IsNullOrEmpty(usuariosView.Departamento))
            {
                return true;
            }
            else { return false; }
        }
        public void Clear()
        {
            usuariosView.Id = string.Empty;
            usuariosView.Nome = string.Empty;
            usuariosView.Sobrenome = string.Empty;
            usuariosView.Departamento = string.Empty;
        }
    }
}
