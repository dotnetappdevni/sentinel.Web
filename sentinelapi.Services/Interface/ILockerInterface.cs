using sentinelapi.Domain.Models;
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

    }
}
