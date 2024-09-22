
using DB.Domian.Entidades;
using DB.Domian.Interfaces;
using System.Linq;


namespace DB.Domain.Servicios
{
    public class UsuarioService : IUsuario
    {
        private readonly IRepository<Usuario> _repository;

        public UsuarioService(IRepository<Usuario> repository)
        {
            _repository = repository;
        }

        public string GetNombre()
        {
            var user = _repository.GetAll().FirstOrDefault();
            return user?.Nombre;
        }

        public void SetRol(int rolId)
        {
            var user = _repository.GetAll().FirstOrDefault();
            if (user != null)
            {
                user.RolId = rolId;
                _repository.Update(user);
            }
        }
    }
}
