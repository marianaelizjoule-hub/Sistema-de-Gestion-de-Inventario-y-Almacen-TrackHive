namespace TrackHive.Interfaz
{
    partial class FrmPrincipalAdministrador
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
            this.btnPosiciones = new System.Windows.Forms.Button();
            this.btnConsultarStock = new System.Windows.Forms.Button();
            this.btnCentroReportes = new System.Windows.Forms.Button();
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

            this.btnPosiciones.Name = "btnPosiciones";
            this.btnPosiciones.BackColor = System.Drawing.Color.FromArgb(176, 80, 107);
            this.btnPosiciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPosiciones.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPosiciones.ForeColor = System.Drawing.Color.White;
            this.btnPosiciones.Location = new System.Drawing.Point(67, 170);
            this.btnPosiciones.Size = new System.Drawing.Size(282, 48);
            this.btnPosiciones.Text = "POSICIONES POR MARCA";
            this.btnPosiciones.UseVisualStyleBackColor = false;
            this.btnPosiciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPosiciones.FlatAppearance.BorderSize = 0;
            this.btnPosiciones.Click += new System.EventHandler(this.btnPosiciones_Click);

            this.btnConsultarStock.Name = "btnConsultarStock";
            this.btnConsultarStock.BackColor = System.Drawing.Color.FromArgb(106, 63, 155);
            this.btnConsultarStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarStock.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConsultarStock.ForeColor = System.Drawing.Color.White;
            this.btnConsultarStock.Location = new System.Drawing.Point(67, 235);
            this.btnConsultarStock.Size = new System.Drawing.Size(282, 48);
            this.btnConsultarStock.Text = "CONSULTAR STOCK";
            this.btnConsultarStock.UseVisualStyleBackColor = false;
            this.btnConsultarStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultarStock.FlatAppearance.BorderSize = 0;
            this.btnConsultarStock.Click += new System.EventHandler(this.btnConsultarStock_Click);

            this.btnCentroReportes.Name = "btnCentroReportes";
            this.btnCentroReportes.BackColor = System.Drawing.Color.FromArgb(71, 65, 160);
            this.btnCentroReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCentroReportes.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCentroReportes.ForeColor = System.Drawing.Color.White;
            this.btnCentroReportes.Location = new System.Drawing.Point(67, 300);
            this.btnCentroReportes.Size = new System.Drawing.Size(282, 48);
            this.btnCentroReportes.Text = "CENTRO DE REPORTES";
            this.btnCentroReportes.UseVisualStyleBackColor = false;
            this.btnCentroReportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCentroReportes.FlatAppearance.BorderSize = 0;
            this.btnCentroReportes.Click += new System.EventHandler(this.btnCentroReportes_Click);

            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.BackColor = System.Drawing.Color.FromArgb(61, 52, 136);
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesion.Location = new System.Drawing.Point(67, 500);
            this.btnCerrarSesion.Size = new System.Drawing.Size(282, 48);
            this.btnCerrarSesion.Text = "CERRAR SESIÓN";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarSesion.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
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
            this.btnPosiciones.TabIndex = 2;
            this.pnlMenu.Controls.Add(this.btnPosiciones);
            this.btnConsultarStock.TabIndex = 3;
            this.pnlMenu.Controls.Add(this.btnConsultarStock);
            this.btnCentroReportes.TabIndex = 4;
            this.pnlMenu.Controls.Add(this.btnCentroReportes);
            this.btnCerrarSesion.TabIndex = 5;
            this.pnlMenu.Controls.Add(this.btnCerrarSesion);
            this.pnlLinea2.TabIndex = 6;
            this.pnlMenu.Controls.Add(this.pnlLinea2);
            this.pnlUsuario.TabIndex = 7;
            this.pnlMenu.Controls.Add(this.pnlUsuario);
            this.pnlAvatar.TabIndex = 0;
            this.pnlUsuario.Controls.Add(this.pnlAvatar);
            this.lblNombre.TabIndex = 1;
            this.pnlUsuario.Controls.Add(this.lblNombre);
            this.lblRol.TabIndex = 2;
            this.pnlUsuario.Controls.Add(this.lblRol);
            this.Load += new System.EventHandler(this.FrmPrincipalAdministrador_Load);
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
        private System.Windows.Forms.Button btnPosiciones;
        private System.Windows.Forms.Button btnConsultarStock;
        private System.Windows.Forms.Button btnCentroReportes;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Panel pnlLinea2;
        private System.Windows.Forms.Panel pnlUsuario;
        private System.Windows.Forms.Panel pnlAvatar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblRol;
    }
}
