using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
