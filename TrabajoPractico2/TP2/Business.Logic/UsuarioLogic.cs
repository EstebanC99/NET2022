using Business.Entities;
using Data.Database;
using System.Collections.Generic;

namespace Business.Logic
{
    public class UsuarioLogic : BusinessLogic
    {
        private UsuarioAdapter UsuarioData {get;set;}

        public UsuarioLogic()
        {
            this.UsuarioData = new UsuarioAdapter();
        }

        public Usuario GetOne(int id)
        {
            return this.UsuarioData.GetOne(id);
        }

        public List<Usuario> GetAll()
        {
            return this.UsuarioData.GetAll();
        }

        public void Save(Usuario usuario)
        {
            this.UsuarioData.Save(usuario);
        }

        public void Delete(int id)
        {
            this.UsuarioData.Delete(id);
        }
    }
}
