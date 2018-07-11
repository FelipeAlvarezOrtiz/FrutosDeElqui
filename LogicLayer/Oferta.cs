using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LogicLayer
{
     public struct Oferta : IDisposable
     {
        private string _nombreOferta;
        private int _code;
        private int _precio;

        public string NombreOferta { get => _nombreOferta; set => _nombreOferta = value; }
        public int Code { get => _code; set => _code = value; }
        public int Precio { get => _precio; set => _precio = value; }

        public void Dispose()
        {

        }
    }
}
