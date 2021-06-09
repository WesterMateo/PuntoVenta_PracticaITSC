using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Grid;
using Sistema_de_Venta_Facturacion.EF;
using Sistema_de_Venta_Facturacion.Modelos.FacturaLineaModelo;
using Sistema_de_Venta_Facturacion.Modelos.FacturaModelo;
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
    public partial class frmPedidos : Form
    {
        FacturaModelo _FacturaModelo;
        FacturaLineaModelo _FacturaLineaModelo;
        public frmPedidos()
        {
            InitializeComponent();
            Text = "Pedidos";
            _FacturaModelo = new FacturaModelo();
            _FacturaLineaModelo = new FacturaLineaModelo();
            CargarListado();
            ConfiguracionGRD();
        }
        public List<Factura> ObtenerTodoFactura()
        {
                return _FacturaModelo.ObtenerTodosFactura().Where(x => x.ID_Usuario == ModuloGlobal._Usuario.ID_Usuario).ToList();           
        }
        public void CargarListado()
        {
            gridControl1.DataSource = new BindingList<Factura>(ObtenerTodoFactura());
        }
        private void ConfiguracionGRD()
        {
            foreach (DevExpress.XtraGrid.Columns.GridColumn item in gridView1.Columns)
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
            DevExpress.XtraGrid.Columns.GridColumn columnaDespachar = gridView1.Columns.Add();
            columnaDespachar.FieldName = "Estado";
            columnaDespachar.ColumnEdit = BotonDespachar;
            columnaDespachar.VisibleIndex = 7;
            columnaDespachar.Width = 30;
            columnaDespachar.OptionsColumn.AllowEdit = false;
            //ej.ColumnEdit = repositoryItemButtonEdit1;

        }
        private void gridView1_RowStyle(object sender, RowStyleEventArgs e)
        {
            Factura Factura = gridView1.GetRow(e.RowHandle) as Factura;
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

        private void gridView1_CustomRowCellEdit(object sender, CustomRowCellEditEventArgs e)
        {
            if (e.Column.FieldName == "Estado")
            {
                Factura FacturaSeleccionada = gridView1.GetRow(e.RowHandle) as Factura;
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

        private void gridView1_MasterRowExpanded(object sender, CustomMasterRowEventArgs e)
        {
            GridView GRD = gridView1.GetDetailView(e.RowHandle, e.RelationIndex) as GridView;

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
