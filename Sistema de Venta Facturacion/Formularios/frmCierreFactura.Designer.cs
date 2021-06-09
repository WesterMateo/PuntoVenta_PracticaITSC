namespace Sistema_de_Venta_Facturacion.Formularios
{
    partial class frmCierreFactura
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCierreFactura));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.TCliente = new DevExpress.XtraEditors.TextEdit();
            this.TCambio = new DevExpress.XtraEditors.TextEdit();
            this.TDineroRecibido = new DevExpress.XtraEditors.TextEdit();
            this.TTotalFactura = new DevExpress.XtraEditors.TextEdit();
            this.TDespachador = new DevExpress.XtraEditors.TextEdit();
            this.btnAceptar = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TCliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TCambio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TDineroRecibido.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TTotalFactura.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TDespachador.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.TCliente);
            this.layoutControl1.Controls.Add(this.TCambio);
            this.layoutControl1.Controls.Add(this.TDineroRecibido);
            this.layoutControl1.Controls.Add(this.TTotalFactura);
            this.layoutControl1.Controls.Add(this.TDespachador);
            this.layoutControl1.Controls.Add(this.btnAceptar);
            this.layoutControl1.Controls.Add(this.btnCancelar);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(467, 235);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // TCliente
            // 
            this.TCliente.Location = new System.Drawing.Point(12, 28);
            this.TCliente.MaximumSize = new System.Drawing.Size(0, 24);
            this.TCliente.MinimumSize = new System.Drawing.Size(0, 24);
            this.TCliente.Name = "TCliente";
            this.TCliente.Properties.ReadOnly = true;
            this.TCliente.Size = new System.Drawing.Size(443, 24);
            this.TCliente.StyleController = this.layoutControl1;
            this.TCliente.TabIndex = 10;
            // 
            // TCambio
            // 
            this.TCambio.Location = new System.Drawing.Point(235, 160);
            this.TCambio.MaximumSize = new System.Drawing.Size(0, 24);
            this.TCambio.MinimumSize = new System.Drawing.Size(0, 24);
            this.TCambio.Name = "TCambio";
            this.TCambio.Properties.Mask.EditMask = "c2";
            this.TCambio.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.TCambio.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.TCambio.Properties.ReadOnly = true;
            this.TCambio.Size = new System.Drawing.Size(220, 24);
            this.TCambio.StyleController = this.layoutControl1;
            this.TCambio.TabIndex = 9;
            this.TCambio.EditValueChanged += new System.EventHandler(this.TCambio_EditValueChanged);
            // 
            // TDineroRecibido
            // 
            this.TDineroRecibido.Location = new System.Drawing.Point(12, 160);
            this.TDineroRecibido.MaximumSize = new System.Drawing.Size(0, 24);
            this.TDineroRecibido.MinimumSize = new System.Drawing.Size(0, 24);
            this.TDineroRecibido.Name = "TDineroRecibido";
            this.TDineroRecibido.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TDineroRecibido.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TDineroRecibido.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.None;
            this.TDineroRecibido.Properties.Mask.EditMask = "c2";
            this.TDineroRecibido.Properties.Mask.IgnoreMaskBlank = false;
            this.TDineroRecibido.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.TDineroRecibido.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.TDineroRecibido.Size = new System.Drawing.Size(219, 24);
            this.TDineroRecibido.StyleController = this.layoutControl1;
            this.TDineroRecibido.TabIndex = 8;
            this.TDineroRecibido.EditValueChanged += new System.EventHandler(this.TDineroRecibido_EditValueChanged);
            // 
            // TTotalFactura
            // 
            this.TTotalFactura.Location = new System.Drawing.Point(235, 116);
            this.TTotalFactura.MaximumSize = new System.Drawing.Size(0, 24);
            this.TTotalFactura.MinimumSize = new System.Drawing.Size(0, 24);
            this.TTotalFactura.Name = "TTotalFactura";
            this.TTotalFactura.Properties.Mask.EditMask = "c2";
            this.TTotalFactura.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.TTotalFactura.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.TTotalFactura.Properties.ReadOnly = true;
            this.TTotalFactura.Size = new System.Drawing.Size(220, 24);
            this.TTotalFactura.StyleController = this.layoutControl1;
            this.TTotalFactura.TabIndex = 7;
            // 
            // TDespachador
            // 
            this.TDespachador.Location = new System.Drawing.Point(12, 72);
            this.TDespachador.MaximumSize = new System.Drawing.Size(0, 24);
            this.TDespachador.MinimumSize = new System.Drawing.Size(0, 24);
            this.TDespachador.Name = "TDespachador";
            this.TDespachador.Properties.ReadOnly = true;
            this.TDespachador.Size = new System.Drawing.Size(443, 24);
            this.TDespachador.StyleController = this.layoutControl1;
            this.TDespachador.TabIndex = 6;
            // 
            // btnAceptar
            // 
            this.btnAceptar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.ImageOptions.Image")));
            this.btnAceptar.Location = new System.Drawing.Point(235, 201);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(220, 22);
            this.btnAceptar.StyleController = this.layoutControl1;
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.ImageOptions.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(12, 201);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(219, 22);
            this.btnCancelar.StyleController = this.layoutControl1;
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.emptySpaceItem2,
            this.layoutControlItem7});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(467, 235);
            this.Root.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 88);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(223, 44);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btnCancelar;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 189);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(223, 26);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnAceptar;
            this.layoutControlItem2.Location = new System.Drawing.Point(223, 189);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(224, 26);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.TDespachador;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 44);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(447, 44);
            this.layoutControlItem3.Text = "Despachado por:";
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(82, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.TTotalFactura;
            this.layoutControlItem4.Location = new System.Drawing.Point(223, 88);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(224, 44);
            this.layoutControlItem4.Text = "Total factura:";
            this.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(82, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.TDineroRecibido;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 132);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(223, 44);
            this.layoutControlItem5.Text = "Dinero recibido:";
            this.layoutControlItem5.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(82, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.TCambio;
            this.layoutControlItem6.Location = new System.Drawing.Point(223, 132);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(224, 44);
            this.layoutControlItem6.Text = "Cambio:";
            this.layoutControlItem6.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(82, 13);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 176);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(447, 13);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.TCliente;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(447, 44);
            this.layoutControlItem7.Text = "Cliente:";
            this.layoutControlItem7.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem7.TextSize = new System.Drawing.Size(82, 13);
            // 
            // frmCierreFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 235);
            this.Controls.Add(this.layoutControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCierreFactura";
            this.Text = "frmCierreFactura";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TCliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TCambio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TDineroRecibido.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TTotalFactura.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TDespachador.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.SimpleButton btnAceptar;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.TextEdit TDespachador;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.TextEdit TTotalFactura;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.TextEdit TCambio;
        private DevExpress.XtraEditors.TextEdit TDineroRecibido;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraEditors.TextEdit TCliente;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
    }
}