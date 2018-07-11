using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using LogicLayer;

namespace UILayer
{
    public partial class IngresoForm : Form
    {
        private readonly int rut;
        public IngresoForm(int _rut)
        {
            rut = _rut;
            InitializeComponent();
        }

        private void AceptarEvent(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(montoBox.Text.Replace(".", "").Replace("$", ""), out var salida) && motivoTextBox.Text != string.Empty)
                {
                    var id = DateTime.Now.ToString("ddMMyyyyHmmssff");
                    var idMov = long.Parse(id);
                    var fecha = DateTime.Now.ToString("yyyy-MM-dd");
                    var hora = DateTime.Now.ToString("H:mm:ss");
                    Conexion.Instance.SetIngreso(idMov, salida, rut, fecha, hora, motivoTextBox.Text);
                    MessageBox.Show(this, "Ingreso de Dinero ingresado con Exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show(this, "El monto a egresar debe ser númerico y la razón no puede estar vacía", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (SqlException)
            {
                MessageBox.Show(this, "Error de DATABASE", "Error");
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
