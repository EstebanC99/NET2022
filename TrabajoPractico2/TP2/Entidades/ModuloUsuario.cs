namespace Business.Entities
{
    public class ModuloUsuario : BusinessEntity
    {
        private int _IdUsuario;
        public int IdUsuario
        {
            get { return this._IdUsuario; }
            set { this._IdUsuario = value; }
        }

        private int _IdModulo;
        public int IdModulo
        {
            get { return this._IdModulo; }
            set { this._IdModulo = value; }
        }

        private bool _PermiteAlta;
        public bool PermiteAlta
        {
            get { return this._PermiteAlta; }
            set { this._PermiteAlta = value; }
        }

        private bool _PermiteBaja;
        public bool PermiteBaja
        {
            get { return this._PermiteBaja; }
            set { this._PermiteBaja = value; }
        }

        private bool _PermiteModificacion;
        public bool PermiteModificacion
        {
            get { return this._PermiteModificacion; }
            set { this._PermiteModificacion = value; }
        }

        private bool _PermiteConsulta;
        public bool PermiteConsulta
        {
            get { return this._PermiteConsulta; }
            set { this._PermiteConsulta = value; }
        }
    }
}
