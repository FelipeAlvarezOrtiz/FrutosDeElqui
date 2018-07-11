using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Int32;

namespace LogicLayer
{
    public class Conexion : IDisposable
    {
        private static readonly Lazy<Conexion> instance = new Lazy<Conexion>(()=> new Conexion());
        private string _dataSource = "DESKTOP-1SS3IN5";
        //private string _dataSource = "DESKTOP-UI2EHT2\\ANTUSQLSERVER";
        private string _userId = "sa";
        private string _pw = "felipe2-";
        private string _catalogoInicial = "FRUTOS_DE_ELQUI";
        internal SqlConnectionStringBuilder Builder;
        internal static SqlConnection conexion = null;

        private Conexion()
        {
            try
            {
                Builder = new SqlConnectionStringBuilder
                {
                    DataSource = _dataSource,
                    UserID = _userId,
                    Password = _pw,
                    InitialCatalog = _catalogoInicial
                };
                conexion = new SqlConnection(Builder.ConnectionString);
                conexion.Open();
            }
            catch (SqlException)
            {
                MessageBox.Show(null, "Error al Conectar a la base de datos", "Error FATAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static Conexion Instance => instance.Value;

        public void SetUp(string inDataSource,string inUserId, string inPw,string inCatalogoInicial)
        {
            conexion?.Close();
            try
            {
                Builder = new SqlConnectionStringBuilder
                {
                    DataSource = inDataSource,
                    UserID = inUserId,
                    Password = inPw,
                    InitialCatalog = inCatalogoInicial
                };
                conexion = new SqlConnection(Builder.ConnectionString);
                conexion.Open();
            }
            catch (SqlException)
            {
                MessageBox.Show(null, "Error al conectar a la BD con los datos proporcionados", "Error Fatal",
                    MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        #region IDisposable Support
        private bool _disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                _disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~Conexion() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        void IDisposable.Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion

        public bool ExisteUsuario(int rutEntrante,string contrasena)
        {
            try
            {
                var cmd = new SqlCommand
                {
                    Connection = conexion,
                    CommandText = "dbo.UsuarioValido",
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@rut", rutEntrante);
                cmd.Parameters.AddWithValue("@pw", contrasena);
                var retValue = cmd.Parameters.Add("return", SqlDbType.Int);
                retValue.Direction = ParameterDirection.ReturnValue;
                cmd.ExecuteNonQuery();

                return Parse(retValue.Value.ToString()) == 1;
            }
            catch (SqlException)
            {
                MessageBox.Show(null, text: "Error al intentar consultar en la BD.", caption: "Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                return false;
            }
        }

        public bool ValidarRut(string rut)
        {
            bool validacion = false;
            try
            {
                rut = rut.ToUpper();
                int rutAux = Parse(rut.Substring(0, rut.Length - 1));

                char dv = char.Parse(rut.Substring(rut.Length - 1, 1));

                int m = 0, s = 1;
                for (; rutAux != 0; rutAux /= 10)
                {
                    s = (s + rutAux % 10 * (9 - m++ % 6)) % 11;
                }
                if (dv == (char)(s != 0 ? s + 47 : 75))
                {
                    validacion = true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return validacion;
        }

        public Usuario LlenarUsuario(int rut)
        {
            try
            {
                var cmd = new SqlCommand("Select Nombre, RUT_Vendedor, rango From dbo.Usuario where dbo.Usuario.RUT_VENDEDOR = " + rut,
                    conexion);
                var dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    //Con 1 es admin, con 0 es normal
                    var userAux = new Usuario(int.Parse(Convert.ToString(dr["RUT_VENDEDOR"])),
                        Convert.ToString(dr["Nombre"]),int.Parse(Convert.ToString(dr["rango"])));
                    dr.Close();
                    return userAux;
                }
                else
                {
                    return new Usuario();
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(null, e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new Usuario();
            }
        }
        public bool SetEgreso(long idMovimiento, int cantidad,int rut, string fecha, string hora,string motivo)
        {
            try
            {
                var cmd = new SqlCommand
                {
                    Connection = conexion,
                    CommandText = "dbo.InsertarEgreso",
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@movDinero_id", idMovimiento);
                cmd.Parameters.AddWithValue("@cantidad", cantidad);
                cmd.Parameters.AddWithValue("@fecha", fecha);
                cmd.Parameters.AddWithValue("@rut", rut);
                cmd.Parameters.AddWithValue("@hora", hora);
                cmd.Parameters.AddWithValue("@razon", motivo);
                var result = cmd.ExecuteNonQuery();
                if (result == 0)
                {
                    MessageBox.Show(null, "La query Insertar Egreso no hizo efecto", "Error");
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (SqlException)
            {
                MessageBox.Show(null, "Error al Insertar un Egreso de Dinero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public void InsertarLogin(int rut, string horaIn, string horaOut, string fecha)
        {
            try
            {
                var cmd = new SqlCommand
                {
                    Connection = conexion,
                    CommandText = "dbo.InsertarLogLogin",
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@rut", rut);
                cmd.Parameters.AddWithValue("@horaIn", horaIn);
                cmd.Parameters.AddWithValue("@horaOut", horaOut);
                cmd.Parameters.AddWithValue("@fecha", fecha);
                var result = cmd.ExecuteNonQuery();
                if (result == 0)
                {
                    MessageBox.Show(null, "La query Insertar Login no hizo efecto", "Error");
                }
            }
            catch (SqlException)
            {
                MessageBox.Show(null, text: "Error al insertar en la LOG.", caption: "Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }
        }

        public bool ExisteEnOferta(int codigo)
        {
            //Consulta en Tabla Oferta si el codigo pertenece
            try
            {
                var cmd = new SqlCommand("Select Nombre_Oferta From dbo.Ofertas where dbo.Ofertas.IDOferta = " + codigo,
                    conexion);
                var dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    return true;
                }
                else
                {
                    dr.Close();
                    return false;
                }
            }
            catch (SqlException)
            {
                MessageBox.Show(null, "Error al Consultar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool ExisteEnProductos(int codigo)
        {
            try
            {
                var cmd = new SqlCommand(
                    "Select Nombre From dbo.Productos where dbo.Productos.Codigo_Barra = " + codigo,
                    conexion);
                var dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    return true;
                }
                else
                {
                    dr.Close();
                    return false;
                }
            }
            catch (SqlException)
            {
                MessageBox.Show(null, "Error al Consultar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public void LlenarCarroConProductos(CarroCompras carro, int code,string tipoVenta)
        {
            var aux = tipoVenta.CompareTo("Venta al Detalle") == 0 ? "Precio" : "Precio_Mayor";
            try
            {
                var cmd = new SqlCommand("select Codigo_Barra, Nombre,Medida, "+aux+" from dbo.PRODUCTOS where dbo.PRODUCTOS.CODIGO_BARRA =  " + code,
                    conexion);
                var dr = cmd.ExecuteReader();
                if (!dr.Read()) return;
                var nombreArmado = Convert.ToString(dr["Nombre"]) +" "+ Convert.ToString(dr["Medida"]);
                var productoAux = new CarroCompras.ProteccionData(int.Parse(Convert.ToString(dr["Codigo_Barra"])),nombreArmado,int.Parse(Convert.ToString(dr[aux])));
                carro.Proteccion.AddLast(productoAux);
                //Tener presente que mejor llenar y crear los productos para el descuento y toa la wea al finalizar la compra
                var productoFinal = new Producto(int.Parse(Convert.ToString(dr[aux])),nombreArmado, int.Parse(Convert.ToString(dr["Codigo_Barra"])));
                carro.ProductosEnCarro.AddLast(productoFinal);
                carro.RefreshPrecioCarro();
                dr.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show(null, "Error al Consultar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LlenarCarroConOfertas(CarroCompras carro, int code, string tipoVenta,DataGridView tabla)
        {
            //Hay que tener una lista para mostrar proteccion data y la otra tendra para 
            var aux = tipoVenta.CompareTo("Venta al Detalle") == 0 ? "Precio" : "Precio_Mayor";
            try
            {
                var cmd = new SqlCommand("select IDOferta, Nombre_Oferta ,Precio from dbo.Ofertas where dbo.Ofertas.IDOferta =  " + code,
                    conexion);
                var dr = cmd.ExecuteReader();
                if (!dr.Read()) return;
                var productoAux = new CarroCompras.ProteccionData(int.Parse(Convert.ToString(dr["IDOferta"])), 
                                                                    Convert.ToString(dr["Nombre_Oferta"]), 
                                                                    int.Parse(Convert.ToString(dr["Precio"])));
                carro.Proteccion.AddLast(productoAux);
                tabla.Rows.Add(int.Parse(Convert.ToString(dr["IDOferta"])),Convert.ToString(dr["Nombre_Oferta"]),1,Convert.ToString(dr["Precio"]));
                
                //var productoFinal = new Producto(int.Parse(Convert.ToString(dr[aux])), nombreArmado, int.Parse(Convert.ToString(dr["Codigo_Barra"])));
                //carro.ProductosEnCarro.AddLast(productoFinal);
                carro.RefreshPrecioCarro();
                dr.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show(null, "Error al Consultar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void TransaccionVenta(CarroCompras carro, int rutAutorizante, int precioFinal,string tipoVenta,string tipoPago)
        {
            //Creamos una lista con todos los productos y sus cantidad que seran para descontar, estos no necesitan precio
            if (carro.Proteccion.Count == 0)
            {
                MessageBox.Show(null, "Agrege productos al carro", "Error");
            }

            var productosCarro = new LinkedList<producSQL>();
            var hora = DateTime.Now.ToString(format: "H:mm:ss");
            var fecha = DateTime.Now.ToString(format: "yyyy-MM-dd");
            var idMovStockchar = DateTime.Now.ToString("ddMMyyyyHmmssff");
            var idMovStock = long.Parse(idMovStockchar);
            //Loop para crear la Lista de productos
            Console.WriteLine(precioFinal);
            foreach (var producto in carro.Proteccion)
            {
                //Console.WriteLine("El id del producto es "+producto.Id+" y la cantidad elegida es "+producto.Cantidad);
                if (ExisteEnProductos(producto.Id))
                {
                    var encontrado = false;
                    foreach (var pro in productosCarro)
                    {
                        if (pro.Id != producto.Id) continue;
                        pro.Cantidad += producto.Cantidad;
                        encontrado = true;
                    }
                    if (encontrado) continue;
                    var aux = new producSQL(producto.Id, producto.Cantidad,1);
                    productosCarro.AddLast(aux);
                }
                else if (ExisteEnOferta(producto.Id))
                {
                    //Aqui va la consulta para pedir los ID de los codigos y la cantidad para la multiplicacion
                    var cmd = new SqlCommand(
                        "select Codigo_Barra,Cantidad from dbo.Productos_en_Oferta where dbo.Productos_en_Oferta.IDOferta =  " +
                        producto.Id,
                        conexion);
                    var dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            #region Codigo Descontinuado
                            /*var encontrado = false;
                            var codigoBarraenConsulta = int.Parse(Convert.ToString(dr.GetValue(0)));
                            var cantidadEnConsulta = int.Parse(Convert.ToString(dr.GetValue(1)));
                            foreach (var pro in productosCarro)
                            {
                                if (pro.Id == codigoBarraenConsulta)
                                {
                                    pro.Cantidad += cantidadEnConsulta;
                                    encontrado = true;
                                }
                            }

                            if (!encontrado)
                            {
                                var aux = new producSQL(int.Parse(Convert.ToString(dr.GetValue(0))),
                                    int.Parse(Convert.ToString(dr.GetValue(1))));
                                productosCarro.AddLast(aux);
                            }*/
                            #endregion

                            var encontrado = false;
                            var codigoObtenido = int.Parse(dr.GetValue(0).ToString());
                            var cantidadObtenida = int.Parse(dr.GetValue(1).ToString());
                            //Console.WriteLine("El codigo es {0} y cantidad es {1}", codigoObtenido, cantidadObtenida);
                            foreach (var pro in productosCarro)
                            {
                                if (pro.Id == codigoObtenido)
                                {
                                    //var aux = pro.Cantidad * cantidadObtenida;
                                    pro.Cantidad += cantidadObtenida;
                                    encontrado = true;
                                }
                            }

                            if (!encontrado)
                            {
                                var aux = new producSQL(codigoObtenido,cantidadObtenida,producto.Cantidad);
                                productosCarro.AddLast(aux);
                            }
                        }
                    }

                    dr.Close();
                }
                else
                {
                    MessageBox.Show(null, "Error", "Error");
                }
            }

            //Generarmos el codigo de Dinero
            var idMovDinerochar = DateTime.Now.ToString("ddMMyyyyHmmssff");
            var idMovDinero = long.Parse(idMovDinerochar);
            //Aqui va el loop de update 
            //InsertarMovimientoStock(idMovStock,fecha,hora);
            InsertarStockMov(idMovStock);
            foreach (var prox in productosCarro)
            {
                //Console.WriteLine("El id del producto es " + prox.Id + " y la cantidad elegida es " + prox.Cantidad);
                ModificarStock(prox.Id,prox.Cantidad);
                InsertarMovimientoStock(idMovStock,prox.Id,prox.Cantidad);
            }
            //Aqui hacemos el insert de todos los datos ya sea movimiento de stock y de dinero
            InsertarMovDineroConVenta(idMovDinero,fecha,hora,precioFinal);
            var idVenta = long.Parse(DateTime.Now.ToString("ddMMyyyyHmmssff"));

            InsertarVenta(idVenta,idMovDinero,idMovStock,rutAutorizante,tipoVenta,tipoPago,fecha,hora);
            MessageBox.Show(null, "La venta fue ingresada con éxito al Sistema", "Información",MessageBoxButtons.OK,MessageBoxIcon.Information);
            //Aqui al final deberia ir un foreach en carro.Protección para llenar Datos_Venta
            foreach (var proc in carro.Proteccion)
            {
                InsertarDatosVenta(idVenta,proc.Id,proc.Cantidad,proc.Precio,proc.PrecioFinal);
            }
        }

        public void InsertarDatosVenta(long idVenta,int codigo,int cantidad, int precioUnidad,int precioFinal)
        {
            try
            {
                var cmd = new SqlCommand
                {
                    Connection = conexion,
                    CommandText = "dbo.InsertarDatosVenta",
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@codigoVenta", idVenta);
                cmd.Parameters.AddWithValue("@codigo", codigo);
                cmd.Parameters.AddWithValue("@cantidad", cantidad);
                cmd.Parameters.AddWithValue("@precioUnitario", precioUnidad);
                cmd.Parameters.AddWithValue("@precioTotal", precioFinal);
                if (cmd.ExecuteNonQuery() == 0)
                {
                    Console.WriteLine("Error datosVenta no hizo efecto");   
                }

            }
            catch (SqlException e)
            {
                MessageBox.Show(null, "Error al ingresar query de InsertarDatosVentas con excepción en "+e.Message, "Error");
            }
        }

        public void InsertarStockMov(long idMov)
        {
            try
            {
                var cmd = new SqlCommand("Insert into Movimiento_Stock(ID_StockMov) values("+idMov+")",conexion);
                if (cmd.ExecuteNonQuery() == 0)
                {
                    Console.WriteLine("Error al insetar stock Mov");
                }
            }
            catch (SqlException)
            {
                MessageBox.Show(null, "La query Insertar MovimientoStock no hizo efecto", "Error");
            }
        }
        public void ModificarStock(int id, int cantidad)
        {
            var cmdCantidad = new SqlCommand("Select Cantidad from dbo.Tienda where dbo.Tienda.Codigo_prodc = "+id,conexion);
            var drCantidad = cmdCantidad.ExecuteReader();
            if (drCantidad.Read())
            {
                var cantidadActual = int.Parse(drCantidad.GetValue(0).ToString());
                drCantidad.Close();
                cantidadActual -= cantidad;
                var cmd = new SqlCommand(
                    "UPDATE dbo.Tienda SET Cantidad = " + cantidadActual + " where dbo.Tienda.Codigo_prodc =  " + id,
                    conexion);
                var dr = cmd.ExecuteReader();
                dr.Close();
            }
            else
            {
                MessageBox.Show(null, "Error de lectura del reader en Modificar Stock", "Error");
            }

        }
        //Este se crea primero
        public void InsertarMovimientoStock(long idMov,int codigo, int cantidad)
        {
            try
            {
                var cmd = new SqlCommand
                {
                    Connection = conexion,
                    CommandText = "dbo.InsertarMovimientoStock",
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@movDinero_id", idMov);
                cmd.Parameters.AddWithValue("@codigo", codigo);
                cmd.Parameters.AddWithValue("@cantidad", cantidad);
                var result = cmd.ExecuteNonQuery();
                if (result == 0)
                {
                    MessageBox.Show(null, "La query Insertar MovimientoStock no hizo efecto", "Error");
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(null, text: "Error al insertar en la LOG con excepción : "+e.Message, caption: "Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }
        }

        #region Codigo Descontinuado
        //Aqui insertamos carro de Compras
        public void InsertarCarroCompras(long idMovStock,int codigoBarra,int cantidad)
        {
            try
            {
                var cmd = new SqlCommand
                {
                    Connection = conexion,
                    CommandText = "dbo.InsertarCarroCompras",
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@movStockId", idMovStock);
                cmd.Parameters.AddWithValue("@code", codigoBarra);
                cmd.Parameters.AddWithValue("@cantidad", cantidad);
                var result = cmd.ExecuteNonQuery();
                if (result == 0)
                {
                    MessageBox.Show(null, "La query Insertar MovimientoStock no hizo efecto", "Error");
                }
            }
            catch (SqlException)
            {
                MessageBox.Show(null, text: "Error al insertar en la LOG.", caption: "Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }
        }
#endregion
        
        //Aqui creamos el Mov de dinero
        public void InsertarMovDineroConVenta(long idMovDinero,string fecha, string hora,int cantidadDineroFinal)
        {
            try
            {
                var cmd = new SqlCommand
                {
                    Connection = conexion,
                    CommandText = "dbo.InsertarMovimientoDineroConVenta",
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@movStockId", idMovDinero);
                cmd.Parameters.AddWithValue("@fecha", fecha);
                cmd.Parameters.AddWithValue("@hora", hora);
                cmd.Parameters.AddWithValue("@precioFinal", cantidadDineroFinal);
                var result = cmd.ExecuteNonQuery();
                if (result == 0)
                {
                    MessageBox.Show(null, "La query Insertar MovimientoStock no hizo efecto", "Error");
                }
            }
            catch (SqlException)
            {
                MessageBox.Show(null, text: "Error al insertar en la LOG.", caption: "Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }
        }
        //Aqui insertamos la venta y ahi se cierra la venta Finalmente
        public void InsertarVenta(long idVenta,long idMovDinero, long idMovStock,int rut,string tipoVenta, string tipoPago,string fecha, string hora)
        {
            //Hay que generar otro codigo de Venta con el mismo proceso
            try
            {
                var cmd = new SqlCommand
                {
                    Connection = conexion,
                    CommandText = "dbo.InsertarVenta",
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@movStockId", idMovStock);
                cmd.Parameters.AddWithValue("@movDineroId", idMovDinero);
                cmd.Parameters.AddWithValue("@idVenta", idVenta);
                cmd.Parameters.AddWithValue("@rut", rut);
                cmd.Parameters.AddWithValue("@tipoVenta", tipoVenta);
                cmd.Parameters.AddWithValue("@tipoPago", tipoPago);
                cmd.Parameters.AddWithValue("@fecha", fecha);
                cmd.Parameters.AddWithValue("@hora", hora);

                var result = cmd.ExecuteNonQuery();
                if (result == 0)
                {
                    MessageBox.Show(null, "La query Insertar MovimientoStock no hizo efecto", "Error");
                }
            }
            catch (SqlException)
            {
                MessageBox.Show(null, text: "Error al insertar en la LOG.", caption: "Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }
        }

        //Nota crear para anular ventas, lo que si no habria seria si saber cual fue con oferta o no

        //El modificarStock podria servir para agregar stock reutilizacion de codigo

        //Crear las querys para las consultas entre fechas, saber el dinero que entro, y saber los logs del dia

        public void InsertarProductoNuevo(int code,string nombre,string medidad,int precioDetalle, int precioMayor,string categoria,int stockInicial)
        {
            try
            {
                var cmd = new SqlCommand
                {
                    Connection = conexion,
                    CommandText = "dbo.IngresarNuevoProducto",
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@code",code);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@medida", medidad);
                cmd.Parameters.AddWithValue("@precioDetalle", precioDetalle);
                cmd.Parameters.AddWithValue("@precioMayor", precioMayor);
                cmd.Parameters.AddWithValue("@categoria", categoria);
                if (cmd.ExecuteNonQuery() == 0)
                {
                    MessageBox.Show(null, "La query Insertar Nuevo Producto no hizo efecto", "Error");
                }

                var cmdStock = new SqlCommand("INSERT INTO dbo.Tienda(Codigo_Prodc,Cantidad) values("+code+","+stockInicial+")",conexion);
                if (cmdStock.ExecuteNonQuery() == 0)
                {
                    Console.WriteLine("Error");
                }
            }
            catch (SqlException)
            {
                MessageBox.Show(null, "Error al insertar nuevo producto, contacte con Felipe Alvarez", "Error");
            }
        }

        public bool VerificarDisponibilidadDeCodigo(int code)
        {
            var cmd = new SqlCommand("Select Codigo_Barra from dbo.Productos where dbo.Productos.Codigo_Barra = "+code,conexion);
            var result = cmd.ExecuteReader();
            if (result.HasRows)
            {
                result.Close();
                return true;
            }
            else
            {
                result.Close();
                return false;
            }
        }

        public void InsertarNuevoUsuario(int rut, string nombre,string celular, string email,string password,int rango)
        {
            var cmdIn = new SqlCommand("Select RUT_VENDEDOR from dbo.Usuario where dbo.Usuario.RUT_VENDEDOR = "+rut,conexion);
            var read = cmdIn.ExecuteReader();
            if (!read.HasRows)
            {
                read.Close();
                var cmd = new SqlCommand
                {
                    Connection = conexion,
                    CommandText = "dbo.InsertarUsuarioNuevo",
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@rut", rut);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@celular", celular);
                cmd.Parameters.AddWithValue("@mail", email);
                cmd.Parameters.AddWithValue("@pass", password);
                cmd.Parameters.AddWithValue("@rango",rango);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show(null, "El usuario se ha ingresado correctamente", "Éxito");
                }
                else
                {
                    Console.WriteLine("Error de ingreso");
                }
                
            }
            else
            {
                MessageBox.Show(null, "Ese RUT ya esta asociado a una cuenta", "Error");
                read.Close();
            }
        }

        public void LlenarGridBusqueda(string fechaInicio,string fechaFinal, DataGridView datagrid)
        {
            try
            {
                datagrid.DataSource = null;
                var da = new SqlDataAdapter("Select B.Nombre,B.RUT_VENDEDOR,A.HORA_INGRESO,A.HORA_EGRESO,A.FECHA from dbo.Login_log as A, dbo.Usuario as B where A.RUT_VENDEDOR = B.RUT_VENDEDOR and A.fecha between '" + fechaInicio + "' and '"+ fechaFinal + "'",conexion);
                var dt = new DataTable();
                da.Fill(dataTable: dt); 
                datagrid.DataSource = dt;
            }
            catch (SqlException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        public void InventarioProductos( DataGridView dataGrid)
        {
            try
            {
                dataGrid.DataSource = null;
                var da = new SqlDataAdapter("Select A.Codigo_Barra,A.Nombre,A.Medida,B.Cantidad from dbo.Productos as A, dbo.Tienda as B where A.Codigo_Barra = B.Codigo_Prodc",conexion);
                var dt = new DataTable();
                da.Fill(dataTable: dt); 
                dataGrid.DataSource = dt;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void LlenarGridBusquedaVenta(string fechaInicio,string fechaFin, DataGridView dataGrid)
        {
            try
            {
                var da = new SqlDataAdapter("Select A.ID_Venta, C.RUT_VENDEDOR, C.Nombre, A.Tipo_Transaccion,A.Tipo_Venta, A.fecha, A.Hora,B.Cantidad" +
                                            " from dbo.Venta as A,dbo.Movimiento_Dinero as B, dbo.Usuario as C where A.ID_MovDinero = B.ID_MovDinero and A.RUT_VENDEDOR = C.RUT_VENDEDOR " +
                                            "and A.Fecha between '"+fechaInicio+"' and '"+fechaFin+"' and A.Validez = 1",conexion);
                var dt = new DataTable();
                da.Fill(dt);
                dataGrid.DataSource = dt;
                
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void LlenarGridEgresos(string fechaInicio,string fechaFin, DataGridView dataGrid)
        {

            try
            {
                var da = new SqlDataAdapter("Select C.RUT_VENDEDOR, C.Nombre, C.Celular, B.Fecha, B.hora, A.Motivo, B.Cantidad" +
                                            " from dbo.Egreso as A,dbo.Movimiento_Dinero as B, dbo.Usuario as C where A.ID_MovDinero = B.ID_MovDinero and A.RUT_VENDEDOR = C.RUT_VENDEDOR " +
                                            "and B.Fecha between '" + fechaInicio + "' and '" + fechaFin+"'", conexion);
                var dt = new DataTable();
                da.Fill(dt);
                dataGrid.DataSource = dt;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void LlenarDatosModificacionProducto(TextBox name,TextBox precioDetalle,TextBox precioMayor,TextBox medida,TextBox categoria, int codeId,CheckBox validez,TextBox stockBox)
        {
            try
            {
                var cmd = new SqlCommand("Select A.Codigo_Barra, A.Nombre, A.Precio, A.Medida, A.Precio_Mayor,A.Categoria, A.Validez,B.Cantidad from dbo.Productos as A, dbo.Tienda as B where A.Codigo_Barra ="+codeId+" and B.Codigo_Prodc = "+codeId,conexion);
                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    name.Text = Convert.ToString(reader["Nombre"]);
                    precioDetalle.Text = Convert.ToString(reader["Precio"]);
                    precioMayor.Text = Convert.ToString(reader["Precio_Mayor"]);
                    medida.Text = Convert.ToString(reader["Medida"]);
                    categoria.Text = Convert.ToString(reader["Categoria"]);
                    stockBox.Text = Convert.ToString(reader["Cantidad"]);
                    var enStock = (bool) reader["Validez"];
                    validez.CheckState = enStock ? CheckState.Checked : CheckState.Unchecked;

                    reader.Close();
                }
                else
                {
                    Console.WriteLine("La query no hizo efecto al consultar por el Producto");
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void ModificarProducto(int codeId,string name, int precioDetalle,int precioMayor, string medida, string cateogoria, bool validez,int stock)
        {
            try
            {
                //Aqui un UPDATE
                var enVenta = 1;
                if (!validez)
                {
                    enVenta = 0;
                }
                var cmd = new SqlCommand
                {
                    Connection = conexion,
                    CommandText = "dbo.ModificarProducto",
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@codeId", codeId);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@medida", medida);
                cmd.Parameters.AddWithValue("@precioDetalle", precioDetalle);
                cmd.Parameters.AddWithValue("@precioMayor", precioMayor);
                cmd.Parameters.AddWithValue("@categoria", cateogoria);
                cmd.Parameters.AddWithValue("@validez", enVenta);
                if (cmd.ExecuteNonQuery() == 0)
                {
                    Console.WriteLine("Error de UPDATE en la BD");
                }

                var cmdStock = new SqlCommand("UPDATE dbo.Tienda SET dbo.Tienda.Cantidad = "+stock+" where dbo.Tienda.Codigo_Prodc = "+codeId,conexion);
                if (cmdStock.ExecuteNonQuery() == 0)
                {
                    Console.WriteLine("Error");
                }
            }
            catch (SqlException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        public void LlenarDatosProducto(int codeId, TextBox name,TextBox precio,TextBox disponibilidad,TextBox categoria,TextBox medida)
        {
            try
            {
                if (VerificarDisponibilidadDeCodigo(codeId))
                {
                    var cmd = new SqlCommand("Select Nombre,Precio,Categoria,Medida from dbo.Productos where dbo.Productos.Codigo_Barra = "+codeId,conexion);
                    var reader = cmd.ExecuteReader();
                    if (!reader.Read()) return;
                    name.Text = Convert.ToString(reader["Nombre"]);
                    precio.Text = Convert.ToString(reader["Precio"]);
                    categoria.Text = Convert.ToString(reader["Categoria"]);
                    medida.Text = Convert.ToString(reader["Medida"]);
                    reader.Close();
                    var cmd2 = new SqlCommand("Select Cantidad from dbo.Tienda where dbo.Tienda.Codigo_Prodc = "+codeId,conexion);
                    var reader2 = cmd2.ExecuteReader();
                    if (!reader2.Read()) return;
                    disponibilidad.Text = Convert.ToString(reader2["Cantidad"]);
                    reader2.Close();
                }
                else
                {
                    MessageBox.Show(null, "El codigo no corresponde a un producto registrado en la Base de Datos",
                        "Información");
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void LlenarGridIngresos(string fechaInicio,string fechaFinal,DataGridView dataGrid)
        {
            try
            {
                var da = new SqlDataAdapter("Select C.RUT_VENDEDOR, C.Nombre, C.Celular, B.Fecha, B.hora, A.Motivo, B.Cantidad" +
                                            " from dbo.Ingresos as A,dbo.Movimiento_Dinero as B, dbo.Usuario as C where A.ID_MovDinero = B.ID_MovDinero and A.RUT_VENDEDOR = C.RUT_VENDEDOR " +
                                            "and B.Fecha between '" + fechaInicio + "' and '" + fechaFinal + "'", conexion);
                var dt = new DataTable();
                da.Fill(dt);
                dataGrid.DataSource = dt;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void LlenarGridProductosDeOferta(int idOferta,DataGridView dataGrid,TextBox nombre, TextBox precio)
        {
            try
            {
                dataGrid.DataSource = null;
                var da = new SqlDataAdapter("select DISTINCT A.CODIGO_BARRA, A.CANTIDAD from dbo.PRODUCTOS_EN_OFERTA as A, dbo.OFERTAS as B where A.IDOFERTA ="+idOferta, conexion);
                var dt = new DataTable();
                da.Fill(dt);
                dataGrid.DataSource = dt;
                var cmdConsulta = new SqlCommand("Select Nombre_Oferta,Precio from dbo.Ofertas where dbo.Ofertas.IDOferta = "+idOferta,conexion);
                var readerCmd = cmdConsulta.ExecuteReader();
                if (readerCmd.Read())
                {
                    if (readerCmd.HasRows)
                    {
                        nombre.Text = readerCmd.GetValue(0).ToString();
                        precio.Text = readerCmd.GetValue(1).ToString();
                    }
                }
                readerCmd.Close();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        
        public void SetGananciasPerdidas(string fechaInicio, string fechaFinal,DataGridView dataGridVentas,DataGridView dataGridEgresos,
                                        TextBox efectivoBox,TextBox tarjetaBox,TextBox mayorBox,TextBox detalleBox,TextBox ganaciaTotal, TextBox egresosBox,TextBox creditoBox
                                        ,DataGridView dataGridIngresos, TextBox ingresosBox)
        {
            LlenarGridBusquedaVenta(fechaInicio,fechaFinal,dataGridVentas);
            LlenarGridEgresos(fechaInicio,fechaFinal,dataGridEgresos);
            LlenarGridIngresos(fechaInicio,fechaFinal,dataGridIngresos);
            try
            {
                #region Efectivo Ganado
                var cmdEfectivoGanado = new SqlCommand(
                    "Select SUM(A.Cantidad) from dbo.Movimiento_Dinero as A,dbo.Venta as B " +
                    "where B.VALIDEZ = 1 and A.ID_MOVDINERO = B.ID_MOVDINERO and B.Fecha between '" + fechaInicio + "' and '" +
                    fechaFinal + "' and " +
                    "B.Tipo_Venta = 'Efectivo'", conexion);
                var readerEfectivo = cmdEfectivoGanado.ExecuteReader();
                if (readerEfectivo.Read())
                {
                    var aux = readerEfectivo.GetValue(0).ToString();
                    if (aux.Length > 0)
                    {
                        efectivoBox.Text = int.Parse(aux).ToString("C0");
                        readerEfectivo.Close();
                    }
                    else
                    {
                        efectivoBox.Text = 0.ToString("C0");
                        readerEfectivo.Close();
                    }
                }
                else
                {
                    efectivoBox.Text = 0.ToString("C0");
                    readerEfectivo.Close();
                }
                #endregion

                #region Debito Ganado
                var cmdTarjeta = new SqlCommand(
                    "Select SUM(A.Cantidad) from dbo.Movimiento_Dinero as A,dbo.Venta as B " +
                    "where A.ID_MOVDINERO = B.ID_MOVDINERO and B.VALIDEZ = 1 and B.Fecha between '" + fechaInicio + "' and '" +
                    fechaFinal + "' and " +
                    "B.Tipo_Venta = 'Debito'", conexion);
                var readerTarjeta = cmdTarjeta.ExecuteReader();
                if (readerTarjeta.Read())
                {
                    var aux = readerTarjeta.GetValue(0).ToString();
                    if (aux.Length > 0)
                    {
                        tarjetaBox.Text = int.Parse(aux).ToString("C0");
                        readerTarjeta.Close();
                    }
                    else
                    {
                        tarjetaBox.Text = 0.ToString("C0");
                        readerTarjeta.Close();
                    }
                }
                else
                {
                    tarjetaBox.Text = 0.ToString("C0");
                    readerTarjeta.Close();
                }
                #endregion

                #region Credito Ganado
                var cmdCredito = new SqlCommand(
                    "Select SUM(A.Cantidad) from dbo.Movimiento_Dinero as A,dbo.Venta as B " +
                    "where B.VALIDEZ = 1 and A.ID_MOVDINERO = B.ID_MOVDINERO and B.Fecha between '" + fechaInicio + "' and '" +
                    fechaFinal + "' and " +
                    "B.Tipo_Venta = 'Credito'", conexion);
                var readerCredito = cmdCredito.ExecuteReader();
                if (readerCredito.Read())
                {
                    var aux = readerCredito.GetValue(0).ToString();
                    if (aux.Length > 0)
                    {
                        creditoBox.Text = int.Parse(aux).ToString("C0");
                        readerCredito.Close();
                    }
                    else
                    {
                        creditoBox.Text = 0.ToString("C0");
                        readerCredito.Close();
                    }
                }
                else
                {
                    creditoBox.Text = 0.ToString("C0");
                    readerCredito.Close();
                }

                #endregion

                #region Ventas al por Mayor
                var cmdMayor = new SqlCommand("Select SUM(A.Cantidad) from dbo.Movimiento_Dinero as A,dbo.Venta as B " +
                                              "where B.VALIDEZ = 1 and A.ID_MOVDINERO = B.ID_MOVDINERO and B.Fecha between '" +
                                              fechaInicio + "' and '" + fechaFinal + "' and " +
                                              "B.Tipo_Transaccion = 'Venta al Por Mayor'", conexion);
                var readerMayor = cmdMayor.ExecuteReader();
                if (readerMayor.Read())
                {
                    var aux = readerMayor.GetValue(0).ToString();
                    if (aux.Length > 0)
                    {
                        mayorBox.Text = int.Parse(aux).ToString("C0");
                        readerMayor.Close();
                    }
                    else
                    {
                        mayorBox.Text = 0.ToString("C0");
                        readerMayor.Close();
                    }
                }
                else
                {
                    mayorBox.Text = 0.ToString("C0");
                    readerMayor.Close();
                }
                #endregion

                #region Ventas al Detalle
                var cmdDetalle = new SqlCommand(
                    "Select SUM(A.Cantidad) from dbo.Movimiento_Dinero as A,dbo.Venta as B " +
                    "where B.VALIDEZ = 1 and A.ID_MOVDINERO = B.ID_MOVDINERO and B.Fecha between '" + fechaInicio + "' and '" +
                    fechaFinal + "' and " +
                    "B.Tipo_Transaccion = 'Venta al Detalle'", conexion);
                var readerDetalle = cmdDetalle.ExecuteReader();
                if (readerDetalle.Read())
                {
                    var aux = readerDetalle.GetValue(0).ToString();
                    if (aux.Length > 0)
                    {
                        detalleBox.Text = int.Parse(aux).ToString("C0");
                        readerDetalle.Close();
                    }
                    else
                    {
                        detalleBox.Text = 0.ToString("C0");
                        readerDetalle.Close();
                    }
                }
                else
                {
                    detalleBox.Text = 0.ToString("C0");
                    readerDetalle.Close();
                }
                #endregion

                #region Ganancia Total
                var cmdGanancia = new SqlCommand(
                    "Select SUM(A.Cantidad) from dbo.Movimiento_Dinero as A,dbo.Venta as B " +
                    "where B.VALIDEZ = 1 and A.ID_MOVDINERO = B.ID_MOVDINERO and B.Fecha between '" + fechaInicio + "' and '" +
                    fechaFinal + "'", conexion);
                var readerGanancia = cmdGanancia.ExecuteReader();
                if (readerGanancia.Read())
                {
                    var aux = readerGanancia.GetValue(0).ToString();
                    if (aux.Length > 0)
                    {
                        ganaciaTotal.Text = int.Parse(aux).ToString("C0");
                        readerGanancia.Close();
                    }
                    else
                    {
                        ganaciaTotal.Text = 0.ToString("C0");
                        readerGanancia.Close();
                    }
                }
                else
                {
                    ganaciaTotal.Text = 0.ToString("C0");
                    readerGanancia.Close();
                }
                #endregion

                #region Dinero de Egresos
                var cmdEgresos = new SqlCommand(
                    "Select SUM(A.Cantidad) from dbo.Movimiento_Dinero as A, dbo.Egreso as B "
                    + "where A.ID_MovDinero = B.ID_MovDinero and A.Fecha between '" + fechaInicio + "' and '" +
                    fechaFinal + "'", conexion);
                var readerEgresos = cmdEgresos.ExecuteReader();
                if (readerEgresos.Read())
                {
                    var aux = readerEgresos.GetValue(0).ToString();
                    if (aux.Length > 0)
                    {
                        egresosBox.Text = int.Parse(aux).ToString("C0");
                        readerEgresos.Close();
                    }
                    else
                    {
                        egresosBox.Text = 0.ToString("C0");
                        readerEgresos.Close();
                    }
                }
                else
                {
                    egresosBox.Text = 0.ToString("C0");
                    readerEgresos.Close();
                }
                #endregion

                #region Dinero de Ingresos
                var cmdIngresos = new SqlCommand(
                    "Select SUM(A.Cantidad) from dbo.Movimiento_Dinero as A, dbo.Ingresos as B "
                    + "where A.ID_MovDinero = B.ID_MovDinero and A.Fecha between '" + fechaInicio + "' and '" +
                    fechaFinal + "'", conexion);
                var readerIngresos = cmdIngresos.ExecuteReader();
                if (readerIngresos.Read())
                {
                    var aux = readerIngresos.GetValue(0).ToString();
                    if (aux.Length > 0)
                    {
                        ingresosBox.Text = int.Parse(aux).ToString("C0");
                        readerIngresos.Close();
                    }
                    else
                    {
                        ingresosBox.Text = 0.ToString("C0");
                        readerIngresos.Close();
                    }
                }
                else
                {
                    ingresosBox.Text = 0.ToString("C0");
                    readerIngresos.Close();
                }

                #endregion

            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        public void InsertarNuevoStock(ComboBox tipoBox,int cantidad, int codeId,int rut)
        {
            try
            {
                if (String.Compare(tipoBox.Text, "Ingreso", StringComparison.Ordinal) == 0)
                {
                    //Generarmos un codigo de Lote
                    var aux = DateTime.Now.ToString("ddMMyyyyHmmssff"); ;
                    var fecha = DateTime.Now.ToString("yyyy-MM-dd");
                    var hora = DateTime.Now.ToString("H:mm:ss");
                    var longIdLote = long.Parse(aux);
                    var cmdStock = new SqlCommand("Select Cantidad from dbo.Tienda where dbo.Tienda.Codigo_Prodc = "+codeId,conexion);
                    var stockReader = cmdStock.ExecuteReader();
                    if (stockReader.Read())
                    {
                        var cantidadActual = Convert.ToString(stockReader["Cantidad"]);
                        var cantidadNueva = int.Parse(cantidadActual) + cantidad;
                        stockReader.Close();
                        var nuevoCmd = new SqlCommand
                        {
                            Connection = conexion,
                            CommandText = "dbo.InsertarStockLote",
                            CommandType = CommandType.StoredProcedure
                        };
                        nuevoCmd.Parameters.AddWithValue("@rut", rut);
                        nuevoCmd.Parameters.AddWithValue("@IdLote", longIdLote);
                        nuevoCmd.Parameters.AddWithValue("@fecha", fecha);
                        nuevoCmd.Parameters.AddWithValue("@hora", hora);
                        nuevoCmd.Parameters.AddWithValue("@cantidad", cantidadNueva);
                        nuevoCmd.Parameters.AddWithValue("@code", codeId);
                        if (nuevoCmd.ExecuteNonQuery() == 0)
                        {
                            Console.WriteLine("Error al ingresar nuevo Stock");
                        }

                    }

                }
                else
                {
                    var aux = DateTime.Now.ToString("ddMMyyyyHmmssff"); ;
                    var fecha = DateTime.Now.ToString("yyyy-MM-dd");
                    var hora = DateTime.Now.ToString("H:mm:ss");
                    var longIdLote = long.Parse(aux);
                    var cmdStock = new SqlCommand("Select Cantidad from dbo.Tienda where dbo.Tienda.Codigo_Prodc = " + codeId, conexion);
                    var stockReader = cmdStock.ExecuteReader();
                    if (stockReader.Read())
                    {
                        var cantidadActual = Convert.ToString(stockReader["Cantidad"]);
                        var cantidadNueva = int.Parse(cantidadActual) - cantidad;
                        if (cantidadNueva >= 0)
                        {
                            stockReader.Close();
                            var nuevoCmd = new SqlCommand
                            {
                                Connection = conexion,
                                CommandText = "dbo.InsertarStockLote",
                                CommandType = CommandType.StoredProcedure
                            };
                            nuevoCmd.Parameters.AddWithValue("@rut", rut);
                            nuevoCmd.Parameters.AddWithValue("@IdLote", longIdLote);
                            nuevoCmd.Parameters.AddWithValue("@fecha", fecha);
                            nuevoCmd.Parameters.AddWithValue("@hora", hora);
                            nuevoCmd.Parameters.AddWithValue("@cantidad", cantidadNueva);
                            nuevoCmd.Parameters.AddWithValue("@code", codeId);
                            if (nuevoCmd.ExecuteNonQuery() == 0)
                            {
                                Console.WriteLine("Error al ingresar nuevo Stock");
                            }
                        }
                        else
                        {
                            MessageBox.Show(null, "La tienda no tiene suficiente Stock de ese producto", "Error");
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine( e.Message);
            }
        }

        public void AnularVenta(long codigoVenta)
        {
            try
            {
                #region Actualizar la Venta
                var cmdActualizarCommand = new SqlCommand(
                    "UPDATE dbo.Venta SET dbo.Venta.Validez = 0 where dbo.Venta.ID_Venta = " + codigoVenta, conexion);
                if (cmdActualizarCommand.ExecuteNonQuery() == 0)
                {
                    MessageBox.Show("Error", "Ninguna Row fue Afectada");
                }
                #endregion
                #region Obtenemos la cantidad para devolver los Stocks
                var cmdDevolverStock = new SqlCommand("Select B.Codigo_Barra,B.Cantidad from dbo.Venta as A,dbo.CARRO_COMPRAS as B "
                                                      + "where A.ID_STOCKMOV = b.ID_STOCKMOV and A.ID_VENTA = "+codigoVenta,conexion);
                var readerStock = cmdDevolverStock.ExecuteReader();
                Dictionary<int,int> carro = new Dictionary<int, int>();
                if (readerStock.HasRows)
                {
                    while (readerStock.Read())
                    {
                        var cantidad = int.Parse(readerStock.GetValue(1).ToString());
                        var codigoBarra = int.Parse(readerStock.GetValue(0).ToString());
                       carro.Add(codigoBarra,cantidad);
                    }
                }
                readerStock.Close();
                foreach (var producto in carro)
                {
                    var cmdActualizarStock = new SqlCommand("Select Cantidad from dbo.Tienda where dbo.Tienda.Codigo_Prodc = "+producto.Key, conexion);
                    var reader = cmdActualizarStock.ExecuteReader();
                    if (!reader.HasRows) continue;
                    if (!reader.Read()) continue;
                    var cantidadAntigua = int.Parse(reader.GetValue(0).ToString());
                    var cantidadNueva = producto.Value + cantidadAntigua;
                    reader.Close();
                    var cmdUpdate = new SqlCommand("Update dbo.Tienda SET cantidad = "+cantidadNueva+" where dbo.Tienda.Codigo_Prodc = "+producto.Key, conexion);
                    if (cmdUpdate.ExecuteNonQuery() == 0)
                    {
                        Console.WriteLine("Error de insertar nueva cantidad");
                    }
                }
                #endregion

                MessageBox.Show("Venta Anulada con Éxito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException exception)
            {
                MessageBox.Show("Error al intentar Anular la venta " + exception.Message, "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (NullReferenceException nullException)
            {
                MessageBox.Show("Seleccione una venta para Borrar " + nullException.Message,"Error" , MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        public void LlenarGridVentaDetalle(long idVenta ,DataGridView productosGrid)
        {
            try
            {
                var dataAdapterProductos = new SqlDataAdapter("Select Codigo, Cantidad, Precio_Unidad, Precio_Total from dbo.Datos_Venta where ID_Venta = "+idVenta,conexion);
                var dtProductos = new DataTable();
                dataAdapterProductos.Fill(dtProductos);
                productosGrid.DataSource = dtProductos;
            }
            catch (SqlException sqlException)
            {
                MessageBox.Show("Error : " + sqlException.Message, "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        public void ConsultarVentas(int id,TextBox total,TextBox ofertaBox, TextBox detalleBox,DataGridView ventasGridView,string fechaInicio,string fechaFinal)
        {
            try
            {
                var cmdDetalle = new SqlCommand("Select SUM(A.CANTIDAD) from DATOS_VENTA as A, VENTA as B where Codigo = "+id+" and A.ID_Venta = B.ID_Venta AND "+
                    " B.FECHA between '"+fechaInicio+"' and '"+fechaFinal+ "' and B.VALIDEZ = 1", conexion);
                var detalleReader = cmdDetalle.ExecuteReader();
                if (detalleReader.HasRows)
                {
                    while (detalleReader.Read())
                    {
                        var valor =detalleReader.GetValue(0).ToString(); 
                        detalleBox.Text = valor.Length > 0 ? valor : 0.ToString();
                    }

                    detalleReader.Close();
                }
                else
                {
                    detalleReader.Close();
                    detalleBox.Text = 0.ToString();
                }

                var cmdOfertas = new SqlCommand("select SUM(A.CANTIDAD) as Cantidad_Vendida from DATOS_VENTA as A , VENTA as C where A.CODIGO in "+
                    " (Select distinct B.IDOFERTA from PRODUCTOS_EN_OFERTA as B where B.CODIGO_BARRA = "+id+") and "+
                    " A.ID_VENTA = C.ID_VENTA and C.FECHA BETWEEN '"+fechaInicio+"' and '"+fechaFinal+"' and C.VALIDEZ = 1", conexion);
                var ofertasReader = cmdOfertas.ExecuteReader();
                if (ofertasReader.HasRows)
                {
                    while (ofertasReader.Read())
                    {
                        var valor = ofertasReader.GetValue(0).ToString();
                        ofertaBox.Text = valor.Length > 0 ? valor : 0.ToString();
                    }
                    ofertasReader.Close();
                }
                else
                {
                    ofertasReader.Close();
                    ofertaBox.Text = 0.ToString();
                }

                var totalVendido = int.Parse(detalleBox.Text) + int.Parse(ofertaBox.Text);
                total.Text = totalVendido.ToString();

                var dataAdapterDesgloce = new SqlDataAdapter("select SUM(A.CANTIDAD) as Cantidad_Vendida,A.CODIGO from DATOS_VENTA as A , VENTA as C where A.CODIGO in "+
                    " (Select distinct B.IDOFERTA from PRODUCTOS_EN_OFERTA as B where B.CODIGO_BARRA = "+id+ ") and A.ID_VENTA = C.ID_VENTA "+
                    "  and C.FECHA BETWEEN '"+fechaInicio+"' and '"+fechaFinal+ "' and C.Validez = 1 group by CODIGO", conexion);
                var dtTable = new DataTable();
                dataAdapterDesgloce.Fill(dtTable);
                ventasGridView.DataSource = dtTable;
            }
            catch (SqlException sqlException)
            {
                MessageBox.Show("Error: " + sqlException.Message, "Error De Consulta");
            }
        }

        public void SetIngreso(long idMovimiento, int cantidad, int rut, string fecha, string hora, string motivo)
        {
            try
            {
                var cmd = new SqlCommand
                {
                    Connection = conexion,
                    CommandText = "dbo.InsertarIngreso",
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@movDinero_id", idMovimiento);
                cmd.Parameters.AddWithValue("@cantidad", cantidad);
                cmd.Parameters.AddWithValue("@fecha", fecha);
                cmd.Parameters.AddWithValue("@rut", rut);
                cmd.Parameters.AddWithValue("@hora", hora);
                cmd.Parameters.AddWithValue("@razon", motivo);
                var result = cmd.ExecuteNonQuery();
                if (result == 0)
                {
                    MessageBox.Show(null, "La query Insertar Ingreso no hizo efecto", "Error");
                }
            }
            catch (SqlException)
            {
                MessageBox.Show(null, "Error al Insertar un Ingreso de Dinero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LimpiadorOfertas(int idOferta)
        {
            try
            {
                var cmd = new SqlCommand
                {
                    Connection = conexion,
                    CommandText = "dbo.EliminarOferta",
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@idOferta", idOferta);
                var result = cmd.ExecuteNonQuery();
                if (result == 0)
                {
                    MessageBox.Show(null, "La query Eliminar Oferta no hizo efecto", "Error");
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(null,"Error al Eliminar productos asociados a la Oferta "+idOferta,"Error");
                Console.WriteLine(e.Message);
            }
        }

        public void CrearOfertas(int idOferta,string NombreOferta,int Cantidad)
        {
            try
            {
                var cmd = new SqlCommand
                {
                    Connection = conexion,
                    CommandText = "dbo.CrearOferta",
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@idOferta", idOferta);
                cmd.Parameters.AddWithValue("@name", NombreOferta);
                cmd.Parameters.AddWithValue("@precio", Cantidad);
                var result = cmd.ExecuteNonQuery();
                if (result == 0)
                {
                    MessageBox.Show(null, "La query Crear Oferta no hizo efecto", "Error");
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(null, "Error al Crear Oferta asociados a la Oferta " + idOferta, "Error");
                Console.WriteLine(e.Message);
            }
        }

        public void AnexarProductosAOfertas(int idProducto,int Cantidad,int idOferta)
        {
            try
            {
                if (ExisteEnProductos(idProducto)) {
                    var cmd = new SqlCommand
                    {
                        Connection = conexion,
                        CommandText = "dbo.AnexarProductoOferta",
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.AddWithValue("@idOferta", idOferta);
                    cmd.Parameters.AddWithValue("@idProducto", idProducto);
                    cmd.Parameters.AddWithValue("@cantidad", Cantidad);
                    var result = cmd.ExecuteNonQuery();
                    if (result == 0)
                    {
                        MessageBox.Show(null, "La query Anexar Productos no hizo efecto", "Error");
                    }
                }
                else
                {
                    MessageBox.Show(null,"El id del producto "+idProducto+" no existe, transacción anulada","Error");
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(null,"Error al Anexar Producto a la oferta "+idOferta,"Error");
                Console.WriteLine(e.Message);
            }
        }

    }
}
