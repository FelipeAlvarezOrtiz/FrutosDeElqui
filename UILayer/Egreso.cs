using System;
using System.Windows.Forms;
using LogicLayer;

namespace UILayer
{
    public partial class Egreso : Form
    {
        private bool _clickeado = false;
        private int _rutAutorizante;
        public Egreso(int rut)
        {
            InitializeComponent();
            _rutAutorizante = rut;
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
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show(this, "El monto a egresar debe ser númerico y la razón no puede estar vacía", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        //Imprimir Nombre de quien egreso, Motivo, Cantidad, Fecha y Hora
        private void GenerarPDFEgreso()
        {

        }
    }
}
