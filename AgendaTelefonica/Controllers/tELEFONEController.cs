using AgendaTelefonica.Entities;
using AgendaTelefonica.Repository;
using System.Collections.Generic;

namespace AgendaTelefonica.Controllers
{
    public class TelefoneController : IBaseController<TelefoneEntity>
    {
        private readonly TelefoneRepository _telefoneRepository;

        public TelefoneController()
        {
            _telefoneRepository = new TelefoneRepository();
        }

        public void Delete(TelefoneEntity obj)
        {
            _telefoneRepository.Delete(obj);
        }

        public IEnumerable<TelefoneEntity> GetAll()
        {
            return _telefoneRepository.GetAll();
        }

        public IEnumerable<TelefoneEntity> GetAllByContato(int id)
        {
            return _telefoneRepository.GetAllByContato(id);
        }

        public void Insert(TelefoneEntity obj)
        {
            _telefoneRepository.Insert(obj);
        }

        public TelefoneEntity Select(int id)
        {
            return _telefoneRepository.Select(id);
        }

        public int? SelectByNumero(string numero)
        {
            return _telefoneRepository.SelectByNumero(numero);
        }

        public void Update(TelefoneEntity obj)
        {
            _telefoneRepository.Update(obj);
        }
    }
}
