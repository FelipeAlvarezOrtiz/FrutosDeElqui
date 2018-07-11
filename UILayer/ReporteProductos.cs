using System;
using System.Windows.Forms;
using LogicLayer;

namespace UILayer
{
    public partial class ReporteProductos : Form
    {
        public ReporteProductos()
        {
            InitializeComponent();
        }

        private void CerrarButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void KeyPressEvent(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar != (char)13) return;
            if (int.TryParse(codeTextBox.Text,out var result))
            {
                Conexion.Instance.ConsultarVentas(result,totalTextBox,ofertasTextBox,singularTextBox,dataGridVentas,fechaInput.SelectionRange.Start.ToString("yyyy/MM/dd"),
                    fechaInput.SelectionRange.End.ToString("yyyy/MM/dd"));

            }
            else
            {
                MessageBox.Show("Ingrese valores Numericos", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void IngresarButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(codeTextBox.Text, out var result))
            {
                Conexion.Instance.ConsultarVentas(result, totalTextBox, ofertasTextBox, singularTextBox, dataGridVentas, fechaInput.SelectionRange.Start.ToString("yyyy/MM/dd"),
                    fechaInput.SelectionRange.End.ToString("yyyy/MM/dd"));

            }
            else
            {
                MessageBox.Show("Ingrese valores Numericos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
