
using DB.Domian.Entidades;
using DB.Domian.Interfaces;
using System.Linq;

namespace DB.Domain.Servicios
{
    public class TaxiService : ITaxi
    {
        private readonly IRepository<Taxi> _repository;

        public TaxiService(IRepository<Taxi> repository)
        {
            _repository = repository;
        }

        public string GetPlaca()
        {
            var taxi = _repository.GetAll().FirstOrDefault();
            return taxi?.Placa;
        }

        public void SetModelo(string modelo)
        {
            var taxi = _repository.GetAll().FirstOrDefault();
            if (taxi != null)
            {
                taxi.Modelo = modelo;
                _repository.Update(taxi);
            }
        }
    }
}

