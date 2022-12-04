using Microsoft.AspNetCore.Mvc;
using sentinelapi.Services.Interface;
using sentinelapi.Entities;
using static System.Reflection.Metadata.BlobBuilder;

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


        [HttpPut]
        public IActionResult Put(Locker locker)
        {
            _iLockerInterface.UpdateLockerStatus(locker);
            return Ok(locker);

        }

    }
    }
