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
    public partial class frmLogin : Form
    {
        private UsuarioModelo _UsuarioModelo;
        public frmLogin()
        {
            InitializeComponent();
            this.Text = "Inicio de sesión";
            _UsuarioModelo = new UsuarioModelo();
        }

        public List<Usuario> ObtenerTodosUsuarios()
        {
            return _UsuarioModelo.ObtenerTodosUsuario();
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (TNombre.EditValue == null || TNombre.EditValue as string == "")
            {
                MessageBox.Show("Debes llenar los campos");
                return;
            }
            Usuario UsuarioLogin = _UsuarioModelo.Consultar().Where(x => x.Usuario1 == TNombre.EditValue.ToString()).FirstOrDefault();
            if (UsuarioLogin != null)
            {
                if (UsuarioLogin.Password == TContra.EditValue as string)
                {
                    ModuloGlobal._Usuario = UsuarioLogin;
                    frmFactura frm = new frmFactura();
                    frm.Show();
                    this.Close();
                    return;
                }
            }
            MessageBox.Show("Usuario invalido");
            this.LayoutLRegistrarme.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                
        }

        private void labelControl1_MouseHover(object sender, EventArgs e)
        {
            LRegistrarme.Appearance.FontStyleDelta = FontStyle.Underline;
            LRegistrarme.Appearance.ForeColor = Color.DarkBlue;
        }

        private void LRegistrarme_MouseLeave(object sender, EventArgs e)
        {
            LRegistrarme.Appearance.FontStyleDelta = FontStyle.Regular;
            LRegistrarme.Appearance.ForeColor = Color.Black;
        }

        private void LRegistrarme_Click(object sender, EventArgs e)
        {
            frmUsuario frm = new frmUsuario(this);
            frm.Show();
            this.Close();
        }
    }
}
