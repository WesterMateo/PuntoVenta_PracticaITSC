using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.CustomEditor;
using DevExpress.XtraEditors.Filtering.Templates;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Sistema_de_Venta_Facturacion.EF;
using Sistema_de_Venta_Facturacion.Modelos.FacturaLineaModelo;
using Sistema_de_Venta_Facturacion.Modelos.FacturaModelo;
using Sistema_de_Venta_Facturacion.Modelos.UsuarioModelo;
using Sistema_de_Venta_Facturacion.Properties;
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
    public partial class frmListadoFactura : Form
    {
        FacturaModelo _FacturaModelo;
        FacturaLineaModelo _FacturaLineaModelo;
        UsuarioModelo _UsuarioModelo;
        public frmListadoFactura()
        {
            InitializeComponent();
            this.Text = "Listado de facturas";
            _FacturaModelo = new FacturaModelo();
            _FacturaLineaModelo = new FacturaLineaModelo();
            _UsuarioModelo = new UsuarioModelo();
            DFechaInicio.EditValue = DateTime.Now.AddDays(-1);
            DFechaFin.EditValue = DateTime.Now;
            CargarListado();
            ConfiguracionGRD();
        }
        private void ConfiguracionGRD()
        {
            foreach (DevExpress.XtraGrid.Columns.GridColumn item in GRD_VIEW.Columns)
            {
                    if (item.FieldName == "ID_Factura")
                    {
                        item.Caption = "Código";
                        item.Visible = true;
                        item.VisibleIndex = 0;
                        item.Width = 40;
                    }
                    else if (item.FieldName == "Cliente")
                    {
                        item.Visible = true;
                        item.VisibleIndex = 1;
                    }
                    else if (item.FieldName == "Fecha")
                    {
                        item.Visible = true;
                        item.VisibleIndex = 2;
                        item.Width = 40;
                    }
                    else if (item.FieldName == "ImporteFactura")
                    {
                        item.Visible = true;
                        item.VisibleIndex = 3;
                        item.Width = 50;
                    }                    
                    else if (item.FieldName == "Despachado")
                    {
                        item.Visible = true;
                        item.VisibleIndex = 5;
                        item.Width = 35;
                    }
                    else if (item.FieldName == "Despachador")
                    {
                        item.Visible = true;
                        item.VisibleIndex = 6;
                    }
                    else
                    {
                        item.Visible = false;
                    }
                        item.OptionsColumn.AllowEdit = false;
            }
            RepositoryItemButtonEdit BotonDespachar = new RepositoryItemButtonEdit();
            BotonDespachar.TextEditStyle = TextEditStyles.HideTextEditor;
            BotonDespachar.Buttons.ElementAtOrDefault(0).Kind = ButtonPredefines.Glyph;
            BotonDespachar.Buttons.ElementAtOrDefault(0).ImageOptions.Image = Resources.BO_Order_Item;
            DevExpress.XtraGrid.Columns.GridColumn columnaDespachar = GRD_VIEW.Columns.Add();
            columnaDespachar.FieldName = "Despachar";
            columnaDespachar.ColumnEdit = BotonDespachar;
            columnaDespachar.VisibleIndex = 7;
            columnaDespachar.Width = 30;
            columnaDespachar.OptionsColumn.AllowEdit = true;
            //ej.ColumnEdit = repositoryItemButtonEdit1;

        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarListado();
        }
        public List<Factura> ObtenerTodoFactura()
        {
            if (Convert.ToBoolean(CHKDespachados.EditValue))
            {
                return _FacturaModelo.ObtenerTodosFactura().Where(x =>  x.Fecha.Date >= Convert.ToDateTime(DFechaInicio.EditValue).Date && x.Fecha.Date <= Convert.ToDateTime(DFechaFin.EditValue).Date).ToList();
            }
            else
            {
                object otro = _FacturaModelo.ObtenerTodosFactura().Where(x => x.Despachado == false && x.Fecha.Date >= Convert.ToDateTime(DFechaInicio.EditValue).Date && x.Fecha.Date <= Convert.ToDateTime(DFechaFin.EditValue).Date).ToList();

                return _FacturaModelo.ObtenerTodosFactura().Where(x => x.Despachado == false && x.Fecha.Date >= Convert.ToDateTime(DFechaInicio.EditValue).Date && x.Fecha.Date <= Convert.ToDateTime(DFechaFin.EditValue).Date).ToList();
            }
        }
        public void CargarListado()
        {
            GRD.DataSource = new BindingList<Factura>(ObtenerTodoFactura());
        }

        private void GRD_VIEW_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            Factura Factura = GRD_VIEW.GetRow(e.RowHandle) as Factura;
            if (Factura != null)
            {
                if (Factura.Despachado)
                {
                    e.Appearance.BackColor = Color.LightGreen;
                }
                else
                {
                    e.Appearance.BackColor = Color.LightSalmon;
                }

            }
        }

        private void GRD_VIEW_ShowingEditor(object sender, CancelEventArgs e)
        {
            Factura FacturaSeleccionada = GRD_VIEW.GetRow(GRD_VIEW.FocusedRowHandle) as Factura;
            if (FacturaSeleccionada != null)
            {
                if (FacturaSeleccionada.Despachado)
                {
                    MessageBox.Show("La factura ya ha sido despachada");
                } else
                {
                    FacturaSeleccionada.FacturaLinea = _FacturaLineaModelo.ObtenerTodosFacturaLinea().Where(x => x.ID_Factura == FacturaSeleccionada.ID_Factura).ToList();
                    Usuario Cliente = _UsuarioModelo.ObtenerUsuarioPorID(FacturaSeleccionada.ID_Usuario);
                    frmCierreFactura frm = new frmCierreFactura(Cliente, FacturaSeleccionada.FacturaLinea);
                    frm.VentaCompleta += AlCerrarfrm;
                    frm.ShowDialog();
                }
            }
        }
        private void AlCerrarfrm(bool VentaRealizada)
        {
            if (VentaRealizada)
            {
                CargarListado();
                MessageBox.Show("Factura despachada");
            }
        }
        private void GRD_VIEW_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            if (e.Column.FieldName == "Despachar")
            {
                Factura FacturaSeleccionada = GRD_VIEW.GetRow(e.RowHandle) as Factura;
                if (FacturaSeleccionada != null)
                {
                    RepositoryItemButtonEdit BotonDespachar = new RepositoryItemButtonEdit();
                    BotonDespachar.TextEditStyle = TextEditStyles.HideTextEditor;
                    BotonDespachar.Buttons.ElementAtOrDefault(0).Kind = ButtonPredefines.Glyph;
                    if (FacturaSeleccionada.Despachado)
                    {
                        BotonDespachar.Buttons.ElementAtOrDefault(0).ImageOptions.Image = Resources.State_Validation_Valid;
                    }
                    else
                    {
                        BotonDespachar.Buttons.ElementAtOrDefault(0).ImageOptions.Image = Resources.BO_Order_Item;
                    }
                    e.RepositoryItem = BotonDespachar;
                }
            }
        }

        private void GRD_VIEW_MasterRowExpanded(object sender, DevExpress.XtraGrid.Views.Grid.CustomMasterRowEventArgs e)
        {
            GridView GRD = GRD_VIEW.GetDetailView(e.RowHandle, e.RelationIndex) as GridView;

            GRD.OptionsBehavior.Editable = false;
            foreach (DevExpress.XtraGrid.Columns.GridColumn item in GRD.Columns)
            {
                if (item.FieldName == "Descripcion")
                {
                    item.VisibleIndex = 0;
                }
                else if (item.FieldName == "Cantidad")
                {
                    item.VisibleIndex = 1;
                }
                else if (item.FieldName == "Precio")
                {
                    item.VisibleIndex = 2;
                }
                else if (item.FieldName == "TotalPrecio")
                {
                    item.VisibleIndex = 3;
                }
                else
                {
                    item.Visible = false;
                }
            }
        }
    }
}
