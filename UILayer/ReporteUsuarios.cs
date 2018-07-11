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
    public partial class ReporteUsuarios : Form
    {
        public ReporteUsuarios()
        {
            InitializeComponent();
        }

        private void CloseEvent(object sender, EventArgs e)
        {
            Close();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            //Console.WriteLine(calendarioUser.SelectionRange.Start.ToShortDateString()+" y final "+calendarioUser.SelectionRange.End.ToShortDateString());
            Conexion.Instance.LlenarGridBusqueda(calendarioUser.SelectionRange.Start.ToString("yyyy/MM/dd"),calendarioUser.SelectionRange.End.ToString("yyyy/MM/dd"),userDataGrid);

        }
    }
}
