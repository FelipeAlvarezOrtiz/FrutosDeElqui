using System;
using System.Windows.Forms;
using LogicLayer;

namespace UILayer
{
    public partial class InformeVentas : Form
    {
        public InformeVentas()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
                Conexion.Instance.SetGananciasPerdidas(userCalendar.SelectionRange.Start.ToString("yyyy/MM/dd"),userCalendar.SelectionRange.End.ToString("yyyy/MM/dd"),
                                                        ventasDataGrid,egresosDataView,efectivoTextBox,debitoTextBox,ventasMayorTextBox,ventasDetalleTextBox,gananciaTotalTextBox,egresosTextBox,creditoTextBox,ingresoDataGrid,
                                                        ingresosBox);
            //searchButton.Enabled = false;
            
            var valor = int.Parse(efectivoTextBox.Text.Replace("$","").Replace(".","")) + int.Parse(ingresosBox.Text.Replace("$", "").Replace(".", "")) - int.Parse(egresosTextBox.Text.Replace("$", "").Replace(".", ""));
            cajaBox.Text = valor.ToString("C0");
        }

        private void CloseEVentClick(object sender, EventArgs e)
        {
            Close();
        }

        private void AnularEventClick(object sender, EventArgs e)
        {
            try
            {
                Conexion.Instance.AnularVenta(long.Parse(ventasDataGrid.CurrentRow.Cells[0].Value.ToString()));
            }
            catch (NullReferenceException exception)
            {
                MessageBox.Show("Seleccione una Venta para borrar " + exception.Message, "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void DetalleButton_Click(object sender, EventArgs e)
        {
            try
            {
                new DetalleVenta(long.Parse(ventasDataGrid.CurrentRow.Cells[0].Value.ToString())).Show();
            }
            catch (NullReferenceException nullReference)
            {
                MessageBox.Show("Seleccione una Venta para borrar " + nullReference.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void reportDocument1_InitReport(object sender, EventArgs e)
        {

        }
    }
}
