using System;

namespace Business.Entities
{
    public class Persona : BusinessEntity
    {
        private string _Apellido;
        public string Apellido
        {
            get { return this._Apellido; }
            set { this._Apellido = value; }
        }

        private string _Direccion;
        public string Direccion
        {
            get { return this._Direccion; }
            set { this._Direccion = value; }
        }

        private string _Email;
        public string Email
        {
            get { return this._Email; }
            set { this._Email = value; }
        }

        private DateTime _FechaNacimiento;
        public DateTime FechaNacimiento
        {
            get { return this._FechaNacimiento; }
            set { this._FechaNacimiento = value; }
        }

        private int _IdPlan;
        public int IdPlan
        {
            get { return this._IdPlan; }
            set { this._IdPlan = value; }
        }

        private int _Legajo;
        public int Legajo
        {
            get { return this._Legajo; }
            set { this._Legajo = value; }
        }

        private string _Nombre;
        public string Nombre
        {
            get { return this._Nombre; }
            set { this._Nombre = value; }
        }

        private string _Telefono;
        public string Telefono
        {
            get { return this._Telefono; }
            set { this._Telefono = value; }
        }

        private TiposPersona _TipoPersona;
        public TiposPersona TipoPersona
        {
            get { return this._TipoPersona; }
            set { this._TipoPersona = value; }
        }

        public enum TiposPersona
        {

        }
    }
}
