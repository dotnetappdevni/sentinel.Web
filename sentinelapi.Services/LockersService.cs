using Microsoft.EntityFrameworkCore;
using sentinel.Persistance;
using sentinelapi.Domain.Entities;
using sentinelapi.Services.Interface;

namespace sentinelapi.Services
{
    public class LockersService : ILockerInterface
    {
        private readonly ApplicationDBContext _context;

        public LockersService(ApplicationDBContext context) { 
        
            _context = context;
        }
        public IEnumerable<Locker> GetAll()
        {
 
            return _context.Lockers.Where(w=>w.GroupId==1 && w.IsActive==true && w.IsDeleted == true).AsEnumerable();

        }

    }
}