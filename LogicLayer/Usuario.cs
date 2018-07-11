using System;

namespace LogicLayer
{
    internal enum TipoUsuario : int
    {
        Administrador = 0,
        Standard = 1
    }
    public struct Usuario : IDisposable
    {
        #region Variables y Metodos de Acceso
        private int _rut;
        private string _nombre;
        private string _horaIngreso;
        private string _fechaIngreso;
        private int _rango;
        private TipoUsuario _tipo;

        public int Rut { get => _rut; set => _rut = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string HoraIngreso { get => _horaIngreso; set => _horaIngreso = value; }
        internal TipoUsuario Tipo { get => _tipo; set => _tipo = value; }
        public string FechaIngreso { get => _fechaIngreso; set => _fechaIngreso = value; }
        public int Rango { get => _rango; set => _rango = value; }

        #endregion

        #region Patron Dispose
        public void Dispose()
        {
        }
        #endregion


        public Usuario(int rut,string name,int rango)
        {
            _rut = rut;
            _nombre = name;
            _rango = rango;
            _horaIngreso = DateTime.Now.ToString("H:mm:ss");
            _fechaIngreso = DateTime.Now.ToString("yyyy-MM-dd");
            _tipo = TipoUsuario.Administrador;
        }


    }
}
