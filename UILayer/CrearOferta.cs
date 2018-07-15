using LogicLayer;
using System;
using System.Windows.Forms;

namespace UILayer
{
    public partial class CrearOferta : Form
    {
        private bool valido = false;
        public CrearOferta()
        {
            InitializeComponent();
        }

        private void CheckEvent(object sender, EventArgs e)
        {
            if (Int32.TryParse(CodeBox.Text.Replace("$","").Replace(".",""),out int result))
            {
                if (Conexion.Instance.ExisteEnOferta(result))
                {
                    MessageBox.Show(this,"El codigo no esta disponible, intente con otro","Error");
                    valido = false;
                }
                else
                {
                    MessageBox.Show(this,"El código esta disponible para usar","Confirmación");
                    valido = true;
                }
            }
            else
            {
                MessageBox.Show(this, "Inserte números válidos", "Error");
                valido = false;
            }
        }

        private void IngresarOfertaEvent(object sender, EventArgs e)
        {
            if (valido)
            {
                if (Int32.TryParse(CodeBox.Text,out int result))
                {
                    if (Int32.TryParse(PriceBox.Text.Replace("$","").Replace(".",""),out int precioFinal))
                    {
                        Conexion.Instance.CrearOfertas(result,NameBox.Text,precioFinal);
                        foreach (DataGridViewRow row in productosGridView.Rows)
                        {
                            try
                            {
                                Conexion.Instance.AnexarProductosAOfertas(Int32.Parse(row.Cells["Producto"].Value.ToString()), Int32.Parse(row.Cells["Cantidad"].Value.ToString()), result);
                            }
                            catch (Exception exce)
                            {
                                Console.WriteLine("Error de null pero controlable " + exce.Message);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show(this,"Error","Error");
                    }
                }
                else
                {
                    MessageBox.Show(this,"Error","Error");
                }
            }
            else
            {
                MessageBox.Show(this,"Debes verificar la disponibilidad del Código antes de ingresar la oferta","Información");
            }
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new ReportManager().ImprimirEgreso(123, 23, "asd", "asdsa");
        }
    }
}
