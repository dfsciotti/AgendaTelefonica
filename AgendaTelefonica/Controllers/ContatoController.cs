using AgendaTelefonica.Entities;
using AgendaTelefonica.Repository;
using System.Collections.Generic;

namespace AgendaTelefonica.Controllers
{
    public class ContatoController : IBaseController<ContatoEntity>
    {
        private readonly ContatoRepository _contatoRepository;
        private readonly LogFile _logFile;

        public ContatoController()
        {
            _contatoRepository = new ContatoRepository();
            _logFile = new LogFile();
        }

        public void Delete(ContatoEntity obj)
        {
            _contatoRepository.Delete(obj);
            _logFile.AddLine("Contato Excluído: " + obj.Id + " - " + obj.Nome);
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

        public IEnumerable<ContatoEntity> SelectByNumero(string numero)
        {
            return _contatoRepository.SelectByNumero(numero);
        }

        public void Update(ContatoEntity obj)
        {
            _contatoRepository.Update(obj);
        }
    }
}
