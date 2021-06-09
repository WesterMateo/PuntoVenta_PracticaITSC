using DevExpress.Utils;
using Sistema_de_Venta_Facturacion.EF;
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

namespace Sistema_de_Venta_Facturacion.Formularios
{
    public partial class frmCierreFactura : Form
    {
        private FacturaModelo _FacturaModelo;
        private FacturaLineaModelo _facturaLineaModelo;
        private ArticuloModelo _ArticuloModelo;
        private Usuario _Cliente;
        private BindingList<FacturaLinea> _ListadoArticulo;
        public frmCierreFactura(Usuario Cliente, List<FacturaLinea> ListadoArticulo)
        {
            InitializeComponent();
            this.Text = "Cierre de factura";
            _FacturaModelo = new FacturaModelo();
            _facturaLineaModelo = new FacturaLineaModelo();
            _ArticuloModelo = new ArticuloModelo();
            _Cliente = Cliente;
            _ListadoArticulo = new BindingList<FacturaLinea>(ListadoArticulo);
            CargarDatos();
        }
        public Articulo ObtenerArticuloPorID(int ID_Articulo)
        {
            return _ArticuloModelo.ObtenerArticuloPorID(ID_Articulo);
        }
        public void CargarDatos()
        {
            decimal TotalFactura = 0;
            foreach (FacturaLinea item in _ListadoArticulo)
            {
                TotalFactura += item.TotalPrecio;
            }
            TTotalFactura.EditValue = TotalFactura;
            TCambio.EditValue = TotalFactura * -1;
            TDineroRecibido.EditValue = 0.00;
            TCliente.EditValue = _Cliente.Usuario1;
            TDespachador.EditValue = ModuloGlobal._Usuario.Usuario1;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            VentaCompleta.Invoke(false);
            this.Close();
        }

        public delegate void CierreVenta(bool VentaRealizada);
        public event CierreVenta VentaCompleta;

        private void TDineroRecibido_EditValueChanged(object sender, EventArgs e)
        {
            TCambio.EditValue = Convert.ToDecimal(TDineroRecibido.EditValue) - Convert.ToDecimal(TTotalFactura.EditValue);
        }

        private void TCambio_EditValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(TCambio.EditValue) < 0)
            {
                TCambio.ForeColor = Color.DarkRed;
            }
            else
            {
                TCambio.ForeColor = Color.DarkGreen;
            }                
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            bool Validacion = true;
            foreach(FacturaLinea item in _ListadoArticulo)
            {
                Articulo Articulo = ObtenerArticuloPorID(item.ID_Articulo);
                if (Articulo != null)
                {
                   if (Articulo.Cantidad < item.Cantidad)
                    {
                        Validacion = false;
                    }    
                }
            }
                if (Convert.ToDecimal(TCambio.EditValue) < 0)
                {
                    MessageBox.Show("Dinero insuficiente");
                    return;
                }
            if (Validacion == false)
            {
                if (MessageBox.Show("La factura contiene artículos con cantidades insuficientes, Deseas continuar?","Artículos insuficientes en stock",MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Validacion = true;
                }
            }

            if (Validacion)
            {
                FacturaLinea FacturaLineaCargara = _ListadoArticulo.FirstOrDefault();
                Factura Factura = _FacturaModelo.ObtenerFacturaPorID(FacturaLineaCargara.ID_Factura);
                if (Factura == null)
                {                                    
                    Factura NuevaFactura = new Factura();
                    NuevaFactura.Codigo = DateTime.UtcNow.AddSeconds(60).ToString();
                    NuevaFactura.ID_Usuario = _Cliente.ID_Usuario;
                    NuevaFactura.Despachado = true;
                    NuevaFactura.Despachador = TDespachador.EditValue as string;
                    NuevaFactura.Fecha = DateTime.Now;
                    NuevaFactura.ImporteFactura = Convert.ToDecimal(TTotalFactura.EditValue);
                    NuevaFactura.Cambio = Convert.ToDecimal(TCambio.EditValue);
                     if (GuardarFactura(NuevaFactura))
                    {
                        foreach(FacturaLinea item in _ListadoArticulo)
                        {
                            item.ID_Factura = NuevaFactura.ID_Factura;
                            GuardarFacturaLinea(item);

                            Articulo ArticuloAfectado;
                            ArticuloAfectado = ObtenerArticuloPorID(item.ID_Articulo);
                            ArticuloAfectado.Cantidad = ArticuloAfectado.Cantidad - item.Cantidad;
                            GuardarArticulo(ArticuloAfectado);
                        }

                        VentaCompleta.Invoke(true);
                        this.Close();
                    }                   
                }else
                {
                    Factura = new Factura();
                    Factura = _FacturaModelo.ObtenerFacturaPorID(FacturaLineaCargara.ID_Factura);
                    Factura.Despachado = true;
                    Factura.Despachador = TDespachador.EditValue as string;
                    Factura.Cambio = Convert.ToDecimal(TCambio.EditValue);
                    if (GuardarFactura(Factura))
                    {
                        foreach (FacturaLinea item in _ListadoArticulo)
                        {
                            Articulo ArticuloAfectado;
                            ArticuloAfectado = ObtenerArticuloPorID(item.ID_Articulo);
                            ArticuloAfectado.Cantidad = ArticuloAfectado.Cantidad - item.Cantidad;
                            GuardarArticulo(ArticuloAfectado);
                        }

                        VentaCompleta.Invoke(true);
                        this.Close();
                    }
                }
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
    }
}
