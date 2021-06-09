using Sistema_de_Venta_Facturacion.EF;
using Sistema_de_Venta_Facturacion.Modelos.UsuarioModelo;
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
    public partial class frmListadoCliente : Form
    {
        private UsuarioModelo _UsuarioModelo;
        public frmListadoCliente()
        {
            InitializeComponent();
            _UsuarioModelo = new UsuarioModelo();
            GRDCliente.DataSource = new BindingList<Usuario>(ObtenerTodoUsuario());
            ConfiguracionGRD();
           
            this.Text = "Clientes";
        }

        public List<Usuario> ObtenerTodoUsuario()
        {
            return _UsuarioModelo.ObtenerTodosUsuario().Where(x => x.Activo == true).ToList();
        }
        public delegate void ClienteSeleccionado(Usuario UsuarioSeleccionado);
        public event ClienteSeleccionado ClienteSeleccionad;
        

        private void frmListadoCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
        private void ConfiguracionGRD()
        {
            foreach (DevExpress.XtraGrid.Columns.GridColumn item in GRD_VIEWCliente.Columns)
            {
                if (item.FieldName == "Usuario1" || item.FieldName == "Direccion" || item.FieldName == "Telefono")
                {
                    if (item.FieldName == "Usuario1")
                    {
                        item.Caption = "Cliente";
                    }
                    item.Visible = true;
                }
                else
                {
                    item.Visible = false;
                }
                item.OptionsColumn.AllowEdit = false;
            }
        }

        private void GRDCliente_DoubleClick(object sender, EventArgs e)
        {
            Usuario UsuarioSeleccionado = GRD_VIEWCliente.GetRow(GRD_VIEWCliente.FocusedRowHandle) as Usuario;
            ClienteSeleccionad.Invoke(UsuarioSeleccionado);
            this.Close();
        }
    }
}
