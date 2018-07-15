using System;
using System.Windows.Forms;
using LogicLayer;

namespace UILayer
{
    public partial class Egreso : Form
    {
        private bool _clickeado = false;
        private int _rutAutorizante;
        private readonly string _nombre;
        public Egreso(int rut,string Nombre)
        {
            InitializeComponent();
            _rutAutorizante = rut;
            _nombre = Nombre;
        }

        private void CambioTextoEvent(object sender, EventArgs e)
        {
           
   
        }

        private void CancelarEgresoEvent(object sender, EventArgs e)
        {
            Close();
        }

        private void firstClickEvent(object sender, EventArgs e)
        {
            if (_clickeado) return;
            razonTextBox.Text = string.Empty;
            _clickeado = true;
        }

        private void acceptEgreso_Click(object sender, EventArgs e)
        {
            if (int.TryParse(montoTextBox.Text.Replace(".","").Replace("$",""),out var salida) && razonTextBox.Text != string.Empty)
            {
                var id = DateTime.Now.ToString("ddMMyyyyHmmssff");
                var idMov = long.Parse(id);
                var fecha = DateTime.Now.ToString("yyyy-MM-dd");
                var hora = DateTime.Now.ToString("H:mm:ss");
                if (Conexion.Instance.SetEgreso(idMov,salida, _rutAutorizante, fecha, hora,razonTextBox.Text))
                {
                    MessageBox.Show(this, "Egreso ingresado con Exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    new ReportManager().ImprimirEgreso(_rutAutorizante, salida, razonTextBox.Text, _nombre);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show(this, "El monto a egresar debe ser númerico y la razón no puede estar vacía", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
