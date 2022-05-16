namespace Business.Entities
{
    public class Curso : BusinessEntity
    {
        private int _AnioCalendario;
        public int AnioCalendario
        {
            get { return this._AnioCalendario; }
            set { this._AnioCalendario = value; }
        }

        private int _Cupo;
        public int Cupo
        {
            get { return this._Cupo; }
            set { this._Cupo = value; }
        }

        private string _Descripcion;
        public string Descripcion
        {
            get { return this._Descripcion; }
            set { this._Descripcion = value; }
        }

        private int _IdComision;
        public int IdComision
        {
            get { return this._IdComision; }
            set { this._IdComision = value; }
        }

        private int _IdMateria;
        public int IdMateria
        {
            get { return this._IdMateria; }
            set { this._IdMateria = value; }
        }

    }
}
