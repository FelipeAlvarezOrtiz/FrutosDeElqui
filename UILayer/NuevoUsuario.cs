using System;
using System.Windows.Forms;
using LogicLayer;

namespace UILayer
{
    public partial class NuevoUsuario : Form
    {
        public NuevoUsuario()
        {
            InitializeComponent();
        }

        private void CancelClick(object sender, EventArgs e)
        {
            Close();
        }

        private void aceptarButton_Click(object sender, EventArgs e)
        {
            if (Conexion.Instance.ValidarRut(rut: rutTextBox.Text.Replace(".","").Replace("-","")))
            {
                Conexion.Instance.InsertarNuevoUsuario(int.Parse(rutTextBox.Text.Replace(".", "").Replace("-", "")),
                    nameTextBox.Text, celularTextBox.Text, mailTextBox.Text, passTextBox.Text,getRangoSeleccionado());
                Close();
            }
            else
            {
                MessageBox.Show(this, "El RUT ingresado no es válido", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private int getRangoSeleccionado()
        {
            if (accessLevel.Text.CompareTo("Administrador") == 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
