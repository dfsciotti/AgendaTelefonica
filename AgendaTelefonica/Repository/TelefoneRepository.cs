using AgendaTelefonica.Database;
using AgendaTelefonica.Entities;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace AgendaTelefonica.Repository
{
    public class TelefoneRepository : IBaseRepository<TelefoneEntity>
    {
        private readonly Context _context;

        public TelefoneRepository()
        {
            _context = new Context();
        }

        public void Delete(TelefoneEntity obj)
        {
            _context.Telefone.Attach(obj);
            _context.Telefone.Remove(obj);
            _context.SaveChanges();
        }

        public IEnumerable<TelefoneEntity> GetAll()
        {
            return _context.Telefone.ToList();
        }

        public IEnumerable<TelefoneEntity> GetAllByContato(int id)
        {
            return _context.Telefone.Where(p => p.IdContato == id).AsNoTracking().ToList();
        }

        public void Insert(TelefoneEntity obj)
        {
            _context.Telefone.Add(obj);
            _context.SaveChanges();
        }

        public TelefoneEntity Select(int id)
        {
            return _context.Telefone.Where(p => p.Id == id).AsNoTracking().FirstOrDefault();
        }

        public int? SelectByNumero(string numero)
        {
            return _context.Telefone.Where(p => p.Numero == numero).AsNoTracking().FirstOrDefault()?.IdContato;
        }

        public void Update(TelefoneEntity obj)
        {
            var telefone = _context.Telefone.First(i => i.Id == obj.Id);
            telefone.IdContato = obj.IdContato;
            telefone.Numero = obj.Numero;
            _context.SaveChanges();
        }
    }
}
