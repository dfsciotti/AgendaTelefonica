using AgendaTelefonica.Entities;
using AgendaTelefonica.Repository;
using System.Collections.Generic;

namespace AgendaTelefonica.Controllers
{
    public class ContatoController : IBaseController<ContatoEntity>
    {
        private readonly ContatoRepository _contatoRepository;

        public ContatoController()
        {
            _contatoRepository = new ContatoRepository();
        }

        public void Delete(ContatoEntity obj)
        {
            _contatoRepository.Delete(obj);
        }

        public IEnumerable<ContatoEntity> GetAll()
        {
            return _contatoRepository.GetAll();
        }

        public void Insert(ContatoEntity obj)
        {
            _contatoRepository.Insert(obj);
        }

        public ContatoEntity Select(int id)
        {
            return _contatoRepository.Select(id);
        }

        public void Update(ContatoEntity obj)
        {
            _contatoRepository.Update(obj);
        }
    }
}
