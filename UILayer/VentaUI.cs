using System;
using System.Windows.Forms;
using LogicLayer;

namespace UILayer
{
    public partial class VentaUI : Form 
    {
        private readonly int _rut;
        private CarroCompras _carro = new CarroCompras();
        private int _posicion;
        private string _tipoVenta = string.Empty;
        private string _tipoPago = string.Empty;

        public VentaUI(int rutAutorizante)
        {
            InitializeComponent();
            _rut = rutAutorizante;
            _carro.Inicializar();
            codeListener.Focus();
        }

        private void ValueChanged(object sender, EventArgs e)
        {
            _tipoPago = paymentBox.SelectedItem.ToString();
            codeListener.Focus();
        }

        private void CancelEvent(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show(@"¿Estás seguro que quieres cancelar la venta?",@"Confirmación",MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Close();
            }
        }

        private void IntroKey(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char) 13) return;
            //Aqui se hace la consulta del producto, se crea el producto y toda la wea
            if (codeListener.Text != string.Empty)
            {
                if (int.TryParse(codeListener.Text,out var result))
                {
                    Venta(result);
                    totalTextBox.Text = _carro.TotalCarro.ToString("C0");
                    codeListener.Text = string.Empty;
                    Console.WriteLine("Estoy en el evento IntroKey");
                    codeListener.Focus();
                }
                else
                {
                    MessageBox.Show(this, "Ingrese un codigo de Barra válido", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(this, "Ingrese un valor Númerico no vacío", "Error",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void Venta(int codigoIngresado)
        {
            if (kindVentaBox.Text.CompareTo("Venta al Detalle") == 0 || kindVentaBox.Text.CompareTo("Venta al Por Mayor") == 0)
            {
                _tipoVenta = kindVentaBox.Text;
                if (Conexion.Instance.ExisteEnProductos(codigoIngresado))
                {
                    Conexion.Instance.LlenarCarroConProductos(_carro, codigoIngresado, _tipoVenta);
                    datosVentaGrid.Rows.Add(_carro.Proteccion.Last.Value.Id, _carro.Proteccion.Last.Value.Nombre, 1,
                        _carro.Proteccion.Last.Value.Precio);
                    _carro.RefreshPrecioCarro();
                    totalTextBox.Text = _carro.TotalCarro.ToString("C0");
                    codeListener.Focus();
                }
                else if (Conexion.Instance.ExisteEnOferta(codigoIngresado))
                {
                    //Console.WriteLine("Existe en ofertas");
                    Conexion.Instance.LlenarCarroConOfertas(_carro, codigoIngresado, _tipoVenta, datosVentaGrid);
                    _carro.RefreshPrecioCarro();
                    totalTextBox.Text = _carro.TotalCarro.ToString("C0");
                    codeListener.Focus();
                }
                else
                {
                    MessageBox.Show(this, "El codigo no esta asociado a ningún producto", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(this,"Porfavor escoga un tipo de venta para adecuar el precio","Información",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void CapturarIdCelda(object sender, DataGridViewCellEventArgs e)
        {
            if (datosVentaGrid.CurrentRow != null) _posicion = datosVentaGrid.CurrentRow.Index;
            if (e.ColumnIndex == 2)
            {
                //Lo vaciamos 
                Console.WriteLine("Estamos en CapturarIdCelda");
                datosVentaGrid[2, _posicion].Value = string.Empty;
            }

        }

        private void ValidadorCelda(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                try
                {
                    var aux = Convert.ToString(e.FormattedValue);
                    
                    if (int.TryParse(aux, out var result))
                    {
                        //Aqui va la multiplicación
                        datosVentaGrid[2, _posicion].Value = result.ToString();
                        codeListener.Text = string.Empty;
                        ModificarCantidad(int.Parse(datosVentaGrid[0,_posicion].Value.ToString()),result);
                        totalTextBox.Text = _carro.RefreshPrecioCarro().ToString("C0");
                        Console.WriteLine("ValidadorCelda en If");
                        codeListener.Focus();
                    }
                    else
                    {
                        codeListener.Text = string.Empty;
                        Console.WriteLine("ValidadorCelda en Else");
                        //codeListener.Focus();
                    }
                }
                catch (NullReferenceException)
                {

                }
            }
        }

        private void BorrarElementoButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Aqui borramos de la lista en productos
                _carro.RemoverProducto(int.Parse(datosVentaGrid[0, _posicion].Value.ToString()));
                totalTextBox.Text = _carro.RefreshPrecioCarro().ToString("C0");
                datosVentaGrid.Rows.RemoveAt(datosVentaGrid.CurrentRow.Index);
                //datosVentaGrid.Rows.RemoveAt(_posicion);
                codeListener.Focus();
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show(this, "Debe hacer click en el Nombre del producto para eliminarlo", "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show(this, "Debe seleccionar un producto válido para Eliminar.", "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        private void IngresarVenta_Click(object sender, EventArgs e)
        {
            //Se ingresa la venta
            var dialogResult = MessageBox.Show("¿Estás seguro que quieres ingresar la venta al Sistema?", "Confirmación", MessageBoxButtons.YesNo); 
            //if(String.Compare(kindVentaBox.Text, "Venta al Detalle", StringComparison.Ordinal) == 0 || kindVentaBox.Text.CompareTo("Venta al Por Mayor") == 0 && 
                //paymentBox.Text.CompareTo("Tarjeta") == 0 || paymentBox.Text.CompareTo("Efectivo") == 0)
            if (paymentBox.Text.CompareTo("Debito") == 0 || paymentBox.Text.CompareTo("Credito") == 0 || paymentBox.Text.CompareTo("Efectivo") == 0)
            {
                if (dialogResult != DialogResult.Yes) return;
                var aux = totalTextBox.Text.Replace("$", "").Replace(".", "");
                Conexion.Instance.TransaccionVenta(_carro, _rut, int.Parse(aux), kindVentaBox.Text,
                    paymentBox.Text);
                _carro.Dispose();
                Close();
            }
            else
            {
                MessageBox.Show(this, "Porfavor escoge método de pago válido", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ResetListenerEvent(object sender, EventArgs e)
        {
            codeListener.Focus();
        }

        private void ValueChangedVenta(object sender, EventArgs e)
        {
            _tipoVenta = kindVentaBox.SelectedItem.ToString();
            codeListener.Text = string.Empty;
            Console.WriteLine("ValueChangedVenta entre a");
            codeListener.Focus();
        }

        private void ModificarCantidad(int id,int nuevaCantidad)
        {
            foreach (var producto in _carro.Proteccion)
            {
                //Aqui modificamos con el id la cantidad.
                if (producto.Id != id) continue;
                producto.Cantidad = nuevaCantidad;
                producto.ActualizarCantidad();
                datosVentaGrid[3, _posicion].Value = producto.PrecioFinal.ToString("C0");
            }

        }

        private void codeListener_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
