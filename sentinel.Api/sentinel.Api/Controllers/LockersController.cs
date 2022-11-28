using Microsoft.AspNetCore.Mvc;
using sentinelapi.Domain.Entities;
using sentinelapi.Services.Interface;

namespace sentinel.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LockersController : ControllerBase 
    {
        private readonly ILockerInterface _iLockerInterface;

        public LockersController(ILockerInterface lockerInterface)

        {

            _iLockerInterface = lockerInterface;
        }
        [HttpGet(Name = "GetAll")]
        public IEnumerable<Locker> GetAll()
        {

            return _iLockerInterface.GetAll(); 
        }

    }
}
