using Sistema_de_Venta_Facturacion.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Venta_Facturacion.Modelos.UsuarioModelo
{
    class UsuarioModelo
    {
        private BaseEntities _db;
        public UsuarioModelo()
        {
            _db = new BaseEntities();
        }
        private void Instanciar()
        {
            _db = new BaseEntities();
        }
        public System.Data.Entity.DbSet<Usuario> Consultar()
        {
            return _db.Usuario;
        }
        public List<Usuario> ObtenerTodosUsuario()
        {
            this.Instanciar();
            return _db.Usuario.ToList();
        }
        public Usuario ObtenerUsuarioPorID(int ID_Usuario)
        {
            return _db.Usuario.Where(x => x.ID_Usuario == ID_Usuario).FirstOrDefault();
        }
        public bool GuardarUsuario(Usuario NuevoUsuario)
        {
            if (NuevoUsuario.ID_Usuario > 0)
            {
                _db.Entry(NuevoUsuario).State = System.Data.Entity.EntityState.Modified;
            }
            else
            {
                _db.Usuario.Add(NuevoUsuario);
            }
            return _db.SaveChanges() > 0;
        }
        public bool EliminarUsuario(Usuario Usuario)
        {
            _db.Usuario.Remove(Usuario);    
            return _db.SaveChanges() > 0;
        }
    }
}
