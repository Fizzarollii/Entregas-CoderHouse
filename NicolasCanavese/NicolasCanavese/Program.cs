namespace NicolasCanavese
{
    public class Program
    {
        ProductoData productoData = new ProductoData();
        UsuarioData usuarioData = new UsuarioData();
        ProductoVendidoData productoVendidoData = new ProductoVendidoData();
        VentaData ventaData = new VentaData();
        
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}