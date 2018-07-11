using System;
using System.Windows.Forms;

namespace UILayer
{
    public partial class ModuloInformesVentas : Form
    {
        public ModuloInformesVentas()
        {
            InitializeComponent();
        }

        private void ventasInformesButton_Click(object sender, EventArgs e)
        {
            new InformeVentas().Show();
            Close();
        }

        private void InformeProductosEvent(object sender, EventArgs e)
        {
            new ReporteProductos().Show();
            Close();
        }
    }
}
