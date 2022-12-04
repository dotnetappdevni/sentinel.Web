using sentinel.Persistance;

using sentinelapi.Services.Interface;
using sentinelapi.Entities;
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

            return _context.Lockers.Where(w => w.IsActive == true && w.IsDeleted == false).AsEnumerable();

        }
        public void UpdateLockerStatus(Locker locker)
        {
            
            var currentLocker = _context.Lockers.Where(w => w.LockerId==locker.LockerId && w.IsActive == true && w.IsDeleted == false).FirstOrDefault();
            currentLocker.IsRented = locker.IsRented;
            _context.Update(currentLocker);
            try
            {
                _context.SaveChanges();
            }
            catch(Exception ex)
            {
            }
           





        }

    }
}