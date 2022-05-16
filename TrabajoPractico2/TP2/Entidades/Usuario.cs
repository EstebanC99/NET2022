namespace Business.Entities
{
    public class Usuario : BusinessEntity
    {
        private string _NombreUsuario;
        public string NombreUsuario
        {
            get { return this._NombreUsuario; }
            set { this._NombreUsuario = value; }
        }

        private string _Clave;
        public string Clave
        {
            get { return this._Clave; }
            set { this._Clave = value; }
        }

        private string _Nombre;
        public string Nombre
        {
            get { return this._Nombre; }
            set { this._Nombre = value; }
        }

        private string _Apellido;
        public string Apellido
        {
            get { return this._Apellido; }
            set { this._Apellido = value; }
        }

        private string _Email;
        public string Email
        {
            get { return this._Email; }
            set { this._Email = value; }
        }

        private bool _Habilitado;
        public bool Habilitado
        {
            get { return this._Habilitado; }
            set { this._Habilitado = value; }
        }
    }
}
