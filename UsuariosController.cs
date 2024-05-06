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
            usuariosModel.Lerdados();
            AtualizaTable();
            TableEnabled();
        }
        public void Gravar()
        {
            if (IsNull() == true)
            {

                if (usuariosModel.ValidaExistencia(usuariosView.Id) != true)
                {
                    usuariosModel.Gravar(new Pessoa(usuariosView.Id, usuariosView.Nome, usuariosView.Sobrenome, usuariosView.Departamento, (usuariosView.Masculino.Checked) ? 'M' : 'F'));
                    Clear();
                }
                else
                {
                    DialogResult result = MessageBox.Show($"Deseja realmente alterar os dados do usuário {usuariosView.Id}?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        usuariosModel.Editar(new Pessoa(usuariosView.Id, usuariosView.Nome, usuariosView.Sobrenome, usuariosView.Departamento, (usuariosView.Masculino.Checked) ? 'M' : 'F'));
                        Clear();
                    }
                }
                AtualizaTable();
                TableEnabled();
            }
        }
        public void ExcluirUser()
        {
            if (IsNull())
            {
                DialogResult result = MessageBox.Show("Deseja excluir o usuário selecionado?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    usuariosModel.Excluir(usuariosView.Id);
                    Clear();
                }
                AtualizaTable();
                TableEnabled();
            }
        }
        public void Novo()
        {
            if (IsNull() != true)
            {
                Clear();
            }
            else
            {
                DialogResult result = MessageBox.Show("Os dados auais não foram salvos, deseja proceguir?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Clear();
                }

            }
        }
        public void Procurar()
        {
            var usuerfiltro = usuariosModel.Pessoa
                .Where(item =>
                    item.Nome.StartsWith(usuariosView.Pesquisar, StringComparison.OrdinalIgnoreCase) ||
                    item.Sobrenome.StartsWith(usuariosView.Pesquisar, StringComparison.OrdinalIgnoreCase) ||
                    (item.Nome + " " + item.Sobrenome).StartsWith(usuariosView.Pesquisar, StringComparison.OrdinalIgnoreCase) ||
                    (item.Id).StartsWith(usuariosView.Pesquisar, StringComparison.OrdinalIgnoreCase)
                );

            usuariosView.Table.Rows.Clear();
            foreach (var obj in usuerfiltro)
            {
                usuariosView.Table.Rows.Add(obj.Id, obj.Nome, obj.Sobrenome, obj.Sexo, obj.Departamento);
            }
        }
        public void AtualizaTable()
        {
            usuariosView.Table.Rows.Clear();
            foreach (Pessoa obj in usuariosModel.Pessoa)
            {
                usuariosView.Table.Rows.Add(obj.Id, obj.Nome, obj.Sobrenome, obj.Sexo, obj.Departamento);
            }
        }
        private bool IsNull()
        {
            if (!string.IsNullOrEmpty(usuariosView.Id) && !string.IsNullOrEmpty(usuariosView.Nome) && !string.IsNullOrEmpty(usuariosView.Sobrenome) && !string.IsNullOrEmpty(usuariosView.Departamento))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Verifique novamente os campos!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public void RetornarUsuario(string id, int line)
        {
            AtualizaTable();
            usuariosView.Table.Rows[line].DefaultCellStyle.BackColor = System.Drawing.SystemColors.Highlight;

            usuariosView.Table.Rows[line].DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            foreach (Pessoa obj in usuariosModel.Pessoa)
            {
                if (obj.Id == id)
                {
                    usuariosView.Id = id;
                    usuariosView.Nome = obj.Nome;
                    usuariosView.Sobrenome = obj.Sobrenome;
                    usuariosView.Departamento = obj.Departamento;
                    if (obj.Sexo == 'F')
                    {
                        usuariosView.Feminino.Checked = true;
                    }
                    else
                    {
                        usuariosView.Masculino.Checked = true;
                    }
                }
            }
        }
        public void Clear()
        {
            usuariosView.Id = string.Empty;
            usuariosView.Nome = string.Empty;
            usuariosView.Sobrenome = string.Empty;
            usuariosView.Departamento = string.Empty;
        }
        private void TableEnabled()
        {
            if (usuariosModel.QuantidadeNaLista() == false)
            {
                usuariosView.Table.Enabled = false;
            }
            else
            {
                usuariosView.Table.Enabled = true;
            }
        }
        public void Leave()
        {
            if (usuariosView.Id != string.Empty)
            {
                foreach (Pessoa obj in usuariosModel.Pessoa)
                {
                    if (obj.Id == usuariosView.Id)
                    {
                        usuariosView.Nome = obj.Nome;
                        usuariosView.Sobrenome = obj.Sobrenome;
                        usuariosView.Departamento = obj.Departamento;
                        if (obj.Sexo == 'F')
                        {
                            usuariosView.Feminino.Checked = true;
                        }
                        else
                        {
                            usuariosView.Masculino.Checked = true;
                        }
                    }
                }
            }
        }
    }
}
