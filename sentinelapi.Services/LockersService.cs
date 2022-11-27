using sentinelapi.Domain.Models;
using sentinelapi.Services.Interface;

namespace sentinelapi.Services
{
    public class LockersService : ILockerInterface
    {

        public IEnumerable<Locker> GetAll()
        {
            List<Locker> lockerslist =  new List<Locker>();

            for(int i = 0; i < 100; i++)
            {

                lockerslist.Add(new Locker
                {
                    LockerId = i,
                   
                    Booking= new Booking {
                        StartDate = DateTime.Now,
                        EndDate = DateTime.Now.AddDays(5)
                        
                        
                    },
                    
                    Description = "Test Lockers " + i,
                    RowId = "A",
                    IsRented = false,
                });  


            }
            return lockerslist;

        }

    }
}