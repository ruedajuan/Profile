using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Control
    {
        public String ctrlAcceso(string NombreUsuario, string Clave)
        {
            Modelo modelo = new Modelo();
            String respuesta = "";
            Usuario datosUsuario = null;
            if (string.IsNullOrEmpty(NombreUsuario) || string.IsNullOrEmpty(Clave))
            {
                respuesta = "Complete todos los campos";
            }
            else
            {
                datosUsuario = modelo.porUsuario(NombreUsuario);
                if (datosUsuario == null)
                {
                    respuesta = "El usuario no existe";
                }
                else
                {
                    if (datosUsuario.Clave != Clave)
                    {
                        respuesta = "El usuario y la contraseña no coinciden";
                    }
                    else
                    {
                        //una vez que ingresa genero la sesion
                        Sesion.NombreUsuario = datosUsuario.NombreUsuario;
                        Sesion.Clave = datosUsuario.Clave;
                        Sesion.NombreCompleto = datosUsuario.NombreCompleto;
                        Sesion.IdRol= datosUsuario.IdRol;
                        Sesion.IdUsuario = datosUsuario.IdUsuario;
                    }
                }
            }
            return respuesta;
        }

        public String ctrlUsuarioNuevo(Usuario usuario)
        {
            Modelo modelo = new Modelo();
            string respuesta = "";
            //verifico que esten llenos los campos
            if (String.IsNullOrEmpty(usuario.Documento) || String.IsNullOrEmpty(usuario.NombreCompleto) || String.IsNullOrEmpty(usuario.NombreUsuario) || String.IsNullOrEmpty(usuario.Clave) || String.IsNullOrEmpty(usuario.Correo))
            {
                respuesta = "Complete todos los campos";
            }
           
            else
            {
                modelo.registroUsuario(usuario);

            }
            return respuesta;
        }

        public String ctrlUsuarioEliminado(string NombreUsuario)
        {
            Modelo modelo = new Modelo();
            string respuesta = "";
            //verifico que esten llenos los campos
            if (String.IsNullOrEmpty(NombreUsuario))
            {
                respuesta = "Complete el cuadro de texto";
            }

            else
            {
                int numerito = modelo.eliminarUsuarios(NombreUsuario);
                if (numerito == 0)
                {
                    respuesta = "Usuario no encontrado";
                }

            }
            return respuesta;
        }
        public String ctrlCategoriaNueva(Categoria categoria)
        {
            Modelo modelo = new Modelo();
            string respuesta = "";
            //verifico que esten llenos los campos
            if (String.IsNullOrEmpty(categoria.Nombre))
            {
                respuesta = "Complete todos los campos";
            }

            else
            {
                modelo.registroCategoria(categoria);

            }
            return respuesta;
        }
        public String ctrlCategoriaEliminada(string IdCategoria)
        {
            Modelo modelo = new Modelo();
            string respuesta = "";
            //verifico que esten llenos los campos
            if (String.IsNullOrEmpty(IdCategoria))
            {
                respuesta = "Complete el cuadro de texto";
            }

            else
            {
                int numerito = modelo.eliminarCategoria(IdCategoria);
                if (numerito == 0)
                {
                    respuesta = "Categoria no encontrada";
                }

            }
            return respuesta;
        }

        public String ctrlProductoNuevo(Producto producto)
        {
            Modelo modelo = new Modelo();
            string respuesta = "";
           
            //verifico que esten llenos los campos
            if (String.IsNullOrEmpty(producto.Nombre) || String.IsNullOrEmpty(producto.Presentacion) || String.IsNullOrEmpty(producto.Descripcion) || String.IsNullOrEmpty(producto.IdCategoria.ToString()) || String.IsNullOrEmpty(producto.Stock.ToString()) || String.IsNullOrEmpty(producto.PrecioCompra.ToString()) || String.IsNullOrEmpty(producto.PrecioVenta.ToString()))
            {
                respuesta = "Complete todos los campos";
            }
            
            else if (modelo.comprobarIdCategoria(producto.IdCategoria.ToString()) ==0) 
            {
                respuesta = "La categoria ingresada no existe";
            }
            
            else
            {
                modelo.registroProductos(producto);

            }
            return respuesta;
        }

        public String ctrlProductoEliminado(string IdProducto)
        {
            Modelo modelo = new Modelo();
            string respuesta = "";
            //verifico que esten llenos los campos
            if (String.IsNullOrEmpty(IdProducto))
            {
                respuesta = "Complete el cuadro de texto";
            }

            else
            {
                int numerito = modelo.eliminarProducto(IdProducto);
                if (numerito == 0)
                {
                    respuesta = "Producto no encontrado";
                }

            }
            return respuesta;
        }

        //cliente
        public String ctrlClienteNuevo(Cliente clie)
        {
            Modelo modelo = new Modelo();
            string respuesta = "";

            //verifico que esten llenos los campos
            if (String.IsNullOrEmpty(clie.NombreCompleto) || String.IsNullOrEmpty(clie.Documento) || String.IsNullOrEmpty(clie.Descripcion) || String.IsNullOrEmpty(clie.CuilCuit) || String.IsNullOrEmpty(clie.Correo) || String.IsNullOrEmpty(clie.Telefono) || String.IsNullOrEmpty(clie.Domicilio) || String.IsNullOrEmpty(clie.Localidad)) 
            {
                respuesta = "Complete todos los campos";
            }

            else
            {
                modelo.registroClientes(clie);

            }
            return respuesta;
        }

        public String ctrlClienteEliminado(string IdCliente)
        {
            Modelo modelo = new Modelo();
            string respuesta = "";
            //verifico que esten llenos los campos
            if (String.IsNullOrEmpty(IdCliente))
            {
                respuesta = "Complete el cuadro de texto";
            }

            else
            {
                int numerito = modelo.eliminarCliente(IdCliente);
                if (numerito == 0)
                {
                    respuesta = "Cliente no encontrado. Revise el IdCliente ingresado";
                }

            }
            return respuesta;
        }

        public String ctrlVentaNueva(Venta venta)
        {
            Modelo modelo = new Modelo();
            string respuesta = "";

            //verifico que esten llenos los campos
            if (String.IsNullOrEmpty(venta.IdCliente.ToString())|| String.IsNullOrEmpty(venta.Descripcion.ToString())|| String.IsNullOrEmpty(venta.ModalidadPago.ToString()))
            {
                respuesta = "Complete todos los campos";
            }

            else if (modelo.comprobarIdCliente(venta.IdCliente.ToString()) == 0)
            {
                respuesta = "El cliente ingresado no existe";
            }

            else
            {
                modelo.registroVenta(venta);

            }
            return respuesta;
        }

        public String ctrlCargarProductosDVenta(Detalle_Venta dventa)
        {
            Modelo modelo = new Modelo();
            string respuesta = "";

            if (modelo.comprobarIdProducto(dventa.IdProducto.ToString()) == 0)
            {
                respuesta = "El IdProducto ingresado no existe";
            }
            else if (modelo.comprobarNroVenta(dventa.NroVenta.ToString()) == 0)
            {
                respuesta = "El Nro venta ingresado no existe";
            }
            //verifico stock
            else if (modelo.verificarStock(dventa)  < dventa.Cantidad)
            {
                respuesta = "No hay stock suficiente";
            }
            else
            {
                //REGISTRO EL PRODUCTO
                modelo.registroDetalle_Venta(dventa);
                //MODIFICO EL STOCK EN TABLA PRODUCTOS
                modelo.RestarStock(dventa);
                //SUMO EL SUBTOTAL A LA TABLA VENTA
                modelo.SumarProdVenta(dventa);

            }
            return respuesta;
        }

        public String ctrlProductoEditado(Producto producto)
        {
            Modelo modelo = new Modelo();
            string respuesta = "";

            
            if (modelo.comprobarIdCategoria(producto.IdCategoria.ToString()) == 0)
            {
                respuesta = "La categoria ingresada no existe";
            }
            //controlo el IDProducto ingresado
            if (modelo.comprobarIdProducto(producto.IdProducto.ToString()) == 0)
            {
                respuesta = "El IdProducto ingresado no existe";
            }

            else
            {
                modelo.editarProducto(producto);
                //hacer los cambios en este metodo
            }
            return respuesta;
        }

        public String ctrlBuscarNroVenta(int NroVenta) 
        {
            Modelo modelo = new Modelo();
            string respuesta = "";

            if (modelo.comprobarNroVenta(NroVenta.ToString()) == 0)
            {
                respuesta = "El Nro venta ingresado no existe";
            }

            else
            {
                modelo.eliminarVenta(NroVenta);
                
            }
            return respuesta;
        }

        //Proveedor
        public String ctrlProveedorNuevo(Proveedor prove)
        {
            Modelo modelo = new Modelo();
            string respuesta = "";

            //verifico que esten llenos los campos
            if (String.IsNullOrEmpty(prove.NombreComercial) || String.IsNullOrEmpty(prove.RazonSocial) || String.IsNullOrEmpty(prove.Descripcion) || String.IsNullOrEmpty(prove.CuilCuit) || String.IsNullOrEmpty(prove.Correo) || String.IsNullOrEmpty(prove.Telefono))
            {
                respuesta = "Complete todos los campos";
            }

            else
            {
                modelo.registroProveedor(prove);

            }
            return respuesta;
        }

        public String ctrlProveedorEliminado(string IdProveedor)
        {
            Modelo modelo = new Modelo();
            string respuesta = "";
            //verifico que esten llenos los campos
            if (String.IsNullOrEmpty(IdProveedor))
            {
                respuesta = "Complete el cuadro de texto";
            }

            else
            {
                int numerito = modelo.eliminarProveedor(IdProveedor);
                if (numerito == 0)
                {
                    respuesta = "Proveedor no encontrado. Revise el IdProveedor ingresado";
                }

            }
            return respuesta;
        }

        public String ctrlCompraNueva(Compra comp)
        {
            Modelo modelo = new Modelo();
            string respuesta = "";

            //verifico que esten llenos los campos
            if (String.IsNullOrEmpty(comp.IdProveedor.ToString()) || String.IsNullOrEmpty(comp.TipoDocumento.ToString()) || String.IsNullOrEmpty(comp.ModalidadPago.ToString()))
            {
                respuesta = "Complete todos los campos";
            }

            else if (modelo.comprobarIdProveedor(comp.IdProveedor.ToString()) == 0)
            {
                respuesta = "El proveedor ingresado no existe";
            }

            else
            {
                modelo.registroCompra(comp);

            }
            return respuesta;
        }

        public String ctrlCargarProductosDCompra(Detalle_Compra dcomp)
        {
            Modelo modelo = new Modelo();
            string respuesta = "";

            if (modelo.comprobarIdProducto(dcomp.IdProducto.ToString()) == 0)
            {
                respuesta = "El IdProducto ingresado no existe";
            }
            else if (modelo.comprobarNroCompra(dcomp.NroCompra.ToString()) == 0)
            {
                respuesta = "El Nro compra ingresado no existe";
            }
            else
            {
                //REGISTRO EL PRODUCTO
                modelo.registroDetalle_Compra(dcomp);
                //MODIFICO EL STOCK EN TABLA PRODUCTOS
                modelo.SumarStock(dcomp);
                //SUMO EL SUBTOTAL A LA TABLA VENTA
                modelo.SumarProdCompra(dcomp);

            }
            return respuesta;
        }

        public String ctrlBuscarNroCompra(int NroCompra)
        {
            Modelo modelo = new Modelo();
            string respuesta = "";

            if (modelo.comprobarNroCompra(NroCompra.ToString()) == 0)
            {
                respuesta = "El Nro compra ingresado no existe";
            }

            else
            {
                modelo.eliminarCompra(NroCompra);

            }
            return respuesta;
        }

        public String ctrlNroVenta(int NroVenta)
        {
            Modelo modelo = new Modelo();
            string respuesta = "";

            if (modelo.comprobarNroVenta(NroVenta.ToString()) == 0)
            {
                respuesta = "El Nro venta ingresado no existe";
            }
            return respuesta;
        }

    }
}
