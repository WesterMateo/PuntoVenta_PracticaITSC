namespace Sistema_de_Venta_Facturacion.Formularios
{
    partial class frmUsuario
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.CHKActivo = new DevExpress.XtraEditors.CheckEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.TConfirmarContra = new DevExpress.XtraEditors.TextEdit();
            this.TContra = new DevExpress.XtraEditors.TextEdit();
            this.TTelefono = new DevExpress.XtraEditors.TextEdit();
            this.TDireccion = new DevExpress.XtraEditors.TextEdit();
            this.TNombre = new DevExpress.XtraEditors.TextEdit();
            this.TNivel = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.LayoutTNivel = new DevExpress.XtraLayout.LayoutControlItem();
            this.LayoutCHKActivo = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CHKActivo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TConfirmarContra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TContra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TTelefono.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TDireccion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TNivel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayoutTNivel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayoutCHKActivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.CHKActivo);
            this.layoutControl1.Controls.Add(this.simpleButton1);
            this.layoutControl1.Controls.Add(this.TConfirmarContra);
            this.layoutControl1.Controls.Add(this.TContra);
            this.layoutControl1.Controls.Add(this.TTelefono);
            this.layoutControl1.Controls.Add(this.TDireccion);
            this.layoutControl1.Controls.Add(this.TNombre);
            this.layoutControl1.Controls.Add(this.TNivel);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(370, 314);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // CHKActivo
            // 
            this.CHKActivo.Location = new System.Drawing.Point(187, 164);
            this.CHKActivo.Name = "CHKActivo";
            this.CHKActivo.Properties.Caption = "Activo";
            this.CHKActivo.Size = new System.Drawing.Size(171, 20);
            this.CHKActivo.StyleController = this.layoutControl1;
            this.CHKActivo.TabIndex = 10;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(12, 276);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(346, 22);
            this.simpleButton1.StyleController = this.layoutControl1;
            this.simpleButton1.TabIndex = 9;
            this.simpleButton1.Text = "Registrarme";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // TConfirmarContra
            // 
            this.TConfirmarContra.Location = new System.Drawing.Point(12, 248);
            this.TConfirmarContra.MaximumSize = new System.Drawing.Size(0, 24);
            this.TConfirmarContra.MinimumSize = new System.Drawing.Size(0, 24);
            this.TConfirmarContra.Name = "TConfirmarContra";
            this.TConfirmarContra.Properties.PasswordChar = '*';
            this.TConfirmarContra.Properties.UseSystemPasswordChar = true;
            this.TConfirmarContra.Size = new System.Drawing.Size(346, 24);
            this.TConfirmarContra.StyleController = this.layoutControl1;
            this.TConfirmarContra.TabIndex = 8;
            // 
            // TContra
            // 
            this.TContra.Location = new System.Drawing.Point(12, 204);
            this.TContra.MaximumSize = new System.Drawing.Size(0, 24);
            this.TContra.MinimumSize = new System.Drawing.Size(0, 24);
            this.TContra.Name = "TContra";
            this.TContra.Properties.PasswordChar = '*';
            this.TContra.Properties.UseSystemPasswordChar = true;
            this.TContra.Size = new System.Drawing.Size(346, 24);
            this.TContra.StyleController = this.layoutControl1;
            this.TContra.TabIndex = 7;
            // 
            // TTelefono
            // 
            this.TTelefono.Location = new System.Drawing.Point(12, 160);
            this.TTelefono.MaximumSize = new System.Drawing.Size(0, 24);
            this.TTelefono.MinimumSize = new System.Drawing.Size(0, 24);
            this.TTelefono.Name = "TTelefono";
            this.TTelefono.Properties.Mask.EditMask = "(\\(\\d\\d\\d\\) )?\\d{1,3}-\\d\\d\\d-\\d\\d\\d\\d";
            this.TTelefono.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.TTelefono.Size = new System.Drawing.Size(171, 24);
            this.TTelefono.StyleController = this.layoutControl1;
            this.TTelefono.TabIndex = 6;
            // 
            // TDireccion
            // 
            this.TDireccion.Location = new System.Drawing.Point(12, 116);
            this.TDireccion.MaximumSize = new System.Drawing.Size(0, 24);
            this.TDireccion.MinimumSize = new System.Drawing.Size(0, 24);
            this.TDireccion.Name = "TDireccion";
            this.TDireccion.Size = new System.Drawing.Size(346, 24);
            this.TDireccion.StyleController = this.layoutControl1;
            this.TDireccion.TabIndex = 5;
            // 
            // TNombre
            // 
            this.TNombre.Location = new System.Drawing.Point(12, 28);
            this.TNombre.MaximumSize = new System.Drawing.Size(0, 24);
            this.TNombre.MinimumSize = new System.Drawing.Size(0, 24);
            this.TNombre.Name = "TNombre";
            this.TNombre.Size = new System.Drawing.Size(346, 24);
            this.TNombre.StyleController = this.layoutControl1;
            this.TNombre.TabIndex = 4;
            // 
            // TNivel
            // 
            this.TNivel.Location = new System.Drawing.Point(12, 72);
            this.TNivel.MaximumSize = new System.Drawing.Size(0, 24);
            this.TNivel.MinimumSize = new System.Drawing.Size(0, 24);
            this.TNivel.Name = "TNivel";
            this.TNivel.Size = new System.Drawing.Size(346, 24);
            this.TNivel.StyleController = this.layoutControl1;
            this.TNivel.TabIndex = 8;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.LayoutTNivel,
            this.LayoutCHKActivo,
            this.emptySpaceItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(370, 314);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.TNombre;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(350, 44);
            this.layoutControlItem1.Text = "Nombre:";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(108, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.TDireccion;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 88);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(350, 44);
            this.layoutControlItem2.Text = "Dirección:";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(108, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.TTelefono;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 132);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(175, 44);
            this.layoutControlItem3.Text = "Teléfono:";
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(108, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.TContra;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 176);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(350, 44);
            this.layoutControlItem4.Text = "Contraseña:";
            this.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(108, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.TConfirmarContra;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 220);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(350, 44);
            this.layoutControlItem5.Text = "Confirmar contraseña:";
            this.layoutControlItem5.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(108, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.simpleButton1;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 264);
            this.layoutControlItem6.MaxSize = new System.Drawing.Size(0, 26);
            this.layoutControlItem6.MinSize = new System.Drawing.Size(78, 26);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(350, 30);
            this.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // LayoutTNivel
            // 
            this.LayoutTNivel.Control = this.TNivel;
            this.LayoutTNivel.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.LayoutTNivel.CustomizationFormText = "Confirmar contraseña:";
            this.LayoutTNivel.Location = new System.Drawing.Point(0, 44);
            this.LayoutTNivel.Name = "LayoutTNivel";
            this.LayoutTNivel.Size = new System.Drawing.Size(350, 44);
            this.LayoutTNivel.Text = "Nivel:";
            this.LayoutTNivel.TextLocation = DevExpress.Utils.Locations.Top;
            this.LayoutTNivel.TextSize = new System.Drawing.Size(108, 13);
            // 
            // LayoutCHKActivo
            // 
            this.LayoutCHKActivo.Control = this.CHKActivo;
            this.LayoutCHKActivo.Location = new System.Drawing.Point(175, 152);
            this.LayoutCHKActivo.Name = "LayoutCHKActivo";
            this.LayoutCHKActivo.Size = new System.Drawing.Size(175, 24);
            this.LayoutCHKActivo.TextSize = new System.Drawing.Size(0, 0);
            this.LayoutCHKActivo.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(175, 132);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(175, 20);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 314);
            this.Controls.Add(this.layoutControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUsuario";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmUsuario_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CHKActivo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TConfirmarContra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TContra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TTelefono.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TDireccion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TNivel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayoutTNivel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayoutCHKActivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TextEdit TConfirmarContra;
        private DevExpress.XtraEditors.TextEdit TContra;
        private DevExpress.XtraEditors.TextEdit TTelefono;
        private DevExpress.XtraEditors.TextEdit TDireccion;
        private DevExpress.XtraEditors.TextEdit TNombre;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraEditors.TextEdit TNivel;
        private DevExpress.XtraLayout.LayoutControlItem LayoutTNivel;
        private DevExpress.XtraEditors.CheckEdit CHKActivo;
        private DevExpress.XtraLayout.LayoutControlItem LayoutCHKActivo;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
    }
}