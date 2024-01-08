using AssetControl.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Diagnostics;

namespace AssetControl
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]        
        static void Main()
        {
            using (var db = new Data.ApplicationDbContext())
            {
                db.Database.EnsureCreated();
            }

            var usuario = new Models.Usuario
            {
                UserName = "admin",
                Password = "admin",
                Activo = true,
                FechaRegistro = System.DateTime.Now,
                FechaModificacion = System.DateTime.Now
            };

            using (var db = new Data.ApplicationDbContext())
            {
                db.Usuarios.Add(usuario);
                db.SaveChanges();
            }

            // imprimir en consola el usuario creado
            using (var db = new Data.ApplicationDbContext())
            {
                var usuarios = db.Usuarios.ToList();
                foreach (var item in usuarios)
                {
                    Debug.WriteLine($"Id: {item.IdUsuario} - UserName: {item.UserName} - Password: {item.Password} - Activo: {item.Activo} - FechaRegistro: {item.FechaRegistro} - FechaModificacion: {item.FechaModificacion}");
                }
            }

            ApplicationConfiguration.Initialize();
            Application.Run(new Login());
        }
    }
}