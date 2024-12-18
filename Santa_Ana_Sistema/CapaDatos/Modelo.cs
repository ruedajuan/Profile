using CapaEntidad;
using MySqlConnector;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Modelo
    {
        public Usuario porUsuario(string NombreUsuario)
        {
            MySqlDataReader reader;
            MySqlConnection conexion = Conexion.conexion();
            conexion.Open();
            string sql = "SELECT Idusuario,Documento,NombreUsuario,Clave,NombreCompleto,IdRol FROM usuario WHERE NombreUsuario LIKE @usuario";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@usuario", NombreUsuario);
            reader = comando.ExecuteReader();
            Usuario usr = null;
            while (reader.Read())
            {
                usr = new Usuario();
                usr.IdUsuario = int.Parse(reader["IdUsuario"].ToString());
                usr.Documento = reader["Documento"].ToString();
                usr.NombreUsuario = reader["NombreUsuario"].ToString();
                usr.Clave = reader["Clave"].ToString();
                usr.NombreCompleto = reader["NombreCompleto"].ToString();
                usr.IdRol= int.Parse(reader["IdRol"].ToString());

            }
            return usr;


        }
        public List<Object> mostrarUsuarios(string dato)
        {
            MySqlDataReader reader;
            List<Object> lista = new List<Object>();
            string sql;
            if (dato == null || dato == "")
            {
                sql = "SELECT IdUsuario,Documento,NombreUsuario,Correo,NombreCompleto,IdRol,FechaRegistro FROM usuario";
            }
            else
            {
                sql = "SELECT IdUsuario,Documento,NombreUsuario,Correo,NombreCompleto,IdRol,FechaRegistro FROM usuario WHERE NombreCompleto like @nombre";

            }

            MySqlConnection conexion = Conexion.conexion();
            conexion.Open();
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@nombre","%"+ dato + "%");
            reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Usuario usr = new Usuario();
                usr.IdUsuario = int.Parse(reader["IdUsuario"].ToString());
                usr.Documento = reader["Documento"].ToString();
                usr.NombreUsuario = reader["NombreUsuario"].ToString();
                usr.Correo = reader["Correo"].ToString();
                usr.NombreCompleto = reader["NombreCompleto"].ToString();
                usr.IdRol = int.Parse(reader["IdRol"].ToString());
                usr.FechaRegistro= reader["FechaRegistro"].ToString();

                lista.Add(usr);

            }
            return lista;
        }

        public int eliminarUsuarios(string dato)
        {
            MySqlConnection conexion = Conexion.conexion();
            conexion.Open();
            string sql;

                sql = "DELETE FROM usuario WHERE NombreUsuario like @nombre";


            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@nombre", dato);
            int resultado = comando.ExecuteNonQuery();
           
            return resultado;
        }



        public int registroUsuario(Usuario usr)
        {
            MySqlConnection conexion = Conexion.conexion();
            conexion.Open();
            string sql = "INSERT INTO usuario (Documento,NombreUsuario,NombreCompleto,Clave,Correo,IdRol) VALUES (@Documento, @NombreUsuario, @NombreCompleto,@Clave,@Correo,@IdRol)";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@Documento", usr.Documento);
            comando.Parameters.AddWithValue("@NombreUsuario", usr.NombreUsuario);
            comando.Parameters.AddWithValue("@NombreCompleto",usr.NombreCompleto );
            comando.Parameters.AddWithValue("@Clave", usr.Clave );
            comando.Parameters.AddWithValue("@Correo", usr.Correo);
            comando.Parameters.AddWithValue("@IdRol", usr.IdRol);
            int resultado = comando.ExecuteNonQuery();
            return resultado;
        }

        //ventana categoria

        public List<Object> mostrarCategorias(string dato)
        {
            MySqlDataReader reader;
            List<Object> lista = new List<Object>();
            string sql;
            if (dato == null || dato == "")
            {
                sql = "SELECT IdCategoria,Nombre,FechaRegistro FROM categoria";
            }
            else
            {
                sql = "SELECT IdCategoria,Nombre,FechaRegistro FROM categoria WHERE Nombre like @nombre";

            }

            MySqlConnection conexion = Conexion.conexion();
            conexion.Open();
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@nombre", "%" + dato + "%");
            reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Categoria cat = new Categoria();
                cat.IdCategoria = int.Parse(reader["IdCategoria"].ToString());
                cat.Nombre = reader["Nombre"].ToString();
                cat.FechaRegistro = reader["FechaRegistro"].ToString();

                lista.Add(cat);

            }
            return lista;
        }
        public int registroCategoria(Categoria cat)
        {
            MySqlConnection conexion = Conexion.conexion();
            conexion.Open();
            string sql = "INSERT INTO categoria (Nombre) VALUES (@Nombre)";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@Nombre", cat.Nombre);
            int resultado = comando.ExecuteNonQuery();
            return resultado;
        }

        public int eliminarCategoria(string dato)
        {
            MySqlConnection conexion = Conexion.conexion();
            conexion.Open();
            string sql;

            sql = "DELETE FROM categoria WHERE IdCategoria like @nombre";


            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@nombre", dato);
            int resultado = comando.ExecuteNonQuery();

            return resultado;
        }

        //productos
        public List<Object> mostrarProductos(string dato)
        {
            MySqlDataReader reader;
            List<Object> lista = new List<Object>();
            string sql;
            if (dato == null || dato == "")
            {
                sql = "SELECT IdProducto,Nombre,Presentacion,Descripcion,IdCategoria,Stock,PrecioCompra,PrecioVenta,FechaRegistro FROM producto";
            }
            else
            {
                sql = "SELECT IdProducto,Nombre,Presentacion,Descripcion,IdCategoria,Stock,PrecioCompra,PrecioVenta,FechaRegistro FROM producto WHERE Nombre like @nombre";

            }

            MySqlConnection conexion = Conexion.conexion();
            conexion.Open();
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@nombre", "%" + dato + "%");
            reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Producto prod = new Producto();
                prod.IdProducto = int.Parse(reader["IdProducto"].ToString());
                prod.Nombre = reader["Nombre"].ToString();
                prod.Presentacion = reader["Presentacion"].ToString();
                prod.Descripcion = reader["Descripcion"].ToString();
                prod.IdCategoria = int.Parse(reader["IdCategoria"].ToString());
                prod.Stock = int.Parse(reader["Stock"].ToString());
                prod.PrecioCompra = decimal.Parse(reader["PrecioCompra"].ToString());
                prod.PrecioVenta= decimal.Parse(reader["PrecioVenta"].ToString());
                prod.FechaRegistro = reader["FechaRegistro"].ToString();
                lista.Add(prod);

            }
            return lista;
        }

        public int registroProductos(Producto prod)
        {
            MySqlConnection conexion = Conexion.conexion();
            conexion.Open();
            string sql = "INSERT INTO producto (Nombre,Presentacion,Descripcion,IdCategoria,Stock,PrecioCompra,PrecioVenta) VALUES (@Nombre,@Presentacion,@Descripcion,@IdCategoria,@Stock,@PrecioCompra,@PrecioVenta)";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@Nombre", prod.Nombre);
            comando.Parameters.AddWithValue("@Presentacion", prod.Presentacion);
            comando.Parameters.AddWithValue("@Descripcion", prod.Descripcion);
            comando.Parameters.AddWithValue("@IdCategoria", prod.IdCategoria);
            comando.Parameters.AddWithValue("@Stock", prod.Stock);
            comando.Parameters.AddWithValue("@PrecioCompra", prod.PrecioCompra);
            comando.Parameters.AddWithValue("@PrecioVenta", prod.PrecioVenta);
            int resultado = comando.ExecuteNonQuery();
            return resultado;
        }

        public int eliminarProducto(string dato)
        {
            MySqlConnection conexion = Conexion.conexion();
            conexion.Open();
            string sql;

            sql = "DELETE FROM producto WHERE IdProducto like @nombre";


            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@nombre", dato);
            int resultado = comando.ExecuteNonQuery();

            return resultado;
        }

        public int comprobarIdCategoria(string dato) 
        {
            MySqlConnection conexion = Conexion.conexion();
            conexion.Open();
            string sql;

            sql = "SELECT COUNT(*) FROM categoria WHERE IdCategoria like @nombre";


            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@nombre", dato);
            int resultado = Convert.ToInt32(comando.ExecuteScalar());

            return resultado;
        }

        //Clientes
        public List<Object> mostrarClientes(string dato) 
        {
            MySqlDataReader reader;
            List<Object> lista = new List<Object>();
            string sql;
            if (dato == null || dato == "")
            {
                sql = "SELECT IdCliente,NombreCompleto,Documento,CUILoCUIT,Telefono,Correo,Descripcion,FechaRegistro,Domicilio,Localidad FROM cliente";
            }
            else
            {
                sql = "SELECT IdCliente,NombreCompleto,Documento,CUILoCUIT,Telefono,Correo,Descripcion,FechaRegistro,Domicilio,Localidad FROM cliente WHERE NombreCompleto like @nombre";

            }

            MySqlConnection conexion = Conexion.conexion();
            conexion.Open();
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@nombre", "%" + dato + "%");
            reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Cliente clie = new Cliente();
                clie.IdCliente = int.Parse(reader["IdCliente"].ToString());
                clie.NombreCompleto = reader["NombreCompleto"].ToString();
                clie.Documento = reader["Documento"].ToString();
                clie.CuilCuit = reader["CUILoCUIT"].ToString();
                clie.Telefono = reader["Telefono"].ToString();
                clie.Correo = reader["Correo"].ToString();
                clie.Descripcion = reader["Descripcion"].ToString();
                clie.Domicilio = reader["Domicilio"].ToString();
                clie.Localidad = reader["Localidad"].ToString();
                clie.FechaRegistro = reader["FechaRegistro"].ToString();
                lista.Add(clie);

            }
            return lista;
        }

        public int registroClientes(Cliente clie)
        {
            MySqlConnection conexion = Conexion.conexion();
            conexion.Open();
            string sql = "INSERT INTO cliente (NombreCompleto,Documento,CUILoCUIT,Telefono,Correo,Descripcion,Domicilio,Localidad) VALUES (@NombreCompleto,@Documento,@CUILoCUIT,@Telefono,@Correo,@Descripcion,@Domicilio,@Localidad)";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@NombreCompleto", clie.NombreCompleto);
            comando.Parameters.AddWithValue("@Documento", clie.Documento);
            comando.Parameters.AddWithValue("@CUILoCUIT", clie.CuilCuit);
            comando.Parameters.AddWithValue("@Telefono", clie.Telefono);
            comando.Parameters.AddWithValue("@Correo", clie.Correo);
            comando.Parameters.AddWithValue("@Descripcion", clie.Descripcion);
            comando.Parameters.AddWithValue("@Domicilio", clie.Domicilio);
            comando.Parameters.AddWithValue("@Localidad", clie.Localidad);
            int resultado = comando.ExecuteNonQuery();
            return resultado;
        }

        public int eliminarCliente(string dato)
        {
            MySqlConnection conexion = Conexion.conexion();
            conexion.Open();
            string sql;

            sql = "DELETE FROM cliente WHERE IdCliente like @nombre";


            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@nombre", dato);
            int resultado = comando.ExecuteNonQuery();

            return resultado;
        }

        //ventas


        public int comprobarIdCliente(string dato)
        {
            MySqlConnection conexion = Conexion.conexion();
            conexion.Open();
            string sql;

            sql = "SELECT COUNT(*) FROM cliente WHERE IdCliente like @nombre";


            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@nombre", dato);
            int resultado = Convert.ToInt32(comando.ExecuteScalar());

            return resultado;
        }

        public int registroVenta(Venta vent)
        {
            MySqlConnection conexion = Conexion.conexion();
            conexion.Open();
            string sql = "INSERT INTO venta (IdUsuario,IdCliente,Descripcion,ModalidadPago) VALUES (@IdUsuario,@IdCliente,@Descripcion,@ModalidadPago)";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@IdUsuario", vent.IdUsuario);
            comando.Parameters.AddWithValue("@IdCliente", vent.IdCliente);
            comando.Parameters.AddWithValue("@Descripcion", vent.Descripcion);
            comando.Parameters.AddWithValue("@ModalidadPago", vent.ModalidadPago);

            int resultado = comando.ExecuteNonQuery();
            return resultado;
        }

        public List<Object> mostrarVentas(string dato)
        {
            MySqlDataReader reader;
            List<Object> lista = new List<Object>();
            string sql;
            if (dato == null || dato == "")
            {
                sql = "SELECT NroVenta,IdUsuario,IdCliente,MontoTotal,ModalidadPago,Descripcion,FechaRegistra FROM venta";
            }
            else
            {
                sql = "SELECT NroVenta,IdUsuario,IdCliente,MontoTotal,ModalidadPago,Descripcion,FechaRegistra FROM venta WHERE NroVenta like @nombre";

            }

            MySqlConnection conexion = Conexion.conexion();
            conexion.Open();
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@nombre", dato );
            reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Venta vent = new Venta();
                vent.IdCliente = int.Parse(reader["IdCliente"].ToString());
                vent.NroVenta = int.Parse(reader["NroVenta"].ToString());
                vent.IdUsuario = int.Parse(reader["IdUsuario"].ToString());
                vent.MontoTotal = decimal.Parse(reader["MontoTotal"].ToString());
                vent.ModalidadPago = reader["ModalidadPago"].ToString();
                vent.Descripcion = reader["Descripcion"].ToString();
                vent.FechaRegistro = reader["FechaRegistra"].ToString();
                lista.Add(vent);

            }
            return lista;
        }
        //cargar productos

        public int comprobarIdProducto(string dato)
        {
            MySqlConnection conexion = Conexion.conexion();
            conexion.Open();
            string sql;

            sql = "SELECT COUNT(*) FROM producto WHERE IdProducto like @nombre";


            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@nombre", dato);
            int resultado = Convert.ToInt32(comando.ExecuteScalar());

            return resultado;
        }

        public int comprobarNroVenta(string dato)
        {
            MySqlConnection conexion = Conexion.conexion();
            conexion.Open();
            string sql;

            sql = "SELECT COUNT(*) FROM venta WHERE NroVenta like @nombre";


            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@nombre", dato);
            int resultado = Convert.ToInt32(comando.ExecuteScalar());

            return resultado;
        }

        public decimal obtenerPrecioProducto(string IdProducto)
        {
            decimal resultado = 0;
            MySqlConnection conexion = Conexion.conexion();
            conexion.Open();
            string sql = "Select PrecioVenta from producto where IdProducto like @dato";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@dato", IdProducto);

            // Ejecutar el comando y obtener el valor
            object valor = comando.ExecuteScalar();

            // Verificar si el valor no es nulo y convertirlo a decimal
            if (valor != null && valor != DBNull.Value)
            {
                resultado = Convert.ToDecimal(valor);
            }

            return resultado;
        }

        public int registroDetalle_Venta(Detalle_Venta dvent)
        {
            MySqlConnection conexion = Conexion.conexion();
            conexion.Open();
            string sql = "INSERT INTO detalle_venta (NroVenta,IdProducto,Cantidad,SubTotal) VALUES (@NroVenta,@IdProducto,@Cantidad,@SubTotal)";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@NroVenta", dvent.NroVenta);
            comando.Parameters.AddWithValue("@IdProducto", dvent.IdProducto);
            comando.Parameters.AddWithValue("@Cantidad", dvent.Cantidad);
            comando.Parameters.AddWithValue("@SubTotal", dvent.SubTotal);

            int resultado = comando.ExecuteNonQuery();
            return resultado;
        }

        //metodo para sumar productos a la venta

        public int SumarProdVenta(Detalle_Venta dvent)
        {
            MySqlConnection conexion = Conexion.conexion();
            conexion.Open();
            string sql = "UPDATE venta SET MontoTotal=(SELECT SUM(SubTotal) FROM detalle_venta WHERE detalle_venta.NroVenta = venta.NroVenta) WHERE NroVenta LIKE @NroVenta ";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@NroVenta", dvent.NroVenta);
            int resultado = comando.ExecuteNonQuery();
            return resultado;
        }

        //metodo para restar stock a los productos

        public int RestarStock(Detalle_Venta dvent)
        {
            MySqlConnection conexion = Conexion.conexion();
            conexion.Open();
            string sql = "UPDATE producto SET Stock=(Stock - @Cantidad) WHERE IdProducto = @IdProducto ";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@Cantidad", dvent.Cantidad);
            comando.Parameters.AddWithValue("@IdProducto", dvent.IdProducto);
            int resultado = comando.ExecuteNonQuery();
            return resultado;
        }

        public int verificarStock(Detalle_Venta dvent)
        {
            int resultado = 0;

            MySqlConnection conexion = Conexion.conexion();
            conexion.Open();
            string sql = "SELECT Stock FROM producto WHERE IdProducto = @IdProducto ";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@IdProducto", dvent.IdProducto);


            // Ejecutar el comando y obtener el valor
            object valor = comando.ExecuteScalar();

            // Verificar si el valor no es nulo y convertirlo a decimal
            if (valor != null && valor != DBNull.Value)
            {
                resultado = Convert.ToInt32(valor);
            }

            return resultado;
        }

        public int editarProducto(Producto prod)
        {
            //Ver campos que son nulos 
            List<string> camposParaActualizar = new List<string>();
            if (prod.Nombre != null)
                camposParaActualizar.Add("Nombre = @Nombre");
            if(prod.Presentacion != null)
                camposParaActualizar.Add("Presentacion = @Presentacion");
            if (prod.Descripcion != null)
                camposParaActualizar.Add("Descripcion = @Descripcion");
            if (prod.IdCategoria != null)
                camposParaActualizar.Add("IdCategoria = @IdCategoria");
            if (prod.PrecioVenta != null)
                camposParaActualizar.Add("PrecioVenta = @PrecioVenta");
            if (prod.PrecioCompra != null)
                camposParaActualizar.Add("PrecioCompra = @PrecioCompra");
            if (prod.Stock != null)
                camposParaActualizar.Add("Stock = @Stock");

            // Verificar si hay campos para actualizar
            if (camposParaActualizar.Count == 0)
            {
                // No hay nada que actualizar, retorno 0
                return 0;
            }

            MySqlConnection conexion = Conexion.conexion();
            conexion.Open();

            string sql = "UPDATE producto SET " + string.Join(", ", camposParaActualizar) + " WHERE IdProducto = @IdProducto";

            MySqlCommand comando = new MySqlCommand(sql, conexion);

            // Asignar valores a los parámetros solo si han sido agregados
            if (camposParaActualizar.Contains("Nombre = @Nombre"))
                comando.Parameters.AddWithValue("@Nombre", prod.Nombre);
            if (camposParaActualizar.Contains("Presentacion = @Presentacion"))
                comando.Parameters.AddWithValue("@Presentacion", prod.Presentacion);
            if (camposParaActualizar.Contains("Descripcion = @Descripcion"))
                comando.Parameters.AddWithValue("@Descripcion", prod.Descripcion);
            if (camposParaActualizar.Contains("IdCategoria = @IdCategoria"))
                comando.Parameters.AddWithValue("@IdCategoria", prod.IdCategoria);
            if (camposParaActualizar.Contains("Stock = @Stock"))
                comando.Parameters.AddWithValue("@Stock", prod.Stock);
            if (camposParaActualizar.Contains("PrecioCompra = @PrecioCompra"))
                comando.Parameters.AddWithValue("@PrecioCompra", prod.PrecioCompra);
            if (camposParaActualizar.Contains("PrecioVenta = @PrecioVenta"))
                comando.Parameters.AddWithValue("@PrecioVenta", prod.PrecioVenta);

            comando.Parameters.AddWithValue("@IdProducto", prod.IdProducto);
            int resultado = comando.ExecuteNonQuery();
            return resultado;
        }

        public void eliminarVenta(int nroVenta)
        {
            MySqlConnection conexion = Conexion.conexion();
            conexion.Open();

            try
            {
                // Paso 1: Obtener los productos y cantidades de detalle_venta
                string sql = "SELECT IdProducto, Cantidad FROM detalle_venta WHERE NroVenta = @NroVenta";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.Parameters.AddWithValue("@NroVenta", nroVenta);

                MySqlDataReader reader = comando.ExecuteReader();
                List<(int idProducto, int cantidad)> productos = new List<(int, int)>();

                // Guardamos los productos y cantidades en una lista para procesar después
                while (reader.Read())
                {
                    int idProducto = reader.GetInt32("IdProducto");
                    int cantidad = reader.GetInt32("Cantidad");
                    productos.Add((idProducto, cantidad));
                }
                reader.Close();  // Cerramos el lector antes de continuar con las actualizaciones

                // Paso 2: Reponer el stock de los productos
                foreach (var producto in productos)
                {
                    string queryUpdateStock = "UPDATE producto SET Stock = Stock + @Cantidad WHERE IdProducto = @IdProducto";
                    MySqlCommand cmdUpdateStock = new MySqlCommand(queryUpdateStock, conexion);
                    cmdUpdateStock.Parameters.AddWithValue("@Cantidad", producto.cantidad);
                    cmdUpdateStock.Parameters.AddWithValue("@IdProducto", producto.idProducto);
                    cmdUpdateStock.ExecuteNonQuery();
                }

                // Paso 3: Eliminar los detalles de la venta
                string queryEliminarDetalles = "DELETE FROM detalle_venta WHERE NroVenta = @NroVenta";
                MySqlCommand cmdEliminarDetalles = new MySqlCommand(queryEliminarDetalles, conexion);
                cmdEliminarDetalles.Parameters.AddWithValue("@NroVenta", nroVenta);
                cmdEliminarDetalles.ExecuteNonQuery();

                // Paso 4: Eliminar la venta
                string queryEliminarVenta = "DELETE FROM venta WHERE NroVenta = @NroVenta";
                MySqlCommand cmdEliminarVenta = new MySqlCommand(queryEliminarVenta, conexion);
                cmdEliminarVenta.Parameters.AddWithValue("@NroVenta", nroVenta);
                cmdEliminarVenta.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Manejar la excepción si es necesario
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                // Cerrar la conexión en el bloque finally para asegurarse de que siempre se cierre
                conexion.Close();
            }
        }

        public List<Object> mostrarProveedores(string dato)
        {
            MySqlDataReader reader;
            List<Object> lista = new List<Object>();
            string sql;
            if (dato == null || dato == "")
            {
                sql = "SELECT IdProveedor,NombreComercial,RazonSocial,CUILCUIT,Telefono,Correo,Descripcion,FechaRegistro FROM proveedor";
            }
            else
            {
                sql = "SELECT IdProveedor,NombreComercial,RazonSocial,CUILCUIT,Telefono,Correo,Descripcion,FechaRegistro FROM proveedor WHERE IdProveedor like @nombre";

            }

            MySqlConnection conexion = Conexion.conexion();
            conexion.Open();
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@nombre", dato);
            reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Proveedor prove = new Proveedor();
                prove.IdProveedor = int.Parse(reader["IdProveedor"].ToString());
                prove.NombreComercial = reader["NombreComercial"].ToString();
                prove.RazonSocial = reader["RazonSocial"].ToString();
                prove.CuilCuit = reader["CUILCUIT"].ToString();
                prove.Telefono = reader["Telefono"].ToString();
                prove.Correo = reader["Correo"].ToString();
                prove.Descripcion = reader["Descripcion"].ToString();
                prove.FechaRegistro = reader["FechaRegistro"].ToString();
                lista.Add(prove);

            }
            return lista;
        }

        public int registroProveedor(Proveedor prove)
        {
            MySqlConnection conexion = Conexion.conexion();
            conexion.Open();
            string sql = "INSERT INTO proveedor (NombreComercial,RazonSocial,CUILCUIT,Telefono,Correo,Descripcion) VALUES (@NombreComercial,@RazonSocial,@CUILCUIT,@Telefono,@Correo,@Descripcion)";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@NombreComercial", prove.NombreComercial);
            comando.Parameters.AddWithValue("@RazonSocial", prove.RazonSocial);
            comando.Parameters.AddWithValue("@CUILCUIT", prove.CuilCuit);
            comando.Parameters.AddWithValue("@Telefono", prove.Telefono);
            comando.Parameters.AddWithValue("@Correo", prove.Correo);
            comando.Parameters.AddWithValue("@Descripcion", prove.Descripcion);
            int resultado = comando.ExecuteNonQuery();
            return resultado;
        }

        public int eliminarProveedor(string dato)
        {
            MySqlConnection conexion = Conexion.conexion();
            conexion.Open();
            string sql;

            sql = "DELETE FROM proveedor WHERE IdProveedor like @nombre";


            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@nombre", dato);
            int resultado = comando.ExecuteNonQuery();

            return resultado;
        }



        //Compras

        public List<Object> mostrarCompras(string dato)
        {
            MySqlDataReader reader;
            List<Object> lista = new List<Object>();
            string sql;
            if (dato == null || dato == "")
            {
                sql = "SELECT NroCompra,IdUsuario,IdProveedor,MontoTotal,ModalidadPago,TipoDocumento,FechaRegistro FROM compra";
            }
            else
            {
                sql = "SELECT NroCompra,IdUsuario,IdProveedor,MontoTotal,ModalidadPago,TipoDocumento,FechaRegistro FROM compra WHERE NroCompra like @nombre";

            }

            MySqlConnection conexion = Conexion.conexion();
            conexion.Open();
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@nombre", dato);
            reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Compra comp = new Compra();
                comp.IdProveedor = int.Parse(reader["IdProveedor"].ToString());
                comp.NroCompra = int.Parse(reader["NroCompra"].ToString());
                comp.IdUsuario = int.Parse(reader["IdUsuario"].ToString());
                comp.MontoTotal = decimal.Parse(reader["MontoTotal"].ToString());
                comp.ModalidadPago = reader["ModalidadPago"].ToString();
                comp.TipoDocumento = reader["TipoDocumento"].ToString();
                comp.FechaRegistro = reader["FechaRegistro"].ToString();
                lista.Add(comp);

            }
            return lista;
        }

        public int comprobarIdProveedor(string dato)
        {
            MySqlConnection conexion = Conexion.conexion();
            conexion.Open();
            string sql;

            sql = "SELECT COUNT(*) FROM proveedor WHERE IdProveedor like @nombre";


            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@nombre", dato);
            int resultado = Convert.ToInt32(comando.ExecuteScalar());

            return resultado;
        }

        public int registroCompra(Compra comp)
        {
            MySqlConnection conexion = Conexion.conexion();
            conexion.Open();
            string sql = "INSERT INTO compra (IdUsuario,IdProveedor,TipoDocumento,ModalidadPago) VALUES (@IdUsuario,@IdProveedor,@TipoDocumento,@ModalidadPago)";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@IdUsuario", comp.IdUsuario);
            comando.Parameters.AddWithValue("@IdProveedor", comp.IdProveedor);
            comando.Parameters.AddWithValue("@TipoDocumento", comp.TipoDocumento);
            comando.Parameters.AddWithValue("@ModalidadPago", comp.ModalidadPago);

            int resultado = comando.ExecuteNonQuery();
            return resultado;
        }

        public decimal obtenerPrecioCompraProducto(string IdProducto)
        {
            decimal resultado = 0;
            MySqlConnection conexion = Conexion.conexion();
            conexion.Open();
            string sql = "Select PrecioCompra from producto where IdProducto like @dato";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@dato", IdProducto);

            // Ejecutar el comando y obtener el valor
            object valor = comando.ExecuteScalar();

            // Verificar si el valor no es nulo y convertirlo a decimal
            if (valor != null && valor != DBNull.Value)
            {
                resultado = Convert.ToDecimal(valor);
            }

            return resultado;
        }

        public int comprobarNroCompra(string dato)
        {
            MySqlConnection conexion = Conexion.conexion();
            conexion.Open();
            string sql;

            sql = "SELECT COUNT(*) FROM compra WHERE NroCompra like @nombre";


            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@nombre", dato);
            int resultado = Convert.ToInt32(comando.ExecuteScalar());

            return resultado;
        }

        public int registroDetalle_Compra(Detalle_Compra dcomp)
        {
            MySqlConnection conexion = Conexion.conexion();
            conexion.Open();
            string sql = "INSERT INTO detalle_compra (NroCompra,IdProducto,Cantidad,SubTotal) VALUES (@NroCompra,@IdProducto,@Cantidad,@SubTotal)";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@NroCompra", dcomp.NroCompra);
            comando.Parameters.AddWithValue("@IdProducto", dcomp.IdProducto);
            comando.Parameters.AddWithValue("@Cantidad", dcomp.Cantidad);
            comando.Parameters.AddWithValue("@SubTotal", dcomp.SubTotal);

            int resultado = comando.ExecuteNonQuery();
            return resultado;
        }

        public int SumarStock(Detalle_Compra dcomp)
        {
            MySqlConnection conexion = Conexion.conexion();
            conexion.Open();
            string sql = "UPDATE producto SET Stock=(Stock + @Cantidad) WHERE IdProducto = @IdProducto ";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@Cantidad", dcomp.Cantidad);
            comando.Parameters.AddWithValue("@IdProducto", dcomp.IdProducto);
            int resultado = comando.ExecuteNonQuery();
            return resultado;
        }

        public int SumarProdCompra(Detalle_Compra dcomp)
        {
            MySqlConnection conexion = Conexion.conexion();
            conexion.Open();
            string sql = "UPDATE compra SET MontoTotal=(SELECT SUM(SubTotal) FROM detalle_compra WHERE detalle_compra.NroCompra = compra.NroCompra) WHERE NroCompra LIKE @NroCompra ";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@NroCompra", dcomp.NroCompra);
            int resultado = comando.ExecuteNonQuery();
            return resultado;
        }

        public void eliminarCompra(int nroCompra)
        {
            MySqlConnection conexion = Conexion.conexion();
            conexion.Open();

            try
            {
                // Paso 1: Obtener los productos y cantidades de detalle_venta
                string sql = "SELECT IdProducto, Cantidad FROM detalle_compra WHERE NroCompra = @NroCompra";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.Parameters.AddWithValue("@NroCompra", nroCompra);

                MySqlDataReader reader = comando.ExecuteReader();
                List<(int idProducto, int cantidad)> productos = new List<(int, int)>();

                // Guardamos los productos y cantidades en una lista para procesar después
                while (reader.Read())
                {
                    int idProducto = reader.GetInt32("IdProducto");
                    int cantidad = reader.GetInt32("Cantidad");
                    productos.Add((idProducto, cantidad));
                }
                reader.Close();  // Cerramos el lector antes de continuar con las actualizaciones

                // Paso 2: Restar el stock de los productos
                foreach (var producto in productos)
                {
                    string queryUpdateStock = "UPDATE producto SET Stock = Stock - @Cantidad WHERE IdProducto = @IdProducto";
                    MySqlCommand cmdUpdateStock = new MySqlCommand(queryUpdateStock, conexion);
                    cmdUpdateStock.Parameters.AddWithValue("@Cantidad", producto.cantidad);
                    cmdUpdateStock.Parameters.AddWithValue("@IdProducto", producto.idProducto);
                    cmdUpdateStock.ExecuteNonQuery();
                }

                // Paso 3: Eliminar los detalles de la venta
                string queryEliminarDetalles = "DELETE FROM detalle_compra WHERE NroCompra = @NroCompra";
                MySqlCommand cmdEliminarDetalles = new MySqlCommand(queryEliminarDetalles, conexion);
                cmdEliminarDetalles.Parameters.AddWithValue("@NroCompra", nroCompra);
                cmdEliminarDetalles.ExecuteNonQuery();

                // Paso 4: Eliminar la venta
                string queryEliminarVenta = "DELETE FROM compra WHERE NroCompra = @NroCompra";
                MySqlCommand cmdEliminarVenta = new MySqlCommand(queryEliminarVenta, conexion);
                cmdEliminarVenta.Parameters.AddWithValue("@NroCompra", nroCompra);
                cmdEliminarVenta.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Manejar la excepción si es necesario
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                // Cerrar la conexión en el bloque finally para asegurarse de que siempre se cierre
                conexion.Close();
            }
        }

        public string obtenerNombreCliente(string nroVenta) 
        {
            string nombre = string.Empty; // Inicializa la variable
            using (MySqlConnection conexion = Conexion.conexion())
            {
                conexion.Open();
                string sql = "SELECT cliente.NombreCompleto FROM venta " + // Asegúrate de tener un espacio aquí
                             "JOIN cliente ON venta.IdCliente = cliente.IdCliente WHERE venta.nroVenta = @dato";

                using (MySqlCommand comando = new MySqlCommand(sql, conexion))
                {
                    comando.Parameters.AddWithValue("@dato", nroVenta);
                    using (MySqlDataReader reader = comando.ExecuteReader())
                    {
                        if (reader.Read()) // Solo lee la primera fila
                        {
                            nombre = reader["NombreCompleto"].ToString();
                        }
                    }
                }
            }

            return nombre; // Devuelve el nombre (puede ser una cadena vacía si no se encontró)

        }
        public string obtenerDomicilioCliente(string nroVenta)
        {
            string nombre = string.Empty; // Inicializa la variable
            using (MySqlConnection conexion = Conexion.conexion())
            {
                conexion.Open();
                string sql = "SELECT cliente.Domicilio FROM venta " + // Asegúrate de tener un espacio aquí
                             "JOIN cliente ON venta.IdCliente = cliente.IdCliente WHERE venta.nroVenta = @dato";

                using (MySqlCommand comando = new MySqlCommand(sql, conexion))
                {
                    comando.Parameters.AddWithValue("@dato", nroVenta);
                    using (MySqlDataReader reader = comando.ExecuteReader())
                    {
                        if (reader.Read()) // Solo lee la primera fila
                        {
                            nombre = reader["Domicilio"].ToString();
                        }
                    }
                }
            }

            return nombre; // Devuelve el nombre (puede ser una cadena vacía si no se encontró)

        }
        public string obtenerLocalidadCliente(string nroVenta)
        {
            string nombre = string.Empty; // Inicializa la variable
            using (MySqlConnection conexion = Conexion.conexion())
            {
                conexion.Open();
                string sql = "SELECT cliente.Localidad FROM venta " + // Asegúrate de tener un espacio aquí
                             "JOIN cliente ON venta.IdCliente = cliente.IdCliente WHERE venta.nroVenta = @dato";

                using (MySqlCommand comando = new MySqlCommand(sql, conexion))
                {
                    comando.Parameters.AddWithValue("@dato", nroVenta);
                    using (MySqlDataReader reader = comando.ExecuteReader())
                    {
                        if (reader.Read()) // Solo lee la primera fila
                        {
                            nombre = reader["Localidad"].ToString();
                        }
                    }
                }
            }

            return nombre; // Devuelve el nombre (puede ser una cadena vacía si no se encontró)

        }
        public List<Object> mostrarDetalleVentas(string dato)
        {
            MySqlDataReader reader;
            List<Object> lista = new List<Object>();
            string sql;

            // Corregido: Asegurarse de que la concatenación de la consulta tenga los espacios adecuados
            sql = "SELECT detalle_venta.Cantidad, producto.Nombre, producto.Presentacion, producto.PrecioVenta," +
                  "detalle_venta.Subtotal FROM detalle_venta " + // Añadir espacio después de 'detalle_venta'
                  "JOIN producto ON detalle_venta.IdProducto = producto.IdProducto " + // Añadir espacio antes de 'JOIN'
                  "WHERE detalle_venta.NroVenta = @dato";

            MySqlConnection conexion = Conexion.conexion();
            conexion.Open();
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@dato", dato);
            reader = comando.ExecuteReader();

            while (reader.Read())
            {
                DetalleVentaMostrar vent = new DetalleVentaMostrar();

                // Corregido: Eliminar el espacio extra en el acceso a la columna 'Presentacion'
                vent.NombreProducto = reader["Nombre"].ToString() + " " + reader["Presentacion"].ToString();
                vent.SubTotal = decimal.Parse(reader["Subtotal"].ToString());
                vent.PrecioUnitario = decimal.Parse(reader["PrecioVenta"].ToString());
                vent.Cantidad = int.Parse(reader["Cantidad"].ToString());
                lista.Add(vent);
            }

            reader.Close(); // Cerrar el DataReader para liberar recursos
            conexion.Close(); // Cerrar la conexión a la base de datos

            return lista;
        }

        public decimal mostrarTotalDetalleVentas(string dato)
        {
            MySqlDataReader reader;
            List<Object> lista = new List<Object>();
            string sql;
            decimal total  = 0;

            // Corregido: Asegurarse de que la concatenación de la consulta tenga los espacios adecuados
            sql = "SELECT detalle_venta.Cantidad, producto.Nombre, producto.Presentacion, producto.PrecioVenta," +
                  "detalle_venta.Subtotal FROM detalle_venta " + // Añadir espacio después de 'detalle_venta'
                  "JOIN producto ON detalle_venta.IdProducto = producto.IdProducto " + // Añadir espacio antes de 'JOIN'
                  "WHERE detalle_venta.NroVenta = @dato";

            MySqlConnection conexion = Conexion.conexion();
            conexion.Open();
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@dato", dato);
            reader = comando.ExecuteReader();

            while (reader.Read())
            {
                DetalleVentaMostrar vent = new DetalleVentaMostrar();

                vent.SubTotal = decimal.Parse(reader["Subtotal"].ToString());
                total += vent.SubTotal;
            }

            reader.Close(); // Cerrar el DataReader para liberar recursos
            conexion.Close(); // Cerrar la conexión a la base de datos

            return total;
        }

        public List<Object> mostrarRegistroVentas(DateTime dato1,DateTime dato2)
        {
            MySqlDataReader reader;
            List<Object> lista = new List<Object>();
            string sql;

                sql = "SELECT NroVenta,IdUsuario,IdCliente,MontoTotal,ModalidadPago,Descripcion,FechaRegistra FROM venta WHERE FechaRegistra BETWEEN @fechaInicio AND @fechaFin";

            

            MySqlConnection conexion = Conexion.conexion();
            conexion.Open();
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@fechaInicio", dato1);
            comando.Parameters.AddWithValue("@fechaFin", dato2);
            reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Venta vent = new Venta();
                vent.IdCliente = int.Parse(reader["IdCliente"].ToString());
                vent.NroVenta = int.Parse(reader["NroVenta"].ToString());
                vent.IdUsuario = int.Parse(reader["IdUsuario"].ToString());
                vent.MontoTotal = decimal.Parse(reader["MontoTotal"].ToString());
                vent.ModalidadPago = reader["ModalidadPago"].ToString();
                vent.Descripcion = reader["Descripcion"].ToString();
                vent.FechaRegistro = reader["FechaRegistra"].ToString();
                lista.Add(vent);

            }
            return lista;
        }

        public List<Object> mostrarRegistroCompras(DateTime dato1, DateTime dato2)
        {
            MySqlDataReader reader;
            List<Object> lista = new List<Object>();
            string sql;

            sql = "SELECT NroCompra,IdUsuario,IdProveedor,MontoTotal,ModalidadPago,TipoDocumento,FechaRegistro FROM compra WHERE FechaRegistro BETWEEN @fechaInicio AND @fechaFin";



            MySqlConnection conexion = Conexion.conexion();
            conexion.Open();
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@fechaInicio", dato1);
            comando.Parameters.AddWithValue("@fechaFin", dato2);
            reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Compra comp = new Compra();
                comp.IdProveedor = int.Parse(reader["IdProveedor"].ToString());
                comp.NroCompra = int.Parse(reader["NroCompra"].ToString());
                comp.IdUsuario = int.Parse(reader["IdUsuario"].ToString());
                comp.MontoTotal = decimal.Parse(reader["MontoTotal"].ToString());
                comp.ModalidadPago = reader["ModalidadPago"].ToString();
                comp.TipoDocumento = reader["TipoDocumento"].ToString();
                comp.FechaRegistro = reader["FechaRegistro"].ToString();
                lista.Add(comp);

            }
            return lista;
        }


    }
}
