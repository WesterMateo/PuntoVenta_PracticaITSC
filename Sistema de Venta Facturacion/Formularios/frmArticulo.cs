using LibreriaPrueba;
using Sistema_de_Venta_Facturacion.EF;
using Sistema_de_Venta_Facturacion.Modelos.ArticuloModelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Venta_Facturacion.Formularios
{
    public partial class frmArticulo : Form
    {
        private ArticuloModelo _ArticuloModelo;
        public frmArticulo()
        {
            InitializeComponent();
            _ArticuloModelo = new ArticuloModelo();
            CargarListado();
            ConfiguracionGRD();
            LimpiarDatos();
        }
        public void CargarListado()
        {
            gridControl1.DataSource = new BindingList<Articulo>(ObtenerTodosArticulos());
        }
        private void ConfiguracionGRD()
        {
            foreach (DevExpress.XtraGrid.Columns.GridColumn item in gridView1.Columns)
            {
                if (item.FieldName == "ID_Articulo")
                {
                    item.Caption = "Código";
                    item.Visible = true;
                    item.VisibleIndex = 0;
                    item.Width = 20;
                }
                else if (item.FieldName == "Descripcion")
                {
                    item.Caption = "Nombre";
                    item.Visible = true;
                    item.VisibleIndex = 1;
                    item.Width = 70;
                }
                else if (item.FieldName == "Categoria")
                {
                    item.Visible = true;
                    item.VisibleIndex = 2;
                    item.Width = 35;
                }
                else if (item.FieldName == "Cantidad")
                {
                    item.Visible = true;
                    item.VisibleIndex = 3;
                    item.Width = 30;
                }
                else if (item.FieldName == "Precio")
                {
                    item.Visible = true;
                    item.VisibleIndex = 4;
                    item.Width = 30;
                }
                else if (item.FieldName == "Activo")
                {
                    item.Visible = true;
                    item.VisibleIndex = 5;
                    item.Width = 20;
                }
                else
                {
                    item.Visible = false;
                }
                item.OptionsColumn.AllowEdit = false;
            }
        }
        public List<Articulo> ObtenerTodosArticulos()
        {
            return _ArticuloModelo.ObtenerTodosArticulo().Where(x => x.Activo == true).ToList();
        }
        public Articulo ObtenerArticuloPorID_Articulo(int ID_Articulo)
        {
            return _ArticuloModelo.ObtenerArticuloPorID(ID_Articulo);
        }
        public bool EliminarArticuloPorID_Articulo(int ID_Articulo)
        {
            if (ID_Articulo > 0)
            {
                return _ArticuloModelo.EliminarArticuloPorID_Articulo(ID_Articulo);
            }
            return false;
        }
        public bool GuardarArticulo(Articulo Articulo)
        {
                return _ArticuloModelo.GuardarArticulo(Articulo);
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            LimpiarDatos();
        }
        public bool ValidarArticulo()
        {
            if (TID_Articulo.EditValue == null || TID_Articulo.EditValue as string == string.Empty)
            {
                return false;
            }
            if (TDescripcion.EditValue == null || TDescripcion.EditValue as string == string.Empty)
            {
                return false;
            }
            if (TCantidad.EditValue == null || TCantidad.EditValue as string == string.Empty)
            {
                return false;
            }
            if (TPrecio.EditValue == null || TPrecio.EditValue as string == string.Empty)
            {
                return false;
            }
            return true;
        }
        public void LimpiarDatos()
        {
            TID_Articulo.EditValue = 0;
            TDescripcion.EditValue = "";
            TCategoria.EditValue = "";
            TCantidad.EditValue = 0;
            TPrecio.EditValue = 0.00;
            CHKActivo.EditValue = true;
        }
        public void CargarDatos()
        {
            Articulo row = gridView1.GetRow(gridView1.FocusedRowHandle) as Articulo;
            if (row != null)
            {
                TID_Articulo.EditValue = row.ID_Articulo;
                TDescripcion.EditValue = row.Descripcion;
                TCategoria.EditValue = row.Categoria;
                TCantidad.EditValue = row.Cantidad;
                TPrecio.EditValue = row.Precio;
                CHKActivo.EditValue = row.Activo;
            }    
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int ID_Articulo =Convert.ToInt32(TID_Articulo.EditValue); 
            if (ID_Articulo > 0)
            {
                Articulo row = ObtenerArticuloPorID_Articulo(ID_Articulo);
                if (row != null)
                {
                    row.Activo = false;
                   if(GuardarArticulo(row))
                    {
                        MessageBox.Show("Artículo eliminado");
                        LimpiarDatos();
                        CargarListado();
                    }            
                }
            }    
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarArticulo())
            {
                Articulo row = new Articulo();
                 row.ID_Articulo = Convert.ToInt32(TID_Articulo.EditValue);
                 row.Descripcion = TDescripcion.EditValue as string;
                 row.Categoria = TCategoria.EditValue as string;
                 row.Cantidad = Convert.ToInt32(TCantidad.EditValue);
                 row.Precio = Convert.ToInt32(TPrecio.EditValue);
                 row.Activo = Convert.ToBoolean(CHKActivo.EditValue);
                if (GuardarArticulo(row))
                {
                    MessageBox.Show("Articulo guardado");
                    CargarListado();
                    LimpiarDatos();
                }
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            CargarDatos();
        }
    }
}
