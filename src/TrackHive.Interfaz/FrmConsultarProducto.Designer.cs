namespace TrackHive.Interfaz
{
    partial class FrmConsultarProducto
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
            System.Windows.Forms.DataGridViewCellStyle estiloEncabezado = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle estiloCelda = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle estiloFecha = new System.Windows.Forms.DataGridViewCellStyle();
            estiloEncabezado.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            estiloEncabezado.BackColor = System.Drawing.Color.FromArgb(0, 56, 93);
            estiloEncabezado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            estiloEncabezado.ForeColor = System.Drawing.Color.White;
            estiloEncabezado.SelectionBackColor = System.Drawing.Color.FromArgb(0, 56, 93);
            estiloEncabezado.SelectionForeColor = System.Drawing.Color.White;
            estiloCelda.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            estiloCelda.BackColor = System.Drawing.Color.FromArgb(242, 242, 242);
            estiloCelda.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            estiloCelda.ForeColor = System.Drawing.Color.Black;
            estiloCelda.SelectionBackColor = System.Drawing.Color.FromArgb(77, 177, 224);
            estiloCelda.SelectionForeColor = System.Drawing.Color.Black;
            estiloFecha.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            estiloFecha.Format = "dd/MM/yyyy";
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlFiltros = new System.Windows.Forms.Panel();
            this.lblHint = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.cboProducto = new System.Windows.Forms.ComboBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.pnlResultados = new System.Windows.Forms.Panel();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.colCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            this.pnlFiltros.SuspendLayout();
            this.pnlResultados.SuspendLayout();
            this.SuspendLayout();

            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(10, 57, 92);
            this.lblTitulo.Location = new System.Drawing.Point(25, 18);
            this.lblTitulo.Text = "CONSULTAR PRODUCTO";

            this.pnlFiltros.Name = "pnlFiltros";
            this.pnlFiltros.BackColor = System.Drawing.Color.FromArgb(242, 242, 242);
            this.pnlFiltros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFiltros.Location = new System.Drawing.Point(25, 56);
            this.pnlFiltros.Size = new System.Drawing.Size(650, 104);

            this.lblHint.Name = "lblHint";
            this.lblHint.AutoSize = true;
            this.lblHint.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHint.ForeColor = System.Drawing.Color.FromArgb(128, 128, 128);
            this.lblHint.Location = new System.Drawing.Point(18, 10);
            this.lblHint.Text = "*Campos obligatorios – Seleccione un producto existente";

            this.lblMarca.Name = "lblMarca";
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMarca.ForeColor = System.Drawing.Color.FromArgb(10, 57, 92);
            this.lblMarca.Location = new System.Drawing.Point(34, 40);
            this.lblMarca.Text = "Marca*";

            this.cboMarca.Name = "cboMarca";
            this.cboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(34, 60);
            this.cboMarca.Size = new System.Drawing.Size(170, 25);
            this.cboMarca.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboMarca.SelectedIndexChanged += new System.EventHandler(this.cboMarca_SelectedIndexChanged);

            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCategoria.ForeColor = System.Drawing.Color.FromArgb(10, 57, 92);
            this.lblCategoria.Location = new System.Drawing.Point(244, 40);
            this.lblCategoria.Text = "Categoría";

            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(244, 60);
            this.cboCategoria.Size = new System.Drawing.Size(170, 25);
            this.cboCategoria.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboCategoria.SelectedIndexChanged += new System.EventHandler(this.cboCategoria_SelectedIndexChanged);

            this.lblProducto.Name = "lblProducto";
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProducto.ForeColor = System.Drawing.Color.FromArgb(10, 57, 92);
            this.lblProducto.Location = new System.Drawing.Point(454, 40);
            this.lblProducto.Text = "Producto";

            this.cboProducto.Name = "cboProducto";
            this.cboProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProducto.FormattingEnabled = true;
            this.cboProducto.Location = new System.Drawing.Point(454, 60);
            this.cboProducto.Size = new System.Drawing.Size(170, 25);
            this.cboProducto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);

            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.BackColor = System.Drawing.Color.White;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConsultar.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.btnConsultar.Location = new System.Drawing.Point(280, 176);
            this.btnConsultar.Size = new System.Drawing.Size(140, 36);
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultar.FlatAppearance.BorderSize = 1;
            this.btnConsultar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);

            this.pnlResultados.Name = "pnlResultados";
            this.pnlResultados.BackColor = System.Drawing.Color.FromArgb(242, 242, 242);
            this.pnlResultados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlResultados.Location = new System.Drawing.Point(25, 228);
            this.pnlResultados.Size = new System.Drawing.Size(650, 210);

            this.dgvStock.Name = "dgvStock";
            this.dgvStock.AllowUserToAddRows = false;
            this.dgvStock.AllowUserToDeleteRows = false;
            this.dgvStock.AllowUserToResizeRows = false;
            this.dgvStock.AllowUserToResizeColumns = false;
            this.dgvStock.AutoGenerateColumns = false;
            this.dgvStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStock.BackgroundColor = System.Drawing.Color.FromArgb(242, 242, 242);
            this.dgvStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvStock.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvStock.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvStock.ColumnHeadersDefaultCellStyle = estiloEncabezado;
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvStock.ColumnHeadersHeight = 34;
            this.dgvStock.DefaultCellStyle = estiloCelda;
            this.dgvStock.EnableHeadersVisualStyles = false;
            this.dgvStock.Location = new System.Drawing.Point(18, 16);
            this.dgvStock.MultiSelect = false;
            this.dgvStock.ReadOnly = true;
            this.dgvStock.RowHeadersVisible = false;
            this.dgvStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStock.Size = new System.Drawing.Size(612, 176);
            this.dgvStock.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgvStock.RowTemplate.Height = 32;
            this.dgvStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colCategoria,
                this.colProducto,
                this.colStock});

            this.colCategoria.Name = "colCategoria";
            this.colCategoria.HeaderText = "CATEGORIA";
            this.colCategoria.DataPropertyName = "Categoria";
            this.colCategoria.FillWeight = 100F;
            this.colCategoria.ReadOnly = true;
            this.colCategoria.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;

            this.colProducto.Name = "colProducto";
            this.colProducto.HeaderText = "NOMBRE PRODUCTO";
            this.colProducto.DataPropertyName = "Producto";
            this.colProducto.FillWeight = 130F;
            this.colProducto.ReadOnly = true;
            this.colProducto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;

            this.colStock.Name = "colStock";
            this.colStock.HeaderText = "STOCK DISPONIBLE";
            this.colStock.DataPropertyName = "Stock";
            this.colStock.FillWeight = 100F;
            this.colStock.ReadOnly = true;
            this.colStock.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(225, 232, 240);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClientSize = new System.Drawing.Size(700, 462);
            this.Text = "TrackHive - Consultar Producto";
            this.lblTitulo.TabIndex = 0;
            this.Controls.Add(this.lblTitulo);
            this.pnlFiltros.TabIndex = 1;
            this.Controls.Add(this.pnlFiltros);
            this.lblHint.TabIndex = 0;
            this.pnlFiltros.Controls.Add(this.lblHint);
            this.lblMarca.TabIndex = 1;
            this.pnlFiltros.Controls.Add(this.lblMarca);
            this.cboMarca.TabIndex = 2;
            this.pnlFiltros.Controls.Add(this.cboMarca);
            this.lblCategoria.TabIndex = 3;
            this.pnlFiltros.Controls.Add(this.lblCategoria);
            this.cboCategoria.TabIndex = 4;
            this.pnlFiltros.Controls.Add(this.cboCategoria);
            this.lblProducto.TabIndex = 5;
            this.pnlFiltros.Controls.Add(this.lblProducto);
            this.cboProducto.TabIndex = 6;
            this.pnlFiltros.Controls.Add(this.cboProducto);
            this.btnConsultar.TabIndex = 2;
            this.Controls.Add(this.btnConsultar);
            this.pnlResultados.TabIndex = 3;
            this.Controls.Add(this.pnlResultados);
            this.dgvStock.TabIndex = 0;
            this.pnlResultados.Controls.Add(this.dgvStock);
            this.Load += new System.EventHandler(this.FrmConsultarProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.pnlFiltros.ResumeLayout(false);
            this.pnlResultados.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlFiltros;
        private System.Windows.Forms.Label lblHint;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.ComboBox cboProducto;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Panel pnlResultados;
        private System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStock;
    }
}
