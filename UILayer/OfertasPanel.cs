using System;
using System.Windows.Forms;

namespace UILayer
{
    public partial class OfertasPanel : Form
    {
        public OfertasPanel()
        {
            InitializeComponent();
        }

        private void CrearOfertasForm(object sender, EventArgs e)
        {
            new CrearOferta().Show();
            Close();
        }

        private void ModificarShow(object sender, EventArgs e)
        {
            new ModificarOfertas().Show();
            Close();
        }
    }
}
