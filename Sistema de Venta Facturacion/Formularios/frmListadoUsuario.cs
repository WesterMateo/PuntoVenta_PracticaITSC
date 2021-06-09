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
    public partial class frmListadoUsuario : Form
    {
        private UsuarioModelo _UsuarioModelo;
        public frmListadoUsuario()
        {
            InitializeComponent();
            this.Text = "Registro";
            _UsuarioModelo = new UsuarioModelo();
            CargarListado();
            ConfiguracionGRD();
        }
        public void CargarListado()
        {
            List<Usuario> Listado = new List<Usuario>();
            if (CHKVisualizar.CheckState == CheckState.Checked)
            {
                Listado = ObtenerTodosUsuario();
            }
            else
            {
                Listado = ObtenerTodosUsuario().Where(x => x.Activo == true).ToList();
            }
                
            gridControl1.DataSource = new BindingList<Usuario>(Listado);
        }

        public List<Usuario> ObtenerTodosUsuario()
        {
            return _UsuarioModelo.ObtenerTodosUsuario();
        }
        private void ConfiguracionGRD()
        {
            foreach (DevExpress.XtraGrid.Columns.GridColumn item in gridView1.Columns)
            {
                if (item.FieldName == "ID_Usuario")
                {
                    item.Caption = "Código";
                    item.Visible = true;
                    item.VisibleIndex = 0;
                    item.Width = 20;
                }
                else if (item.FieldName == "Usuario1")
                {
                    item.Caption = "Nombre";
                    item.Visible = true;
                    item.VisibleIndex = 1;
                    item.Width = 70;
                }
                else if (item.FieldName == "Nivel")
                {
                    item.Visible = true;
                    item.VisibleIndex = 2;
                    item.Width = 35;
                }
                else if (item.FieldName == "Direccion")
                {
                    item.Visible = true;
                    item.VisibleIndex = 3;
                    item.Width = 70;
                }
                else if (item.FieldName == "Telefono")
                {
                    item.Visible = true;
                    item.VisibleIndex = 4;
                    item.Width = 35;
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Usuario row = gridView1.GetRow(gridView1.FocusedRowHandle) as Usuario;
            if (row != null)
            {
                row.Activo = false;
                if (_UsuarioModelo.GuardarUsuario(row))
                {
                    MessageBox.Show("Usuario eliminado");                    
                }
                gridView1.DeleteSelectedRows();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AbrirFrmUsuario(0);
        }
       
        public bool ValidarUsuario(Usuario usuario)
        {
            if (usuario.Usuario1 == null || usuario.Usuario1 as string == string.Empty)
            {
                return false;
            }
            if (usuario.Password == null || usuario.Password as string == string.Empty)
            {
                return false;
            }
            if (usuario.Nivel == null || usuario.Nivel as string == string.Empty)
            {
                return false;
            }
            if (usuario.Nivel != "Cliente" || usuario.Nivel as string != "Administrador" || usuario.Nivel as string != "Empleado")
            {
                MessageBox.Show("Los niveles disponibles son: Cliente, Administrador, Empleado");
                return false;
            }
            return true;
        }
     
        public void AbrirFrmUsuario(int ID_Usuario)
        {                 
                frmUsuario frm = new frmUsuario(this, ID_Usuario);
                frm.Show();
                frm.FormClosed += Frm_FormClosed;
                this.Close();            
        }

        private void Frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            CargarListado();
        }    

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
           Usuario row = gridView1.GetRow(gridView1.FocusedRowHandle) as Usuario;
            if (row != null)
            {
                AbrirFrmUsuario(row.ID_Usuario);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Usuario row = gridView1.GetRow(gridView1.FocusedRowHandle) as Usuario;
            if (row != null)
            {
                AbrirFrmUsuario(row.ID_Usuario);
            }
        }

        private void checkEdit1_CheckStateChanged(object sender, EventArgs e)
        {
            CargarListado();
        }
    }
}
