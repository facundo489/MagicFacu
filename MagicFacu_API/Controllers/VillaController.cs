using MagicFacu_API.Modelos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MagicFacu_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VillaController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<VillaDto> GetVillas()
        {        
                        
             return new List<VillaDto>
             {                        
                
                 new VillaDto { Id = 1, Nombre = "Ver una pelicula" },
                 new VillaDto { Id = 2, Nombre = "Ver una serie" }
                
             };
        
        }
        
    }
}
