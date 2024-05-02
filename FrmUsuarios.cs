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
        public bool Feminino
        {
           get { return this.rdFeminino.Checked; }
          set { this.rdFeminino.Checked = value; }
        }
        public bool Masculino
        {
           get { return this.rdMasculino.Checked; }
          set { this.rdMasculino.Checked = value; }
        }
        public DataGridView Table
        {
            get { return grdUsuarios; }
            set { grdUsuarios = value; }
        }

        private void GravarDados(object sender, EventArgs e)
        {
            this.controller.Gravar();
        }

        private void Novo(object sender, EventArgs e)
        {
            this.controller.Novo();
        }
    }
}
