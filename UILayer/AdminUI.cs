using LogicLayer;
using System;
using System.Windows.Forms;

namespace UILayer
{
    public partial class AdminUi : Form
    {
        private Form _formlogUi;
        private Usuario _user;
        public AdminUi(Form uiEntrante,int rut)
        {
            InitializeComponent();
            _formlogUi = uiEntrante;
            //Aqui se inicializa el usuario, con el se plasmaran todas las demas actividades, sea vender y weas
            _user = Conexion.Instance.LlenarUsuario(rut);
            UiSetup();
        }

        private void UiSetup()
        {
            userPlace.Text = _user.Nombre;
            horaPlaceHolder.Text = _user.HoraIngreso;
        }

        private void NuevaVentaClick(object sender, EventArgs e) => new VentaUI(_user.Rut).Show();

        private void CerrandoForm(object sender, FormClosingEventArgs e)
        {
            Conexion.Instance.InsertarLogin(_user.Rut,_user.HoraIngreso, DateTime.Now.ToString(format: "H:mm:ss"), _user.FechaIngreso);
            _formlogUi.Show();
            _formlogUi = null;
            _user.Dispose();
        }

        private void TickEvent(object sender, EventArgs e) => horaActualLabel.Text = DateTime.Now.ToLongTimeString();

        private void CloseSessionButton_Click(object sender, EventArgs e) => Close();

        private void ClickEgresoEvent(object sender, EventArgs e) => new Egreso(_user.Rut,userPlace.Text).Show();

        private void ProductoEvent(object sender, EventArgs e)
        {
            if (_user.Rango == 1)
            {
                new ControlModuloscs(_user.Rut).Show();
            }
            else
            {
                MessageBox.Show(this, "Debes tener rango de administrador para agregar y modificar productos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            

        }
        private void NewUserEvent(object sender, EventArgs e)
        {
            //Aqui Form de agregar Usuario
            if (_user.Rango == 1) {
                new NuevoUsuario().Show();
            }
            else
            {
                MessageBox.Show(this,"Debes tener rango de administrador para agregar usuarios nuevos","Error",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void UserReportButton_Click(object sender, EventArgs e)
        {
            new ReporteUsuarios().Show();
        }

        private void VentaClickEvent(object sender, EventArgs e)
        {
            new ModuloInformesVentas().Show();
        }

        private void InventarioClickEvent(object sender, EventArgs e)
        {
            new AgregarStock(_user.Rut).Show();
        }

        private void IngresoClick(object sender, EventArgs e)
        {
            new IngresoForm(_user.Rut,userPlace.Text).Show();
        }

        private void ModifyOfertasClick(object sender, EventArgs e)
        {
            new OfertasPanel().Show();
        }

        private void StockMovEvent(object sender, EventArgs e)
        {
            //MessageBox.Show(this, "No Disponible", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            new ReportManager().ImprimirEgreso(21,32,"xd","xd");
        }
    }
}
