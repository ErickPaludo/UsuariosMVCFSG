using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsuariosMVC
{
    public partial class FrmUsuarios : Form, IUsuariosView
    {
        UsuariosController controller;
        public FrmUsuarios()
        {
            InitializeComponent();
        }
        public void SetController(UsuariosController controller_)
        {
            this.controller = controller_;
        }
        public string Id
        {
          get { return txtID.Text; }
          set { txtID.Text = value; }
        }
        public string Nome
        {
              get { return this.txtNome.Text; }
          set { this.txtNome.Text = value; }
        }
        public string Sobrenome
        {
          get { return this.txtSobrenome.Text; }
          set { this.txtSobrenome.Text = value; }
        }
        public string Departamento
        {
          get { return this.txtDepartamento.Text; }
          set { this.txtDepartamento.Text = value; }
        }
        public RadioButton Feminino
        {
           get { return rdFeminino; }
          set { rdFeminino = value; }
        }
        public RadioButton Masculino
        {
           get {
                return rdMasculino; }
          set { rdMasculino = value; }
        }
        public DataGridView Table
        {
            get { return grdUsuarios; }
            set { grdUsuarios = value; }
        }
        public string Pesquisar
        {
            get
            {
                return this.txtPesquisa.Text;
            }
            set
            {
                this.txtPesquisa.Text = value;
            }
        }
        private void GravarDados(object sender, EventArgs e)
        {
            this.controller.Gravar();
        }

        private void Novo(object sender, EventArgs e)
        {
            this.controller.Novo();
        }

        private void SelectCell(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                controller.RetornarUsuario((grdUsuarios.Rows[e.RowIndex].Cells[0].Value).ToString(),e.RowIndex);
            }
        }

        private void ExcluirUsuario(object sender, EventArgs e)
        {
            controller.ExcluirUser();
        }

        private void BuscaPorId(object sender, EventArgs e)
        {
            controller.Leave();
        }

        private void Procurar(object sender, EventArgs e)
        {
            controller.Procurar();
        }
    }
}
