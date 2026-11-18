namespace TrackHive.Interfaz
{
    partial class FrmPrincipalEncargado
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            this.pnlContenido = new System.Windows.Forms.Panel();
            this.ucMonitor = new TrackHive.Interfaz.UcMonitorInventario();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.lblInventario = new System.Windows.Forms.Label();
            this.pnlLinea1 = new System.Windows.Forms.Panel();
            this.btnRegistrarIngreso = new System.Windows.Forms.Button();
            this.btnSalidaEntrega = new System.Windows.Forms.Button();
            this.btnSalidaDesecho = new System.Windows.Forms.Button();
            this.btnRegistrarProducto = new System.Windows.Forms.Button();
            this.btnConsultarStock = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.pnlLinea2 = new System.Windows.Forms.Panel();
            this.pnlUsuario = new System.Windows.Forms.Panel();
            this.pnlAvatar = new System.Windows.Forms.Panel();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblRol = new System.Windows.Forms.Label();
            this.pnlContenido.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnlLinea1.SuspendLayout();
            this.pnlLinea2.SuspendLayout();
            this.pnlUsuario.SuspendLayout();
            this.pnlAvatar.SuspendLayout();
            this.SuspendLayout();

            this.pnlContenido.Name = "pnlContenido";
            this.pnlContenido.BackColor = System.Drawing.Color.FromArgb(208, 219, 228);
            this.pnlContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenido.Location = new System.Drawing.Point(415, 0);
            this.pnlContenido.Size = new System.Drawing.Size(845, 720);

            this.ucMonitor.Name = "ucMonitor";
            this.ucMonitor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucMonitor.Location = new System.Drawing.Point(0, 0);
            this.ucMonitor.Size = new System.Drawing.Size(845, 720);

            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(77, 134, 166);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Size = new System.Drawing.Size(415, 720);

            this.lblInventario.Name = "lblInventario";
            this.lblInventario.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInventario.ForeColor = System.Drawing.Color.White;
            this.lblInventario.Location = new System.Drawing.Point(0, 40);
            this.lblInventario.Size = new System.Drawing.Size(415, 60);
            this.lblInventario.Text = "INVENTARIO";
            this.lblInventario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.pnlLinea1.Name = "pnlLinea1";
            this.pnlLinea1.BackColor = System.Drawing.Color.FromArgb(220, 232, 240);
            this.pnlLinea1.Location = new System.Drawing.Point(30, 118);
            this.pnlLinea1.Size = new System.Drawing.Size(355, 1);

            this.btnRegistrarIngreso.Name = "btnRegistrarIngreso";
            this.btnRegistrarIngreso.BackColor = System.Drawing.Color.FromArgb(85, 139, 47);
            this.btnRegistrarIngreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarIngreso.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRegistrarIngreso.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarIngreso.Location = new System.Drawing.Point(67, 170);
            this.btnRegistrarIngreso.Size = new System.Drawing.Size(282, 48);
            this.btnRegistrarIngreso.Text = "REGISTRAR INGRESO";
            this.btnRegistrarIngreso.UseVisualStyleBackColor = false;
            this.btnRegistrarIngreso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarIngreso.FlatAppearance.BorderSize = 0;
            this.btnRegistrarIngreso.Click += new System.EventHandler(this.btnRegistrarIngreso_Click);

            this.btnSalidaEntrega.Name = "btnSalidaEntrega";
            this.btnSalidaEntrega.BackColor = System.Drawing.Color.FromArgb(217, 95, 95);
            this.btnSalidaEntrega.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalidaEntrega.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalidaEntrega.ForeColor = System.Drawing.Color.White;
            this.btnSalidaEntrega.Location = new System.Drawing.Point(67, 235);
            this.btnSalidaEntrega.Size = new System.Drawing.Size(282, 48);
            this.btnSalidaEntrega.Text = "REGISTRAR SALIDA POR ENTREGA";
            this.btnSalidaEntrega.UseVisualStyleBackColor = false;
            this.btnSalidaEntrega.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalidaEntrega.FlatAppearance.BorderSize = 0;
            this.btnSalidaEntrega.Click += new System.EventHandler(this.btnSalidaEntrega_Click);

            this.btnSalidaDesecho.Name = "btnSalidaDesecho";
            this.btnSalidaDesecho.BackColor = System.Drawing.Color.FromArgb(217, 95, 95);
            this.btnSalidaDesecho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalidaDesecho.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalidaDesecho.ForeColor = System.Drawing.Color.White;
            this.btnSalidaDesecho.Location = new System.Drawing.Point(67, 300);
            this.btnSalidaDesecho.Size = new System.Drawing.Size(282, 48);
            this.btnSalidaDesecho.Text = "REGISTRAR SALIDA POR DESECHO";
            this.btnSalidaDesecho.UseVisualStyleBackColor = false;
            this.btnSalidaDesecho.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalidaDesecho.FlatAppearance.BorderSize = 0;
            this.btnSalidaDesecho.Click += new System.EventHandler(this.btnSalidaDesecho_Click);

            this.btnRegistrarProducto.Name = "btnRegistrarProducto";
            this.btnRegistrarProducto.BackColor = System.Drawing.Color.FromArgb(106, 63, 155);
            this.btnRegistrarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarProducto.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRegistrarProducto.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarProducto.Location = new System.Drawing.Point(67, 365);
            this.btnRegistrarProducto.Size = new System.Drawing.Size(282, 48);
            this.btnRegistrarProducto.Text = "REGISTRAR PRODUCTO";
            this.btnRegistrarProducto.UseVisualStyleBackColor = false;
            this.btnRegistrarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarProducto.FlatAppearance.BorderSize = 0;
            this.btnRegistrarProducto.Click += new System.EventHandler(this.btnRegistrarProducto_Click);

            this.btnConsultarStock.Name = "btnConsultarStock";
            this.btnConsultarStock.BackColor = System.Drawing.Color.FromArgb(71, 65, 160);
            this.btnConsultarStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarStock.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConsultarStock.ForeColor = System.Drawing.Color.White;
            this.btnConsultarStock.Location = new System.Drawing.Point(67, 430);
            this.btnConsultarStock.Size = new System.Drawing.Size(282, 48);
            this.btnConsultarStock.Text = "CONSULTAR STOCK";
            this.btnConsultarStock.UseVisualStyleBackColor = false;
            this.btnConsultarStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultarStock.FlatAppearance.BorderSize = 0;
            this.btnConsultarStock.Click += new System.EventHandler(this.btnConsultarStock_Click);

            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.BackColor = System.Drawing.Color.FromArgb(61, 52, 136);
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesion.Location = new System.Drawing.Point(67, 495);
            this.btnCerrarSesion.Size = new System.Drawing.Size(282, 48);
            this.btnCerrarSesion.Text = "CERRAR SESIÓN";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);

            this.pnlLinea2.Name = "pnlLinea2";
            this.pnlLinea2.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            this.pnlLinea2.BackColor = System.Drawing.Color.FromArgb(220, 232, 240);
            this.pnlLinea2.Location = new System.Drawing.Point(30, 590);
            this.pnlLinea2.Size = new System.Drawing.Size(355, 1);

            this.pnlUsuario.Name = "pnlUsuario";
            this.pnlUsuario.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            this.pnlUsuario.BackColor = System.Drawing.Color.FromArgb(224, 229, 235);
            this.pnlUsuario.Location = new System.Drawing.Point(30, 615);
            this.pnlUsuario.Size = new System.Drawing.Size(355, 76);

            this.pnlAvatar.Name = "pnlAvatar";
            this.pnlAvatar.BackColor = System.Drawing.Color.FromArgb(224, 229, 235);
            this.pnlAvatar.Location = new System.Drawing.Point(14, 10);
            this.pnlAvatar.Size = new System.Drawing.Size(56, 56);
            this.pnlAvatar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlAvatar_Paint);

            this.lblNombre.Name = "lblNombre";
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(20, 20, 20);
            this.lblNombre.Location = new System.Drawing.Point(82, 16);
            this.lblNombre.Text = "Nombre";

            this.lblRol.Name = "lblRol";
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRol.ForeColor = System.Drawing.Color.FromArgb(95, 100, 110);
            this.lblRol.Location = new System.Drawing.Point(82, 42);
            this.lblRol.Text = "Rol";

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 720);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(1100, 640);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrackHive - Sistema de Control de Inventario y Movimientos de Almacén";
            this.pnlContenido.TabIndex = 0;
            this.Controls.Add(this.pnlContenido);
            this.ucMonitor.TabIndex = 0;
            this.pnlContenido.Controls.Add(this.ucMonitor);
            this.pnlMenu.TabIndex = 1;
            this.Controls.Add(this.pnlMenu);
            this.lblInventario.TabIndex = 0;
            this.pnlMenu.Controls.Add(this.lblInventario);
            this.pnlLinea1.TabIndex = 1;
            this.pnlMenu.Controls.Add(this.pnlLinea1);
            this.btnRegistrarIngreso.TabIndex = 2;
            this.pnlMenu.Controls.Add(this.btnRegistrarIngreso);
            this.btnSalidaEntrega.TabIndex = 3;
            this.pnlMenu.Controls.Add(this.btnSalidaEntrega);
            this.btnSalidaDesecho.TabIndex = 4;
            this.pnlMenu.Controls.Add(this.btnSalidaDesecho);
            this.btnRegistrarProducto.TabIndex = 5;
            this.pnlMenu.Controls.Add(this.btnRegistrarProducto);
            this.btnConsultarStock.TabIndex = 6;
            this.pnlMenu.Controls.Add(this.btnConsultarStock);
            this.btnCerrarSesion.TabIndex = 7;
            this.pnlMenu.Controls.Add(this.btnCerrarSesion);
            this.pnlLinea2.TabIndex = 8;
            this.pnlMenu.Controls.Add(this.pnlLinea2);
            this.pnlUsuario.TabIndex = 9;
            this.pnlMenu.Controls.Add(this.pnlUsuario);
            this.pnlAvatar.TabIndex = 0;
            this.pnlUsuario.Controls.Add(this.pnlAvatar);
            this.lblNombre.TabIndex = 1;
            this.pnlUsuario.Controls.Add(this.lblNombre);
            this.lblRol.TabIndex = 2;
            this.pnlUsuario.Controls.Add(this.lblRol);
            this.Load += new System.EventHandler(this.FrmPrincipalEncargado_Load);
            this.pnlContenido.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.pnlLinea1.ResumeLayout(false);
            this.pnlLinea2.ResumeLayout(false);
            this.pnlUsuario.ResumeLayout(false);
            this.pnlAvatar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pnlContenido;
        private TrackHive.Interfaz.UcMonitorInventario ucMonitor;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Label lblInventario;
        private System.Windows.Forms.Panel pnlLinea1;
        private System.Windows.Forms.Button btnRegistrarIngreso;
        private System.Windows.Forms.Button btnSalidaEntrega;
        private System.Windows.Forms.Button btnSalidaDesecho;
        private System.Windows.Forms.Button btnRegistrarProducto;
        private System.Windows.Forms.Button btnConsultarStock;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Panel pnlLinea2;
        private System.Windows.Forms.Panel pnlUsuario;
        private System.Windows.Forms.Panel pnlAvatar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblRol;
    }
}
