using System;
using System.Windows.Forms;
using LogicLayer;

namespace UILayer
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void IngresarEvent(object sender, EventArgs e)
        {
            if (int.TryParse(rutTextBox.Text.Replace(".", "").Replace("-",""),out var salida))
            {
                if (Conexion.Instance.ValidarRut(rutTextBox.Text.Replace(".", "").Replace("-", "")))
                {
                    if (Conexion.Instance.ExisteUsuario(salida,passTextBox.Text))
                    {
                        new AdminUi(this,salida).Show();
                        rutTextBox.Text = string.Empty;
                        passTextBox.Text = string.Empty;
                        Hide();
                    }
                    else
                    {
                        MessageBox.Show(this, "Combinación de Usuario y contraseña es invalida.", caption: "Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Exclamation);
                        rutTextBox.Text = string.Empty;
                        passTextBox.Text = string.Empty;
                    }
                }
                else
                {
                    MessageBox.Show(this,"Rut no es Valido.",caption: "Error",buttons: MessageBoxButtons.OK,icon: MessageBoxIcon.Exclamation);
                    rutTextBox.Text = string.Empty;
                    passTextBox.Text = string.Empty;
                }
            }
            else
            {
                MessageBox.Show(this, text: "Ingrese valores númericos validos.", caption: "Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Exclamation);
                rutTextBox.Text = string.Empty;
                passTextBox.Text = string.Empty;
            }

        }

        private void LoginClose(object sender, EventArgs e)
        {
            Close();
        }

        private void LogoSetupHide(object sender, EventArgs e)
        {
            //Este sera para setear los nuevos datos
            new ConnectionFrame().Show();
        }
    }
}
