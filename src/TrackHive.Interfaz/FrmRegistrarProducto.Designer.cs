namespace TrackHive.Interfaz
{
    partial class FrmRegistrarProducto
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlDatos = new System.Windows.Forms.Panel();
            this.lblHint = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.pnlDatos.SuspendLayout();
            this.SuspendLayout();

            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(10, 57, 92);
            this.lblTitulo.Location = new System.Drawing.Point(25, 18);
            this.lblTitulo.Text = "Registrar Producto";

            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.BackColor = System.Drawing.Color.FromArgb(242, 242, 242);
            this.pnlDatos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDatos.Location = new System.Drawing.Point(25, 56);
            this.pnlDatos.Size = new System.Drawing.Size(640, 112);

            this.lblHint.Name = "lblHint";
            this.lblHint.AutoSize = true;
            this.lblHint.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHint.ForeColor = System.Drawing.Color.FromArgb(128, 128, 128);
            this.lblHint.Location = new System.Drawing.Point(14, 10);
            this.lblHint.Text = "*Campos obligatorios – Seleccione un producto existente";

            this.lblNombre.Name = "lblNombre";
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(10, 57, 92);
            this.lblNombre.Location = new System.Drawing.Point(24, 38);
            this.lblNombre.Text = "Nombre de Producto*";

            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Location = new System.Drawing.Point(24, 58);
            this.txtNombre.Size = new System.Drawing.Size(170, 25);
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.MaxLength = 100;

            this.lblMarca.Name = "lblMarca";
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMarca.ForeColor = System.Drawing.Color.FromArgb(10, 57, 92);
            this.lblMarca.Location = new System.Drawing.Point(234, 38);
            this.lblMarca.Text = "Marca*";

            this.cboMarca.Name = "cboMarca";
            this.cboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(234, 58);
            this.cboMarca.Size = new System.Drawing.Size(170, 25);
            this.cboMarca.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);

            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCategoria.ForeColor = System.Drawing.Color.FromArgb(10, 57, 92);
            this.lblCategoria.Location = new System.Drawing.Point(444, 38);
            this.lblCategoria.Text = "Categoría*";

            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(444, 58);
            this.cboCategoria.Size = new System.Drawing.Size(170, 25);
            this.cboCategoria.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);

            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.BackColor = System.Drawing.Color.White;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLimpiar.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.btnLimpiar.Location = new System.Drawing.Point(25, 196);
            this.btnLimpiar.Size = new System.Drawing.Size(300, 46);
            this.btnLimpiar.Text = "Limpiar Campos";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatAppearance.BorderSize = 1;
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);

            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(77, 134, 166);
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(365, 196);
            this.btnGuardar.Size = new System.Drawing.Size(300, 46);
            this.btnGuardar.Text = "Guardar Producto";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(225, 232, 240);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClientSize = new System.Drawing.Size(690, 266);
            this.Text = "TrackHive - Formulario de Registro de Producto";
            this.lblTitulo.TabIndex = 0;
            this.Controls.Add(this.lblTitulo);
            this.pnlDatos.TabIndex = 1;
            this.Controls.Add(this.pnlDatos);
            this.lblHint.TabIndex = 0;
            this.pnlDatos.Controls.Add(this.lblHint);
            this.lblNombre.TabIndex = 1;
            this.pnlDatos.Controls.Add(this.lblNombre);
            this.txtNombre.TabIndex = 2;
            this.pnlDatos.Controls.Add(this.txtNombre);
            this.lblMarca.TabIndex = 3;
            this.pnlDatos.Controls.Add(this.lblMarca);
            this.cboMarca.TabIndex = 4;
            this.pnlDatos.Controls.Add(this.cboMarca);
            this.lblCategoria.TabIndex = 5;
            this.pnlDatos.Controls.Add(this.lblCategoria);
            this.cboCategoria.TabIndex = 6;
            this.pnlDatos.Controls.Add(this.cboCategoria);
            this.btnLimpiar.TabIndex = 2;
            this.Controls.Add(this.btnLimpiar);
            this.btnGuardar.TabIndex = 3;
            this.Controls.Add(this.btnGuardar);
            this.Load += new System.EventHandler(this.FrmRegistrarProducto_Load);
            this.pnlDatos.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlDatos;
        private System.Windows.Forms.Label lblHint;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGuardar;
    }
}
