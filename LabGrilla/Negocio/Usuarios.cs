using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Usuarios
    {
        protected SqlDataAdapter _daUsuarios;

        public SqlDataAdapter daUsuarios
        {
            get { return this._daUsuarios; }
            set { this._daUsuarios = value; }
        }

        protected SqlConnection _connection;

        public SqlConnection Connection
        {
            get { return this._connection; }
            set { this._connection = value; }
        }

        public Usuarios()
        {
            #region Conexion
            this.Connection = new SqlConnection(@"Data Source=(LocalDB)\mssqllocaldb;Initial Catalog=academia;Integrated Security=false;user=net;password=net;");
            #endregion

            #region Llenar con todos los usuarios
            this.daUsuarios = new SqlDataAdapter("SELECT * FROM usuarios", this.Connection);
            #endregion

            #region Update
            this.daUsuarios.UpdateCommand = new SqlCommand("UPDATE usuarios " +
                                                           "SET tipo_doc = @tipo_doc, nro_doc = @nro_doc, fecha_nac = @fecha_nac, " +
                                                           "apellido = @apellido, nombre = @nombre, direccion = @direccion, " +
                                                           "telefono = @telefono, email = @email, celular = @celular, usuario = @usuario, " +
                                                           "clave = @clave WHERE id=@id ", this.Connection);
            this.daUsuarios.UpdateCommand.Parameters.Add("@tipo_doc", SqlDbType.Int, 1, "tipo_doc");
            this.daUsuarios.UpdateCommand.Parameters.Add("@nro_doc", SqlDbType.Int, 1, "nro_doc");
            this.daUsuarios.UpdateCommand.Parameters.Add("@fecha_nac", SqlDbType.DateTime, 1, "fecha_nac");
            this.daUsuarios.UpdateCommand.Parameters.Add("@apellido", SqlDbType.VarChar, 50, "apellido");
            this.daUsuarios.UpdateCommand.Parameters.Add("@nombre", SqlDbType.VarChar, 50, "nombre");
            this.daUsuarios.UpdateCommand.Parameters.Add("@direccion", SqlDbType.VarChar, 50, "direccion");
            this.daUsuarios.UpdateCommand.Parameters.Add("@telefono", SqlDbType.VarChar, 50, "telefono");
            this.daUsuarios.UpdateCommand.Parameters.Add("@email", SqlDbType.VarChar, 50, "email");
            this.daUsuarios.UpdateCommand.Parameters.Add("@celular", SqlDbType.VarChar, 50, "celular");
            this.daUsuarios.UpdateCommand.Parameters.Add("@usuario", SqlDbType.VarChar, 50, "usuario");
            this.daUsuarios.UpdateCommand.Parameters.Add("@clave", SqlDbType.VarChar, 50, "clave");
            this.daUsuarios.UpdateCommand.Parameters.Add("@id", SqlDbType.Int, 1, "id");
            #endregion

            #region Insert
            this.daUsuarios.InsertCommand = new SqlCommand("INSERT INTO usuarios(tipo_doc,nro_doc,fecha_nac,apellido, " +
                                                           "nombre,direccion,telefono,email,celular,usuario,clave) " +
                                                           "VALUES (@tipo_doc,@nro_doc,@fecha_nac,@apellido,@nombre,@direccion, " +
                                                           "@telefono,@email,@celular, @usuario, @clave  )", this.Connection);
            this.daUsuarios.InsertCommand.Parameters.Add("@tipo_doc", SqlDbType.Int, 1, "tipo_doc");
            this.daUsuarios.InsertCommand.Parameters.Add("@nro_doc", SqlDbType.Int, 1, "nro_doc");
            this.daUsuarios.InsertCommand.Parameters.Add("@fecha_nac", SqlDbType.DateTime, 1, "fecha_nac");
            this.daUsuarios.InsertCommand.Parameters.Add("@apellido", SqlDbType.VarChar, 50, "apellido");
            this.daUsuarios.InsertCommand.Parameters.Add("@nombre", SqlDbType.VarChar, 50, "nombre");
            this.daUsuarios.InsertCommand.Parameters.Add("@direccion", SqlDbType.VarChar, 50, "direccion");
            this.daUsuarios.InsertCommand.Parameters.Add("@telefono", SqlDbType.VarChar, 50, "telefono");
            this.daUsuarios.InsertCommand.Parameters.Add("@email", SqlDbType.VarChar, 50, "email");
            this.daUsuarios.InsertCommand.Parameters.Add("@celular", SqlDbType.VarChar, 50, "celular");
            this.daUsuarios.InsertCommand.Parameters.Add("@usuario", SqlDbType.VarChar, 50, "usuario");
            this.daUsuarios.InsertCommand.Parameters.Add("@clave", SqlDbType.VarChar, 50, "clave");
            #endregion

            #region Delete
            this.daUsuarios.DeleteCommand = new SqlCommand("DELETE FROM usuarios WHERE id=@id ", this.Connection);
            this.daUsuarios.DeleteCommand.Parameters.Add("@id", SqlDbType.Int, 1, "id");
            #endregion


        }

        public DataTable GetAll()
        {
            DataTable dtUsuarios = new DataTable();
            this.daUsuarios.Fill(dtUsuarios);
            return dtUsuarios;
        }

        public void GuardarCambios(DataTable dtUsuarios)
        {
            this.daUsuarios.Update(dtUsuarios);
            dtUsuarios.AcceptChanges();
        }
    }
}
