using Sistema_de_Venta_Facturacion.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Venta_Facturacion.Modelos.FacturaLineaModelo
{
    class FacturaLineaModelo
    {
        private BaseEntities _db;
        public FacturaLineaModelo()
        {
            _db = new BaseEntities();
        }
        private void Instanciar()
        {
            _db = new BaseEntities();
        }
        public List<FacturaLinea> ObtenerTodosFacturaLinea()
        {
            return _db.FacturaLinea.ToList();
        }
        public List<FacturaLinea> ObtenerFacturaLineaPorID(int ID_FacturaLinea)
        {
            return _db.FacturaLinea.Where(x => x.ID_FacturaLinea == ID_FacturaLinea).ToList();
        }
        public bool GuardarFacturaLinea(FacturaLinea NuevaFacturaLinea)
        {
            Instanciar();
            if (NuevaFacturaLinea.ID_FacturaLinea > 0)
            {
                _db.Entry(NuevaFacturaLinea).State = System.Data.Entity.EntityState.Modified;
            }
            else
            {
                _db.FacturaLinea.Add(NuevaFacturaLinea);
            }
            return _db.SaveChanges() > 0;
        }

        public bool EliminarFacturaLinea(FacturaLinea FacturaLinea)
        {
            _db.FacturaLinea.Remove(FacturaLinea);
            return _db.SaveChanges() > 0;
        }
    }
}
