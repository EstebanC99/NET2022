namespace Business.Entities
{
    public class Modulo : BusinessEntity
    {
        private string _Descripcion;
        public string Descripcion
        {
            get { return this._Descripcion; }
            set { this._Descripcion = value; }
        }
    }
}
