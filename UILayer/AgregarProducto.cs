using System;
using System.Windows.Forms;
using LogicLayer;

namespace UILayer
{
    public partial class AgregarProducto : Form
    {
        private readonly int _rut;
        public AgregarProducto(int rut)
        {
            InitializeComponent();
            _rut = rut;
            codigoText.Focus();
        }

        private void CancelEvent(object sender, EventArgs e) => Close();

        private void IngresarProductoButton_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion.Instance.InsertarProductoNuevo(int.Parse(codigoText.Text), nameTextBox.Text,
                    medidaTextBo.Text,
                    int.Parse(precioDetalleTextBox.Text), int.Parse(precioMayorTextBox.Text), categoriaTextBox.Text,int.Parse(stockInicialTextBox.Text));
                var dialogResult = MessageBox.Show("Producto Ingresado con éxito, ¿Deseas ingresar otro producto Nuevo?", "Confirmación", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                {
                    Close();
                }
                else
                {
                    codigoText.Text = string.Empty;
                    precioDetalleTextBox.Text = string.Empty;
                    precioMayorTextBox.Text = string.Empty;
                    categoriaTextBox.Text = string.Empty;
                    nameTextBox.Text = string.Empty;
                    medidaTextBo.Text = string.Empty;
                }
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Formato no coincide verificar los datos ingresados", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void VerificarEvent(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(codigoText.Text,out var result))
                {
                    if (!Conexion.Instance.VerificarDisponibilidadDeCodigo(result))
                    {
                        MessageBox.Show(this,
                            "Codigo de Barra Disponible, debe contactar al Desarrollador para generar un codigo de barra válido para el libro",
                            "Exito");
                        dataProductGroupBox.Enabled = true;

                    }
                    else
                    {
                        MessageBox.Show(this,
                            "Codigo de Barra No Disponible",
                            "Error");
                        dataProductGroupBox.Enabled = false;
                    }
                }
                else
                {
                    Console.WriteLine("No se puede converti text a integer");
                }
            }catch(Exception)
            {
                MessageBox.Show(this, "Formato no compatible", "Error");
            }
        }

    }
}
