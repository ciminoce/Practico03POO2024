using ConsoleApp04.Datos;
using ConsoleApp04.Entidades;
using System.Text.RegularExpressions;

namespace WinFormsApp04.Windows
{
    public partial class frmEstanteria : Form
    {
        private Estanteria? estanteria;
        private Producto[]? productosEnEstanteria;
        public frmEstanteria()
        {
            InitializeComponent();
            estanteria = new Estanteria(3, -1);
        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmEstanteria_Load(object sender, EventArgs e)
        {
            ManejarControles(false);
            if (estanteria.EstaVacia())
            {
                MessageBox.Show("Estantería Vacía");
            }
            productosEnEstanteria = estanteria.GetProductos();
            MostrarProductosEnEstanteria();

        }

        private void ManejarControles(bool value)
        {
            txtCodigo.Enabled = value;
            txtMarca.Enabled = value;
            txtPrecio.Enabled = value;

            btnCancelar.Enabled = value;
            btnOK.Enabled = value;
        }

        private void MostrarProductosEnEstanteria()
        {
            dgvDatos.Rows.Clear();
            for (int i = 0; i < estanteria.GetProductos().Length; i++)
            {
                var producto = estanteria.GetProducto(i);
                var r = ConstruirFila();
                SetearFila(r, producto, i);
                AgregarFila(r);
            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            dgvDatos.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r,
            Producto? producto, int i)
        {
            r.Cells[colEstante.Index].Value = i;
            r.Cells[colProducto.Index].Value = Producto
                .MostrarProducto(producto);

            r.Tag = producto;
        }

        private DataGridViewRow ConstruirFila()
        {
            var r = new DataGridViewRow();
            r.CreateCells(dgvDatos);
            return r;
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            ManejarControles(true);
            txtCodigo.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }

        private void LimpiarControles()
        {
            txtCodigo.Clear();
            txtMarca.Clear();
            txtPrecio.Clear();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                Producto producto = new Producto(txtCodigo.Text,
                    txtMarca.Text, float.Parse(txtPrecio.Text));

                if (estanteria + producto)
                {
                    MessageBox.Show("producto Agregado");
                    MostrarProductosEnEstanteria();
                    LimpiarControles();
                    ManejarControles(false);
                    if (estanteria.EstaCompleta())
                    {
                        MessageBox.Show("Estantería LLena");

                        tsbNuevo.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show("Producto existente!!!");
                }

            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (!Regex.IsMatch(txtCodigo.Text, "^\\d{13}$"))
            {
                valido = false;
                errorProvider1.SetError(txtCodigo,
                    "Código de Barras mal ingresado!!!");
            }
            if (string.IsNullOrEmpty(txtMarca.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(txtMarca, "Debe ingresar una marca");
            }
            if (!float.TryParse(txtPrecio.Text, out float precio) || precio <= 0)
            {
                valido = false;
                errorProvider1.SetError(txtPrecio, "Precio mal ingresado");
            }
            return valido;
        }

        private void tsbBorrar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count==0)
            {
                return;
            }

            var r = dgvDatos.SelectedRows[0];
            Producto producto = (Producto)r.Tag;
            DialogResult dr = MessageBox.Show("¿Desea sacar del la estanteria el producto?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No) { return; }
            estanteria=estanteria - producto;
            MostrarProductosEnEstanteria();
            if (!estanteria.EstaCompleta())
            {
                tsbNuevo.Enabled = true;
            }
        }
    }
}
