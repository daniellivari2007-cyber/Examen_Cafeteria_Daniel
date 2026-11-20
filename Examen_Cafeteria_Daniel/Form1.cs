using System;
using System.Globalization;
using System.Windows.Forms;

namespace Examen_Cafeteria_Daniel
{
    public partial class frmPedidos : Form
    {
        // Constantes de reglas de negocio
        private const decimal RECARGO_GRANDE = 25.00m;
        private const decimal RECARGO_PORCION_EXTRA = 30.00m;
        private const decimal PORCENTAJE_DESCUENTO_FRECUENTE = 0.10m;
        private const decimal COSTO_EMPAQUE_LLEVAR = 20.00m;
        private const decimal TASA_ITBIS = 0.18m;

        // Formato con punto decimal (ej. RD$ 560.00)
        private readonly CultureInfo culturaRD = CultureInfo.InvariantCulture;

        // Acumulador del subtotal del pedido
        private decimal subtotalAcumulado = 0.00m;

        public frmPedidos()
        {
            InitializeComponent();
            this.Load += frmPedidos_Load;
        }

        // Evento Load: deja controles y resultados en sus valores iniciales
        private void frmPedidos_Load(object sender, EventArgs e)
        {
            InicializarFormulario();
        }

        // Agregar al pedido: calcula precio unitario y total, formatea en columnas y acumula subtotal
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!ValidarEntradaProducto(out string nombreProducto, out decimal precioBase, out int cantidad))
            {
                return;
            }

            decimal precioUnitario = CalcularPrecioUnitario(precioBase);
            decimal totalLinea = precioUnitario * cantidad;

            subtotalAcumulado += totalLinea;

            string etiquetaOpciones = ObtenerEtiquetaOpciones();
            string productoFormateado = $"{nombreProducto}{etiquetaOpciones}";

            // Columnas: Cant (6), Producto (24), Precio (10), Total (12)
            string lineaPedido =
                cantidad.ToString().PadRight(6) +
                TruncarTexto(productoFormateado, 24).PadRight(24) +
                precioUnitario.ToString("0.00", culturaRD).PadLeft(10) +
                totalLinea.ToString("0.00", culturaRD).PadLeft(12);

            lstPedido.Items.Add(lineaPedido);

