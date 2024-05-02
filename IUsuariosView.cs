using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsuariosMVC
{
    public interface IUsuariosView
    {
        void SetController(UsuariosController controller);
        string Id {get; set;}
        string Nome {get; set;}
        string Sobrenome {get; set;}
        string Departamento {get; set;}
        bool Feminino  {get; set;}
        bool Masculino  {get; set;}
        DataGridView Table { get; set;}
    }
}
