namespace LucasOteroCSharp
{ 

    public class Usuario
    {

        private short id;
        private string nombre;
        private string apellido;
        private string nombreUsuario;
        private string contraseña;
        private string mail;

    }

    public class Producto
    {

        private short id;
        private string descripcion;
        private double costo;
        private double precioVenta;
        private int stock;
        private short idUsuario;

    }

    public class ProductoVendido
    {

        private short id;
        private short idProducto;
        private int stock;
        private short idVenta;

    }
    public class Venta
    {

        private short id;
        private string comentarios;

    }

}