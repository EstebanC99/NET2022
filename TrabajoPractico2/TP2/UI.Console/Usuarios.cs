using Business.Entities;
using Business.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Console
{
    public class Usuarios
    {
        private UsuarioLogic UsuarioNegocio { get; set; }

        public Usuarios()
        {
            this.UsuarioNegocio = new UsuarioLogic();
        }

        private enum OpcionesMenu
        {
            ListadoGeneral = 1,
            Consulta = 2,
            Agregar = 3,
            Modificar = 4,
            Eliminar = 5,
            Salir = 6
        }

        public void Menu()
        {
            int opcion = 0;

            while (opcion != (int)OpcionesMenu.Salir)
            {
                System.Console.Clear();

                System.Console.WriteLine("ABMC de Usuarios --> Ingrese una opcion:");
                System.Console.WriteLine("\t\t{0}- Listado General.", (int)OpcionesMenu.ListadoGeneral);
                System.Console.WriteLine("\t\t{0}- Consulta.", (int)OpcionesMenu.Consulta);
                System.Console.WriteLine("\t\t{0}- Agregar.", (int)OpcionesMenu.Agregar);
                System.Console.WriteLine("\t\t{0}- Modificar.", (int)OpcionesMenu.Modificar);
                System.Console.WriteLine("\t\t{0}- Eliminar.", (int)OpcionesMenu.Eliminar);
                System.Console.WriteLine("\t\t{0}- Salir.", (int)OpcionesMenu.Salir);
                System.Console.WriteLine("Ingrese opcion:");

                if (int.TryParse(System.Console.ReadLine(), out opcion))
                {
                    switch (opcion)
                    {
                        case (int)OpcionesMenu.ListadoGeneral:
                            this.ListadoGeneral();
                            break;
                        case (int)OpcionesMenu.Consulta:
                            this.Consultar();
                            break;
                        case (int)OpcionesMenu.Agregar:
                            this.Agregar();
                            break;
                        case (int)OpcionesMenu.Modificar:
                            this.Modificar();
                            break;
                        case (int)OpcionesMenu.Eliminar:
                            this.Eliminar();
                            break;
                        case (int)OpcionesMenu.Salir:
                            break;
                        default:
                            System.Console.WriteLine("¡¡ OPCION NO VALIDA !!");
                            break;
                    }
                }
                else
                {
                    System.Console.WriteLine("¡¡ OPCION NO VALIDA !!");
                }

                System.Console.WriteLine("Enter para continuar...");
                System.Console.ReadKey();
            }

        }

        public void ListadoGeneral()
        {
            System.Console.Clear();

            foreach (var usuario in this.UsuarioNegocio.GetAll())
            {
                this.MostrarDatos(usuario);
            }
        }

        public void Consultar()
        {
            System.Console.Clear();
            System.Console.Write("Ingrese el ID del usuario a consultar: ");
            try
            {
                var ID = int.Parse(System.Console.ReadLine());
                this.MostrarDatos(this.UsuarioNegocio.GetOne(ID));
            }
            catch (FormatException ex)
            {
                System.Console.Clear();
                System.Console.WriteLine("Ocurrio un error en el ID! La ID ingresada debe ser un numero entero.\n Error:  {0}", ex.Message);
            }
            catch (Exception ex)
            {
                System.Console.Clear();
                System.Console.WriteLine("Ocurrio un error inesperado! {0}", ex.Message);
            }
        }

        public void Agregar()
        {
            System.Console.Clear();
            var usuario = new Usuario();
            try
            {
                System.Console.Write("Ingrese Nombre: ");
                usuario.Nombre = System.Console.ReadLine();
                System.Console.Write("Ingrese Apellido: ");
                usuario.Apellido = System.Console.ReadLine();
                System.Console.Write("Ingrese Nombre de Usuario: ");
                usuario.NombreUsuario = System.Console.ReadLine();
                System.Console.Write("Ingrese Clave: ");
                usuario.Clave = System.Console.ReadLine();
                System.Console.Write("Ingrese Email: ");
                usuario.Email = System.Console.ReadLine();
                System.Console.Write("Ingrese Habilitacion de Usuario (1-Si / 2-No): ");
                usuario.Habilitado = (System.Console.ReadLine() == "1");

                usuario.State = BusinessEntity.States.New;
                this.UsuarioNegocio.Save(usuario);

                System.Console.WriteLine();
                System.Console.WriteLine("ID: {0}", usuario.ID);
            }
            catch (FormatException ex)
            {
                System.Console.WriteLine();
                System.Console.WriteLine("La ID ingresada debe ser un numero entero.");
            }
            catch (Exception ex)
            {

                System.Console.WriteLine();
                System.Console.WriteLine("Ocurrio un error! {0}", ex.Message);
            }

        }

        public void Modificar()
        {
            try
            {
                System.Console.Clear();
                System.Console.Write("Ingrese el ID del usuario a modificar: ");
                var ID = int.Parse(System.Console.ReadLine());
                var usuario = this.UsuarioNegocio.GetOne(ID);

                System.Console.Write("Ingrese Nombre: ");
                usuario.Nombre = System.Console.ReadLine();
                System.Console.Write("Ingrese Apellido: ");
                usuario.Apellido = System.Console.ReadLine();
                System.Console.Write("Ingrese Nombre de Usuario: ");
                usuario.NombreUsuario= System.Console.ReadLine();
                System.Console.Write("Ingrese Clave: ");
                usuario.Clave = System.Console.ReadLine();
                System.Console.Write("Ingrese Email: ");
                usuario.Email = System.Console.ReadLine();
                System.Console.Write("Ingrese Habilitacion de Usuario (1-Si / 2-No): ");
                usuario.Habilitado = (System.Console.ReadLine() == "1");
                
                usuario.State = BusinessEntity.States.Modified;
                this.UsuarioNegocio.Save(usuario);
            }
            catch (FormatException ex)
            {
                System.Console.WriteLine();
                System.Console.WriteLine("La ID ingresada debe ser un numero entero.");
            }
            catch (Exception ex)
            {

                System.Console.WriteLine();
                System.Console.WriteLine("Ocurrio un error! {0}", ex.Message);
            }
        }

        public void Eliminar()
        {
            try
            {
                System.Console.Clear();
                System.Console.Write("Ingrese el ID del usuario a eliminar: ");
                var ID = int.Parse(System.Console.ReadLine());
                this.UsuarioNegocio.Delete(ID);
            }
            catch (FormatException ex)
            {
                System.Console.WriteLine();
                System.Console.WriteLine("La ID ingresada debe ser un numero entero.");
            }
            catch (Exception ex)
            {

                System.Console.WriteLine();
                System.Console.WriteLine("Ocurrio un error! {0}", ex.Message);
            }
        }

        public void MostrarDatos(Usuario usuario)
        {
            System.Console.WriteLine("Usuario: {0}", usuario.ID);
            System.Console.WriteLine("\t\tNombre: {0}", usuario.Nombre);
            System.Console.WriteLine("\t\tApellido: {0}", usuario.Apellido);
            System.Console.WriteLine("\t\tNombre de Usuario: {0}", usuario.NombreUsuario);
            System.Console.WriteLine("\t\tClave: {0}", usuario.Clave);
            System.Console.WriteLine("\t\tMail: {0}", usuario.Email);
            System.Console.WriteLine("\t\tHabilitado: {0}", usuario.Habilitado);
            System.Console.WriteLine();
        }
    }
}