            ReiniciarControlesProducto();
        }

        // Calcular total: valida que haya productos y calcula descuento, empaque, ITBIS y total
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (lstPedido.Items.Count == 0)
            {
                MessageBox.Show(
                    "Debe agregar al menos un producto antes de calcular el total.",
                    "Pedido vacío",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                txtProducto.Focus();
                return;
            }

            decimal subtotal = subtotalAcumulado;
            decimal descuento = chkFrecuente.Checked ? subtotal * PORCENTAJE_DESCUENTO_FRECUENTE : 0.00m;
            decimal empaque = rbtLlevar.Checked ? COSTO_EMPAQUE_LLEVAR : 0.00m;
            decimal baseImponible = subtotal - descuento + empaque;
            decimal itbis = baseImponible * TASA_ITBIS;
            decimal total = baseImponible + itbis;

            MostrarResultados(subtotal, descuento, empaque, itbis, total);
        }

        // Nuevo pedido: limpia todo, subtotal en cero y foco en txtCliente
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            InicializarFormulario();
            txtCliente.Focus();
        }

        // Salir: confirma con MessageBox (Sí/No) antes de cerrar
        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Desea salir de la aplicación?",
                "Confirmar salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta == DialogResult.Yes)
            {
                Close();
            }
        }

        private void InicializarFormulario()
        {
            subtotalAcumulado = 0.00m;

            txtCliente.Clear();
            dtpFecha.Value = DateTime.Today;
            chkFrecuente.Checked = false;

            rbtLocal.Checked = true;
            rbtLlevar.Checked = false;

            lstPedido.Items.Clear();
            ConfigurarEncabezado();
            ReiniciarControlesProducto();
            LimpiarResultados();
        }

        private void ConfigurarEncabezado()
        {
            lblEncabezado.Text =
                "Cant".PadRight(6) +
                "Producto".PadRight(24) +
                "Precio".PadLeft(10) +
                "Total".PadLeft(12);
        }

        private void ReiniciarControlesProducto()
        {
            txtProducto.Clear();
            txtPrecio.Clear();

            nudCantidad.Minimum = 1;
            nudCantidad.Maximum = 20;
            nudCantidad.Value = 1;

            rbtNormal.Checked = true;
            rbtGrande.Checked = false;
            chkPorcionExtra.Checked = false;

            txtProducto.Focus();
        }

        private void LimpiarResultados()
        {
            MostrarResultados(0.00m, 0.00m, 0.00m, 0.00m, 0.00m);
        }

        private void MostrarResultados(decimal subtotal, decimal descuento, decimal empaque, decimal itbis, decimal total)
        {
            lblSubtotal.Text = $"RD$ {subtotal.ToString("0.00", culturaRD)}";
            lblDescuento.Text = $"RD$ {descuento.ToString("0.00", culturaRD)}";
            lblEmpaque.Text = $"RD$ {empaque.ToString("0.00", culturaRD)}";
            lblItbis.Text = $"RD$ {itbis.ToString("0.00", culturaRD)}";
            lblTotal.Text = $"RD$ {total.ToString("0.00", culturaRD)}";
        }

        private decimal CalcularPrecioUnitario(decimal precioBase)
        {
            decimal precio = precioBase;

            if (rbtGrande.Checked)
            {
                precio += RECARGO_GRANDE;
            }

            if (chkPorcionExtra.Checked)
            {
                precio += RECARGO_PORCION_EXTRA;
            }

            return precio;
        }

        private string ObtenerEtiquetaOpciones()
        {
            if (rbtGrande.Checked && chkPorcionExtra.Checked)
            {
                return " (Grande, Extra)";
            }

            if (rbtGrande.Checked)
            {
                return " (Grande)";
            }

            if (chkPorcionExtra.Checked)
            {
                return " (Extra)";
            }

            return " (Normal)";
        }

        private string TruncarTexto(string texto, int anchoMaximo)
        {
            return texto.Length <= anchoMaximo ? texto : texto.Substring(0, anchoMaximo);
        }

        private bool ValidarEntradaProducto(out string nombreProducto, out decimal precioBase, out int cantidad)
        {
            nombreProducto = txtProducto.Text.Trim();
            precioBase = 0.00m;
            cantidad = Convert.ToInt32(nudCantidad.Value);

            if (string.IsNullOrWhiteSpace(nombreProducto))
            {
                MessageBox.Show(
                    "Debe digitar el nombre del producto.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                txtProducto.Focus();
                return false;
            }

            string textoPrecio = txtPrecio.Text.Trim().Replace(',', '.');
            if (!decimal.TryParse(textoPrecio, NumberStyles.Number, culturaRD, out precioBase) || precioBase <= 0)
            {
                MessageBox.Show(
                    "Debe digitar un precio válido mayor que cero.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                txtPrecio.Focus();
                txtPrecio.SelectAll();
                return false;
            }

            return true;
        }

        // Eventos existentes en el diseñador
        private void label2_Click(object sender, EventArgs e) { }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) { }
        private void chkFrecuente_CheckedChanged(object sender, EventArgs e) { }
        private void radioButton2_CheckedChanged(object sender, EventArgs e) { }
        private void label13_Click(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
        private void listBox1_Load(object sender, EventArgs e) { }
        private void lblDescuento_Click(object sender, EventArgs e) { }
        private void lblEmpaque_Click(object sender, EventArgs e) { }
        private void lblItbis_Click(object sender, EventArgs e) { }
        private void lblTotal_Click(object sender, EventArgs e) { }
        private void lblSubtotal_Click(object sender, EventArgs e) { }
    }
}