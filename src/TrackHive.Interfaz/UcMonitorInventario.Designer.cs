namespace TrackHive.Interfaz
{
    partial class UcMonitorInventario
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
            this.tlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.pnlBarra = new System.Windows.Forms.Panel();
            this.lblMonitor = new System.Windows.Forms.Label();
            this.flpControles = new System.Windows.Forms.FlowLayoutPanel();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblOrdenar = new System.Windows.Forms.Label();
            this.btnOrdenId = new System.Windows.Forms.Button();
            this.btnOrdenAZ = new System.Windows.Forms.Button();
            this.btnOrdenReciente = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.dgvMonitor = new System.Windows.Forms.DataGridView();
            this.lblFicha = new System.Windows.Forms.Label();
            this.txtFicha = new System.Windows.Forms.TextBox();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGuia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonitor)).BeginInit();
            this.tlpPrincipal.SuspendLayout();
            this.pnlBarra.SuspendLayout();
            this.flpControles.SuspendLayout();
            this.SuspendLayout();

            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.BackColor = System.Drawing.Color.FromArgb(208, 219, 228);
            this.tlpPrincipal.ColumnCount = 1;
            this.tlpPrincipal.RowCount = 4;
            this.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tlpPrincipal.Size = new System.Drawing.Size(845, 720);
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38F));

            this.pnlBarra.Name = "pnlBarra";
            this.pnlBarra.BackColor = System.Drawing.Color.FromArgb(208, 219, 228);
            this.pnlBarra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBarra.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);

            this.lblMonitor.Name = "lblMonitor";
            this.lblMonitor.AutoSize = true;
            this.lblMonitor.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMonitor.ForeColor = System.Drawing.Color.FromArgb(10, 57, 92);
            this.lblMonitor.Location = new System.Drawing.Point(18, 16);
            this.lblMonitor.Text = "Monitor de Inventario";

            this.flpControles.Name = "flpControles";
            this.flpControles.AutoSize = true;
            this.flpControles.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpControles.BackColor = System.Drawing.Color.FromArgb(208, 219, 228);
            this.flpControles.Dock = System.Windows.Forms.DockStyle.Right;
            this.flpControles.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            this.flpControles.Padding = new System.Windows.Forms.Padding(0, 14, 14, 0);
            this.flpControles.WrapContents = false;

            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBuscar.ForeColor = System.Drawing.Color.FromArgb(125, 133, 146);
            this.lblBuscar.Margin = new System.Windows.Forms.Padding(8, 6, 3, 0);
            this.lblBuscar.Text = "Buscar (Nombre):";

            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.txtBuscar.Size = new System.Drawing.Size(130, 23);
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);

            this.lblOrdenar.Name = "lblOrdenar";
            this.lblOrdenar.AutoSize = true;
            this.lblOrdenar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOrdenar.ForeColor = System.Drawing.Color.FromArgb(125, 133, 146);
            this.lblOrdenar.Margin = new System.Windows.Forms.Padding(8, 6, 3, 0);
            this.lblOrdenar.Text = "Ordenar:";

            this.btnOrdenId.Name = "btnOrdenId";
            this.btnOrdenId.BackColor = System.Drawing.Color.FromArgb(200, 206, 214);
            this.btnOrdenId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrdenId.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOrdenId.ForeColor = System.Drawing.Color.FromArgb(125, 133, 146);
            this.btnOrdenId.Size = new System.Drawing.Size(42, 24);
            this.btnOrdenId.Text = "ID";
            this.btnOrdenId.UseVisualStyleBackColor = false;
            this.btnOrdenId.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrdenId.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.btnOrdenId.FlatAppearance.BorderSize = 0;
            this.btnOrdenId.Click += new System.EventHandler(this.btnOrdenId_Click);

            this.btnOrdenAZ.Name = "btnOrdenAZ";
            this.btnOrdenAZ.BackColor = System.Drawing.Color.FromArgb(200, 206, 214);
            this.btnOrdenAZ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrdenAZ.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOrdenAZ.ForeColor = System.Drawing.Color.FromArgb(125, 133, 146);
            this.btnOrdenAZ.Size = new System.Drawing.Size(50, 24);
            this.btnOrdenAZ.Text = "A - Z";
            this.btnOrdenAZ.UseVisualStyleBackColor = false;
            this.btnOrdenAZ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrdenAZ.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.btnOrdenAZ.FlatAppearance.BorderSize = 0;
            this.btnOrdenAZ.Click += new System.EventHandler(this.btnOrdenAZ_Click);

            this.btnOrdenReciente.Name = "btnOrdenReciente";
            this.btnOrdenReciente.BackColor = System.Drawing.Color.FromArgb(200, 206, 214);
            this.btnOrdenReciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrdenReciente.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOrdenReciente.ForeColor = System.Drawing.Color.FromArgb(125, 133, 146);
            this.btnOrdenReciente.Size = new System.Drawing.Size(62, 24);
            this.btnOrdenReciente.Text = "Reciente";
            this.btnOrdenReciente.UseVisualStyleBackColor = false;
            this.btnOrdenReciente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrdenReciente.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.btnOrdenReciente.FlatAppearance.BorderSize = 0;
            this.btnOrdenReciente.Click += new System.EventHandler(this.btnOrdenReciente_Click);

            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(90, 154, 90);
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Size = new System.Drawing.Size(66, 24);
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);

            this.dgvMonitor.Name = "dgvMonitor";
            this.dgvMonitor.AllowUserToAddRows = false;
            this.dgvMonitor.AllowUserToDeleteRows = false;
            this.dgvMonitor.AllowUserToResizeRows = false;
            this.dgvMonitor.AllowUserToResizeColumns = false;
            this.dgvMonitor.AutoGenerateColumns = false;
            this.dgvMonitor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMonitor.BackgroundColor = System.Drawing.Color.FromArgb(242, 242, 242);
            this.dgvMonitor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvMonitor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvMonitor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvMonitor.ColumnHeadersDefaultCellStyle = estiloEncabezado;
            this.dgvMonitor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMonitor.ColumnHeadersHeight = 34;
            this.dgvMonitor.DefaultCellStyle = estiloCelda;
            this.dgvMonitor.EnableHeadersVisualStyles = false;
            this.dgvMonitor.MultiSelect = false;
            this.dgvMonitor.ReadOnly = true;
            this.dgvMonitor.RowHeadersVisible = false;
            this.dgvMonitor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMonitor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgvMonitor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMonitor.Margin = new System.Windows.Forms.Padding(18, 0, 18, 8);
            this.dgvMonitor.RowTemplate.Height = 34;
            this.dgvMonitor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colFecha,
                this.colMarca,
                this.colProducto,
                this.colCantidad,
                this.colCategoria,
                this.colGuia,
                this.colRemito});
            this.dgvMonitor.SelectionChanged += new System.EventHandler(this.dgvMonitor_SelectionChanged);

            this.lblFicha.Name = "lblFicha";
            this.lblFicha.AutoSize = false;
            this.lblFicha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFicha.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFicha.ForeColor = System.Drawing.Color.FromArgb(10, 57, 92);
            this.lblFicha.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.lblFicha.Text = "Ficha Técnica e Historial";
            this.lblFicha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.txtFicha.Name = "txtFicha";
            this.txtFicha.BackColor = System.Drawing.Color.FromArgb(242, 242, 242);
            this.txtFicha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFicha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFicha.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFicha.Margin = new System.Windows.Forms.Padding(18, 0, 18, 18);
            this.txtFicha.Multiline = true;
            this.txtFicha.ReadOnly = true;
            this.txtFicha.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;

            this.colFecha.Name = "colFecha";
            this.colFecha.HeaderText = "FECHA";
            this.colFecha.DataPropertyName = "Fecha";
            this.colFecha.FillWeight = 80F;
            this.colFecha.ReadOnly = true;
            this.colFecha.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colFecha.DefaultCellStyle = estiloFecha;

            this.colMarca.Name = "colMarca";
            this.colMarca.HeaderText = "MARCA";
            this.colMarca.DataPropertyName = "Marca";
            this.colMarca.FillWeight = 100F;
            this.colMarca.ReadOnly = true;
            this.colMarca.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;

            this.colProducto.Name = "colProducto";
            this.colProducto.HeaderText = "NOMBRE PRODUCTO";
            this.colProducto.DataPropertyName = "Producto";
            this.colProducto.FillWeight = 130F;
            this.colProducto.ReadOnly = true;
            this.colProducto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;

            this.colCantidad.Name = "colCantidad";
            this.colCantidad.HeaderText = "CANTIDAD";
            this.colCantidad.DataPropertyName = "Cantidad";
            this.colCantidad.FillWeight = 70F;
            this.colCantidad.ReadOnly = true;
            this.colCantidad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;

            this.colCategoria.Name = "colCategoria";
            this.colCategoria.HeaderText = "CATEGORIA";
            this.colCategoria.DataPropertyName = "Categoria";
            this.colCategoria.FillWeight = 90F;
            this.colCategoria.ReadOnly = true;
            this.colCategoria.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;

            this.colGuia.Name = "colGuia";
            this.colGuia.HeaderText = "GUIA REMISION";
            this.colGuia.DataPropertyName = "GuiaRemision";
            this.colGuia.FillWeight = 110F;
            this.colGuia.ReadOnly = true;
            this.colGuia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;

            this.colRemito.Name = "colRemito";
            this.colRemito.HeaderText = "REMITO";
            this.colRemito.DataPropertyName = "Remito";
            this.colRemito.FillWeight = 90F;
            this.colRemito.ReadOnly = true;
            this.colRemito.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(208, 219, 228);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MinimumSize = new System.Drawing.Size(760, 520);
            this.Size = new System.Drawing.Size(845, 720);
            this.tlpPrincipal.TabIndex = 0;
            this.Controls.Add(this.tlpPrincipal);
            this.pnlBarra.TabIndex = 0;
            this.tlpPrincipal.Controls.Add(this.pnlBarra, 0, 0);
            this.lblMonitor.TabIndex = 0;
            this.pnlBarra.Controls.Add(this.lblMonitor);
            this.flpControles.TabIndex = 1;
            this.pnlBarra.Controls.Add(this.flpControles);
            this.lblBuscar.TabIndex = 0;
            this.flpControles.Controls.Add(this.lblBuscar);
            this.txtBuscar.TabIndex = 1;
            this.flpControles.Controls.Add(this.txtBuscar);
            this.lblOrdenar.TabIndex = 2;
            this.flpControles.Controls.Add(this.lblOrdenar);
            this.btnOrdenId.TabIndex = 3;
            this.flpControles.Controls.Add(this.btnOrdenId);
            this.btnOrdenAZ.TabIndex = 4;
            this.flpControles.Controls.Add(this.btnOrdenAZ);
            this.btnOrdenReciente.TabIndex = 5;
            this.flpControles.Controls.Add(this.btnOrdenReciente);
            this.btnActualizar.TabIndex = 6;
            this.flpControles.Controls.Add(this.btnActualizar);
            this.dgvMonitor.TabIndex = 1;
            this.tlpPrincipal.Controls.Add(this.dgvMonitor, 0, 1);
            this.lblFicha.TabIndex = 2;
            this.tlpPrincipal.Controls.Add(this.lblFicha, 0, 2);
            this.txtFicha.TabIndex = 3;
            this.tlpPrincipal.Controls.Add(this.txtFicha, 0, 3);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonitor)).EndInit();
            this.tlpPrincipal.ResumeLayout(false);
            this.pnlBarra.ResumeLayout(false);
            this.flpControles.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.Panel pnlBarra;
        private System.Windows.Forms.Label lblMonitor;
        private System.Windows.Forms.FlowLayoutPanel flpControles;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblOrdenar;
        private System.Windows.Forms.Button btnOrdenId;
        private System.Windows.Forms.Button btnOrdenAZ;
        private System.Windows.Forms.Button btnOrdenReciente;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.DataGridView dgvMonitor;
        private System.Windows.Forms.Label lblFicha;
        private System.Windows.Forms.TextBox txtFicha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGuia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRemito;
    }
}
