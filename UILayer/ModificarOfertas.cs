using LogicLayer;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace UILayer
{
    public partial class ModificarOfertas : Form
    {
        public ModificarOfertas()
        {
            InitializeComponent();
            codeListener.Focus();
        }

        private void CancelEvent(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show("¿Estás Seguro que deseas salir sin confirmar los cambios?", "Confirmación", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Close();
            }
        }

        private void ModifyEvent(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show("¿Estás seguro que deseas realizar estos cambios?", "Confirmación", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (Int32.TryParse(codeListener.Text,out int result)) {
                    Conexion.Instance.LimpiadorOfertas(result);
                    Conexion.Instance.CrearOfertas(result,nombreBox.Text,Int32.Parse(precioOfertaText.Text.Replace(".","").Replace("$","").Replace(" ","")));
                    foreach (DataGridViewRow row in productosAsociadosGridView.Rows)
                    {
                        //Console.WriteLine(row.Cells["Codigo_Barra"].Value.ToString());
                        //Console.WriteLine(row.Cells["Cantidad"].Value.ToString());
                        try
                        {
                            Conexion.Instance.AnexarProductosAOfertas(Int32.Parse(row.Cells["Codigo_Barra"].Value.ToString()), Int32.Parse(row.Cells["Cantidad"].Value.ToString()), result);
                        }
                        catch (Exception exce)
                        {
                            Console.WriteLine("Error de null pero controlable "+exce.Message );
                        }
                    }
                }
                MessageBox.Show(this,"Cambios efectuados con exito","Confirmación");
                Close();
            }
            else
            {
                MessageBox.Show(this,"Proceso Cancelado por el Usuario","Cancelación");
            }
        }

        private void EnterPresionadoEvent(object sender, KeyPressEventArgs e)
        {
            
        }

        private void cargandoForm(object sender, EventArgs e)
        {

        }

        private void IngresarClick(object sender, EventArgs e)
        {
            if (Int32.TryParse(codeListener.Text,out int result))
            {
                if (Conexion.Instance.ExisteEnOferta(result))
                {
                    Conexion.Instance.LlenarGridProductosDeOferta(result,productosAsociadosGridView,nombreBox,precioOfertaText);
                    
                }
                else
                {
                    MessageBox.Show(this,"El codigo ingresado no pertenece a ninguna oferta","Informacion",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    codeListener.Text = string.Empty;
                }
            }
            else
            {
                MessageBox.Show(this,"Error ingrese valores Númericos","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
