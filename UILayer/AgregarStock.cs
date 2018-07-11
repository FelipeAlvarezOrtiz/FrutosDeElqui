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
    public partial class AgregarStock : Form
    {
        private readonly int _rut;
        public AgregarStock(int rut)
        {
            InitializeComponent();
            _rut = rut;
        }

        private void EnterEventCode(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)13) return;
            if (int.TryParse(codeListener.Text,out var result))
            {
                Conexion.Instance.LlenarDatosProducto(result,nameTextBox,precioTextBox,disponibilidadTextBox,categoriaTextBox,medidaTextBox);
                
            }
            else
            {
                MessageBox.Show(this, "Error de formato, ingrese valores númericos", "Error");
            }

        }

        private void OnLoadFormEvent(object sender, EventArgs e)
        {
            //Aqui va cargar el dataGridView
            Conexion.Instance.InventarioProductos(dataStockDisponible);
        }

        private void CancelarEventClick(object sender, EventArgs e)
        {
            Close();
        }

        private void IngresarButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(cantidadTextBox.Text,out var result))
                {
                    Conexion.Instance.InsertarNuevoStock(comboBox1, result,int.Parse(codeListener.Text),_rut);
                    Conexion.Instance.InventarioProductos(dataStockDisponible);
                    MessageBox.Show(this, "Se ha actualizado el inventario", "Exito");
                }
            }
            catch (Exception )
            {
                Console.WriteLine("Error");
            }
        }

        private void codeListener_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cantidadTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Imprimir_Inventario(object sender, EventArgs e)
        {

        }
    }
}
