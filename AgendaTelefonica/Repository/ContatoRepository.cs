using AgendaTelefonica.Database;
using AgendaTelefonica.Entities;
using System.Collections.Generic;
using System.Linq;

namespace AgendaTelefonica.Repository
{
    public class ContatoRepository : IBaseRepository<ContatoEntity>
    {
        private readonly Context _context;

        public ContatoRepository()
        {
            _context = new Context();
        }

        public void Delete(ContatoEntity obj)
        {
            _context.Contato.Remove(obj);
            _context.SaveChanges();
        }

        public IEnumerable<ContatoEntity> GetAll()
        {
            return _context.Contato.ToList();
        }

        public void Insert(ContatoEntity obj)
        {
            _context.Contato.Add(obj);
            _context.SaveChanges();
        }

        public ContatoEntity Select(int id)
        {
            return _context.Contato.Where(p => p.Id == id).FirstOrDefault();
        }

        public void Update(ContatoEntity obj)
        {
            var contato = _context.Contato.First(i => i.Id == obj.Id);
            contato.Nome = obj.Nome;
            contato.Idade = obj.Idade;
            _context.SaveChanges();
        }
    }
}
