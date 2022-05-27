namespace Util
{
    public class ValidationException
    {
        private const string MESSAGE_SEPARATOR = ".\n"; 

        public string Message { get; private set; }

        public ValidationException()
        {
            this.Message = "";
        }

        public void Add(string mensaje)
        {
            if (string.IsNullOrEmpty(this.Message))
            {
                this.Message = string.Concat(this.Message, mensaje);
            }
            else
            {
                this.Message = string.Concat(this.Message, MESSAGE_SEPARATOR, mensaje);
            }
        }

        public bool Any()
        {
            return !string.IsNullOrEmpty(this.Message);
        }
    }
}
