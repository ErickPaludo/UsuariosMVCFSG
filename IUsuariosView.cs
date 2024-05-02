using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsuariosMVC
{
    public interface IUsuariosView
    {
        void SetController(UsuariosController controller);
        int Id {get; set;}
        string Nome {get; set;}
        string Sobrenome {get; set;}
        string Departamento {get; set;}
        bool Feminino  {get; set;}
        bool Masculino  {get; set;}
    }
}
