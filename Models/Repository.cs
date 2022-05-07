using Knowledge.Data;

namespace Knowledge.Models
{
<<<<<<< HEAD
    public class Repository : IRepository
=======
    public class Repository
>>>>>>> 86701c0cbe9b1bf2bacf4ed84cf100a732f97c12
    {
        private readonly ApplicationDbContext _context;

        public Repository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Framework> GetFrameworks()
        {
            return _context.Frameworks;
        }
    }
}
