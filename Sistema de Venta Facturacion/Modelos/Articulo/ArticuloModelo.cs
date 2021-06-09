using Sistema_de_Venta_Facturacion.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Venta_Facturacion.Modelos.ArticuloModelo
{
    class ArticuloModelo
    {
        private BaseEntities _db;
        public ArticuloModelo()
        {
            _db = new BaseEntities();
        }
        private void Instanciar()
        {
            _db = new BaseEntities();
        }
        public List<Articulo> ObtenerTodosArticulo()
        {
            this.Instanciar();
            return _db.Articulo.ToList();
        }
        public List<Articulo> ObtenerTodosArticuloPorID(int ID_Articulo)
        {
            return _db.Articulo.Where(x => x.ID_Articulo == ID_Articulo).ToList();
        }
        public Articulo ObtenerArticuloPorID(int ID_Articulo)
        {
            return _db.Articulo.Where(x => x.ID_Articulo == ID_Articulo).FirstOrDefault();
        }
        public bool GuardarArticulo(Articulo NuevaArticulo)
        {
            this.Instanciar();
            if (NuevaArticulo.ID_Articulo > 0)
            {
                _db.Entry(NuevaArticulo).State = System.Data.Entity.EntityState.Modified;
            }
            else
            {
                _db.Articulo.Add(NuevaArticulo);
            }
            return _db.SaveChanges() > 0;
        }
        public bool EliminarArticulo(Articulo Articulo)
        {
            _db.Articulo.Remove(Articulo);
            return _db.SaveChanges() > 0;
        }
        public bool EliminarArticuloPorID_Articulo(int ID_Articulo)
        {
            Articulo row = ObtenerArticuloPorID(ID_Articulo);
            if (row != null)
            {
                _db.Articulo.Remove(row);
                return _db.SaveChanges() > 0;
            }
            return false;
        }
    }
}
