using Sistema_de_Venta_Facturacion.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Venta_Facturacion.Modelos.FacturaModelo
{
    class FacturaModelo
    {
        private BaseEntities _db;
        public FacturaModelo()
        {
            _db = new BaseEntities();
        }
        private void Instanciar()
        {
            _db = new BaseEntities();
        }
        public List<Factura> ObtenerTodosFactura()
        {
            this.Instanciar();
            return _db.Factura.ToList();
        }
        public Factura ObtenerFacturaPorID(int ID_Factura)
        {
            return _db.Factura.Where(x => x.ID_Factura == ID_Factura).FirstOrDefault();
        }
        public bool GuardarFactura(Factura NuevaFactura)
        {
            if (NuevaFactura.ID_Factura > 0)
            {
                _db.Entry(NuevaFactura).State = System.Data.Entity.EntityState.Modified;
            }
            else
            {
                _db.Factura.Add(NuevaFactura);
            }
            return _db.SaveChanges() > 0;
        }
        public bool EliminarFactura(Factura Factura)
        {
            _db.Factura.Remove(Factura);
            return _db.SaveChanges() > 0;
        }
    }
}
