using System;
using System.Windows.Forms;

namespace UILayer
{
    public partial class ControlModuloscs : Form
    {
        private readonly int _rutAutorizante;

        public ControlModuloscs(int rut)
        {
            InitializeComponent();
            _rutAutorizante = rut;
        }


        private void AgregarProductoEvento(object sender, EventArgs e) { 
            new AgregarProducto(_rutAutorizante).Show();
            Close();
        }

        private void ModificarProductoEvent(object sender, EventArgs e)
        {
            new ModificarProducto(_rutAutorizante).Show();
            Close();
        }
    }
}
