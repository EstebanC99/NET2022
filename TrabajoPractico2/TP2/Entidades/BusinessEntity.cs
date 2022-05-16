namespace Business.Entities
{
    public class BusinessEntity
    {
        public BusinessEntity()
        {
            this.State = States.New;
        }

        private int _ID;
        public int ID
        {
            get { return this._ID; }
            set { this._ID = value; }
        }

        private States _State;
        public States State
        {
            get { return this._State; }
            set { this._State = value; }
        }

        public enum States
        {
            Deleted,
            New,
            Modified,
            Unmodified
        }
    }
}
