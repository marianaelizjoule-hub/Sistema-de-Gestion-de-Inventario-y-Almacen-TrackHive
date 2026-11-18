namespace TrackHive.Interfaz
{
    partial class FrmLogin
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
            this.pnlLateral = new System.Windows.Forms.Panel();
            this.lblInventario = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.lblError = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.pnlLateral.SuspendLayout();
            this.SuspendLayout();

            this.pnlLateral.Name = "pnlLateral";
            this.pnlLateral.BackColor = System.Drawing.Color.FromArgb(77, 134, 166);
            this.pnlLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLateral.Location = new System.Drawing.Point(0, 0);
            this.pnlLateral.Size = new System.Drawing.Size(150, 330);

            this.lblInventario.Name = "lblInventario";
            this.lblInventario.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInventario.ForeColor = System.Drawing.Color.White;
            this.lblInventario.Location = new System.Drawing.Point(0, 120);
            this.lblInventario.Size = new System.Drawing.Size(150, 60);
            this.lblInventario.Text = "INVENTARIO";
            this.lblInventario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(10, 57, 92);
            this.lblTitulo.Location = new System.Drawing.Point(175, 22);
            this.lblTitulo.Text = "TrackHive";

            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(128, 128, 128);
            this.lblSubtitulo.Location = new System.Drawing.Point(178, 60);
            this.lblSubtitulo.Size = new System.Drawing.Size(210, 30);
            this.lblSubtitulo.Text = "Sistema de Control de Inventario y Movimientos de Almacén";

            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(10, 57, 92);
            this.lblUsuario.Location = new System.Drawing.Point(178, 104);
            this.lblUsuario.Text = "Usuario";

            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Location = new System.Drawing.Point(178, 124);
            this.txtUsuario.Size = new System.Drawing.Size(200, 25);
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.lblClave.Name = "lblClave";
            this.lblClave.AutoSize = true;
            this.lblClave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblClave.ForeColor = System.Drawing.Color.FromArgb(10, 57, 92);
            this.lblClave.Location = new System.Drawing.Point(178, 160);
            this.lblClave.Text = "Contraseña";

            this.txtClave.Name = "txtClave";
            this.txtClave.Location = new System.Drawing.Point(178, 180);
            this.txtClave.Size = new System.Drawing.Size(200, 25);
            this.txtClave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtClave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClave.UseSystemPasswordChar = true;

            this.lblError.Name = "lblError";
            this.lblError.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblError.ForeColor = System.Drawing.Color.FromArgb(190, 40, 40);
            this.lblError.Location = new System.Drawing.Point(178, 212);
            this.lblError.Size = new System.Drawing.Size(205, 40);
            this.lblError.Text = "";

            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(77, 134, 166);
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnIngresar.ForeColor = System.Drawing.Color.White;
            this.btnIngresar.Location = new System.Drawing.Point(178, 262);
            this.btnIngresar.Size = new System.Drawing.Size(200, 40);
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngresar.FlatAppearance.BorderSize = 0;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(225, 232, 240);
            this.ClientSize = new System.Drawing.Size(410, 330);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrackHive - Iniciar sesión";
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AcceptButton = this.btnIngresar;
            this.pnlLateral.TabIndex = 0;
            this.Controls.Add(this.pnlLateral);
            this.lblInventario.TabIndex = 0;
            this.pnlLateral.Controls.Add(this.lblInventario);
            this.lblTitulo.TabIndex = 1;
            this.Controls.Add(this.lblTitulo);
            this.lblSubtitulo.TabIndex = 2;
            this.Controls.Add(this.lblSubtitulo);
            this.lblUsuario.TabIndex = 3;
            this.Controls.Add(this.lblUsuario);
            this.txtUsuario.TabIndex = 4;
            this.Controls.Add(this.txtUsuario);
            this.lblClave.TabIndex = 5;
            this.Controls.Add(this.lblClave);
            this.txtClave.TabIndex = 6;
            this.Controls.Add(this.txtClave);
            this.lblError.TabIndex = 7;
            this.Controls.Add(this.lblError);
            this.btnIngresar.TabIndex = 8;
            this.Controls.Add(this.btnIngresar);
            this.pnlLateral.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pnlLateral;
        private System.Windows.Forms.Label lblInventario;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnIngresar;
    }
}
