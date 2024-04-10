
namespace DemoGenerateursEtValidation.Models
{
    public class DbAutoRep : IAutoRep
    {

        private readonly AutoDbContext _context;

        public DbAutoRep(AutoDbContext autoDbContext)
        {
            _context = autoDbContext;
        }

        
        public IEnumerable<Auto> MesAuto
        {
            get
            {
                return _context.Autos.OrderBy(a => a.Id);
            }
        }

        public void AddAuto(Auto auto)
        {
            _context.Add(auto);
            _context.SaveChanges();
        }

        public Auto GetAuto(int? id)
        {
            return _context.Autos.First(a => a.Id == id);
        }

        public void ModifierAuto(Auto auto)
        {
            _context.Autos.Update(auto);
            _context.SaveChanges();
        }

        public void SupprimerAuto(int id)
        {
            _context.Autos.Remove(GetAuto(id));
            _context.SaveChanges();
        }
    }
}
