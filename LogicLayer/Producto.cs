using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public class Producto : IDisposable
    {
        private int _precio;
        private string _nombre;
        private int _codigo;
        private int _cantidad;
        private int _precioFinal;

        public Producto(int prec, string name,int code)
        {
            _precio = prec;
            _nombre = name;
            _codigo = code;
            _cantidad = 1;
            _precioFinal = Precio;
        }
       
        public string Nombre { get => _nombre; set => _nombre = value; }
        public int Precio { get => _precio; set => _precio = value; }
        public int Codigo { get => _codigo; set => _codigo = value; }
        public int Cantidad { get => _cantidad; set => _cantidad = value; }
        public int PrecioFinal { get => _precioFinal; set => _precioFinal = value; }

        public void Dispose()
        {
            _nombre = null;
        }

        public void ActualizarPrecioFinal()
        {
            PrecioFinal = Precio * Cantidad;
        }

    }

    public class producSQL
    {
        private int _id;
        private int _cantidad;

        public producSQL(int id, int cantidad,int cantidadIngresada)
        {
            _id = id;
            var aux = cantidad * cantidadIngresada;
            _cantidad = aux;
        }
        public int Id { get => _id; set => _id = value; }
        public int Cantidad { get => _cantidad; set => _cantidad = value; }
    }
}
