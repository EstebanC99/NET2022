namespace Business.Entities
{
    public class Plan : BusinessEntity
    {
        private int _IdEspecialidad;
        public int IdEspecialidad
        {
            get { return this._IdEspecialidad; }
            set { this._IdEspecialidad = value; }
        }

        private string _Descripcion;
        public string Descripcion
        {
            get { return this._Descripcion; }
            set { this._Descripcion = value; }
        }


    }
}
