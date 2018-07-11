using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicLayer;

namespace UILayer
{
    public partial class ConnectionFrame : Form
    {
        public ConnectionFrame()
        {
            InitializeComponent();
        }

        private void IngresarConexionEvent(object sender, EventArgs e)
        {
            Conexion.Instance.SetUp(DataSourceTextBox.Text,UserTextBox.Text,PasswordTextBox.Text,"FRUTOS_DE_ELQUI");
            MessageBox.Show(this, "Prueba de conexión exitosa, se puede proceder con esta configuración", "Éxito",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();

        }
    }
}
