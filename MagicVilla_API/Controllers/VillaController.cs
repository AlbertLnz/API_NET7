using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using MagicVilla_API.Modelos;

namespace MagicVilla_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VillaController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Villa> GetVillas()
        {
            return new List<Villa>
            {
                new Villa{Id=1, Nombre="Vista a la piscina"},
                new Villa{Id=2, Nombre="Vista a la playa"}
            };
        }
    }
}

