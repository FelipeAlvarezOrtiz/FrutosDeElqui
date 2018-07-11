using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogicLayer
{
    public class CarroCompras : IDisposable
    {
        //Productos en carro es para el descuento
        public LinkedList<Producto> ProductosEnCarro { get; set; }

        //Proteccion Data debiese ser para calcular la wea de la UI y productos en carro para hacer el descuento 
        public LinkedList<ProteccionData> Proteccion { get; set; }
        public int TotalCarro { get => _totalCarro; set => _totalCarro = value; }

        private int _totalCarro;

        public class ProteccionData
        {
            /*Struct solo para desplegar data, las demas sera para hacer logica*/
            private int _id;
            private string _nombre;
            private int _precio;
            private int _cantidad;
            private int _precioFinal;

            public ProteccionData(int codigo, string name, int valor)
            {
                _id = codigo;
                _nombre = name;
                _precio = valor;
                _cantidad = 1;
                PrecioFinal = valor;
            }

            public void ActualizarCantidad()
            {
                PrecioFinal = Cantidad * Precio;
            }

            public int Precio { get => _precio; set => _precio = value; }
            public string Nombre { get => _nombre; set => _nombre = value; }
            public int Id { get => _id; set => _id = value; }
            public int Cantidad { get => _cantidad; set => _cantidad = value; }
            public int PrecioFinal { get => _precioFinal; set => _precioFinal = value; }
        };

        public void Inicializar()
        {
            ProductosEnCarro = new LinkedList<Producto>();
            Proteccion = new LinkedList<ProteccionData>();
            _totalCarro = 0;
        }

        public int RefreshPrecioCarro()
        {
            //Refrescamos el total
            var aux = 0;
            foreach (var producto in Proteccion)
            {
                aux += producto.PrecioFinal;
            }

            _totalCarro = aux;
            return _totalCarro;
        }

        public void RemoverProducto(int codeId)
        {
            try
            {
                foreach (var producto in ProductosEnCarro.ToList())
                {
                    if (producto.Codigo == codeId)
                    {
                        ProductosEnCarro.Remove(producto);
                    }
                }
                
                foreach (var pro in Proteccion.ToList())
                {
                    if (pro.Id == codeId)
                    {
                        Proteccion.Remove(pro);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public void Dispose()
        {
            ProductosEnCarro = null;
            Proteccion = null;
        }

    }
}
