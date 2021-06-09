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
    public partial class frmUsuario : Form
    {
        Usuario NuevoUsuario;
        private UsuarioModelo _UsuarioModelo;
        private Form frmOrigen;
        public frmUsuario(Form Origen, int ID_Usuario = 0)
        {
            InitializeComponent();
            this.Text = "Registro";
            frmOrigen = Origen;
            _UsuarioModelo = new UsuarioModelo();
            if (ID_Usuario == 0)
            {
                NuevoUsuario = new Usuario();
                LayoutTNivel.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                LayoutCHKActivo.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }
            else
            {
                NuevoUsuario = _UsuarioModelo.Consultar().Where(x => x.ID_Usuario == ID_Usuario).FirstOrDefault();
                LayoutTNivel.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                LayoutCHKActivo.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                TNombre.EditValue = NuevoUsuario.Usuario1;
                 TDireccion.EditValue = NuevoUsuario.Direccion;
                 TTelefono.EditValue = NuevoUsuario.Telefono;                                
                 TContra.EditValue = NuevoUsuario.Password;
                TConfirmarContra.EditValue = NuevoUsuario.Password;
                TNivel.EditValue = NuevoUsuario.Nivel;
                CHKActivo.EditValue = NuevoUsuario.Activo;
                simpleButton1.Text = "Guardar";
            }
        }
        public bool ValidarUsuario()
        {
            if(TNombre.EditValue == null || TNombre.EditValue as string == string.Empty)
            {
                return false;
            }
            if(TContra.EditValue == null || TContra.EditValue as string == string.Empty)
            {
                return false;
            }
            if (TConfirmarContra.EditValue == null || TConfirmarContra.EditValue as string == string.Empty)
            {
                return false;
            }
            if (TConfirmarContra.EditValue as string != TContra.EditValue as string)
            {
                return false;
            }          
            return true;
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (ValidarUsuario())
            {
                
                NuevoUsuario.Usuario1 = TNombre.EditValue as string;
                NuevoUsuario.Direccion = TDireccion.EditValue as string;
                NuevoUsuario.Telefono = TTelefono.EditValue as string;
                if (NuevoUsuario.ID_Usuario == 0)
                {
                    NuevoUsuario.Nivel = "Cliente";
                    NuevoUsuario.Activo = true;
                }else
                {
                    if (TNivel.EditValue == null || TNivel.EditValue as string == string.Empty)
                    {
                        MessageBox.Show("Asegurate de rellenar los campos correctamente");
                        return;
                    }
                    if (TNivel.EditValue as string == "Cliente" || TNivel.EditValue as string == "Administrador" || TNivel.EditValue as string == "Empleado")
                    {                       
                    }
                    else
                    {
                        MessageBox.Show("Los niveles disponibles son: Cliente, Administrador, Empleado");
                        return;
                    }
                    NuevoUsuario.Nivel = TNivel.EditValue as string;
                    NuevoUsuario.Activo = Convert.ToBoolean(CHKActivo.CheckState);
                }
                NuevoUsuario.Password = TContra.EditValue as string;
                if (_UsuarioModelo.GuardarUsuario(NuevoUsuario))
                {
                    MessageBox.Show("Usuario registrado");
                    this.Close();
                    return;
                }
            }
            MessageBox.Show("Asegurate de rellenar los campos correctamente");
        }

        private void frmUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form ej = Activator.CreateInstance(frmOrigen.GetType()) as Form;
            ej.Show();
        }
    }
}
