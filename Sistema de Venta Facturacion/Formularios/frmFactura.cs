using DevExpress.Utils.Drawing.Helpers;
using DevExpress.XtraEditors.Mask;
using Sistema_de_Venta_Facturacion.EF;
using Sistema_de_Venta_Facturacion.Formularios;
using Sistema_de_Venta_Facturacion.Modelos.ArticuloModelo;
using Sistema_de_Venta_Facturacion.Modelos.FacturaLineaModelo;
using Sistema_de_Venta_Facturacion.Modelos.FacturaModelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Venta_Facturacion
{
    public partial class frmFactura : Form
    {
        private Usuario _Usuario;
        private ArticuloModelo _ArticuloModelo;
        private FacturaModelo _FacturaModelo;
        private FacturaLineaModelo _facturaLineaModelo;
        public frmFactura()
        {
            InitializeComponent();
            _Usuario = new Usuario();
            _Usuario = ModuloGlobal._Usuario;
            _ArticuloModelo = new ArticuloModelo();
            _FacturaModelo = new FacturaModelo();
            _facturaLineaModelo = new FacturaLineaModelo();
            this.Text = "Ventas";
            ValidarUsuario();
            CargarDatosArticulo();
            CargarDatosFactura();
            ConfiguracionGRD();
        }
        public void ValidarUsuario()
        {
            if (ModuloGlobal._Usuario.Nivel == "Empleado")
            {
                LayoutBtnPedidosRealizadosCliente.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                LayoutBtnInventario.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                LayoutBtnUsuario.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                layoutControlItem9.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                TDireccion.ReadOnly = false;
                TTelefono.ReadOnly = false;
            }
            else if (ModuloGlobal._Usuario.Nivel == "Administrador")
            {
                LayoutBtnPedidosRealizadosCliente.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                LayoutBtnInventario.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                LayoutBtnUsuario.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                layoutControlItem9.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                TDireccion.ReadOnly = false;
                TTelefono.ReadOnly = false;
            }           
            else
            {
                LayoutBtnPedidosRealizadosCliente.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                LayoutBtnInventario.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                layoutControlItem9.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                TDireccion.ReadOnly = true;
                TTelefono.ReadOnly = true;
                TCliente.Properties.Buttons.ElementAt(0).Visible = false;
                TCliente.Properties.Buttons.ElementAt(1).Visible = false;
                TDireccion.EditValue = ModuloGlobal._Usuario.Direccion;
                TTelefono.EditValue = ModuloGlobal._Usuario.Telefono;
                TCliente.EditValue = ModuloGlobal._Usuario.Usuario1;
                btnCerrarVenta.Text = "REALIZAR PEDIDO";
                LayoutBtnUsuario.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }
        }
        public void CargarDatosArticulo()
        {
            GRDArticulo.DataSource = new BindingList<Articulo>( ObtenerTodoArticulo());
        }
        public void CargarDatosFactura()
        {
            GRDFactura.DataSource = new BindingList<FacturaLinea>(new List<FacturaLinea>());
        }
        public List<Articulo> ObtenerTodoArticulo()
        {
            return _ArticuloModelo.ObtenerTodosArticulo().Where(x => x.Activo == true && x.Cantidad > 0).ToList();
        }
        private void ConfiguracionGRD()
        { //Configuracion del listado de articulos
            foreach (DevExpress.XtraGrid.Columns.GridColumn item in GRD_VIEWArticulo.Columns)
            {
                if (item.FieldName == "Descripcion" || item.FieldName == "Precio" || item.FieldName == "Cantidad" || item.FieldName == "Estado")
                {
                    item.Visible = true;
                }
                else
                {
                    item.Visible = false;
                }
                item.OptionsColumn.AllowEdit = false;
            }
            //Configuracion del listado de facturaLinea
            foreach (DevExpress.XtraGrid.Columns.GridColumn item in GRD_VIEWFactura.Columns)
            {
                if (item.FieldName == "Descripcion" || item.FieldName == "Precio" || item.FieldName == "Cantidad" || item.FieldName == "TotalPrecio")
                {
                    
                    item.Visible = true;
                }
                else
                {
                    item.Visible = false;
                }

                if (item.FieldName == "TotalPrecio")
                {
                    item.OptionsColumn.AllowEdit = false;
                }
                else
                {
                    if (ModuloGlobal._Usuario.Nivel == "Cliente")
                    {
                        if (item.FieldName == "Precio")
                        {
                            item.OptionsColumn.AllowEdit = false;
                        }
                    }
                    else
                    {
                        item.OptionsColumn.AllowEdit = true;
                    }
                }
            }

        }
        private void TCliente_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Caption)
            {
                case "Lupita":
                    frmListadoCliente frm = new frmListadoCliente();
                    frm.ClienteSeleccionad += CargarCliente;
                    frm.ShowDialog();
                    break;
                case "Cancelar":
                    LimpiarDatosCliente();
                    break;
            }

        }
        private void LimpiarDatosCliente()
        {
            _Usuario = new Usuario();
            TCliente.EditValue = null;
            TDireccion.EditValue = null;
            TTelefono.EditValue = null;
        }
        private void CargarCliente(Usuario UsuarioSeleccionado)
        {
            if(UsuarioSeleccionado != null)
            {
                _Usuario = UsuarioSeleccionado;
                TCliente.EditValue = UsuarioSeleccionado.Usuario1;
                TDireccion.EditValue = UsuarioSeleccionado.Direccion;
                TTelefono.EditValue = UsuarioSeleccionado.Telefono;
            }
        }

        private void GRDArticulo_DoubleClick(object sender, EventArgs e)
        {
            Articulo ArticuloSeleccionado = GRD_VIEWArticulo.GetRow(GRD_VIEWArticulo.FocusedRowHandle) as Articulo;
            BindingList<FacturaLinea> FacturaLineas = GRD_VIEWFactura.DataSource as BindingList<FacturaLinea>;

            FacturaLinea FacturaLinea = FacturaLineas.Where(x => x.ID_Articulo == ArticuloSeleccionado.ID_Articulo).FirstOrDefault();
            if (FacturaLinea != null)
            {
                int NuevaCantidad = FacturaLinea.Cantidad += 1;
                GRD_VIEWFactura.SetRowCellValue(GRD_VIEWFactura.LocateByValue("ID_Articulo", FacturaLinea.ID_Articulo), "Cantidad", NuevaCantidad);
                GRD_VIEWFactura.RefreshData();
            }
            else
            {
                FacturaLinea NuevaFacturaLinea = new FacturaLinea();
                NuevaFacturaLinea.Cantidad = 1;
                NuevaFacturaLinea.ID_Articulo = ArticuloSeleccionado.ID_Articulo;
                NuevaFacturaLinea.Precio = ArticuloSeleccionado.Precio;
                NuevaFacturaLinea.Descripcion = ArticuloSeleccionado.Descripcion;
                FacturaLineas.Add(NuevaFacturaLinea);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            GRD_VIEWFactura.DeleteSelectedRows();
        }

        private void GRD_VIEWArticulo_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            Articulo Articulo = GRD_VIEWArticulo.GetRow(e.RowHandle) as Articulo;
            if (Articulo != null)
            {
                if (Articulo.Cantidad < 1)
                {
                    e.Appearance.BackColor = Color.LightCoral;
                }
                else
                {
                    e.Appearance.BackColor = Color.LightGreen;
                }
                    
            }
        }

        private void btnCerrarVenta_Click(object sender, EventArgs e)
        {
            BindingList<FacturaLinea> ListadoLineas = GRDFactura.DataSource as BindingList<FacturaLinea>;
            if (_Usuario.ID_Usuario != 0 && ListadoLineas.Count > 0)
            {
                if (ModuloGlobal._Usuario.Nivel == "Cliente")
                {
                    HacerPedido();
                }
                else
                {
                    frmCierreFactura frm = new frmCierreFactura(_Usuario, ListadoLineas.ToList());
                    frm.VentaCompleta += AlCerrarfrm;
                    frm.ShowDialog();
                }
            }   
            else
            {
                MessageBox.Show(this, "No se puede cerrar la venta si no hay cliente seleccionado y si no existen articulos en el listado");
            }
        }
        public Articulo ObtenerArticuloPorID(int ID_Articulo)
        {
            return _ArticuloModelo.ObtenerArticuloPorID(ID_Articulo);
        }
        private void HacerPedido()
        {
            decimal TotalFactura = 0;
            foreach (FacturaLinea item in GRDFactura.DataSource as BindingList<FacturaLinea>)
            {
                TotalFactura += item.TotalPrecio;
            }
            Factura NuevaFactura = new Factura();
                NuevaFactura.Codigo = DateTime.UtcNow.AddSeconds(60).ToString();
                NuevaFactura.ID_Usuario = _Usuario.ID_Usuario;
                NuevaFactura.Despachado = false;
                NuevaFactura.Despachador = null;
                NuevaFactura.Fecha = DateTime.Now;
                NuevaFactura.ImporteFactura = TotalFactura;
                NuevaFactura.Cambio = 0;
                if (GuardarFactura(NuevaFactura))
                {
                    foreach (FacturaLinea item in GRDFactura.DataSource as BindingList<FacturaLinea>)
                    {
                        item.ID_Factura = NuevaFactura.ID_Factura;
                        GuardarFacturaLinea(item);
                    }
                        CargarDatosFactura();
                        CargarDatosArticulo();
                MessageBox.Show(this, "Pedido realizado con exito");
            }
            
        }
        private bool GuardarFactura(Factura factura)
        {
            return _FacturaModelo.GuardarFactura(factura);
        }
        private bool GuardarFacturaLinea(FacturaLinea FacturaLineas)
        {
            return _facturaLineaModelo.GuardarFacturaLinea(FacturaLineas);
        }
        private bool GuardarArticulo(Articulo Articulo)
        {
            return _ArticuloModelo.GuardarArticulo(Articulo);
        }
        private void AlCerrarfrm(bool VentaRealizada)
        {
            if (VentaRealizada)
            {
                LimpiarDatosCliente();
                CargarDatosFactura();
                CargarDatosArticulo();
            }
        }

        private void btnVerVentas_Click(object sender, EventArgs e)
        {
            frmListadoFactura frm = new frmListadoFactura();
            frm.FormClosed += Frm_FormClosed;
            frm.ShowDialog();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            frmListadoUsuario frm = new frmListadoUsuario();
            frm.ShowDialog();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frmArticulo frm = new frmArticulo();
            frm.Show();
            frm.FormClosed += Frm_FormClosed;
        }

        private void Frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            CargarDatosArticulo();
        }

        private void btnPedidosRealizadosCliente_Click(object sender, EventArgs e)
        {
            frmPedidos frm = new frmPedidos();
            frm.Show();
        }
    }
}
