using sentinelapi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sentinelapi.Services.Interface
{
     public interface ILockerInterface
    {
        public IEnumerable<Locker> GetAll();

        public void UpdateLockerStatus(Locker locker);


    }
}
