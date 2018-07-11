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
    public partial class DetalleVenta : Form
    {
        private readonly long _id;
        public DetalleVenta(long idVenta)
        {
            InitializeComponent();
            _id = idVenta;
            Conexion.Instance.LlenarGridVentaDetalle(_id,productosGridView);
        }

        private void AceptarClickEvent(object sender, EventArgs e)
        {
            Close();
        }

        private void AnularVentaEvent(object sender, EventArgs e)
        {
            Conexion.Instance.AnularVenta(_id);
            Close();
        }
    }
}
