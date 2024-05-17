namespace WinFormsApp04.Windows
{
    partial class frmEstanteria
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            toolStrip1 = new ToolStrip();
            tsbNuevo = new ToolStripButton();
            tsbBorrar = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tsbSalir = new ToolStripButton();
            panelGrid = new Panel();
            dgvDatos = new DataGridView();
            colEstante = new DataGridViewTextBoxColumn();
            colProducto = new DataGridViewTextBoxColumn();
            panelProducto = new Panel();
            btnCancelar = new Button();
            btnOK = new Button();
            txtPrecio = new TextBox();
            label3 = new Label();
            txtMarca = new TextBox();
            label2 = new Label();
            txtCodigo = new TextBox();
            label1 = new Label();
            errorProvider1 = new ErrorProvider(components);
            toolStrip1.SuspendLayout();
            panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            panelProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbNuevo, tsbBorrar, toolStripSeparator1, tsbSalir });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(852, 62);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsbNuevo
            // 
            tsbNuevo.Image = Properties.Resources.Nuevo1;
            tsbNuevo.ImageScaling = ToolStripItemImageScaling.None;
            tsbNuevo.ImageTransparentColor = Color.Magenta;
            tsbNuevo.Name = "tsbNuevo";
            tsbNuevo.Size = new Size(46, 59);
            tsbNuevo.Text = "Nuevo";
            tsbNuevo.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbNuevo.Click += tsbNuevo_Click;
            // 
            // tsbBorrar
            // 
            tsbBorrar.Image = Properties.Resources.Delete1;
            tsbBorrar.ImageScaling = ToolStripItemImageScaling.None;
            tsbBorrar.ImageTransparentColor = Color.Magenta;
            tsbBorrar.Name = "tsbBorrar";
            tsbBorrar.Size = new Size(44, 59);
            tsbBorrar.Text = "Borrar";
            tsbBorrar.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbBorrar.Click += tsbBorrar_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 62);
            // 
            // tsbSalir
            // 
            tsbSalir.Image = Properties.Resources.Close1;
            tsbSalir.ImageScaling = ToolStripItemImageScaling.None;
            tsbSalir.ImageTransparentColor = Color.Magenta;
            tsbSalir.Name = "tsbSalir";
            tsbSalir.Size = new Size(44, 59);
            tsbSalir.Text = "Salir";
            tsbSalir.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbSalir.Click += tsbSalir_Click;
            // 
            // panelGrid
            // 
            panelGrid.Controls.Add(dgvDatos);
            panelGrid.Location = new Point(0, 67);
            panelGrid.Name = "panelGrid";
            panelGrid.Size = new Size(414, 357);
            panelGrid.TabIndex = 1;
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.AllowUserToDeleteRows = false;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { colEstante, colProducto });
            dgvDatos.Dock = DockStyle.Fill;
            dgvDatos.Location = new Point(0, 0);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
            dgvDatos.Size = new Size(414, 357);
            dgvDatos.TabIndex = 3;
            // 
            // colEstante
            // 
            colEstante.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colEstante.HeaderText = "Estante Nro.";
            colEstante.Name = "colEstante";
            colEstante.ReadOnly = true;
            colEstante.Width = 96;
            // 
            // colProducto
            // 
            colProducto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colProducto.HeaderText = "Producto";
            colProducto.Name = "colProducto";
            colProducto.ReadOnly = true;
            // 
            // panelProducto
            // 
            panelProducto.Controls.Add(btnCancelar);
            panelProducto.Controls.Add(btnOK);
            panelProducto.Controls.Add(txtPrecio);
            panelProducto.Controls.Add(label3);
            panelProducto.Controls.Add(txtMarca);
            panelProducto.Controls.Add(label2);
            panelProducto.Controls.Add(txtCodigo);
            panelProducto.Controls.Add(label1);
            panelProducto.Location = new Point(420, 67);
            panelProducto.Name = "panelProducto";
            panelProducto.Size = new Size(420, 259);
            panelProducto.TabIndex = 4;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(126, 138);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 41);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(36, 138);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 41);
            btnOK.TabIndex = 11;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(109, 89);
            txtPrecio.MaxLength = 13;
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(235, 23);
            txtPrecio.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 92);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 4;
            label3.Text = "Precio:";
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(109, 60);
            txtMarca.MaxLength = 13;
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(235, 23);
            txtMarca.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 63);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 5;
            label2.Text = "Marca:";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(109, 31);
            txtCodigo.MaxLength = 13;
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(235, 23);
            txtCodigo.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 34);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 6;
            label1.Text = "Cód. Barras:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmEstanteria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(852, 450);
            Controls.Add(panelProducto);
            Controls.Add(panelGrid);
            Controls.Add(toolStrip1);
            Name = "frmEstanteria";
            Text = "Estantería";
            Load += frmEstanteria_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            panelProducto.ResumeLayout(false);
            panelProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton tsbNuevo;
        private ToolStripButton tsbBorrar;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton tsbSalir;
        private Panel panelGrid;
        private DataGridView dgvDatos;
        private DataGridViewTextBoxColumn colEstante;
        private DataGridViewTextBoxColumn colProducto;
        private Panel panelProducto;
        private Button btnCancelar;
        private Button btnOK;
        private TextBox txtPrecio;
        private Label label3;
        private TextBox txtMarca;
        private Label label2;
        private TextBox txtCodigo;
        private Label label1;
        private ErrorProvider errorProvider1;
    }
}
