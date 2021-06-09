namespace Sistema_de_Venta_Facturacion.Formularios
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.TContra = new DevExpress.XtraEditors.TextEdit();
            this.TNombre = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.LRegistrarme = new DevExpress.XtraEditors.LabelControl();
            this.LayoutLRegistrarme = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TContra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayoutLRegistrarme)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.LRegistrarme);
            this.layoutControl1.Controls.Add(this.pictureEdit1);
            this.layoutControl1.Controls.Add(this.simpleButton1);
            this.layoutControl1.Controls.Add(this.TContra);
            this.layoutControl1.Controls.Add(this.TNombre);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(498, 172);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = global::Sistema_de_Venta_Facturacion.Properties.Resources.login_wordpress;
            this.pictureEdit1.Location = new System.Drawing.Point(12, 12);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(186, 124);
            this.pictureEdit1.StyleController = this.layoutControl1;
            this.pictureEdit1.TabIndex = 7;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(202, 100);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(284, 36);
            this.simpleButton1.StyleController = this.layoutControl1;
            this.simpleButton1.TabIndex = 6;
            this.simpleButton1.Text = "ENTRAR";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // TContra
            // 
            this.TContra.Location = new System.Drawing.Point(202, 72);
            this.TContra.MaximumSize = new System.Drawing.Size(0, 24);
            this.TContra.MinimumSize = new System.Drawing.Size(0, 24);
            this.TContra.Name = "TContra";
            this.TContra.Properties.PasswordChar = '*';
            this.TContra.Properties.UseSystemPasswordChar = true;
            this.TContra.Size = new System.Drawing.Size(284, 24);
            this.TContra.StyleController = this.layoutControl1;
            this.TContra.TabIndex = 5;
            // 
            // TNombre
            // 
            this.TNombre.Location = new System.Drawing.Point(202, 28);
            this.TNombre.MaximumSize = new System.Drawing.Size(0, 24);
            this.TNombre.MinimumSize = new System.Drawing.Size(0, 24);
            this.TNombre.Name = "TNombre";
            this.TNombre.Size = new System.Drawing.Size(284, 24);
            this.TNombre.StyleController = this.layoutControl1;
            this.TNombre.TabIndex = 4;
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
            this.LayoutLRegistrarme});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(498, 172);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.TNombre;
            this.layoutControlItem1.Location = new System.Drawing.Point(190, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(288, 44);
            this.layoutControlItem1.Text = "Nombre de usuario:";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(94, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.TContra;
            this.layoutControlItem2.Location = new System.Drawing.Point(190, 44);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(288, 44);
            this.layoutControlItem2.Text = "Contraseña:";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(94, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.simpleButton1;
            this.layoutControlItem3.Location = new System.Drawing.Point(190, 88);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(288, 40);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.pictureEdit1;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(190, 128);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // LRegistrarme
            // 
            this.LRegistrarme.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LRegistrarme.Appearance.Options.UseFont = true;
            this.LRegistrarme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LRegistrarme.Location = new System.Drawing.Point(210, 140);
            this.LRegistrarme.Name = "LRegistrarme";
            this.LRegistrarme.Size = new System.Drawing.Size(77, 16);
            this.LRegistrarme.StyleController = this.layoutControl1;
            this.LRegistrarme.TabIndex = 8;
            this.LRegistrarme.Text = "Registrarme";
            this.LRegistrarme.Click += new System.EventHandler(this.LRegistrarme_Click);
            this.LRegistrarme.MouseLeave += new System.EventHandler(this.LRegistrarme_MouseLeave);
            this.LRegistrarme.MouseHover += new System.EventHandler(this.labelControl1_MouseHover);
            // 
            // LayoutLRegistrarme
            // 
            this.LayoutLRegistrarme.AppearanceItemCaption.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LayoutLRegistrarme.AppearanceItemCaption.Options.UseFont = true;
            this.LayoutLRegistrarme.ContentHorzAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.LayoutLRegistrarme.Control = this.LRegistrarme;
            this.LayoutLRegistrarme.Location = new System.Drawing.Point(0, 128);
            this.LayoutLRegistrarme.Name = "LayoutLRegistrarme";
            this.LayoutLRegistrarme.OptionsPrint.AppearanceItemCaption.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LayoutLRegistrarme.OptionsPrint.AppearanceItemCaption.Options.UseFont = true;
            this.LayoutLRegistrarme.OptionsPrint.AppearanceItemCaption.Options.UseTextOptions = true;
            this.LayoutLRegistrarme.OptionsPrint.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.LayoutLRegistrarme.Size = new System.Drawing.Size(478, 24);
            this.LayoutLRegistrarme.Text = "Registrarme";
            this.LayoutLRegistrarme.TextSize = new System.Drawing.Size(0, 0);
            this.LayoutLRegistrarme.TextVisible = false;
            this.LayoutLRegistrarme.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 172);
            this.Controls.Add(this.layoutControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TContra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayoutLRegistrarme)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.TextEdit TNombre;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TextEdit TContra;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.LabelControl LRegistrarme;
        private DevExpress.XtraLayout.LayoutControlItem LayoutLRegistrarme;
    }
}