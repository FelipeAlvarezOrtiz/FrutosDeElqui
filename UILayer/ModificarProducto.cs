using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using LogicLayer;

namespace UILayer
{
    public partial class ModificarProducto : Form
    {
        private readonly int _rut;
        public ModificarProducto(int rut)
        {
            InitializeComponent();
            _rut = rut;
            codeTextBox.Focus();
        }

        private void CancelEvent(object sender, EventArgs e) => Close();

        private void ModifyAccept_Click(object sender, EventArgs e)
        {
            var dialog = MessageBox.Show(this, "Desea Confirmar la Modificación del Producto ?", "Confirmación",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dialog == DialogResult.OK)
            {
                Conexion.Instance.ModificarProducto(int.Parse(codeTextBox.Text),nameTextBox.Text,int.Parse(priceMinorTextBox.Text),int.Parse(priceMayorTextBox.Text),medidaTextBox.Text,categoriaTextBox.Text,validezCheckBox.Checked,int.Parse(stockTextBox.Text));
                MessageBox.Show(this, "Modificación realizada con Exito", "Exito");
                Close();
            }
        }

        private void EnterKeyPressEvent(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)13) return;
            if (int.TryParse(codeTextBox.Text,out var result))
            {
                Conexion.Instance.LlenarDatosModificacionProducto(nameTextBox,priceMinorTextBox,priceMayorTextBox,medidaTextBox,categoriaTextBox,result,validezCheckBox,stockTextBox);
            }
            else
            {
                MessageBox.Show(this, "Ingrese valores númericos", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
